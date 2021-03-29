using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DarkUI.Forms;
using DarkUI.Controls;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Dynamic;
using System.Diagnostics;
using System.Collections;

namespace waifu2x_ncnn_vulkan_gui
{
    /// <summary>
    /// waifu2x-ncnn-vulkan GUI MainForm
    /// </summary>
    public partial class MainForm : Form
    {
        #region variable
        private bool IsRendering = false;
        private FileInfo[] ConvertingFiles = null;
        private int ThreadMaxCount = 1;
        private int ThreadCount = 0;
        private int TimeOutSec = 60000;
        private Thread LandingThread;
        private List<FileInfo> FailedConvertingFiles = new List<FileInfo>();
        protected virtual bool DoubleBuffered { get; set; }
        #endregion

        #region Assistance

        #region ErrorLog
        private ErrorLog log = new ErrorLog();
        private void ErrorLog(string txt)
        {
            if (log == null)
                log = new ErrorLog();
            log.Log(txt);
        }
        #endregion

        #region TitleBar
        private Point mousePoint;
        private void TitleBarMouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
        private void TitleBarMouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }
        private string Title
        {
            get
            {
                return TitleLabel.Text;
            }
            set
            {
                TitleLabel.Text = value;
            }
        }
        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
        private void MinimizeButtonClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region return
        private bool IsImageExtension(string Extension)
        {
            switch (Extension)
            {
                //case ".bmp":
                //    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                //case ".jpeg":
                //    return true;
                //case ".gif":
                //    return true;
                default:
                    return false;
            }
        }
        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = string.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = string.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = string.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";
            return size;
        }
        #endregion

        #region LogBox
        private void LogBoxTextChanged(object sender, EventArgs e)
        {
            if (LogBox.Text.Length > 50000)
                LogBox.Text = "Clear!\n";
        }
        #endregion

        #region TextBox
        private string TextBoxText
        {
            get
            {
                return ArgumentsTextBox.Text;
            }
            set
            {
                if (InvokeRequired)
                    Invoke(new MethodInvoker(delegate ()
                    {
                        ArgumentsTextBox.Text = value;
                    }));
                else
                    ArgumentsTextBox.Text = value;
            }
        }
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (int)Keys.Back || e.KeyChar == 1) || e.KeyChar == (int)Keys.Back && ((TextBox)sender).Text.Length == 1)
                e.Handled = true;
        }
        #endregion

        #region Index
        private int _index = 0;
        private int Index
        {
            get { return _index; }
            set
            {
                _index = value;
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        runningLabel.Text = ConvertingFiles.Length + " out of " + value + " completed";
                    }));
                }
                else
                {
                    runningLabel.Text = ConvertingFiles.Length + " out of " + value + " completed";
                }
            }
        }
        #endregion

        #region InitialTest
        private void InitialTest()
        {
            if (FileList.Items.Count == 0)
            {
                DarkMessageBox.ShowWarning("No files!", "Warning");
                return;
            }
            if (!File.Exists(Setting.Waifu2xPath))
            {
                DarkMessageBox.ShowError("File not found in \"waifu2x\\waifu2x-ncnn-vulkan.exe\"!", "Error");
                return;
            }
            ThreadMaxCount = int.Parse(Regex.Replace(ThreadTextBox.Text, @"\D", ""));
            TimeOutSec = int.Parse(Regex.Replace(TimeOutTextBox.Text, @"\D", "")) * 1000;
        }
        #endregion

        #region ListView

        #region Sort ListView
        bool m_ColumnclickASC = true;
        private void FileListColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (m_ColumnclickASC == true)
                ((ListView)sender).ListViewItemSorter = new ListViewItemSortASC(e.Column);
            else
                ((ListView)sender).ListViewItemSorter = new ListViewItemSortDESC(e.Column);

            m_ColumnclickASC = !m_ColumnclickASC;
        }
        #endregion

        #region ListView
        private void SetListView(int ImageIndex, FileInfo file)
        {
            string FileName = Path.GetFileNameWithoutExtension(file.Name);
            foreach (ListViewItem item in FileList.Items)
            {
                if (item.Text == FileName)
                    if (((FileInfo)item.Tag).FullName == file.FullName)
                        item.ImageIndex = ImageIndex;
            }
        }
        private void ItemSelect(FileInfo file)
        {
            string FileName = Path.GetFileNameWithoutExtension(file.Name);
            foreach (ListViewItem item in FileList.Items)
            {
                if (item.Text == FileName)
                    if (((FileInfo)item.Tag).FullName == file.FullName)
                        item.Selected = true;
            }
        }
        #endregion

        #region ListEvent
        private void FileListDoubleClick(object sender, EventArgs e)
        {
            if (FileList.SelectedItems.Count > 0)
                Process.Start(new ProcessStartInfo(((FileInfo)FileList.SelectedItems[0].Tag).FullName));
        }
        private void FileList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                foreach (ListViewItem item in FileList.SelectedItems)
                {
                    item.Remove();
                }
            else if (e.Control && e.KeyCode == Keys.A)
                foreach (ListViewItem item in FileList.Items)
                {
                    item.Selected = true;
                }
        }
        private void RemoveClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in FileList.SelectedItems)
            {
                item.Remove();
            }
        }
        #endregion

        #endregion

        #region ModelsChanged
        private void ModelsRadioButton1CheckedChanged(object sender, EventArgs e)
        {
            NoiseLevelComboBox.Items.Clear();
            NoiseLevelComboBox.Items.Add("off");
            NoiseLevelComboBox.Items.Add("1");
            NoiseLevelComboBox.Items.Add("2");
            NoiseLevelComboBox.Items.Add("3");
            NoiseLevelComboBox.Items.Add("4");
            scaleComboBox.Items.Clear();
            scaleComboBox.Items.Add("1x");
            scaleComboBox.Items.Add("2x");
            NoiseLevelComboBox.SelectedItem = "2";
            scaleComboBox.SelectedItem = "2x";
            NoiseLevelComboBox.Update();
            scaleComboBox.Update();
        }
        private void ModelsRadioButton2CheckedChanged(object sender, EventArgs e)
        {
            NoiseLevelComboBox.Items.Clear();
            NoiseLevelComboBox.Items.Add("off");
            NoiseLevelComboBox.Items.Add("1");
            NoiseLevelComboBox.Items.Add("2");
            NoiseLevelComboBox.Items.Add("3");
            NoiseLevelComboBox.Items.Add("4");
            scaleComboBox.Items.Clear();
            scaleComboBox.Items.Add("2x");
            NoiseLevelComboBox.SelectedItem = "2";
            scaleComboBox.SelectedItem = "2x";
            NoiseLevelComboBox.Update();
            scaleComboBox.Update();
        }
        private void ModelsRadioButton3CheckedChanged(object sender, EventArgs e)
        {
            NoiseLevelComboBox.Items.Clear();
            NoiseLevelComboBox.Items.Add("off");
            NoiseLevelComboBox.Items.Add("1");
            NoiseLevelComboBox.Items.Add("2");
            NoiseLevelComboBox.Items.Add("3");
            NoiseLevelComboBox.Items.Add("4");
            scaleComboBox.Items.Clear();
            scaleComboBox.Items.Add("2x");
            NoiseLevelComboBox.SelectedItem = "2";
            scaleComboBox.SelectedItem = "2x";
            NoiseLevelComboBox.Update();
            scaleComboBox.Update();
        }
        #endregion

        #endregion

        #region Program
        private void MainFormShown(object sender, EventArgs e)
        {
            ThreadTimer.Start();
            NoiseLevelComboBox.SelectedItem = "2";
            scaleComboBox.SelectedItem = "2x";
            NoiseLevelComboBox.Update();
            scaleComboBox.Update();
        }
        public MainForm()
        {
            InitializeComponent();
            FileList.DoubleBuffered(true);
        }
        #endregion

        #region FileDrop
        private void FileListDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        private void FileListDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                Thread thread = new Thread(() =>
                {
                    foreach (string file in files)
                    {
                        try
                        {
                            if (File.Exists(file))
                            {
                                bool duplicate = false;
                                FileInfo fileInfo = new FileInfo(file);
                                string fileName = Path.GetFileNameWithoutExtension(fileInfo.Name);
                                Invoke(new MethodInvoker(delegate ()
                                {
                                    foreach (ListViewItem item in FileList.Items)
                                    {
                                        if (fileName == item.Text)
                                        {
                                            if (fileInfo.FullName == ((FileInfo)item.Tag).FullName)
                                            {
                                                duplicate = true;
                                                break;
                                            }
                                        }
                                    }
                                }));
                                if (!duplicate && IsImageExtension(fileInfo.Extension))
                                {
                                    ListViewItem item = new ListViewItem(fileName);
                                    item.SubItems.Add(fileInfo.Extension.Replace(".", ""));
                                    item.SubItems.Add(GetFileSize(fileInfo.Length));
                                    item.Tag = fileInfo;
                                    Invoke(new MethodInvoker(delegate ()
                                    {
                                        FileList.Items.Add(item);
                                    }));
                                }
                            }
                            else if (Directory.Exists(file))
                                DirectoryGetFile(new DirectoryInfo(file));
                        }
                        catch (Exception ex)
                        {
                            ErrorLog(ex.ToString());
                        }
                    }
                });
                thread.Start();
            }
        }
        #endregion

        #region DirectorySearch
        private void DirectoryGetFile(DirectoryInfo directory)
        {
            try
            {
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (file.Exists)
                    {
                        if (IsImageExtension(file.Extension))
                        {
                            ListViewItem item = new ListViewItem(Path.GetFileNameWithoutExtension(file.Name));
                            item.SubItems.Add(file.Extension.Replace(".", ""));
                            item.SubItems.Add(GetFileSize(file.Length));
                            item.Tag = file;
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                FileList.Items.Add(item);
                            }));
                        }
                    }
                }
                foreach (DirectoryInfo directorY in directory.GetDirectories())
                {
                    if (directorY.Exists)
                        DirectoryGetFile(directorY);
                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.ToString());
            }
        }
        #endregion

        #region StartButton

        #region SelectedWork (edit)
        private void SelectedWorkButton_Click(object sender, EventArgs e)
        {
            if(!IsRendering)
            {
                IsRendering = true;
                InitialTest();
                SelectedWorkButton.Text = "Cancel";
                AllWorkButton.Enabled = false;
                AdvancedGroupBox.Enabled = false;
                OutputGroupBox.Enabled = false;
                ConvertingFiles = null;
                List<FileInfo> files = new List<FileInfo>();
                foreach (ListViewItem item in FileList.SelectedItems)
                {
                    item.ImageIndex = 2;
                    files.Add((FileInfo)item.Tag);
                }
                if (files.Count < ThreadMaxCount)
                {
                    DarkMessageBox.ShowError("The number of threads should not be more than the file!", "Error");
                    ThreadTextBox.Text = files.Count.ToString();
                    return;
                }
                ConvertingFiles = files.ToArray();
                Index = 0;
                LandingProcess();
            }
            else
            {
                if (LandingThread != null)
                    ProcessStopping();
                ResetUI();
            }
        }
        #endregion

        #region AllWork (edit)
        private void AllWorkButtonClick(object sender, EventArgs e)
        {
            if (!IsRendering)
            {
                IsRendering = true;
                InitialTest();
                AllWorkButton.Text = "Cancel";
                SelectedWorkButton.Enabled = false;
                AdvancedGroupBox.Enabled = false;
                OutputGroupBox.Enabled = false;
                ConvertingFiles = null;
                List<FileInfo> files = new List<FileInfo>();
                foreach (ListViewItem item in FileList.Items)
                {
                    item.ImageIndex = 2;
                    files.Add((FileInfo)item.Tag);
                }
                if (files.Count < ThreadMaxCount)
                {
                    DarkMessageBox.ShowError("The number of threads should not be more than the file!", "Error");
                    ThreadTextBox.Text = files.Count.ToString();
                    return;
                }
                ConvertingFiles = files.ToArray();
                Index = 0;
                LandingProcess();
            }
            else
            {
                if (LandingThread != null)
                    ProcessStopping();
                ResetUI();
            }
        }

        private void ProcessStopping()
        {
            LogBox.AppendText("Stopping main thread...");
            LogBox.ScrollToCaret();
            LandingThread.Abort();
            LandingThread.Join();
            int i = 0;
            int Waiting = 5;
            while (ThreadCount != 0)
            {
                Process[] processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Setting.Waifu2xPath));
                if (processes.Length == 0)
                {
                    ResetUI();
                    break;
                }
                if (i > Waiting)
                {
                    if (DarkMessageBox.ShowError("Process is not responding\nDo you want me to force the process to end?\nProcess Count : " + processes.Length, "Error!", DarkDialogButton.YesNo) == DialogResult.OK)
                    {
                        foreach (Process process in processes)
                        {
                            try { process.Kill(); } catch { }
                        }
                        ResetUI();
                        break;
                    }
                    else
                        Application.Restart();
                }
                LogBox.AppendText(string.Format("Waiting for process to end... {0}/{1}", i, Waiting));
                LogBox.ScrollToCaret();
                Thread.Sleep(1000);
                i++;
            }
        }
        #endregion

        #endregion

        #region ArgumentsCode
        private string SetArguments(FileInfo file)
        {
            string Arguments;
            string Input = file.FullName;
            string Output = OutputPath(file);
            Arguments = "-i \"" + Input + "\" -o \"" + Output + "\" -n " + GetNoiseLevel() + " -s " + GetScale();
            if(Regex.Replace(TileSizeTextBox.Text, @"\D", "") != "400")
                Arguments += " -t " + Regex.Replace(TileSizeTextBox.Text, @"\D", "");
            Arguments += " -j " + 
                Regex.Replace(ThreadCountTextBox1.Text, @"\D", "") + ":" + 
                Regex.Replace(ThreadCountTextBox2.Text, @"\D", "") + ":" + 
                Regex.Replace(ThreadCountTextBox3.Text, @"\D", "");
            if (EnableTtaModeCheckBox.Checked)
                Arguments += " -x";
            Arguments += " -m " + GetModels();
            Index++;
            return Arguments;
        }
        private string GetModels()
        {
            if (ModelsRadioButton1.Checked)
                return "models-cunet";
            else if (ModelsRadioButton2.Checked)
                return "models-upconv_7_anime_style_art_rgb";
            else
                return "models-upconv_7_photo";
        }
        private string GetScale()
        {
            return Regex.Replace(scaleComboBox.Text, @"\D", "");
            //switch (scaleComboBox.Text)
            //{
            //    case "1x":
            //        return "1";
            //    case "2x":
            //        return "2";
            //    default:
            //        return "2";
            //}
        }
        private string GetNoiseLevel()
        {
            if (NoiseLevelComboBox.Text == "off")
                return "-1";
            return Regex.Replace(NoiseLevelComboBox.Text, @"\D", "");
            //switch (NoiseLevelComboBox.Text)
            //{
            //    case "off":
            //        return "-1";
            //    case "1":
            //        return "0";
            //    case "2":
            //        return "1";
            //    case "3":
            //        return "2";
            //    case "4":
            //        return "3";
            //    default:
            //        return "0";
            //}
        }
        private string OutputPath(FileInfo file)
        {
            string FileName;
            string FilePath;
            if (FileNameRadio1.Checked)
                FileName = Index + " " + Path.GetFileNameWithoutExtension(file.Name) + ".png";
            else if (FileNameRadio2.Checked)
                 FileName = Path.GetFileNameWithoutExtension(file.Name) + "Waifu2x.png";
            else if (FileNameRadio3.Checked)
                FileName = Index.ToString() + ".png";
            else
                FileName = Path.GetFileNameWithoutExtension(file.Name) + ".png";
            if (FolderRadio1.Checked)
                FilePath = file.DirectoryName + "\\" + FileName;
            else
            {
                if (!Directory.Exists(Application.StartupPath + @"\Output"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Output");
                FilePath = Application.StartupPath + @"\Output\" + FileName;
            }
            if (ffmpegOutputFileList.Checked)
                File.AppendAllText(Application.StartupPath + @"\OutoutFileList.txt", "file \'" + FilePath + "\'\n");
            return FilePath;
        }
        #endregion

        #region FolderOpen
        private void OutputOpenButtonClick(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + @"\Output"))
                Directory.CreateDirectory(Application.StartupPath + @"\Output");
            Process.Start(new ProcessStartInfo(Application.StartupPath + @"\Output"));
        }
        #endregion

        #region MainProcessStart

        #region RepeatThreadExecution
        private void LandingProcess()
        {
            LandingThread = new Thread(() =>
            {
                int Tindex = 0;
                while (ConvertingFiles.Length > Index)
                {
                    if (ThreadCount >= ThreadMaxCount)
                        Thread.Sleep(100);
                    else
                    {
                        if (ConvertingFiles.Length < Index)
                            break;
                        ThreadProcess(Tindex);
                        Tindex++;
                    }
                }
            });
            LandingThread.Start();
        }
        #endregion

        #region ThreadProcessStart
        private void ThreadProcess(int ThisIndex)
        {
            ThreadCount++;
            Thread thread = new Thread(() =>
            {
                Stopwatch CodeStopwatch = new Stopwatch();
                FileInfo file = ConvertingFiles[ThisIndex];
                CodeStopwatch.Start();
                ProcessThreadReturn threadReturn = ProcessThread(file);
                CodeStopwatch.Stop();
                if (threadReturn.ErrorOccurred)
                {
                    FailedConvertingFiles.Add(file);
                    Invoke(new MethodInvoker(delegate ()
                    {
                        SetListView(0, file);
                        LogBox.AppendText(Environment.NewLine + threadReturn.ReturnValue + Environment.NewLine);
                        LogBox.AppendText(string.Format("Failed! {0}\n", ThisIndex));
                        LogBox.ScrollToCaret();
                    }));
                }
                else
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        SetListView(1, file);
                        LogBox.AppendText(Environment.NewLine + threadReturn.ReturnValue + Environment.NewLine);
                        LogBox.AppendText(string.Format("OK! {0}, {1}ms\n", ThisIndex, CodeStopwatch.ElapsedMilliseconds.ToString()));
                        LogBox.ScrollToCaret();
                    }));
                }
                CodeStopwatch = null;
                ThreadCount--;
            });
            thread.Start();
        }
        #endregion

        #region ProcessStart
        private ProcessThreadReturn ProcessThread(FileInfo file)
        {
            Process process = new Process();
            process.StartInfo.FileName = Setting.Waifu2xPath;
            string tmp = null;
            Invoke(new MethodInvoker(delegate ()
            {
                tmp = SetArguments(file);
                ArgumentsTextBox.Text = tmp;
            }));
            process.StartInfo.Arguments = tmp;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.WorkingDirectory = new FileInfo(Setting.Waifu2xPath).DirectoryName;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            if(!process.WaitForExit(TimeOutSec))
            {
                process.Kill();
                process.Close();
                return new ProcessThreadReturn("Time Out!", true);
            }
            string result = process.StandardError.ReadToEnd();
            process.Close();
            string[] temp = result.Split('\n');
            if (result.Contains("failed"))
                return new ProcessThreadReturn(result, true);
            else
                return new ProcessThreadReturn(result, false);
        }
        #endregion

        #endregion

        #region ThreadManager
        private void ThreadTimer_Tick(object sender, EventArgs e)
        {
            ThreadLabel1.Text = string.Format("Thread : {0}/{1}",ThreadCount,ThreadMaxCount);
            if(IsRendering && ConvertingFiles != null && ConvertingFiles.Length - 1 < Index && ThreadCount == 0)
            {
                IsRendering = false;
                foreach (FileInfo item in FailedConvertingFiles)
                {
                    ItemSelect(item);
                    LogBox.AppendText(string.Format("Conversion failed! {0}\n", item));
                    LogBox.ScrollToCaret();
                }
                if (FailedConvertingFiles.Count != 0)
                {
                    //DarkMessageBox.ShowError("There is a file that failed to convert!", "Error");
                    if(DarkMessageBox.ShowInformation(string.Format("Are you sure you want to convert the files of failed {0} again?", string.Join("\n",GetFileNames(FailedConvertingFiles.ToArray(),10))), "Information",DarkDialogButton.YesNo) == DialogResult.Yes)
                    {
                        if(FileNameRadio3.Checked) //FileNameRadio1.Checked
                        {
                            DialogResult result = DarkMessageBox.ShowWarning(MessageText.FileNameWarning, "Information", DarkDialogButton.YesNoCancel);
                            if (result == DialogResult.Yes)
                                FileNameRadio2.Checked = true;
                            else if(result == DialogResult.No)
                                FileNameRadio4.Checked = true;
                        }
                        ConvertingFiles = FailedConvertingFiles.ToArray();
                        FailedConvertingFiles = new List<FileInfo>();
                        Index = 0;
                        IsRendering = true;
                        LandingProcess();
                    }
                    else
                        ResetUI(false);
                    #region
                    //if(DarkMessageBox.ShowInformation("Do you want to convert the failed file again?", "Question?",DarkDialogButton.YesNo) == DialogResult.Yes)
                    //{
                    //    FileInfo[] failedFiles = FailedConvertingFiles.ToArray();
                    //    ConvertingFiles = failedFiles;
                    //    index = 0;
                    //    int Tindex = 0;
                    //    foreach (FileInfo item in failedFiles)
                    //    {
                    //        while (ConvertingFiles.Length > index)
                    //        {
                    //            if (ThreadCount >= ThreadMaxCount)
                    //                Thread.Sleep(100);
                    //            else
                    //            {
                    //                if (ConvertingFiles.Length < index)
                    //                    break;
                    //                ThreadProcess(Tindex);
                    //                Tindex++;
                    //            }
                    //        }
                    //        foreach (FileInfo item1 in FailedConvertingFiles)
                    //        {
                    //            Invoke(new MethodInvoker(delegate ()
                    //            {
                    //                LogBox.AppendText(string.Format("Conversion failed! {0}\n", item1));
                    //                LogBox.ScrollToCaret();
                    //            }));
                    //        }
                    //    }
                    //}
                    #endregion
                }
                else
                    ResetUI(true);
                FailedConvertingFiles = new List<FileInfo>();
            }
        }
        private void ResetUI(bool IsDone)
        {
            IsRendering = false;
            SelectedWorkButton.Text = "Start selected work!";
            AllWorkButton.Text = "Start all work!";
            SelectedWorkButton.Enabled = true;
            AllWorkButton.Enabled = true;
            AdvancedGroupBox.Enabled = true;
            OutputGroupBox.Enabled = true;
            if(IsDone)
                LogBox.AppendText("All Done!\n");
            else
                LogBox.AppendText("Exit!\n");
            LogBox.ScrollToCaret();
        }
        private void ResetUI()
        {
            IsRendering = false;
            SelectedWorkButton.Text = "Start selected work!";
            AllWorkButton.Text = "Start all work!";
            SelectedWorkButton.Enabled = true;
            AllWorkButton.Enabled = true;
            AdvancedGroupBox.Enabled = true;
            OutputGroupBox.Enabled = true;
            LogBox.AppendText("Done!\n");
            LogBox.ScrollToCaret();
        }
        #endregion

        private string[] GetFileNames(FileInfo[] files, int split = -1)
        {
            bool tmp = false;
            if (split == -1)
                split = files.Length - 1;
            else if (split < files.Length)
                tmp = true;
            List<string> fileNames = new List<string>();
            int i = 0;
            foreach (FileInfo item in files)
            {
                fileNames.Add(item.FullName);
                if (i == split)
                    break;
                i++;
            }
            if (tmp)
                fileNames.Add(string.Format(".... total {0} files",fileNames.Count));
            return fileNames.ToArray();
        }
    }

    #region Sort list views
    //http://whiteat.com/WhiteAT_Csharp/35681
    class ListViewItemSort : IComparer
    {
        private int col;
        public ListViewItemSort()
        {
            col = 0;
        }
        public ListViewItemSort(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
        }
    }
    class ListViewItemSortASC : IComparer
    {
        private int col;
        public ListViewItemSortASC()
        {
            col = 0;
        }
        public ListViewItemSortASC(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            try
            {
                if (Convert.ToInt32(((ListViewItem)x).SubItems[col].Text) > Convert.ToInt32(((ListViewItem)y).SubItems[col].Text))
                    return 1;
                else
                    return -1;
            }
            catch (Exception)
            {
                if (1 != String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text))
                    return -1;
                else
                    return 1;
            }
        }
    }
    class ListViewItemSortDESC : IComparer
    {
        private int col;
        public ListViewItemSortDESC()
        {
            col = 0;
        }
        public ListViewItemSortDESC(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            try
            {
                if (Convert.ToInt32(((ListViewItem)x).SubItems[col].Text) < Convert.ToInt32(((ListViewItem)y).SubItems[col].Text))
                    return 1;
                else
                    return -1;
            }

            catch (Exception)
            {
                if (string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text) == 1)
                    return -1;
                else
                    return 1;
            }
        }
    }
    #endregion

    #region ProcessThreadReturn
    public class ProcessThreadReturn
    {
        public string ReturnValue;
        public bool ErrorOccurred = false;
        public ProcessThreadReturn()
        {

        }
        public ProcessThreadReturn(string returnValue,bool errorOccurred)
        {
            ErrorOccurred = errorOccurred;
            ReturnValue = returnValue;
        }
    }
    #endregion

    #region DoubleBuffered
    public static class Extensions
    {
        public static void DoubleBuffered(this Control control, bool enabled)
        {
            var prop = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop.SetValue(control, enabled, null);
        }
    }
    #endregion
}
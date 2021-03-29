namespace waifu2x_ncnn_vulkan_gui
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ThreadLabel1 = new System.Windows.Forms.Label();
            this.runningLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FileList = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImageType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveContextMenu = new DarkUI.Controls.DarkContextMenu();
            this.RemoveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorImageList = new System.Windows.Forms.ImageList(this.components);
            this.AdvancedGroupBox = new DarkUI.Controls.DarkGroupBox();
            this.ModelPanel = new System.Windows.Forms.Panel();
            this.ModelsRadioButton3 = new System.Windows.Forms.RadioButton();
            this.ModelsRadioButton2 = new System.Windows.Forms.RadioButton();
            this.ModelsRadioButton1 = new System.Windows.Forms.RadioButton();
            this.EnableTtaModeCheckBox = new DarkUI.Controls.DarkCheckBox();
            this.ThreadTextBox = new DarkUI.Controls.DarkTextBox();
            this.ThreadCountTextBox3 = new DarkUI.Controls.DarkTextBox();
            this.ThreadCountTextBox2 = new DarkUI.Controls.DarkTextBox();
            this.ThreadCountTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.TimeOutTextBox = new DarkUI.Controls.DarkTextBox();
            this.TileSizeTextBox = new DarkUI.Controls.DarkTextBox();
            this.scaleLabel = new DarkUI.Controls.DarkLabel();
            this.scaleComboBox = new DarkUI.Controls.DarkComboBox();
            this.SecLabel = new DarkUI.Controls.DarkLabel();
            this.ColonLabel2 = new DarkUI.Controls.DarkLabel();
            this.ColonLabel1 = new DarkUI.Controls.DarkLabel();
            this.ThreadLabel = new DarkUI.Controls.DarkLabel();
            this.EnableTtaModeLabel = new DarkUI.Controls.DarkLabel();
            this.ThreadCountLabel = new DarkUI.Controls.DarkLabel();
            this.TimeOutLabel = new DarkUI.Controls.DarkLabel();
            this.TileSizeLabel = new DarkUI.Controls.DarkLabel();
            this.NoiseLevelLabel = new DarkUI.Controls.DarkLabel();
            this.NoiseLevelComboBox = new DarkUI.Controls.DarkComboBox();
            this.ArgumentsTextBox = new DarkUI.Controls.DarkTextBox();
            this.AllWorkButton = new DarkUI.Controls.DarkButton();
            this.SelectedWorkButton = new DarkUI.Controls.DarkButton();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.OutputGroupBox = new DarkUI.Controls.DarkGroupBox();
            this.OutputOpenButton = new DarkUI.Controls.DarkButton();
            this.FileNamePanel = new System.Windows.Forms.Panel();
            this.ffmpegOutputFileList = new DarkUI.Controls.DarkCheckBox();
            this.FileNameRadio4 = new System.Windows.Forms.RadioButton();
            this.FileNameRadio3 = new System.Windows.Forms.RadioButton();
            this.FileNameRadio2 = new System.Windows.Forms.RadioButton();
            this.FileNameRadio1 = new System.Windows.Forms.RadioButton();
            this.FolderRadio2 = new System.Windows.Forms.RadioButton();
            this.FolderRadio1 = new System.Windows.Forms.RadioButton();
            this.ThreadTimer = new System.Windows.Forms.Timer(this.components);
            this.TitleBar.SuspendLayout();
            this.RemoveContextMenu.SuspendLayout();
            this.AdvancedGroupBox.SuspendLayout();
            this.ModelPanel.SuspendLayout();
            this.OutputGroupBox.SuspendLayout();
            this.FileNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.TitleBar.Controls.Add(this.TitleLabel);
            this.TitleBar.Controls.Add(this.ThreadLabel1);
            this.TitleBar.Controls.Add(this.runningLabel);
            this.TitleBar.Controls.Add(this.MinimizeButton);
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(924, 27);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarMouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBarMouseMove);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(146, 15);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Waifu2x ncnn Vulkan GUI";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBarMouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBarMouseMove);
            // 
            // ThreadLabel1
            // 
            this.ThreadLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreadLabel1.AutoSize = true;
            this.ThreadLabel1.Location = new System.Drawing.Point(727, 6);
            this.ThreadLabel1.Name = "ThreadLabel1";
            this.ThreadLabel1.Size = new System.Drawing.Size(61, 15);
            this.ThreadLabel1.TabIndex = 8;
            this.ThreadLabel1.Text = "Thread : 0";
            // 
            // runningLabel
            // 
            this.runningLabel.AutoSize = true;
            this.runningLabel.Location = new System.Drawing.Point(187, 6);
            this.runningLabel.Name = "runningLabel";
            this.runningLabel.Size = new System.Drawing.Size(36, 15);
            this.runningLabel.TabIndex = 8;
            this.runningLabel.Text = "None";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(75)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(842, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(36, 27);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(878, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(46, 27);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // FileList
            // 
            this.FileList.AllowDrop = true;
            this.FileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.ImageType,
            this.FileSize});
            this.FileList.ContextMenuStrip = this.RemoveContextMenu;
            this.FileList.ForeColor = System.Drawing.Color.White;
            this.FileList.FullRowSelect = true;
            this.FileList.HideSelection = false;
            this.FileList.LargeImageList = this.ErrorImageList;
            this.FileList.Location = new System.Drawing.Point(15, 43);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(624, 277);
            this.FileList.SmallImageList = this.ErrorImageList;
            this.FileList.TabIndex = 1;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.Details;
            this.FileList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.FileListColumnClick);
            this.FileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileListDragDrop);
            this.FileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileListDragEnter);
            this.FileList.DoubleClick += new System.EventHandler(this.FileListDoubleClick);
            this.FileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileList_KeyDown);
            // 
            // FileName
            // 
            this.FileName.Text = "FileName";
            this.FileName.Width = 456;
            // 
            // ImageType
            // 
            this.ImageType.Text = "ImageType";
            this.ImageType.Width = 70;
            // 
            // FileSize
            // 
            this.FileSize.Text = "Size";
            this.FileSize.Width = 70;
            // 
            // RemoveContextMenu
            // 
            this.RemoveContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.RemoveContextMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RemoveContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveButton});
            this.RemoveContextMenu.Name = "RemoveContextMenu";
            this.RemoveContextMenu.Size = new System.Drawing.Size(137, 26);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.RemoveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(136, 22);
            this.RemoveButton.Text = "Remove (&R)";
            this.RemoveButton.Click += new System.EventHandler(this.RemoveClick);
            // 
            // ErrorImageList
            // 
            this.ErrorImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ErrorImageList.ImageStream")));
            this.ErrorImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ErrorImageList.Images.SetKeyName(0, "red.png");
            this.ErrorImageList.Images.SetKeyName(1, "Green.png");
            this.ErrorImageList.Images.SetKeyName(2, "yellow.png");
            // 
            // AdvancedGroupBox
            // 
            this.AdvancedGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdvancedGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AdvancedGroupBox.Controls.Add(this.ModelPanel);
            this.AdvancedGroupBox.Controls.Add(this.EnableTtaModeCheckBox);
            this.AdvancedGroupBox.Controls.Add(this.ThreadTextBox);
            this.AdvancedGroupBox.Controls.Add(this.ThreadCountTextBox3);
            this.AdvancedGroupBox.Controls.Add(this.ThreadCountTextBox2);
            this.AdvancedGroupBox.Controls.Add(this.ThreadCountTextBox1);
            this.AdvancedGroupBox.Controls.Add(this.TimeOutTextBox);
            this.AdvancedGroupBox.Controls.Add(this.TileSizeTextBox);
            this.AdvancedGroupBox.Controls.Add(this.scaleLabel);
            this.AdvancedGroupBox.Controls.Add(this.scaleComboBox);
            this.AdvancedGroupBox.Controls.Add(this.SecLabel);
            this.AdvancedGroupBox.Controls.Add(this.ColonLabel2);
            this.AdvancedGroupBox.Controls.Add(this.ColonLabel1);
            this.AdvancedGroupBox.Controls.Add(this.ThreadLabel);
            this.AdvancedGroupBox.Controls.Add(this.EnableTtaModeLabel);
            this.AdvancedGroupBox.Controls.Add(this.ThreadCountLabel);
            this.AdvancedGroupBox.Controls.Add(this.TimeOutLabel);
            this.AdvancedGroupBox.Controls.Add(this.TileSizeLabel);
            this.AdvancedGroupBox.Controls.Add(this.NoiseLevelLabel);
            this.AdvancedGroupBox.Controls.Add(this.NoiseLevelComboBox);
            this.AdvancedGroupBox.Location = new System.Drawing.Point(645, 43);
            this.AdvancedGroupBox.Name = "AdvancedGroupBox";
            this.AdvancedGroupBox.Size = new System.Drawing.Size(266, 248);
            this.AdvancedGroupBox.TabIndex = 3;
            this.AdvancedGroupBox.TabStop = false;
            this.AdvancedGroupBox.Text = "Advanced";
            // 
            // ModelPanel
            // 
            this.ModelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ModelPanel.Controls.Add(this.ModelsRadioButton3);
            this.ModelPanel.Controls.Add(this.ModelsRadioButton2);
            this.ModelPanel.Controls.Add(this.ModelsRadioButton1);
            this.ModelPanel.Location = new System.Drawing.Point(9, 167);
            this.ModelPanel.Name = "ModelPanel";
            this.ModelPanel.Size = new System.Drawing.Size(251, 75);
            this.ModelPanel.TabIndex = 11;
            // 
            // ModelsRadioButton3
            // 
            this.ModelsRadioButton3.Location = new System.Drawing.Point(2, 54);
            this.ModelsRadioButton3.Name = "ModelsRadioButton3";
            this.ModelsRadioButton3.Size = new System.Drawing.Size(247, 19);
            this.ModelsRadioButton3.TabIndex = 9;
            this.ModelsRadioButton3.Text = "models-upconv_7_photo";
            this.ModelsRadioButton3.UseVisualStyleBackColor = true;
            this.ModelsRadioButton3.CheckedChanged += new System.EventHandler(this.ModelsRadioButton3CheckedChanged);
            // 
            // ModelsRadioButton2
            // 
            this.ModelsRadioButton2.Checked = true;
            this.ModelsRadioButton2.Location = new System.Drawing.Point(2, 29);
            this.ModelsRadioButton2.Name = "ModelsRadioButton2";
            this.ModelsRadioButton2.Size = new System.Drawing.Size(247, 19);
            this.ModelsRadioButton2.TabIndex = 9;
            this.ModelsRadioButton2.TabStop = true;
            this.ModelsRadioButton2.Text = "models-upconv_7_anime_style_art_rgb";
            this.ModelsRadioButton2.UseVisualStyleBackColor = true;
            this.ModelsRadioButton2.CheckedChanged += new System.EventHandler(this.ModelsRadioButton2CheckedChanged);
            // 
            // ModelsRadioButton1
            // 
            this.ModelsRadioButton1.Location = new System.Drawing.Point(2, 4);
            this.ModelsRadioButton1.Name = "ModelsRadioButton1";
            this.ModelsRadioButton1.Size = new System.Drawing.Size(247, 19);
            this.ModelsRadioButton1.TabIndex = 9;
            this.ModelsRadioButton1.Text = "models-cunet";
            this.ModelsRadioButton1.UseVisualStyleBackColor = true;
            this.ModelsRadioButton1.CheckedChanged += new System.EventHandler(this.ModelsRadioButton1CheckedChanged);
            // 
            // EnableTtaModeCheckBox
            // 
            this.EnableTtaModeCheckBox.AutoSize = true;
            this.EnableTtaModeCheckBox.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.EnableTtaModeCheckBox.Location = new System.Drawing.Point(146, 147);
            this.EnableTtaModeCheckBox.Name = "EnableTtaModeCheckBox";
            this.EnableTtaModeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EnableTtaModeCheckBox.TabIndex = 8;
            // 
            // ThreadTextBox
            // 
            this.ThreadTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ThreadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThreadTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ThreadTextBox.Location = new System.Drawing.Point(236, 143);
            this.ThreadTextBox.Name = "ThreadTextBox";
            this.ThreadTextBox.Size = new System.Drawing.Size(26, 23);
            this.ThreadTextBox.TabIndex = 7;
            this.ThreadTextBox.Text = "1";
            this.ThreadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThreadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // ThreadCountTextBox3
            // 
            this.ThreadCountTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ThreadCountTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThreadCountTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ThreadCountTextBox3.Location = new System.Drawing.Point(212, 103);
            this.ThreadCountTextBox3.Name = "ThreadCountTextBox3";
            this.ThreadCountTextBox3.Size = new System.Drawing.Size(26, 23);
            this.ThreadCountTextBox3.TabIndex = 7;
            this.ThreadCountTextBox3.Text = "2";
            this.ThreadCountTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThreadCountTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // ThreadCountTextBox2
            // 
            this.ThreadCountTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ThreadCountTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThreadCountTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ThreadCountTextBox2.Location = new System.Drawing.Point(164, 103);
            this.ThreadCountTextBox2.Name = "ThreadCountTextBox2";
            this.ThreadCountTextBox2.Size = new System.Drawing.Size(26, 23);
            this.ThreadCountTextBox2.TabIndex = 7;
            this.ThreadCountTextBox2.Text = "2";
            this.ThreadCountTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThreadCountTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // ThreadCountTextBox1
            // 
            this.ThreadCountTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ThreadCountTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThreadCountTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ThreadCountTextBox1.Location = new System.Drawing.Point(117, 103);
            this.ThreadCountTextBox1.Name = "ThreadCountTextBox1";
            this.ThreadCountTextBox1.Size = new System.Drawing.Size(26, 23);
            this.ThreadCountTextBox1.TabIndex = 7;
            this.ThreadCountTextBox1.Text = "2";
            this.ThreadCountTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThreadCountTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // TimeOutTextBox
            // 
            this.TimeOutTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TimeOutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeOutTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TimeOutTextBox.Location = new System.Drawing.Point(203, 63);
            this.TimeOutTextBox.Name = "TimeOutTextBox";
            this.TimeOutTextBox.Size = new System.Drawing.Size(41, 23);
            this.TimeOutTextBox.TabIndex = 7;
            this.TimeOutTextBox.Text = "60";
            this.TimeOutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeOutTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // TileSizeTextBox
            // 
            this.TileSizeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TileSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TileSizeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TileSizeTextBox.Location = new System.Drawing.Point(87, 63);
            this.TileSizeTextBox.Name = "TileSizeTextBox";
            this.TileSizeTextBox.Size = new System.Drawing.Size(38, 23);
            this.TileSizeTextBox.TabIndex = 7;
            this.TileSizeTextBox.Text = "400";
            this.TileSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TileSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.scaleLabel.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.scaleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.scaleLabel.Location = new System.Drawing.Point(162, 23);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(50, 20);
            this.scaleLabel.TabIndex = 6;
            this.scaleLabel.Text = "scale :";
            // 
            // scaleComboBox
            // 
            this.scaleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.scaleComboBox.FormattingEnabled = true;
            this.scaleComboBox.Items.AddRange(new object[] {
            "1x",
            "2x"});
            this.scaleComboBox.Location = new System.Drawing.Point(219, 21);
            this.scaleComboBox.Name = "scaleComboBox";
            this.scaleComboBox.Size = new System.Drawing.Size(38, 24);
            this.scaleComboBox.TabIndex = 5;
            // 
            // SecLabel
            // 
            this.SecLabel.AutoSize = true;
            this.SecLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SecLabel.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.SecLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SecLabel.Location = new System.Drawing.Point(244, 64);
            this.SecLabel.Name = "SecLabel";
            this.SecLabel.Size = new System.Drawing.Size(15, 20);
            this.SecLabel.TabIndex = 6;
            this.SecLabel.Text = "s";
            // 
            // ColonLabel2
            // 
            this.ColonLabel2.AutoSize = true;
            this.ColonLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ColonLabel2.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.ColonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ColonLabel2.Location = new System.Drawing.Point(195, 104);
            this.ColonLabel2.Name = "ColonLabel2";
            this.ColonLabel2.Size = new System.Drawing.Size(12, 20);
            this.ColonLabel2.TabIndex = 6;
            this.ColonLabel2.Text = ":";
            // 
            // ColonLabel1
            // 
            this.ColonLabel1.AutoSize = true;
            this.ColonLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ColonLabel1.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.ColonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ColonLabel1.Location = new System.Drawing.Point(147, 104);
            this.ColonLabel1.Name = "ColonLabel1";
            this.ColonLabel1.Size = new System.Drawing.Size(12, 20);
            this.ColonLabel1.TabIndex = 6;
            this.ColonLabel1.Text = ":";
            // 
            // ThreadLabel
            // 
            this.ThreadLabel.AutoSize = true;
            this.ThreadLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ThreadLabel.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.ThreadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ThreadLabel.Location = new System.Drawing.Point(167, 144);
            this.ThreadLabel.Name = "ThreadLabel";
            this.ThreadLabel.Size = new System.Drawing.Size(69, 20);
            this.ThreadLabel.TabIndex = 6;
            this.ThreadLabel.Text = "Thread : ";
            // 
            // EnableTtaModeLabel
            // 
            this.EnableTtaModeLabel.AutoSize = true;
            this.EnableTtaModeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.EnableTtaModeLabel.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.EnableTtaModeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.EnableTtaModeLabel.Location = new System.Drawing.Point(6, 144);
            this.EnableTtaModeLabel.Name = "EnableTtaModeLabel";
            this.EnableTtaModeLabel.Size = new System.Drawing.Size(132, 20);
            this.EnableTtaModeLabel.TabIndex = 6;
            this.EnableTtaModeLabel.Text = "enable-tta-mode :";
            // 
            // ThreadCountLabel
            // 
            this.ThreadCountLabel.AutoSize = true;
            this.ThreadCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ThreadCountLabel.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.ThreadCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ThreadCountLabel.Location = new System.Drawing.Point(6, 104);
            this.ThreadCountLabel.Name = "ThreadCountLabel";
            this.ThreadCountLabel.Size = new System.Drawing.Size(106, 20);
            this.ThreadCountLabel.TabIndex = 6;
            this.ThreadCountLabel.Text = "thread-count :";
            // 
            // TimeOutLabel
            // 
            this.TimeOutLabel.AutoSize = true;
            this.TimeOutLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TimeOutLabel.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.TimeOutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TimeOutLabel.Location = new System.Drawing.Point(129, 64);
            this.TimeOutLabel.Name = "TimeOutLabel";
            this.TimeOutLabel.Size = new System.Drawing.Size(78, 20);
            this.TimeOutLabel.TabIndex = 6;
            this.TimeOutLabel.Text = "Timeout : ";
            // 
            // TileSizeLabel
            // 
            this.TileSizeLabel.AutoSize = true;
            this.TileSizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TileSizeLabel.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.TileSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TileSizeLabel.Location = new System.Drawing.Point(6, 64);
            this.TileSizeLabel.Name = "TileSizeLabel";
            this.TileSizeLabel.Size = new System.Drawing.Size(74, 20);
            this.TileSizeLabel.TabIndex = 6;
            this.TileSizeLabel.Text = "tile-size : ";
            // 
            // NoiseLevelLabel
            // 
            this.NoiseLevelLabel.AutoSize = true;
            this.NoiseLevelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.NoiseLevelLabel.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.NoiseLevelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.NoiseLevelLabel.Location = new System.Drawing.Point(6, 23);
            this.NoiseLevelLabel.Name = "NoiseLevelLabel";
            this.NoiseLevelLabel.Size = new System.Drawing.Size(90, 20);
            this.NoiseLevelLabel.TabIndex = 6;
            this.NoiseLevelLabel.Text = "noise-level :";
            // 
            // NoiseLevelComboBox
            // 
            this.NoiseLevelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.NoiseLevelComboBox.FormattingEnabled = true;
            this.NoiseLevelComboBox.Items.AddRange(new object[] {
            "off",
            "1",
            "2",
            "3",
            "4"});
            this.NoiseLevelComboBox.Location = new System.Drawing.Point(103, 21);
            this.NoiseLevelComboBox.Name = "NoiseLevelComboBox";
            this.NoiseLevelComboBox.Size = new System.Drawing.Size(38, 24);
            this.NoiseLevelComboBox.TabIndex = 5;
            // 
            // ArgumentsTextBox
            // 
            this.ArgumentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgumentsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.ArgumentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArgumentsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ArgumentsTextBox.Location = new System.Drawing.Point(15, 326);
            this.ArgumentsTextBox.Name = "ArgumentsTextBox";
            this.ArgumentsTextBox.ReadOnly = true;
            this.ArgumentsTextBox.Size = new System.Drawing.Size(624, 23);
            this.ArgumentsTextBox.TabIndex = 4;
            // 
            // AllWorkButton
            // 
            this.AllWorkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AllWorkButton.Location = new System.Drawing.Point(645, 326);
            this.AllWorkButton.Name = "AllWorkButton";
            this.AllWorkButton.Padding = new System.Windows.Forms.Padding(5);
            this.AllWorkButton.Size = new System.Drawing.Size(267, 23);
            this.AllWorkButton.TabIndex = 5;
            this.AllWorkButton.Text = "Start all work!";
            this.AllWorkButton.Click += new System.EventHandler(this.AllWorkButtonClick);
            // 
            // SelectedWorkButton
            // 
            this.SelectedWorkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedWorkButton.Location = new System.Drawing.Point(645, 297);
            this.SelectedWorkButton.Name = "SelectedWorkButton";
            this.SelectedWorkButton.Padding = new System.Windows.Forms.Padding(5);
            this.SelectedWorkButton.Size = new System.Drawing.Size(267, 23);
            this.SelectedWorkButton.TabIndex = 5;
            this.SelectedWorkButton.Text = "Start selected work!";
            this.SelectedWorkButton.Click += new System.EventHandler(this.SelectedWorkButton_Click);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.ForeColor = System.Drawing.Color.White;
            this.LogBox.Location = new System.Drawing.Point(15, 355);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(624, 165);
            this.LogBox.TabIndex = 6;
            this.LogBox.Text = "";
            this.LogBox.TextChanged += new System.EventHandler(this.LogBoxTextChanged);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.OutputGroupBox.Controls.Add(this.OutputOpenButton);
            this.OutputGroupBox.Controls.Add(this.FileNamePanel);
            this.OutputGroupBox.Controls.Add(this.FolderRadio2);
            this.OutputGroupBox.Controls.Add(this.FolderRadio1);
            this.OutputGroupBox.Location = new System.Drawing.Point(645, 355);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(267, 173);
            this.OutputGroupBox.TabIndex = 7;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Output";
            // 
            // OutputOpenButton
            // 
            this.OutputOpenButton.Location = new System.Drawing.Point(199, 47);
            this.OutputOpenButton.Name = "OutputOpenButton";
            this.OutputOpenButton.Padding = new System.Windows.Forms.Padding(5);
            this.OutputOpenButton.Size = new System.Drawing.Size(58, 19);
            this.OutputOpenButton.TabIndex = 11;
            this.OutputOpenButton.Text = "Open..";
            this.OutputOpenButton.Click += new System.EventHandler(this.OutputOpenButtonClick);
            // 
            // FileNamePanel
            // 
            this.FileNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.FileNamePanel.Controls.Add(this.ffmpegOutputFileList);
            this.FileNamePanel.Controls.Add(this.FileNameRadio4);
            this.FileNamePanel.Controls.Add(this.FileNameRadio3);
            this.FileNamePanel.Controls.Add(this.FileNameRadio2);
            this.FileNamePanel.Controls.Add(this.FileNameRadio1);
            this.FileNamePanel.Location = new System.Drawing.Point(8, 72);
            this.FileNamePanel.Name = "FileNamePanel";
            this.FileNamePanel.Size = new System.Drawing.Size(251, 101);
            this.FileNamePanel.TabIndex = 10;
            // 
            // ffmpegOutputFileList
            // 
            this.ffmpegOutputFileList.AutoSize = true;
            this.ffmpegOutputFileList.Location = new System.Drawing.Point(100, 78);
            this.ffmpegOutputFileList.Name = "ffmpegOutputFileList";
            this.ffmpegOutputFileList.Size = new System.Drawing.Size(151, 19);
            this.ffmpegOutputFileList.TabIndex = 8;
            this.ffmpegOutputFileList.Text = "ffmpeg Output File List";
            // 
            // FileNameRadio4
            // 
            this.FileNameRadio4.Checked = true;
            this.FileNameRadio4.Location = new System.Drawing.Point(2, 77);
            this.FileNameRadio4.Name = "FileNameRadio4";
            this.FileNameRadio4.Size = new System.Drawing.Size(247, 19);
            this.FileNameRadio4.TabIndex = 9;
            this.FileNameRadio4.TabStop = true;
            this.FileNameRadio4.Text = "%FileName%";
            this.FileNameRadio4.UseVisualStyleBackColor = true;
            // 
            // FileNameRadio3
            // 
            this.FileNameRadio3.Location = new System.Drawing.Point(2, 54);
            this.FileNameRadio3.Name = "FileNameRadio3";
            this.FileNameRadio3.Size = new System.Drawing.Size(247, 19);
            this.FileNameRadio3.TabIndex = 9;
            this.FileNameRadio3.Text = "%index%";
            this.FileNameRadio3.UseVisualStyleBackColor = true;
            // 
            // FileNameRadio2
            // 
            this.FileNameRadio2.Location = new System.Drawing.Point(2, 29);
            this.FileNameRadio2.Name = "FileNameRadio2";
            this.FileNameRadio2.Size = new System.Drawing.Size(247, 19);
            this.FileNameRadio2.TabIndex = 9;
            this.FileNameRadio2.Text = "%FileName% Waifu2x";
            this.FileNameRadio2.UseVisualStyleBackColor = true;
            // 
            // FileNameRadio1
            // 
            this.FileNameRadio1.Location = new System.Drawing.Point(2, 4);
            this.FileNameRadio1.Name = "FileNameRadio1";
            this.FileNameRadio1.Size = new System.Drawing.Size(247, 19);
            this.FileNameRadio1.TabIndex = 9;
            this.FileNameRadio1.Text = "%index% %FileName%";
            this.FileNameRadio1.UseVisualStyleBackColor = true;
            // 
            // FolderRadio2
            // 
            this.FolderRadio2.Checked = true;
            this.FolderRadio2.Location = new System.Drawing.Point(10, 47);
            this.FolderRadio2.Name = "FolderRadio2";
            this.FolderRadio2.Size = new System.Drawing.Size(247, 19);
            this.FolderRadio2.TabIndex = 9;
            this.FolderRadio2.TabStop = true;
            this.FolderRadio2.Text = "Output Folder";
            this.FolderRadio2.UseVisualStyleBackColor = true;
            // 
            // FolderRadio1
            // 
            this.FolderRadio1.Location = new System.Drawing.Point(10, 22);
            this.FolderRadio1.Name = "FolderRadio1";
            this.FolderRadio1.Size = new System.Drawing.Size(247, 19);
            this.FolderRadio1.TabIndex = 9;
            this.FolderRadio1.Text = "Source Folder";
            this.FolderRadio1.UseVisualStyleBackColor = true;
            // 
            // ThreadTimer
            // 
            this.ThreadTimer.Tick += new System.EventHandler(this.ThreadTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(924, 532);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.SelectedWorkButton);
            this.Controls.Add(this.AllWorkButton);
            this.Controls.Add(this.ArgumentsTextBox);
            this.Controls.Add(this.AdvancedGroupBox);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.TitleBar);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(924, 532);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Waifu2x GUI";
            this.Shown += new System.EventHandler(this.MainFormShown);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.RemoveContextMenu.ResumeLayout(false);
            this.AdvancedGroupBox.ResumeLayout(false);
            this.AdvancedGroupBox.PerformLayout();
            this.ModelPanel.ResumeLayout(false);
            this.OutputGroupBox.ResumeLayout(false);
            this.FileNamePanel.ResumeLayout(false);
            this.FileNamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListView FileList;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader ImageType;
        private System.Windows.Forms.ColumnHeader FileSize;
        private DarkUI.Controls.DarkGroupBox AdvancedGroupBox;
        private DarkUI.Controls.DarkLabel NoiseLevelLabel;
        private DarkUI.Controls.DarkComboBox NoiseLevelComboBox;
        private DarkUI.Controls.DarkTextBox ArgumentsTextBox;
        private DarkUI.Controls.DarkTextBox TileSizeTextBox;
        private DarkUI.Controls.DarkLabel scaleLabel;
        private DarkUI.Controls.DarkComboBox scaleComboBox;
        private DarkUI.Controls.DarkLabel TileSizeLabel;
        private DarkUI.Controls.DarkTextBox ThreadCountTextBox3;
        private DarkUI.Controls.DarkTextBox ThreadCountTextBox2;
        private DarkUI.Controls.DarkTextBox ThreadCountTextBox1;
        private DarkUI.Controls.DarkLabel ColonLabel2;
        private DarkUI.Controls.DarkLabel ColonLabel1;
        private DarkUI.Controls.DarkLabel ThreadCountLabel;
        private DarkUI.Controls.DarkCheckBox EnableTtaModeCheckBox;
        private DarkUI.Controls.DarkLabel EnableTtaModeLabel;
        private DarkUI.Controls.DarkButton AllWorkButton;
        private DarkUI.Controls.DarkButton SelectedWorkButton;
        private System.Windows.Forms.RichTextBox LogBox;
        private DarkUI.Controls.DarkGroupBox OutputGroupBox;
        private System.Windows.Forms.Panel FileNamePanel;
        private System.Windows.Forms.RadioButton FileNameRadio2;
        private System.Windows.Forms.RadioButton FileNameRadio1;
        private System.Windows.Forms.RadioButton FolderRadio2;
        private System.Windows.Forms.RadioButton FolderRadio1;
        private System.Windows.Forms.ImageList ErrorImageList;
        private System.Windows.Forms.Label runningLabel;
        private System.Windows.Forms.RadioButton FileNameRadio3;
        private DarkUI.Controls.DarkButton OutputOpenButton;
        private DarkUI.Controls.DarkContextMenu RemoveContextMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveButton;
        private System.Windows.Forms.Panel ModelPanel;
        private System.Windows.Forms.RadioButton ModelsRadioButton3;
        private System.Windows.Forms.RadioButton ModelsRadioButton2;
        private System.Windows.Forms.RadioButton ModelsRadioButton1;
        private DarkUI.Controls.DarkTextBox ThreadTextBox;
        private DarkUI.Controls.DarkLabel ThreadLabel;
        private System.Windows.Forms.Label ThreadLabel1;
        private System.Windows.Forms.Timer ThreadTimer;
        private DarkUI.Controls.DarkTextBox TimeOutTextBox;
        private DarkUI.Controls.DarkLabel TimeOutLabel;
        private DarkUI.Controls.DarkLabel SecLabel;
        private System.Windows.Forms.RadioButton FileNameRadio4;
        private DarkUI.Controls.DarkCheckBox ffmpegOutputFileList;
    }
}


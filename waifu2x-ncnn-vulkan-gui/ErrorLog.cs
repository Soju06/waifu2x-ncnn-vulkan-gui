using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waifu2x_ncnn_vulkan_gui
{
    public partial class ErrorLog : Form
    {
        public ErrorLog()
        {
            InitializeComponent();
        }
        public void Log(string txt)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    richTextBox1.AppendText(txt + "\n\n");
                    richTextBox1.ScrollToCaret();
                    Show();
                }));
            }
            else
            {
                richTextBox1.AppendText(txt + "\n\n");
                richTextBox1.ScrollToCaret();
                Show();
            }
        }
    }
}

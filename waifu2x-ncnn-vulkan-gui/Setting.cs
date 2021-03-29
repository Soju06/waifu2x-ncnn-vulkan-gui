using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waifu2x_ncnn_vulkan_gui
{
    class Setting
    {
        public readonly static string Waifu2xPath = Application.StartupPath + @"\waifu2x-ncnn-vulkan\waifu2x-ncnn-vulkan.exe";
    }
    class MessageText
    {
        public static readonly string FileNameWarning = 
            "The file name contains %index%\n" +
            "#Other files may be overwritten!#\n" +
            "To change to %FileName% Waifu2x, click the Yes button,\n" +
            "To change to %FileName%, click the No button.\n" +
            "Press the Cancel button to continue with the existing state.\n" +
            "File Start Name : \"0.png\"";
    }
}

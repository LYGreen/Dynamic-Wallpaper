using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dynamic_Wallpaper.Properties;

namespace Dynamic_Wallpaper
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //浏览器设置
            var settings = new CefSettings()
            {
                Locale = "zh-CN",
                CachePath = Directory.GetCurrentDirectory() + @"\Cache",
            };
            settings.CefCommandLineArgs.Add("proxy-auto-detect", "0");
            settings.CefCommandLineArgs.Add("no-proxy-server", "1");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }
    }
}

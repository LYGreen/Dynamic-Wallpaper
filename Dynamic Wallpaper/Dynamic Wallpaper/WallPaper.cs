using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Wallpaper
{
    //该窗口(WallPaper)用于动态壁纸
    public partial class WallPaper : Form
    {
        public WallPaper(string path)
        {
            InitializeComponent();
            InitWindow();
            InitBrowser(path);
            SetDynamicWallPaper();
        }

        public void InitWindow()
        {
            //初始化WallPaper窗口
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            panel_Browser.Location = new Point(0, 0);
            panel_Browser.Size = Size;
        }
        
        public ChromiumWebBrowser browser;
        public void InitBrowser(string path)
        {
            //将浏览器对象初始化
            browser = new ChromiumWebBrowser(path);
            browser.Parent = panel_Browser;//将浏览器对象的载体设置为panel_Browser控件
            browser.Dock = DockStyle.Fill;
            browser.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(FrameLoadEndFunc);
        }

        private void FrameLoadEndFunc(object sender, FrameLoadEndEventArgs e)
        {
            if(e.Frame.IsMain)
            {
                //隐藏浏览器的滚动条
                e.Browser.MainFrame.ExecuteJavaScriptAsync("document.body.style.overflow = 'hidden'");
            }
        }

        //将WallPaper窗口放置在图标窗口的后面
        private void SetDynamicWallPaper()
        {
            //hProgman为Progman窗口
            IntPtr hProgman = DllImports.FindWindow("Progman", "Program Manager");
            //向Progman窗口发送消息0x52c
            DllImports.SendMessageTimeout(hProgman, 0x52c, 0, 0, 0, 100, out _);

            IntPtr workerW = IntPtr.Zero;
            do
            {
                //找出workerW-1窗口
                workerW = DllImports.FindWindowEx(IntPtr.Zero, workerW, "workerW", null);
                if (DllImports.GetParent(workerW) == hProgman)
                {
                    //隐藏workerW-1窗口
                    DllImports.ShowWindow(workerW, 0);
                }
            } while (workerW != IntPtr.Zero);
            //将WallPaper窗口设置成Proman的子窗口
            DllImports.SetParent(this.Handle, hProgman);
        }

        private void WallPaper_SizeChanged(object sender, EventArgs e)
        {
            //使控件大小、位置适应窗口
            panel_Browser.Size = Size;
        }
    }
}

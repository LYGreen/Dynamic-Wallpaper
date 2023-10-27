using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Wallpaper
{

    public partial class Main_Form : Form
    {
        //Main_Form窗口是主面板
        public Main_Form()
        {
            InitializeComponent();
            InitWindow();
            InitWebBrowser();
        }
        public void InitWindow()
        {
            //初始化控件
            panel_Browser.Location = new Point(12, 12);
            panel_Browser.Size = new Size(Size.Width - 6, Size.Height - 183);
            panel_Controls.Location = new Point(panel_Browser.Location.X, panel_Browser.Location.Y + panel_Browser.Height + 6);
            panel_Controls.Size = new Size(panel_Browser.Width, 138);
            textBox_Path.Text = Directory.GetCurrentDirectory() + "\\index.html";

            
        }

        public ChromiumWebBrowser browser;
        public void InitWebBrowser()
        {
            //将浏览器对象初始化
            string path = Directory.GetCurrentDirectory() + "\\index.html";
            browser = new ChromiumWebBrowser(path);
            browser.Parent = panel_Browser;//将浏览器对象的载体设置为panel_Browser控件
            browser.Dock = DockStyle.Fill;
            browser.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(FrameLoadEndFunc);
        }

        private void FrameLoadEndFunc(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain)
            {
                e.Browser.MainFrame.ExecuteJavaScriptAsync("document.body.style.overflow = 'hidden'");
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //使控件大小、位置适应窗口
            panel_Browser.Size = new Size(Size.Width - 16*3, Size.Height - 32*6);
            panel_Controls.Location = new Point(panel_Browser.Location.X, panel_Browser.Location.Y + panel_Browser.Height + 6);
            panel_Controls.Size = new Size(panel_Browser.Width, 138);
            textBox_Path.Size = new Size(panel_Browser.Width - 122, textBox_Path.Height);
            button_Browser.Location = new Point(panel_Browser.Location.X+6+textBox_Path.Width,button_Browser.Location.Y);
        }

        private void button_Browser_Click(object sender, EventArgs e)
        {
            //选择网页文件
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "打开html文件";
            ofd.Filter = "网页文件(*.html,*.htm)|*.html;*.htm|所有文件(*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                browser.Load(ofd.FileName);
                textBox_Path.Text = ofd.FileName;
            }
            
        }

        //WallPaper窗口
        WallPaper wp = null;
        private void button_SetWallPaper_Click(object sender, EventArgs e)
        {
            //创建WallPaper窗口
            if(wp != null)
            {
                wp.Dispose();
            }
            wp = new WallPaper(textBox_Path.Text);
            wp.Show();
        }

        private void button_CancelWallPaper_Click(object sender, EventArgs e)
        {
            //关闭WallPaper窗口
            if(wp != null)
            {
                wp.Dispose();
            }
        }
    }
}

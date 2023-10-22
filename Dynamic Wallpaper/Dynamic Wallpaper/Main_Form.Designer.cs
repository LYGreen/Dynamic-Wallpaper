namespace Dynamic_Wallpaper
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            //检查WallPaper窗口是否关闭
            if(wp!=null)
            {
                wp.Dispose();
            }

            //关闭Main_Form窗口
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Browser = new System.Windows.Forms.Panel();
            this.panel_Controls = new System.Windows.Forms.Panel();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_Browser = new System.Windows.Forms.Button();
            this.button_SetWallPaper = new System.Windows.Forms.Button();
            this.button_CancelWallPaper = new System.Windows.Forms.Button();
            this.panel_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Browser
            // 
            this.panel_Browser.Location = new System.Drawing.Point(12, 12);
            this.panel_Browser.Name = "panel_Browser";
            this.panel_Browser.Size = new System.Drawing.Size(861, 396);
            this.panel_Browser.TabIndex = 0;
            // 
            // panel_Controls
            // 
            this.panel_Controls.Controls.Add(this.button_CancelWallPaper);
            this.panel_Controls.Controls.Add(this.button_SetWallPaper);
            this.panel_Controls.Controls.Add(this.button_Browser);
            this.panel_Controls.Controls.Add(this.textBox_Path);
            this.panel_Controls.Location = new System.Drawing.Point(12, 414);
            this.panel_Controls.Name = "panel_Controls";
            this.panel_Controls.Size = new System.Drawing.Size(861, 138);
            this.panel_Controls.TabIndex = 1;
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(3, 20);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(727, 25);
            this.textBox_Path.TabIndex = 0;
            // 
            // button_Browser
            // 
            this.button_Browser.Location = new System.Drawing.Point(736, 13);
            this.button_Browser.Name = "button_Browser";
            this.button_Browser.Size = new System.Drawing.Size(122, 43);
            this.button_Browser.TabIndex = 1;
            this.button_Browser.Text = "浏览";
            this.button_Browser.UseVisualStyleBackColor = true;
            this.button_Browser.Click += new System.EventHandler(this.button_Browser_Click);
            // 
            // button_SetWallPaper
            // 
            this.button_SetWallPaper.Location = new System.Drawing.Point(3, 51);
            this.button_SetWallPaper.Name = "button_SetWallPaper";
            this.button_SetWallPaper.Size = new System.Drawing.Size(221, 84);
            this.button_SetWallPaper.TabIndex = 2;
            this.button_SetWallPaper.Text = "设置为动态壁纸";
            this.button_SetWallPaper.UseVisualStyleBackColor = true;
            this.button_SetWallPaper.Click += new System.EventHandler(this.button_SetWallPaper_Click);
            // 
            // button_CancelWallPaper
            // 
            this.button_CancelWallPaper.Location = new System.Drawing.Point(230, 51);
            this.button_CancelWallPaper.Name = "button_CancelWallPaper";
            this.button_CancelWallPaper.Size = new System.Drawing.Size(221, 84);
            this.button_CancelWallPaper.TabIndex = 3;
            this.button_CancelWallPaper.Text = "取消动态壁纸";
            this.button_CancelWallPaper.UseVisualStyleBackColor = true;
            this.button_CancelWallPaper.Click += new System.EventHandler(this.button_CancelWallPaper_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 564);
            this.Controls.Add(this.panel_Controls);
            this.Controls.Add(this.panel_Browser);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel_Controls.ResumeLayout(false);
            this.panel_Controls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Browser;
        private System.Windows.Forms.Panel panel_Controls;
        private System.Windows.Forms.Button button_Browser;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_SetWallPaper;
        private System.Windows.Forms.Button button_CancelWallPaper;
    }
}


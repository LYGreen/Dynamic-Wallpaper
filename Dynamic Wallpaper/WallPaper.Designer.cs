namespace Dynamic_Wallpaper
{
    partial class WallPaper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Browser = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_Browser
            // 
            this.panel_Browser.Location = new System.Drawing.Point(12, 12);
            this.panel_Browser.Name = "panel_Browser";
            this.panel_Browser.Size = new System.Drawing.Size(663, 362);
            this.panel_Browser.TabIndex = 0;
            // 
            // WallPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 386);
            this.Controls.Add(this.panel_Browser);
            this.Name = "WallPaper";
            this.Text = "WallPaper";
            this.SizeChanged += new System.EventHandler(this.WallPaper_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Browser;
    }
}
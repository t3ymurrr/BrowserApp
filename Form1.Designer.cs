namespace BrowserApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sosialMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alətlərToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arxaRəngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıRəngiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çapEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.böyütToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiçiltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıxışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.əlaqəToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();

            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sosialMediaToolStripMenuItem,
            this.alətlərToolStripMenuItem,
            this.əlaqəToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            this.sosialMediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instagramToolStripMenuItem,
            this.youtubeToolStripMenuItem,
            this.facebookToolStripMenuItem,
            this.telegramToolStripMenuItem});
            this.sosialMediaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.sosialMediaToolStripMenuItem.Name = "sosialMediaToolStripMenuItem";
            this.sosialMediaToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.sosialMediaToolStripMenuItem.Text = "Sosial media";

            this.instagramToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.instagramToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            this.instagramToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.instagramToolStripMenuItem.Text = "İnstagram";
            this.instagramToolStripMenuItem.Click += new System.EventHandler(this.instagramToolStripMenuItem_Click);

            this.youtubeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.youtubeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.youtubeToolStripMenuItem.Text = "Youtube";
            this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.youtubeToolStripMenuItem_Click);

            this.facebookToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.facebookToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.facebookToolStripMenuItem.Text = "Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);

            this.telegramToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.telegramToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.telegramToolStripMenuItem.Name = "telegramToolStripMenuItem";
            this.telegramToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.telegramToolStripMenuItem.Text = "Telegram";
            this.telegramToolStripMenuItem.Click += new System.EventHandler(this.telegramToolStripMenuItem_Click);

            this.alətlərToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arxaRəngToolStripMenuItem,
            this.yazıRəngiToolStripMenuItem,
            this.çapEtToolStripMenuItem,
            this.böyütToolStripMenuItem,
            this.kiçiltToolStripMenuItem,
            this.çıxışToolStripMenuItem});
            this.alətlərToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.alətlərToolStripMenuItem.Name = "alətlərToolStripMenuItem";
            this.alətlərToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.alətlərToolStripMenuItem.Text = "Alətlər";

            this.arxaRəngToolStripMenuItem.Name = "arxaRəngToolStripMenuItem";
            this.arxaRəngToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.arxaRəngToolStripMenuItem.Text = "Arxa rəng";
            this.arxaRəngToolStripMenuItem.Click += new System.EventHandler(this.arxaRəngToolStripMenuItem_Click);

            this.yazıRəngiToolStripMenuItem.Name = "yazıRəngiToolStripMenuItem";
            this.yazıRəngiToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.yazıRəngiToolStripMenuItem.Text = "Yazı rəngi";
            this.yazıRəngiToolStripMenuItem.Click += new System.EventHandler(this.yazıRəngiToolStripMenuItem_Click);

            this.çapEtToolStripMenuItem.Name = "çapEtToolStripMenuItem";
            this.çapEtToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.çapEtToolStripMenuItem.Text = "Çap et";
            this.çapEtToolStripMenuItem.Click += new System.EventHandler(this.çapEtToolStripMenuItem_Click);

            this.böyütToolStripMenuItem.Name = "böyütToolStripMenuItem";
            this.böyütToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.böyütToolStripMenuItem.Text = "Böyüt";
            this.böyütToolStripMenuItem.Click += new System.EventHandler(this.böyütToolStripMenuItem_Click);

            this.kiçiltToolStripMenuItem.Name = "kiçiltToolStripMenuItem";
            this.kiçiltToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.kiçiltToolStripMenuItem.Text = "Kiçilt";
            this.kiçiltToolStripMenuItem.Click += new System.EventHandler(this.kiçiltToolStripMenuItem_Click);

            this.çıxışToolStripMenuItem.Name = "çıxışToolStripMenuItem";
            this.çıxışToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.çıxışToolStripMenuItem.Text = "Çıxış";
            this.çıxışToolStripMenuItem.Click += new System.EventHandler(this.çıxışToolStripMenuItem_Click);

            this.əlaqəToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.əlaqəToolStripMenuItem.Name = "əlaqəToolStripMenuItem";
            this.əlaqəToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.əlaqəToolStripMenuItem.Text = "Əlaqə";
            this.əlaqəToolStripMenuItem.Click += new System.EventHandler(this.əlaqəToolStripMenuItem_Click);

            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 28);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(800, 422);
            this.webView21.TabIndex = 1;
            this.webView21.ZoomFactor = 1D;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sosialMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telegramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alətlərToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arxaRəngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıRəngiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çapEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem böyütToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiçiltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıxışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem əlaqəToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
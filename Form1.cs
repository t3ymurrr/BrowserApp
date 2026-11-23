using System;
using System.Windows.Forms;

namespace BrowserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate("https://www.google.az");
        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.instagram.com");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.youtube.com");
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.facebook.com");
        }

        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.telegram.org");
        }

        private void arxaRəngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.BackColor = colorDialog1.Color;
            }
        }

        private void yazıRəngiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                sosialMediaToolStripMenuItem.ForeColor = colorDialog1.Color;
                alətlərToolStripMenuItem.ForeColor = colorDialog1.Color;
                əlaqəToolStripMenuItem.ForeColor = colorDialog1.Color;
            }
        }

        private void çapEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.ShowPrintUI();
        }

        private void böyütToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void kiçiltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void çıxışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Çıxış edilsinmi?", "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void əlaqəToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Əlaqə üçün: info@google.az", "Əlaqə", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
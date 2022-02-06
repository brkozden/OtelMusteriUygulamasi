using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Musteri_Uygulamasi
{
    public partial class AramaMotoruFormu : Form
    {
        public AramaMotoruFormu()
        {
            InitializeComponent();
        }

        private void AramaMotoruFormu_Load(object sender, EventArgs e)
        {
            webBrowserArama.Navigate("www.google.com");
            progressbarIslemGoruntule.Visible = false;
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            webBrowserArama.Navigate("www.google.com");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            webBrowserArama.GoBack();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            webBrowserArama.GoForward();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            webBrowserArama.Refresh();
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            webBrowserArama.Stop();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            webBrowserArama.Navigate(combobxadres.Text);
            this.Text = webBrowserArama.DocumentTitle.ToString();
        }

        private void webBrowserArama_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            combobxadres.Text = webBrowserArama.Url.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusDegisken .Text = webBrowserArama.StatusText;
        }

        private void webBrowserArama_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                progressbarIslemGoruntule.Visible = true;
                progressbarIslemGoruntule.Maximum = Convert.ToInt32(e.MaximumProgress);
                progressbarIslemGoruntule.Value = Convert.ToInt32(e.CurrentProgress);
               
            }
            catch
            {
                progressbarIslemGoruntule.Value = 0;
                progressbarIslemGoruntule.Visible = false;
            }
        }

        private void btnGeri_MouseHover(object sender, EventArgs e)
        {
            ToolTip aciklama2 = new ToolTip();
            aciklama2.SetToolTip(btnGeri, "Geri");
        }

        private void btnIleri_MouseHover(object sender, EventArgs e)
        {

            ToolTip aciklama2 = new ToolTip();
            aciklama2.SetToolTip(btnIleri, "İleri");
        }

        private void btnAnasayfa_MouseHover(object sender, EventArgs e)
        {

            ToolTip aciklama2 = new ToolTip();
            aciklama2.SetToolTip(btnAnasayfa, "Anasayfa");
        }

        private void btnYenile_MouseHover(object sender, EventArgs e)
        {

            ToolTip aciklama2 = new ToolTip();
            aciklama2.SetToolTip(btnYenile, "Yenile");
        }

        private void btnGit_MouseHover(object sender, EventArgs e)
        {

            ToolTip aciklama2 = new ToolTip();
            aciklama2.SetToolTip(btnGit, "Git");
        }

        private void btnDur_MouseHover(object sender, EventArgs e)
        {

            ToolTip aciklama2 = new ToolTip();
            aciklama2.SetToolTip(btnDur, "Dur");
        }
    }
}

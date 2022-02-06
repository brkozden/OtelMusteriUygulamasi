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

namespace Otel_Musteri_Uygulamasi
{
    public partial class AnaMenuFormu : Form
    {
        private bool Kapatsorgu;
        DialogResult dr = System.Windows.Forms.DialogResult.No;
        public AnaMenuFormu()
        {
            InitializeComponent();
        }

     
        private void btnCikis_Click(object sender, EventArgs e)
        {
            

            if (!Kapatsorgu)
            {
                dr = MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Kapatsorgu = dr == System.Windows.Forms.DialogResult.Yes;
            }
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                if (Kapatsorgu)
                {
                    string kayit = "*** " +GirisFormu.username +" Adlı Kullanıcı Sistemden Çıkış Yaptı. ***" + Environment.NewLine;
                    Program.islemKayitEt(kayit);
                    Application.Exit();
                }
                Kapatsorgu = false;
            }
           

        }

        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
            RezervasyonFormu rezervasyon = new RezervasyonFormu();
            rezervasyon.Show();
         
        }

        private void btnPersonelBilgileri_Click(object sender, EventArgs e)
        {
            PersonelFormu personel = new PersonelFormu();
            personel.Show();

        }

        private void btnOdaKontrol_Click(object sender, EventArgs e)
        {
            OdaBilgileriFormu odaBilgileri = new OdaBilgileriFormu();
            odaBilgileri.Show();

          
        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {
            islemKayitFormu formAc = new islemKayitFormu();
            formAc.Show();
        }

        private void AnaMenuFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Kapatsorgu)
            {
                dr = MessageBox.Show("Programdan Çıkmak İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                Kapatsorgu = dr == System.Windows.Forms.DialogResult.Yes;
            }
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                if (Kapatsorgu)
                {
                    string kayit = "*** " +GirisFormu.username +" Adlı Sistemden Çıkış Yaptı. ***" + Environment.NewLine;
                    Program.islemKayitEt(kayit);
                    Application.Exit();
                }
                Kapatsorgu = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            MusteriKayitFormu musteriKayit = new MusteriKayitFormu();
            musteriKayit.Show();
        }

        private void btnMusteriBilgileri_Click(object sender, EventArgs e)
        {
            MusteriBilgileriFormu musteriBilgileri = new MusteriBilgileriFormu();
            musteriBilgileri.Show();
        }

       
        private void yesilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            lblDakika.ForeColor = Color.Black;
            lblHosgeldin.ForeColor = Color.Black;
            lblNokta1.ForeColor = Color.Black;
            lblNokta2.ForeColor = Color.Black;
            lblSaat.ForeColor = Color.Black;
            lblSaniye.ForeColor = Color.Black;
            lblUser.ForeColor = Color.Black;

        }
        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkBlue;
            lblDakika.ForeColor = Color.AliceBlue;
            lblHosgeldin.ForeColor = Color.AliceBlue;
            lblNokta1.ForeColor = Color.AliceBlue;
            lblNokta2.ForeColor = Color.AliceBlue;
            lblSaat.ForeColor = Color.AliceBlue;
            lblSaniye.ForeColor = Color.AliceBlue;
            lblUser.ForeColor = Color.AliceBlue;
        }
        private void morToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
            lblDakika.ForeColor = Color.Black;
            lblHosgeldin.ForeColor = Color.Black;
            lblNokta1.ForeColor = Color.Black;
            lblNokta2.ForeColor = Color.Black;
            lblSaat.ForeColor = Color.Black;
            lblSaniye.ForeColor = Color.Black;
            lblUser.ForeColor = Color.Black;
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            lblDakika.ForeColor = Color.AliceBlue;
            lblHosgeldin.ForeColor = Color.AliceBlue;
            lblNokta1.ForeColor = Color.AliceBlue;
            lblNokta2.ForeColor = Color.AliceBlue;
            lblSaat.ForeColor = Color.AliceBlue;
            lblSaniye.ForeColor = Color.AliceBlue;
            lblUser.ForeColor = Color.AliceBlue;
        }
        private void varsayilanaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Highlight;
            lblDakika.ForeColor = Color.Black;
            lblHosgeldin.ForeColor = Color.Black;
            lblNokta1.ForeColor = Color.Black;
            lblNokta2.ForeColor = Color.Black;
            lblSaat.ForeColor = Color.Black;
            lblSaniye.ForeColor = Color.Black;
            lblUser.ForeColor = Color.Black;
        }

        private void programdanCıkısYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kayit = "*** " + GirisFormu.username + " Adlı Kullanıcı Sistemden Çıkış Yaptı. ***" + Environment.NewLine;
            Program.islemKayitEt(kayit);
            Application.Exit();
        }

       

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            DovizIslemleriFormu formuAc = new DovizIslemleriFormu();
            formuAc.Show();

        }

        private void btnAramaMotoru_Click(object sender, EventArgs e)
        {
            AramaMotoruFormu ac = new AramaMotoruFormu();
            ac.Show();
        }

      
        

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            KullaniciKayitFormu ac = new KullaniciKayitFormu();
            ac.Show();
        }

        int sayac = 0;
        private void timerDijitalSaat_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac %1==0 )
            {
                lblNokta1.Visible = false;
                lblNokta2.Visible = false;
            }
            if (sayac %2==1)
            {
                lblNokta1.Visible = true;
                lblNokta2.Visible = true;
            }

            DateTime zaman =  DateTime.Now;
            if (zaman.Hour < 10 )
            {
                lblSaat.Text ="0"+zaman.Hour.ToString();

            }
            else
            {
                lblSaat.Text =  zaman.Hour.ToString();
            }
            if (zaman.Minute < 10)
            {
                lblDakika.Text ="0" + zaman.Minute.ToString();

            }
            else
            {
                lblDakika.Text =  zaman.Minute.ToString();
            }
            if (zaman.Second < 10)
            {
                lblSaniye.Text = "0" + zaman.Second.ToString();
            }
            else
            {
                lblSaniye.Text = zaman.Second.ToString();
            }
          
            
         }

        private void AnaMenuFormu_Load(object sender, EventArgs e)
        {
            lblUser.Text = GirisFormu.username;
        }
    }
}

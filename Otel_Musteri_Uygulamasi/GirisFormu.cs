using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Otel_Musteri_Uygulamasi
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SNP49SI;Initial Catalog=dbOtel;Integrated Security=True");
        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }
        private int count = 0;
        public static string username;
        private void btnGiris_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("Select * From tblYonetici where kullaniciAdi=@p1 and sifre=@p2 ", baglanti);

                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);

                string sifre = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSifre.Text));
             

                komut.Parameters.AddWithValue("@p2", sifre);

                SqlDataReader dr = komut.ExecuteReader();


                if (dr.Read())
                {
                    username = txtKullaniciAdi.Text;
                    AnaMenuFormu anaMenu = new AnaMenuFormu();
                    anaMenu.Show();
                    this.Hide();
                    string kayit = "*** " + txtKullaniciAdi.Text  + " Adlı Kullanıcı Sisteme Giriş Yaptı. ***";
                    Program.islemKayitEt(kayit);

                }
                else
                {
                    txtKullaniciAdi.Text = "";
                    txtSifre.Text = "";
                    count++;
                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.OrangeRed;
                    lblHata.Text = (count + " Yanlış Deneme!");
                    txtKullaniciAdi.Focus();
                    if (count >= 3)
                    {
                        txtKullaniciAdi.ReadOnly = false;
                        txtSifre.ReadOnly = false;


                        DialogResult dialog = MessageBox.Show("3 Şifre Değişim Hakkınız Sonlanmıştır. Şifre Değişim Ekranına Yönlendiriliyorsunuz...",
                            "Yanlış Şifre", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.Cancel)
                        {
                            Application.Exit();
                        }

                        if (dialog == DialogResult.OK)
                        {
                            SifreDegisimFormu sdf = new SifreDegisimFormu();
                            sdf.Show();
                            this.Hide();
                        }
                    }

                }
                komut.Dispose();
                dr.Close();
               
            }
            catch (Exception a) {
                MessageBox.Show("Hata: " + a, "Bir Hata Oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string hata = DateTime.Now.ToString() + " Kullanıcı " + a +" Hatasını Aldı.";

                Program.WriteDebugLog(hata);
            }
            finally
            {
                baglanti.Close();
            }
        
            

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
           DialogResult dialog;
            dialog = MessageBox.Show("Kapatmak İstiyor Musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes )
            {
                Application.Exit();
                string kayit = "*** " + txtKullaniciAdi.Text + " Adlı Kullanıcı Sistemden Çıkış Yaptı. ***" + Environment.NewLine;
                Program.islemKayitEt(kayit);
            }
        }

        private void linklblSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreDegisimFormu sifreDegisim = new SifreDegisimFormu();
            sifreDegisim.Show();
          }

        private void GirisFormu_Load(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Otel_Musteri_Uygulamasi
{
    public partial class KullaniciKayitFormu : Form
    {
        public KullaniciKayitFormu()
        {
            InitializeComponent();
        }
     
        void temizleYeniKullaniciEkle()
        {
            txtAdSoyad.Text = "";
            txtKullaniciAd.Text = "";
            txtSifre.Text = "";
            txtSifre2.Text = "";
            cmbbxSoru.Text = "";
            txtCevap.Text = "";
        }
        private void btnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtAdSoyad.Text)) && (!string.IsNullOrEmpty(txtKullaniciAd.Text)) && (!string.IsNullOrEmpty(cmbbxSoru.Text)) && (!string.IsNullOrEmpty(txtCevap.Text)))
            {
                if ((!string.IsNullOrEmpty(txtSifre.Text)) && (!string.IsNullOrEmpty(txtSifre2.Text)))
                {
                    if (txtSifre.Text == txtSifre2.Text)
                    {
                        try
                        {
                            Program.baglanti.Open();

                            SqlCommand kullaniciEkle = new SqlCommand("insert into tblYonetici (adSoyad,kullaniciAdi,sifre,soru,cevap)" +
                                "values (@m1,@m2,@m3,@m4,@m5)", Program.baglanti);

                            string sifre = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSifre.Text));

                            kullaniciEkle.Parameters.AddWithValue("@m1", txtAdSoyad.Text);
                            kullaniciEkle.Parameters.AddWithValue("@m2", txtKullaniciAd.Text);
                            kullaniciEkle.Parameters.AddWithValue("@m3", sifre);
                            kullaniciEkle.Parameters.AddWithValue("@m4", cmbbxSoru.Text);
                            kullaniciEkle.Parameters.AddWithValue("@m5", txtCevap.Text);

                            kullaniciEkle.ExecuteNonQuery();
                            MessageBox.Show("Kullanıcı Ekleme İşlemi Başarıyla Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string kayit = "***** "+GirisFormu.username+ " Adlı Kullanıcı " + txtKullaniciAd.Text + " Adlı Yeni Bir Kullanıcı Eklendi *****";
                            Program.islemKayitEt(kayit);
                            temizleYeniKullaniciEkle();
                           

                        }
                        catch (Exception a)
                        {

                            MessageBox.Show("Hata: " + a);
                            string hata = a.ToString() + Environment.NewLine;
                            Program.WriteDebugLog(hata);
                        }
                        finally
                        {
                            Program.baglanti.Close();
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Birbirine Eşit Değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSifre.Text = "";
                        txtSifre2.Text = "";
                      
                    }
                }
                else
                {
                    MessageBox.Show("Şifre Değeri Boş Olmaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz Değerlerde Boş Olan Alanlar Var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

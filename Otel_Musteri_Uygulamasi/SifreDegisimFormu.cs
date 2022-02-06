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
    public partial class SifreDegisimFormu : Form
    {
        public SifreDegisimFormu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SNP49SI;Initial Catalog=dbOtel;Integrated Security=True");
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullanici.Text))
            {
                MessageBox.Show("Kullanıcı Adı alanı boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select kullaniciAdi,sifre From tblYonetici Where kullaniciAdi='" + txtKullanici.Text + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                  
                    try
                    {
                        if ((txtSifre1.Text == txtSifreTekrar.Text) && (!string.IsNullOrEmpty(txtSifre1.Text)))
                        {

                            if (lblCaptcha.Text == txtGuvenlikKodu.Text && !(string.IsNullOrEmpty(txtGuvenlikKodu.Text)))
                            {
                                try
                                {
                                    baglanti.Close();
                                    baglanti.Open();
                                    string sifre =Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSifre1.Text));
                                 

                                    SqlCommand komut1 = new SqlCommand("Update tblYonetici set sifre = '" + sifre + "'", baglanti);
                                    komut1.ExecuteNonQuery();
                                    MessageBox.Show("Şifre Değişim İşleminiz Başarıyla Gerçekleşmiştir. Giriş Ekranına Geri Yönlendiriliyorsunuz..", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    GirisFormu giris = new GirisFormu();
                                    string kayit = "*** " + txtKullanici.Text + " Adlı Kullanıcı Şifresini Güncelledi. ***";

                                    Program.islemKayitEt(kayit);
                                    this.Hide();
                                    giris.Show();
                                }
                                catch (Exception a)
                                {
                                    MessageBox.Show("Hata: " + a);

                                 
                                } 
                            }
                            else
                            {
                                MessageBox.Show("Güvenlik Kodunu Yanlış Girdiniz. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                captcha();
                            }


                        }
                        else
                        {
                            MessageBox.Show("Girdiğiniz Şifreler Birbirinden Farklı Veya Boş Değer Girdiniz. Lütfen Tekrar Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSifre1.Text = txtSifreTekrar.Text = "";
                            captcha();
                        }
                    }
                    catch (System.ArgumentNullException ane)
                    {
                        MessageBox.Show("Boş Bir Değer Girdiniz. Lütfen Girdiğiniz Parametreleri Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string hata = ane.ToString();
                        Program.WriteDebugLog(hata);

                    }
                    catch (System.FormatException fe)
                    {
                        MessageBox.Show("Yanlış Biçimde Parametre Girdiniz. Lütfen Girdiğiniz Parametreleri Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string hata = fe.ToString();
                        Program.WriteDebugLog(hata);

                    }
                    catch (System.OverflowException ofe)
                    {
                        MessageBox.Show("Girilen Veri İzin Verilen Değer Aralığında Değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string hata = ofe.ToString();
                        Program.WriteDebugLog(hata);
                    }
                    catch (System.InvalidCastException ice)
                    {
                        MessageBox.Show("Geçersiz Tür Dönüşümü.Girdiğiniz Verileri Gözden Geçiriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string hata = ice.ToString();
                        Program.WriteDebugLog(hata);
                    }
                    catch (Exception exc)
                    {
                        string hata = exc.ToString();
                        MessageBox.Show("Hata: " + hata);
                        Program.WriteDebugLog(hata);
                    }

                }
               
              
            }
            catch (System.ArgumentNullException ane)
            {
                MessageBox.Show("Boş Bir Değer Girdiniz. Lütfen Girdiğiniz Parametreleri Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string hata = ane.ToString();
                Program.WriteDebugLog(hata);

            }
            catch (System.FormatException fe)
            {
                MessageBox.Show("Yanlış Biçimde Parametre Girdiniz. Lütfen Girdiğiniz Parametreleri Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string hata = fe.ToString();
                Program.WriteDebugLog(hata);

            }
            catch (System.OverflowException ofe)
            {
                MessageBox.Show("Girilen Veri İzin Verilen Değer Aralığında Değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string hata = ofe.ToString();
                Program.WriteDebugLog(hata);
            }
            catch (System.InvalidCastException ice)
            {
                MessageBox.Show("Geçersiz Tür Dönüşümü.Girdiğiniz Verileri Gözden Geçiriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string hata = ice.ToString();
                Program.WriteDebugLog(hata);
            }
            catch (Exception exc)
            {
                string hata = exc.ToString();
                MessageBox.Show("Hata: " + hata);
                Program.WriteDebugLog(hata);
            }

            finally
            {
                baglanti.Close();
                captcha();
            }
           
        }

        private void SifreDegisimFormu_Load(object sender, EventArgs e)
        {
            txtKullanici.Focus();
            captcha();
           
        }
        void captcha()
        {
            string[] karakter = { "A", "B", "C", "D", "E", "F", "G", "1", "2", "3", "4", "$", "&", "#", "T", "Z", "S", "K", "7", "8", "9", "5", "6", "H", "T", "M", "N", "P", "R", "Y" };//Burada rastgele karakterler tanimladim. Siz daha fazla karakter tanimlamasi yapabilirsiniz.

            string code = null;//karakter dizisini döngüye sokarak, rastgele karakterler seçip code isimli degiskene atayacagim.

            Random r = new Random();//rastgele karakter seçilmesi için Random sinifindan yararlanabiliriz.

            for (int i = 0; i < 5; i++)//burada 5 olarak belirttim, siz kaç karakterli bir Captcha Code olusturmak istiyorsaniz burada onu belirtmelisiniz.

            {

                code += karakter[r.Next(0, karakter.Length)];// code isimli degiskenimin içine, döngüm çalistigi süre boyunca rastgele karakterler eklenecek.

            }

            lblCaptcha.Text = code;

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            captcha();
        }
    }
}

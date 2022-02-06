using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Otel_Musteri_Uygulamasi
{

    public partial class MusteriKayitFormu : Form
    {
        List<Oda> musaitOdalar;

        public MusteriKayitFormu()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMail.Text = "";
            txtOdaNo.Text = "";
            txtUcret.Text = "";
            dateTimeGiris.ResetText();
            dateTimeCikis.ResetText();
            radioErkek.Checked = radioKadin.Checked = false;
            maskedtxtTC.Text = "";
            maskedtxtTelefon.Text = "";

            txtAd.Focus();


        }

        private void cmbbxCinsiyet_Click(object sender, EventArgs e) { }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maskedtxtTC.Text) || string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || (radioKadin.Checked == false && radioErkek.Checked == false))
                {
                    MessageBox.Show("Ad, Soyad, TC No ve Cinsiyet alanları boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Program.baglanti.Open();

                SqlCommand musteriekle = new SqlCommand("insert into tblMusteri (ad,soyad,cinsiyet,telefon,mail,TCNo)" +
                    "values (@m1,@m2,@m3,@m4,@m5,@m6); SELECT SCOPE_IDENTITY();", Program.baglanti);

                musteriekle.Parameters.AddWithValue("@m1", txtAd.Text);
                musteriekle.Parameters.AddWithValue("@m2", txtSoyad.Text);
                musteriekle.Parameters.AddWithValue("@m4", maskedtxtTelefon.Text);
                musteriekle.Parameters.AddWithValue("@m5", txtMail.Text);
                musteriekle.Parameters.AddWithValue("@m6", maskedtxtTC.Text);



                if (radioErkek.Checked == true)
                {
                    musteriekle.Parameters.AddWithValue("@m3", "E");
                }

                if (radioKadin.Checked == true)
                {
                    musteriekle.Parameters.AddWithValue("@m3", "K");
                }


                if (!string.IsNullOrEmpty(txtOdaNo.Text))
                {
                    int musteriID = Convert.ToInt32(musteriekle.ExecuteScalar());

                    SqlCommand rezervasyonEkle = new SqlCommand("insert into tblRezervasyon (musteriID,odaNo,girisTarihi,cikisTarihi,ucret)" +
                    "values (@r1,@r2,@r3,@r4,@r5)", Program.baglanti);

                    rezervasyonEkle.Parameters.AddWithValue("@r1", musteriID);
                    rezervasyonEkle.Parameters.AddWithValue("@r2", txtOdaNo.Text);
                    rezervasyonEkle.Parameters.AddWithValue("@r3", dateTimeGiris.Value);
                    rezervasyonEkle.Parameters.AddWithValue("@r4", dateTimeCikis.Value);
                    rezervasyonEkle.Parameters.AddWithValue("@r5", Convert.ToInt32(txtUcret.Text));
                    rezervasyonEkle.ExecuteNonQuery();
                    Program.baglanti.Close();
                    MessageBox.Show("Personel Ekleme İşlemi Başarıyla Gerçekleştirildi. ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string kayit = "** " +GirisFormu.username+ " Adlı Kullanıcı Yeni Müşteri Ekledi **";
                    Program.islemKayitEt(kayit);
                    Temizle();
                }


            }

            catch (System.ArgumentNullException ane)
            {
                MessageBox.Show("Boş Bir Değer Girdiniz. Lütfen Girdiğiniz Parametreleri Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string hata = ane.ToString() + Environment.NewLine;
                Program.WriteDebugLog(hata);

            }
            catch (System.FormatException fe)
            {
                MessageBox.Show("Yanlış Biçimde Parametre Girdiniz. Lütfen Girdiğiniz Parametreleri Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string hata = fe.ToString() + Environment.NewLine;
                Program.WriteDebugLog(hata);

            }
            catch (System.OverflowException ofe)
            {
                MessageBox.Show("Girilen Veri İzin Verilen Değer Aralığında Değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string hata = ofe.ToString() + Environment.NewLine;
                Program.WriteDebugLog(hata);
            }
            catch (System.InvalidCastException ice)
            {
                MessageBox.Show("Geçersiz Tür Dönüşümü.Girdiğiniz Verileri Gözden Geçiriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string hata = ice.ToString() + Environment.NewLine;
                Program.WriteDebugLog(hata);
            }
            catch (Exception exc)
            {
                string hata = exc.ToString() + Environment.NewLine;
                MessageBox.Show("Hata: " + hata);
                Program.WriteDebugLog(hata);
            }
            finally
            {
                Program.baglanti.Close();
            }




        }

        private void MusteriKayitFormu_Load(object sender, EventArgs e)
        {

            MusaitOdalarKontrol();
            dateTimeCikis.Value = DateTime.Now.AddDays(1);

        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
            RezervasyonUcretiHesapla(101);
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
            RezervasyonUcretiHesapla(102);
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
            RezervasyonUcretiHesapla(103);
        }

        private void btnOda201_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "201";
            RezervasyonUcretiHesapla(201);
        }

        private void btnOda202_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "202";
            RezervasyonUcretiHesapla(202);
        }

        private void btnOda203_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "203";
            RezervasyonUcretiHesapla(203);
        }

        private void btnOda301_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "301";
            RezervasyonUcretiHesapla(301);
        }

        private void btnOda302_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "302";
            RezervasyonUcretiHesapla(302);
        }

        private void btnOda303_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "303";
            RezervasyonUcretiHesapla(303);
        }

        private void btnOda401_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "401";
            RezervasyonUcretiHesapla(401);
        }

        private void btnOda402_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "402";
            RezervasyonUcretiHesapla(402);
        }

        private void btnOda403_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "403";
            RezervasyonUcretiHesapla(403);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void MusaitOdalarKontrol()
        {
            musaitOdalar = new List<Oda>();

            Program.baglanti.Open();

            string strCmdMusaitOdalar = $@"SELECT *
                                        FROM tblOda
                                        WHERE odaNo NOT IN
                                        (SELECT odaNo
                                            FROM tblRezervasyon
                                            WHERE
                                            (girisTarihi <= '{dateTimeGiris.Value.ToString("yyyy-MM-dd")}' AND cikisTarihi >= '{dateTimeGiris.Value.ToString("yyyy-MM-dd")}') OR
                                            (girisTarihi <= '{dateTimeCikis.Value.ToString("yyyy-MM-dd")}' AND cikisTarihi >= '{dateTimeCikis.Value.ToString("yyyy-MM-dd")}') OR
                                            (girisTarihi >= '{dateTimeGiris.Value.ToString("yyyy-MM-dd")}' AND cikisTarihi <= '{dateTimeCikis.Value.ToString("yyyy-MM-dd")}'))";


            SqlCommand cmdMusaitOdalar = new SqlCommand(strCmdMusaitOdalar, Program.baglanti);



            using (SqlDataReader reader = cmdMusaitOdalar.ExecuteReader())
            {
                while (reader.Read())
                {
                    musaitOdalar.Add(new Oda() { Id = reader.GetInt32(0), No = reader.GetInt32(1) });
                }
            }


            Program.baglanti.Close();

            for (int i = 0; i < Program.odaList.Count; i++)
            {
                Button btnOda = (Button)this.Controls.Find($"btnOda{Program.odaList[i].No}", true).FirstOrDefault();

                if (musaitOdalar.Any(m => m.No == Program.odaList[i].No))
                {
                    btnOda.BackColor = Color.Green;
                }
                else
                {
                    btnOda.BackColor = Color.DarkRed;
                    btnOda.Enabled = false;
                }
            }
        }

        private void dateTimeGiris_ValueChanged(object sender, EventArgs e)
        {
            MusaitOdalarKontrol();
            RezervasyonUcretiHesapla();
        }

        private void dateTimeCikis_ValueChanged(object sender, EventArgs e)
        {
            MusaitOdalarKontrol();
            RezervasyonUcretiHesapla();
        }
        private void RezervasyonUcretiHesapla(int odaNo = 0)
        {
            if (odaNo != 0 || int.TryParse(txtOdaNo.Text, out odaNo))
            {
                int odaFiyat = Program.odaList.Where(o => o.No == Convert.ToInt32(odaNo)).Select(t => t.Ucret).FirstOrDefault();
                int gun = Convert.ToInt32((dateTimeCikis.Value - dateTimeGiris.Value).TotalDays);
                if (Math.Sign(gun) == -1)
                {
                    gun = 0;
                }
                int toplamFiyat = gun * odaFiyat;
                txtUcret.Text = Convert.ToString(toplamFiyat);
            }

        }
    }
}



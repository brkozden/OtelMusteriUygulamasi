using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Otel_Musteri_Uygulamasi
{
    public partial class OdaBilgileriFormu : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SNP49SI;Initial Catalog=dbOtel;Integrated Security=True");
        List<Oda> bugunMusaitOdalar;
        public OdaBilgileriFormu()
        {
            InitializeComponent();
        }

       
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Program.baglanti.Open();

                SqlCommand odaGuncelle = new SqlCommand("Update tblOda Set odaTipi=@r1,yatakTuru=@r2,ucret=@r3," +
                   "sigaraIcilebilir=@r4,klima=@r5,wifi=@r6,televizyon=@r7,minibar=@r8,kasa=@r9,balkon=@r10,telefon=@r11,jakuzi=@r12 Where odaNo=@r13", Program.baglanti);

                odaGuncelle.Parameters.AddWithValue("@r1", cmbbxOdaTipi.Text);
                odaGuncelle.Parameters.AddWithValue("@r2", cmbbxYatakSayisi.Text);
                odaGuncelle.Parameters.AddWithValue("@r3", Convert.ToInt32(numericOdaUcreti.Value));
                odaGuncelle.Parameters.AddWithValue("@r13", Convert.ToInt16(txtOdaNo.Text));

                if (cmbbxSigaraDurumu.Text == "Evet")
                {
                    odaGuncelle.Parameters.AddWithValue("@r4", true);
                }
                if (cmbbxSigaraDurumu.Text == "Hayır")
                {
                    odaGuncelle.Parameters.AddWithValue("@r4", false);
                }
                if (radiobtnKlimaEvet.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r5", true);
                }
                if (radiobtnKlimaHayir.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r5", false);
                }
                if (radiobtnWifiEvet.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r6", true);
                }
                if (radiobtnWifiHayir.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r6", false);
                }
                if (radiobtnTVEvet.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r7", true);
                }
                if (radiobtnTVHayir.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r7", false);
                }
                if (radiobtnMinibarEvet.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r8", true);
                }
                if (radiobtnMinibarHayir.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r8", false);
                }
                if (radiobtnKasaEvet.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r9", true);
                }
                if (radiobtnKasaHayir.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r9", false);
                }
                if (radiobtnBalkonEvet.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r10", true);
                }
                if (radiobtnBalkonHayir.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r10", false);
                }
                if (radiobtnTelefonEvet.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r11", true);
                }
                if (radiobtnTelefonHayir.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r11", false);
                }
                if (radiobtnJakuziEvet.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r12", true);
                }
                if (radiobtnJakuziHayir.Checked == true)
                {
                    odaGuncelle.Parameters.AddWithValue("@r12", false);
                }

                odaGuncelle.ExecuteNonQuery();
               
                MessageBox.Show(txtOdaNo.Text + " Numaralı Odanın Bilgileri Başarıyla Güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string kayit = "* Kullanıcı " + txtOdaNo.Text + " Numaralı Odanın Bilgilerini Güncelledi *";
                Program.islemKayitEt(kayit);
  
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
                Temizle();
                Program.baglanti.Close();

                Program.OdaListesiGetir();
            }


        }
        enum OdaTipi
        {
            Standart,
            Deluxe,
           Superior
        }
        private void OdaBilgileriFormu_Load(object sender, EventArgs e)
        {
            BugunMusaitOdalarKontrol();
            btnDoluOdaSayisi.Text += Program.odaList.Count - bugunMusaitOdalar.Count;
            btnBosOdaSayisi.Text += bugunMusaitOdalar.Count;

            foreach (var item in Enum.GetValues(typeof(OdaTipi)))
            {
                cmbbxOdaTipi.Items.Add(item);
            }
        }

        private void BugunMusaitOdalarKontrol()
        {
            bugunMusaitOdalar = new List<Oda>();

            baglanti.Open();

            string strCmdMusaitOdalar = $@"SELECT *
                                        FROM tblOda
                                        WHERE odaNo NOT IN
                                        (SELECT odaNo
                                            FROM tblRezervasyon
                                            WHERE
                                            (girisTarihi <= '{DateTime.Now.ToString("yyyy-MM-dd")}' AND cikisTarihi >= '{DateTime.Now.ToString("yyyy-MM-dd")}') OR
                                            (girisTarihi <= '{DateTime.Now.ToString("yyyy-MM-dd")}' AND cikisTarihi >= '{DateTime.Now.ToString("yyyy-MM-dd")}') OR
                                            (girisTarihi >= '{DateTime.Now.ToString("yyyy-MM-dd")}' AND cikisTarihi <= '{DateTime.Now.ToString("yyyy-MM-dd")}'))";


            SqlCommand cmdMusaitOdalar = new SqlCommand(strCmdMusaitOdalar, baglanti);


            using (SqlDataReader reader = cmdMusaitOdalar.ExecuteReader())
            {
                while (reader.Read())
                {
                    bugunMusaitOdalar.Add(new Oda() { Id = reader.GetInt32(0), No = reader.GetInt32(1) });
                }
            }

            baglanti.Close();

            for (int i = 0; i < Program.odaList.Count; i++)
            {
                Button btnOda = (Button)this.Controls.Find($"btnOda{Program.odaList[i].No}", true).FirstOrDefault();

                if (bugunMusaitOdalar.Any(m => m.No == Program.odaList[i].No))
                {
                    btnOda.BackColor = Color.Green;
                }
                else
                {
                    btnOda.BackColor = Color.DarkRed;
                }
            }
        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
            odaVerileriniGetir();

        }
      
        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
            odaVerileriniGetir();
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
            odaVerileriniGetir();
        }

        private void btnOda201_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "201";
            odaVerileriniGetir();
        }

        private void btnOda202_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "202";
            odaVerileriniGetir();
        }

        private void btnOda203_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "203";
            odaVerileriniGetir();
        }

        private void btnOda301_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "301";
            odaVerileriniGetir();
        }

        private void btnOda302_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "302";
            odaVerileriniGetir();
        }

        private void btnOda303_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "303";
            odaVerileriniGetir();
        }

        private void btnOda401_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "401";
            odaVerileriniGetir();
        }

        private void btnOda402_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "402";
            odaVerileriniGetir();
        }

        private void btnOda403_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "403";
            odaVerileriniGetir();
        }
        public void odaVerileriniGetir()
        {
            Program.baglanti.Open();

            SqlCommand veriGetir = new SqlCommand("select *from tblOda where odaNo like '" + txtOdaNo.Text + "'", Program.baglanti);
            SqlDataReader read = veriGetir.ExecuteReader();

            while (read.Read())
            {
                cmbbxOdaTipi.Text = read[2].ToString();
                cmbbxYatakSayisi.Text = read[3].ToString();
                 numericOdaUcreti.Value = Convert.ToInt32( read[4].ToString());
                if (read[5].ToString() == "True")
                {
                    cmbbxSigaraDurumu.Text = "Evet";
                }
                if (read[5].ToString() == "False")
                {
                    cmbbxSigaraDurumu.Text = "Hayır";
                }
                if (read[6].ToString() == "True")
                {
                    radiobtnKlimaEvet.Checked = true;
                }
                if (read[6].ToString() == "False")
                {
                    radiobtnKlimaHayir.Checked = true;
                }
                if (read[7].ToString() == "True")
                {
                    radiobtnWifiEvet.Checked = true;
                }
                if (read[7].ToString() == "False")
                {
                    radiobtnWifiHayir.Checked = true;
                }
                if (read[8].ToString() == "True")
                {
                    radiobtnTVEvet.Checked = true;
                }
                if (read[8].ToString() == "False")
                {
                    radiobtnTVHayir.Checked = true;
                }
                if (read[9].ToString() == "True")
                {
                    radiobtnMinibarEvet.Checked = true;
                }
                if (read[9].ToString() == "False")
                {
                    radiobtnMinibarHayir.Checked = true;
                }
                if (read[10].ToString() == "True")
                {
                    radiobtnKasaEvet.Checked = true;
                }
                if (read[10].ToString() == "False")
                {
                    radiobtnKasaHayir.Checked = true;
                }
                if (read[11].ToString() == "True")
                {
                    radiobtnBalkonEvet.Checked = true;
                }
                if (read[11].ToString() == "False")
                {
                    radiobtnBalkonHayir.Checked = true;
                }
                if (read[12].ToString() == "True")
                {
                    radiobtnTelefonEvet.Checked = true;
                }
                if (read[12].ToString() == "False")
                {
                    radiobtnTelefonHayir.Checked = true;
                }
                if (read[13].ToString() == "True")
                {
                    radiobtnJakuziEvet.Checked = true;
                }
                if (read[13].ToString() == "False")
                {
                    radiobtnJakuziHayir.Checked = true;
                }
            }
            Program.baglanti.Close();
        }
        void Temizle()
        {
            txtOdaNo.Text = "";
            cmbbxOdaTipi.Text = "";
            cmbbxYatakSayisi.Text = "";
            numericOdaUcreti.ResetText();
            cmbbxSigaraDurumu.Text = "";
            radiobtnKlimaEvet.Checked = radiobtnKlimaHayir.Checked = false;
            radiobtnWifiEvet.Checked = radiobtnWifiHayir.Checked = false;
            radiobtnTVEvet.Checked = radiobtnTVHayir.Checked = false;
            radiobtnMinibarEvet.Checked = radiobtnMinibarHayir.Checked = false;
            radiobtnKasaEvet.Checked = radiobtnKasaHayir.Checked = false;
            radiobtnBalkonEvet.Checked = radiobtnBalkonHayir.Checked = false;
            radiobtnTelefonEvet.Checked = radiobtnTelefonHayir.Checked = false;
            radiobtnJakuziEvet.Checked = radiobtnJakuziHayir.Checked = false;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void timerOdalar_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            toolStripTarih.Text = dt.ToLongDateString();
            toolStripSaat.Text = dt.ToLongTimeString();
        }
    }
}

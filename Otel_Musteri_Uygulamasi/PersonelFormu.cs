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
    public partial class PersonelFormu : Form
    {
        
        public PersonelFormu()
        {
            InitializeComponent();
        }

        private void txtAra_Click(object sender, EventArgs e)
        {
            txtAra.Text = "";
        }

       

        void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            maskedtxtTelefon.Text = "";
            txtMail.Text = "";
            maskedtxtTC.Text = "";
            dateTimeGirisTarihi.ResetText();
            cmbbxPozisyon.Text = "Seçiniz";
            txtMaas.Text = "";
            radioErkek.Checked = false;
            radioKadin.Checked = false;
            txtAra.Text = "";

        }
        private void PersonelFormu_Load(object sender, EventArgs e)
        {
          
            listele();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            try { 
           Program.baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into TblPersonel (ad,soyad,telefon,mail,TCNo," +
                "girisTarihi,pozisyonu,maas,cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",Program.baglanti);

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedtxtTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtMail.Text);
            komut.Parameters.AddWithValue("@p5", maskedtxtTC.Text);
            komut.Parameters.AddWithValue("@p6", dateTimeGirisTarihi.Value);
            komut.Parameters.AddWithValue("@p7", cmbbxPozisyon.Text);
            komut.Parameters.AddWithValue("@p8", Convert.ToInt32(txtMaas.Text));

            if (radioErkek.Checked == true)
            {
                komut.Parameters.AddWithValue("@p9", "E");
            }
            if (radioKadin.Checked == true)
            {
                komut.Parameters.AddWithValue("@p9", "K");
            }

            komut.ExecuteNonQuery();
            MessageBox.Show("Personel Ekleme İşlemi Başarıyla Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string kayit = "* " +GirisFormu.username + " Adlı Kullanıcı " + txtAd.Text + " " + txtSoyad.Text + " Adlı Yeni Bir Personel Ekledi *";
            Program.islemKayitEt(kayit);
            
            Temizle();
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
               MessageBox.Show("Girilen Veri İzin Verilen Değer Aralığında Değil.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                string hata = ofe.ToString() + Environment.NewLine;
                Program.WriteDebugLog(hata);
            }
            catch (System.InvalidCastException ice)
            {
                MessageBox.Show("Geçersiz Tür Dönüşümü.Girdiğiniz Verileri Gözden Geçiriniz.","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                listele();
            }



        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void cmbbxPozisyon_Click(object sender, EventArgs e)
        {
            cmbbxPozisyon.Text = "";
           
        }

        private void dtPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            int secilen = dtPersonel.SelectedCells[0].RowIndex;

            txtAd.Text = dtPersonel.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dtPersonel.Rows[secilen].Cells[2].Value.ToString();
            maskedtxtTelefon.Text = dtPersonel.Rows[secilen].Cells[3].Value.ToString();
            txtMail.Text = dtPersonel.Rows[secilen].Cells[4].Value.ToString();
            maskedtxtTC.Text = dtPersonel.Rows[secilen].Cells[5].Value.ToString();
            dateTimeGirisTarihi.Text = dtPersonel.Rows[secilen].Cells[6].Value.ToString();
            cmbbxPozisyon.Text = dtPersonel.Rows[secilen].Cells[7].Value.ToString();
            txtMaas.Text = dtPersonel.Rows[secilen].Cells[8].Value.ToString();
            lblID.Text = dtPersonel.Rows[secilen].Cells[0].Value.ToString();

            if (dtPersonel.Rows[secilen].Cells[9].Value.ToString() == "E")
            {
                radioErkek.Checked = true;

            }
            if (dtPersonel.Rows[secilen].Cells[9].Value.ToString() == "K")
            {
                radioKadin.Checked = true;

            }
            }
            catch (Exception exc)
            {
                string hata = exc.ToString();
                MessageBox.Show("Hata: " + hata);
                Program.WriteDebugLog(hata);
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(maskedtxtTC.Text) || string.IsNullOrEmpty(maskedtxtTelefon.Text) || string.IsNullOrEmpty(txtMaas.Text))
                {
                    MessageBox.Show("Ad, Soyad,TC No,Telefon ve Maaş alanları boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.baglanti.Open();

                SqlCommand komutsil = new SqlCommand("delete from TblPersonel Where TCNo = @k1 ",Program.baglanti);
                komutsil.Parameters.AddWithValue("@k1", maskedtxtTC.Text);
                komutsil.ExecuteNonQuery();

                MessageBox.Show("Personel Silme İşlemi Başarıyla Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string kayit = "* Kullanıcı " + lblID + " ID Numarasına Sahip Personelin Kayıt Bilgilerini Sildi *";
                Program.islemKayitEt(kayit);
                Temizle();
                
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
                listele();
            }
        }

        private void btnKayitGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Program.baglanti.Open();

                SqlCommand komutguncelle = new SqlCommand("Update tblPersonel Set ad=@a1,soyad=@a2,telefon=@a3," +
                    "mail=@a4,TCNo=@a5,girisTarihi=@a6,pozisyonu=@a7,maas=@a8,cinsiyet=@a9 Where personelID=@a10 ",Program.baglanti);

                komutguncelle.Parameters.AddWithValue("@a1", txtAd.Text);
                komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
                komutguncelle.Parameters.AddWithValue("@a3", maskedtxtTelefon.Text);
                komutguncelle.Parameters.AddWithValue("@a4", txtMail.Text);
                komutguncelle.Parameters.AddWithValue("@a5", maskedtxtTC.Text);
                komutguncelle.Parameters.AddWithValue("@a6", dateTimeGirisTarihi.Value);
                komutguncelle.Parameters.AddWithValue("@a7", cmbbxPozisyon.Text);
                komutguncelle.Parameters.AddWithValue("@a8", Convert.ToInt16(txtMaas.Text));
                komutguncelle.Parameters.AddWithValue("@a10", Convert.ToInt32(lblID.Text));

                if (radioErkek.Checked == true)
                {
                    komutguncelle.Parameters.AddWithValue("@a9", "E");
                }
                if (radioKadin.Checked == true)
                {
                    komutguncelle.Parameters.AddWithValue("@a9", "K");
                }

                komutguncelle.ExecuteNonQuery();
                MessageBox.Show("Personel Bilgileri Başarıyla Güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string kayit = "* " +GirisFormu.username + " Adlı Kullanıcı " + lblID.Text + " ID Numarasına Sahip Personelin Bilgilerini Güncelledi *";
                Program.islemKayitEt(kayit);
                
                
                Temizle();
                
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
                listele();
            }


        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblPersonel", Program.baglanti);
            da.Fill(dt);
            dtPersonel.DataSource = dt;
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblPersonel where ad LIKE '%" + txtAra.Text + "%'", Program.baglanti);
                da.Fill(dt);
                dtPersonel.DataSource = dt;
            }
            catch (Exception exc)
            {
                string hata = exc.ToString();
                MessageBox.Show("Hata: " + hata);
                Program.WriteDebugLog(hata);
            }
            finally {
                txtAd.Text = "";
                    }
           
            
        }

    }
}

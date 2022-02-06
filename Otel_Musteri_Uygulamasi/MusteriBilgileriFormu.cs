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
    public partial class MusteriBilgileriFormu : Form
    {
        public MusteriBilgileriFormu()
        {
            InitializeComponent();
        }

       
        private void MusteriBilgileri_Load(object sender, EventArgs e)
        {
             listele();
        }

        private void cmbbxCinsiyet_Click(object sender, EventArgs e)
        {
            cmbbxCinsiyet.Text = "";
        }

        private void txtAra_Click(object sender, EventArgs e)
        {
            txtAra.Text = "";
        }

        private void dtviewMüsteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int secilen = dtviewMüsteriler.SelectedCells[0].RowIndex;

            txtMusteriID.Text = dtviewMüsteriler.Rows[secilen].Cells[0].Value.ToString();
            maskedtxtTC.Text = dtviewMüsteriler.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dtviewMüsteriler.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dtviewMüsteriler.Rows[secilen].Cells[3].Value.ToString();
            maskedtxtTelefon.Text = dtviewMüsteriler.Rows[secilen].Cells[5].Value.ToString();
             txtMail.Text = dtviewMüsteriler.Rows[secilen].Cells[6].Value.ToString();

            if (dtviewMüsteriler.Rows[secilen].Cells[4].Value.ToString() == "E")
            {
                cmbbxCinsiyet.Text = "Erkek";
                
            }
            if (dtviewMüsteriler.Rows[secilen].Cells[4].Value.ToString() == "K")
            {
                cmbbxCinsiyet.Text = "Kadın";

            }     
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Program.baglanti.Open();
                SqlCommand musteriGuncelle = new SqlCommand("Update tblMusteri Set TCNo=@m1,ad=@m2,soyad=@m3,telefon=@m4," +
                    "mail=@m5,cinsiyet=@m6 Where musteriID=@m7", Program.baglanti);

                musteriGuncelle.Parameters.AddWithValue("@m1", maskedtxtTC.Text);
                musteriGuncelle.Parameters.AddWithValue("@m2", txtAd.Text);
                musteriGuncelle.Parameters.AddWithValue("@m3", txtSoyad.Text);
                musteriGuncelle.Parameters.AddWithValue("@m4", maskedtxtTelefon.Text);
                musteriGuncelle.Parameters.AddWithValue("@m5", txtMail.Text);
                musteriGuncelle.Parameters.AddWithValue("@m7", Convert.ToInt16(txtMusteriID.Text));

                if (cmbbxCinsiyet.Text == "Erkek")
                {
                    musteriGuncelle.Parameters.AddWithValue("@m6", 'E');
                }

                if (cmbbxCinsiyet.Text == "Kadın")
                {
                    musteriGuncelle.Parameters.AddWithValue("@m6", 'K');
                }

                musteriGuncelle.ExecuteNonQuery();

              

                MessageBox.Show(txtMusteriID.Text + " ID'li Müşteri Bilgileri Başarıyla Güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string kayit = "** " +GirisFormu.username+ " Adlı Kullanıcı " + txtMusteriID.Text + " ID Numarasına Sahip Müşterinin Bilgilerini Güncelledi **";
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
                listele();
                Program.baglanti.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(maskedtxtTC.Text))
                {
                    MessageBox.Show("Ad, Soyad ve TC No  alanları boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.baglanti.Open();

                SqlCommand musteriSil = new SqlCommand("delete from tblMusteri Where musteriID=@m1", Program.baglanti);
                musteriSil.Parameters.AddWithValue("@m1", Convert.ToInt32(txtMusteriID.Text));
                musteriSil.ExecuteNonQuery();

                SqlCommand komutsil = new SqlCommand("delete from tblRezervasyon Where musteriID=@m1", Program.baglanti);
                komutsil.Parameters.AddWithValue("@m1", Convert.ToInt32(txtMusteriID.Text));

                

                MessageBox.Show("Müşteri Silme İşlemi Başarıyla Gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string kayit = "**" +GirisFormu.username+ " Adlı Kullanıcı " + txtMusteriID.Text + " ID Numarasına Sahip Müşteriyi Sildi  **";
                Program.islemKayitEt(kayit);
                 
            }
            catch (Exception exc)
            {
                string hata = exc.ToString();
                MessageBox.Show("Hata: " + hata);
                Program.WriteDebugLog(hata);
            }
            finally
            {
                 Temizle();
                listele();
                Program.baglanti.Close();
            }

        }

       
        void Temizle()
        {
            txtAd.Text = txtMail.Text = txtMusteriID.Text = txtSoyad.Text = maskedtxtTC.Text = maskedtxtTelefon.Text = "";
            txtAd.Focus();
            txtAra.Text = "";
            cmbbxCinsiyet.Text = "Seçiniz";
            listele();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblMusteri where ad LIKE '%" + txtAra.Text + "%'", Program.baglanti);
                da.Fill(dt);
                dtviewMüsteriler.DataSource = dt;
            }
            catch (Exception exc)
            {
                string hata = exc.ToString() + Environment.NewLine;
                MessageBox.Show("Hata: " + hata);
                Program.WriteDebugLog(hata);
            }
            

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            DialogResult dlr = printDialog1.ShowDialog();
            if (dlr == DialogResult.OK)
            {
                printDocument1.Print();
            }



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Bitmap objBmp = new Bitmap(dtviewMüsteriler.Width, dtviewMüsteriler.Height);
                dtviewMüsteriler.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dtviewMüsteriler.Width, this.dtviewMüsteriler.Height));
            e.Graphics.DrawImage(objBmp,4,90);
           
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
        printPreviewDialog1.ShowDialog();
         }

        private void btnPreview_MouseHover(object sender, EventArgs e)
        {
            ToolTip aciklama = new ToolTip();
            aciklama.SetToolTip(btnPreview, "Önizleme");
        }

        private void btnYazdir_MouseHover(object sender, EventArgs e)
        {
            ToolTip aciklama2 = new ToolTip();
            aciklama2.SetToolTip(btnYazdir, "Yazdır");
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblMusteri", Program.baglanti);
            da.Fill(dt);
            dtviewMüsteriler.DataSource = dt;
        }
    }
   }


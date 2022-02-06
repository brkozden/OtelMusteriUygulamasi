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
    public partial class RezervasyonFormu : Form
    {
        public RezervasyonFormu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();

        void bilgileriGetir()
        {
            con = new SqlConnection("Data Source=DESKTOP-SNP49SI;Initial Catalog=dbOtel;Integrated Security=True");
            da = new SqlDataAdapter("Select m.musteriID, m.ad, m.soyad, m.telefon, r.odaNo, r.girisTarihi, r.cikisTarihi, r.ucret From tblRezervasyon r inner join tblMusteri m on r.MusteriID = m.MusteriID", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Rezervasyon");
            dtviewRezervasyonlar.DataSource = ds.Tables["Rezervasyon"];
            dtviewRezervasyonlar.Columns[0].Visible = false;
            con.Close();
        }
        void bilgileriFiltrele()
        {
            con = new SqlConnection("Data Source=DESKTOP-SNP49SI;Initial Catalog=dbOtel;Integrated Security=True");
            da = new SqlDataAdapter("Select m.musteriID, m.ad, m.soyad, m.telefon, r.odaNo, r.girisTarihi, r.cikisTarihi, r.ucret From tblRezervasyon r inner join tblMusteri m on r.MusteriID = m.MusteriID Where girisTarihi between @p1 and @p2", con);
            ds = new DataSet();
            con.Open();
            da.SelectCommand.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimeBaslangic.Value;
            da.SelectCommand.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimeBitisTarihi.Value;
            da.Fill(ds, "Rezervasyon");
            dtviewRezervasyonlar.DataSource = ds.Tables["Rezervasyon"];
            dtviewRezervasyonlar.Columns[0].Visible = false;
            con.Close();

        }
        void bilgileriTemizle()
        {
            dateTimeBaslangic.ResetText();
            dateTimeBitisTarihi.ResetText();
            cmbbxOdaNo.Text = "";
            txtUcret.Text = "";

        }
        private void RezervasyonFormu_Load(object sender, EventArgs e)
        {
            bilgileriGetir();

        }

        private void dviewRezervasyonlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtviewRezervasyonlar.SelectedCells[0].RowIndex;
            lblMusteriID.Text = dtviewRezervasyonlar.Rows[secilen].Cells[0].Value.ToString();
            cmbbxOdaNo.Text = dtviewRezervasyonlar.Rows[secilen].Cells[4].Value.ToString();
            dateTimeBaslangic.Text = dtviewRezervasyonlar.Rows[secilen].Cells[5].Value.ToString();
            dateTimeBitisTarihi.Text = dtviewRezervasyonlar.Rows[secilen].Cells[6].Value.ToString();
            txtUcret.Text = dtviewRezervasyonlar.Rows[secilen].Cells[7].Value.ToString();

        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            bilgileriFiltrele();
        }

        private void btnTumKayitlariGetir_Click(object sender, EventArgs e)
        {
            bilgileriGetir();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUcret.Text) || string.IsNullOrEmpty(cmbbxOdaNo.Text))
                {
                    MessageBox.Show("Ücret ve Oda Numarası alanları boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.baglanti.Open();
                SqlCommand rezervasyonGuncelle = new SqlCommand("Update tblRezervasyon Set girisTarihi=@m1,cikisTarihi=@m2,odaNo=@m3,Ucret=@m4 Where musteriID=@m5", Program.baglanti);

                rezervasyonGuncelle.Parameters.AddWithValue("@m1", dateTimeBaslangic.Value);
                rezervasyonGuncelle.Parameters.AddWithValue("@m2", dateTimeBitisTarihi.Value);
                rezervasyonGuncelle.Parameters.AddWithValue("@m3", Convert.ToInt32(cmbbxOdaNo.Text));
                rezervasyonGuncelle.Parameters.AddWithValue("@m4", Convert.ToInt32(txtUcret.Text));
                rezervasyonGuncelle.Parameters.AddWithValue("@m5", Convert.ToInt32(lblMusteriID.Text));

                rezervasyonGuncelle.ExecuteNonQuery();

                Program.baglanti.Close();

                MessageBox.Show("Müşterinin Rezervasyon Bilgileri Başarıyla Güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string kayit = "** " +GirisFormu.username +" Adlı Kullanıcı " + lblMusteriID.Text + " ID Numarasına Sahip Müşterinin Rezervasyon Bilgilerini Güncelledi **";
                Program.islemKayitEt(kayit);
                bilgileriTemizle();
                bilgileriGetir();
            }
            catch (Exception a)
            {
                MessageBox.Show("Hata: " + a,"Bir Hata Oluştu",MessageBoxButtons.OK,MessageBoxIcon.Error);
                string hata = GirisFormu.username + " Adlı Kullanıcı " + a + " Hatasını Aldı." + Environment.NewLine;
                Program.WriteDebugLog(hata);
                
            }

        }
    }
}

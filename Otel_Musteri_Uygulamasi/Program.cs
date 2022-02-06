using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Otel_Musteri_Uygulamasi
{
    static class Program
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SNP49SI;Initial Catalog=dbOtel;Integrated Security=True");
        public static List<Oda> odaList;

        [STAThread]
        static void Main()
        {
            OdaListesiGetir();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisFormu());


        }
        public static void WriteDebugLog(String Message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Hatalar.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + " Hata Türü : " + Message + Environment.NewLine);
                sw.Flush();
                sw.Close();
            }
            catch (Exception a)
            {
                string hata = DateTime.Now.ToString() + GirisFormu.username + a + " Hatasını Aldı." + Environment.NewLine;

                Program.WriteDebugLog(hata);
            }
        }
        public static void islemKayitEt(String Kayit)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Kayitlar.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + Kayit);
                sw.Flush();
                sw.Close();
            }
            catch (Exception a)
            {
                string hata = DateTime.Now.ToString() + GirisFormu.username + a + " Hatasını Aldı." + Environment.NewLine;

                Program.WriteDebugLog(hata);

            }

        }

        public static void OdaListesiGetir()
        {

            try
            {
                odaList = new List<Oda>();

                baglanti.Open();

                SqlCommand cmdOdalar = new SqlCommand("select odaID, odaNo, ucret from tblOda", baglanti);

                using (SqlDataReader reader = cmdOdalar.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        odaList.Add(new Oda() { Id = reader.GetInt32(0), No = reader.GetInt32(1), Ucret = reader.GetInt32(2) });
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Hata: " + a, "Bir Hata Oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string hata = DateTime.Now.ToString() + " Kullanıcı " + a + " Hatasını Aldı." + Environment.NewLine;

                Program.WriteDebugLog(hata);
            }
            finally
            {
                baglanti.Close();
            }


        }
    }
}

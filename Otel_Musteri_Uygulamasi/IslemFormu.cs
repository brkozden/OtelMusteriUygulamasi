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

namespace Otel_Musteri_Uygulamasi
{
    public partial class islemKayitFormu : Form
    {
        public islemKayitFormu()
        {
            InitializeComponent();
        }

        private void btnHataGecmisi_Click(object sender, EventArgs e)
        {
            listbxGecmis.Items.Clear();

            StreamReader read = new StreamReader($"{AppDomain.CurrentDomain.BaseDirectory}\\Hatalar.txt");

            string kelime;
            while ((kelime = read.ReadLine()) != null)
            {
                listbxGecmis.Items.Add(kelime);
            }

            read.Close();
        }

        private void btnislemGecmisi_Click(object sender, EventArgs e)
        {
            listbxGecmis.Items.Clear();

            StreamReader read = new StreamReader($"{AppDomain.CurrentDomain.BaseDirectory}\\Kayitlar.txt");

            string kelime;
            while ((kelime = read.ReadLine()) != null)
            {
                listbxGecmis.Items.Add(kelime);
            }

            read.Close();
        }
      
      
        private void btnBold_Click(object sender, EventArgs e)
        {
        listbxGecmis.Font = new Font(listbxGecmis.Font, listbxGecmis.Font.Style ^ FontStyle.Bold);
        }

        private void btnitalic_Click(object sender, EventArgs e)
        {
            listbxGecmis.Font = new Font(listbxGecmis.Font, listbxGecmis.Font.Style ^ FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            listbxGecmis.Font = new Font(listbxGecmis.Font, listbxGecmis.Font.Style ^ FontStyle.Underline);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Otel_Musteri_Uygulamasi
{
    public partial class DovizIslemleriFormu : Form
    {

        XDocument doviz = XDocument.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
      
  
        public DovizIslemleriFormu()
        {
            InitializeComponent();
        }

        

        private void listbxDoviz_SelectedIndexChanged(object sender, EventArgs e)
        {
            var KurBilgi = from x in doviz.Descendants("Currency")
                           where
                  x.Element("Isim").Value == listbxDoviz.SelectedItem.ToString()
                           select new
                           {
                               ad = x.Element("CurrencyName").Value,
                               alis = x.Element("ForexBuying").Value,
                               satis = x.Element("ForexSelling").Value
                           };
            foreach (var x in KurBilgi)
            {
                lblAd.Text = x.ad;
                lblAlis.Text = x.alis;
                lblSatis.Text = x.satis;
            }

            groupbxHesaplama.Enabled = true;


        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (radiobtnTLdenDoviz.Checked == true)
            {
                double a, b, toplam;
                a = Convert.ToDouble(lblAlis.Text);
                b = Convert.ToDouble(txtMiktar.Text);
                toplam = (b / a)*10000;
                toplam = Math.Round(toplam, 2);
                txtSonuc.Text = Convert.ToString(toplam);

            }
            if (radiobtnDovizdenTL.Checked == true)
            {
                double a, b, toplam;
                a = Convert.ToDouble(lblAlis.Text);
                b = Convert.ToDouble(txtMiktar.Text);
                toplam = (b * a) / 10000;
                toplam = Math.Round(toplam, 2);
                txtSonuc.Text = Convert.ToString(toplam + " ₺ ");

            }
           
        }

        private void DovizIslemleriFormu_Load(object sender, EventArgs e)
        {
            var sonuc = from x in doviz.Descendants("Currency")
                        select new
                        {
                            doviz = x.Element("Isim").Value
                        };
            foreach (var item in sonuc)
            {
                listbxDoviz.Items.Add(item.doviz.ToString());
            }
            radiobtnDovizdenTL.Checked = true;
        }
    }
}
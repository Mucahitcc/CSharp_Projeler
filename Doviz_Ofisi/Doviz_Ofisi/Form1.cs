using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya=new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis=xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlıs.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatis.Text = dolarsatis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlıs.Text = eurosatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = euroalis;
        }

        private void BtnDolarAl_Click(object sender, EventArgs e)
        {
            TxtKur.Text=lblDolarAlıs.Text;
        }

        private void BtnDolarSat_Click(object sender, EventArgs e)
        {
            TxtKur.Text = lblDolarSatis.Text;
        }

        private void BtnEuroAl_Click(object sender, EventArgs e)
        {
            TxtKur.Text=lblEuroAlıs.Text ;

        }

        private void BtnEuroSat_Click(object sender, EventArgs e)
        {
            TxtKur.Text=lblEuroSatis.Text ;
        }

        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            double miktar,kur,tutar;
            kur = Convert.ToDouble(TxtKur.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
            miktar =Convert.ToDouble(TxtMiktar.Text);
            
            tutar = miktar * kur;
           TxtTutar.Text=tutar.ToString();
        }

        private void TxtKur_TextChanged(object sender, EventArgs e)
        {
            TxtKur.Text = TxtKur.Text.Replace(".", ",");
        }

        private void BtnAlisYap_Click(object sender, EventArgs e)
        {
            double kur= Convert.ToDouble(TxtKur.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
            double miktar =Convert.ToDouble (TxtMiktar.Text);
            double tutar = miktar/kur;
            TxtTutar.Text = tutar.ToString();
            double kalan;
            kalan=miktar % kur;
            TxtKalan.Text = kalan.ToString();
        }
    }
}

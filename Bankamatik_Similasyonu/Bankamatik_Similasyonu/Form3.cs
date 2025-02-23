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

namespace Bankamatik_Similasyonu
{
    public partial class btnHesap : Form
    {
        public btnHesap()
        {
            InitializeComponent();
        }

        SqlConnection baglanti =new SqlConnection(@"Data Source=DeltaL2\SQLEXPRESS;Initial Catalog=DbBankaSimulasyonu;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKISILER (Ad,Soyad,Tc,Telefon,HesapNo,Sıfre) Values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", MskHesap.Text);
            komut.Parameters.AddWithValue("@p6", TxtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başırılı Şekilde Kayıt Oluşturuldu");
            pictureBox1.Visible=true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele=new Random();
            int sayi=rastgele.Next(10000000, 1000000000);
            MskHesap.Text = sayi.ToString();
        }
    }
}

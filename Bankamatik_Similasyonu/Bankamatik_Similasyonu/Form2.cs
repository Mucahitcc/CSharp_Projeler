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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string hesap;


        SqlConnection baglanti = new SqlConnection(@"Data Source=DeltaL2\SQLEXPRESS;Initial Catalog=DbBankaSimulasyonu;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesap.Text = hesap;
            baglanti.Open();
            SqlCommand komut =new SqlCommand("Select * From TBLKISILER where hesapno=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",hesap);
            SqlDataReader dr= komut.ExecuteReader();
            while(dr.Read())
            {
                lblAdSoyad.Text=dr[1] + " " + dr[2];
                lblTc.Text = dr[3].ToString();
                Lbltelefon.Text = dr[4].ToString(); 
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gönderilen hesabın para artışı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Update TBLHESAP set bakıye=bakıye+@p1 where hesapno=@p2", baglanti);
            komut2.Parameters.AddWithValue("@p1",decimal.Parse(textBox1.Text));
            komut2.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close() ;
            

            //Gönderen Hesabın para azalışı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Update TBLHESAP set bakıye=bakıye-@k1 where hesapno=@k2",baglanti) ;
            komut3.Parameters.AddWithValue("@k1",decimal.Parse(textBox1.Text)) ;
            komut3.Parameters.AddWithValue("@k2",hesap) ;
            komut3 .ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("İşlem Gerçekleşti");
        }
    }
}

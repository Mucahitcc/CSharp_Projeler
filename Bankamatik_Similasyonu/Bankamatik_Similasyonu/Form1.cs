using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace Bankamatik_Similasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DeltaL2\SQLEXPRESS;Initial Catalog=DbBankaSimulasyonu;Integrated Security=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnHesap frm = new btnHesap();
            frm.Show();
        }

       
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("Select * From TBLKISILER Where hesapno=@p1 and sıfre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",MskHesapNo.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dt = komut.ExecuteReader();
            if (dt.Read())
            {
                Form2 frm = new Form2();
                frm.hesap=MskHesapNo.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bir Giriş Yaptınız");

            }
            baglanti.Close();

        }
    }
}

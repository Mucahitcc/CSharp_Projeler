using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarisması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBoxTrue.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBoxFalse.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBoxTrue.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBoxFalse.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBoxTrue.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBoxFalse.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBoxTrue.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBoxFalse.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            btnSonraki.Enabled = false;

            pictureBoxFalse.Visible=false;
            pictureBoxTrue.Visible = false;

            soruNo++;
            lblSoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1923";
                btnD.Text = "1938";
                label4.Text = "1923";

            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege Bölgesinde Bulunmaz  ?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";

            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazara aittir ?";
                btnA.Text = "Sait Faik Abasıyanık";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Ömer Seyfettin";
                label4.Text = "Sait Faik Abasıyanık";
                btnSonraki.Text = "Sonuçlar";

            }
            if (soruNo==4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }
        }
    }
}

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

namespace Araclar_Dosyalar_Klasörler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        string dosyaAdi, dosyaYolu;
        StreamWriter sw;

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyaYolu;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            dosyaAdi=textBox2.Text;
            sw=File.CreateText(dosyaYolu+"\\"+dosyaAdi+".txt");
            sw.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satir = sr.ReadLine();
                while(satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyaları|*.txt";
            saveFileDialog1.Title = "Metin Belgesi KAyı";
            saveFileDialog1.ShowDialog();
            StreamWriter swr = new StreamWriter(saveFileDialog1.FileName);
            swr.WriteLine(richTextBox1.Text);
            swr.Close();
            MessageBox.Show("Metin Belgesi Kayıt Edildi");
        }


    }
}

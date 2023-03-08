using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Toplam(2, 3).ToString();
            label2.Text = Toplam(3, 5).ToString();
            label3.Text = Toplam(7, 8).ToString();
            label4.Text = Toplam(3, 0).ToString();
        }
        int Carpim(int s1, int s2, int s3)
        {
            int s4 = s1 * s2 * s3;
            return s4;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = Carpim(1, 3, 5).ToString();
            label6.Text = Carpim(0, 2, 4).ToString();
            label7.Text = Carpim(9, 9, 9).ToString();
            label8.Text = Carpim(10, 11, 12).ToString();
        }
        // Klavyeden girilen üç sayının çarpımı
        int Carp(int c1, int c2, int c3)
        {
            c1 = Convert.ToInt16(textBox1.Text);
            c2 = Convert.ToInt16(textBox2.Text);
            c3 = Convert.ToInt16(textBox3.Text);
            int c4 = c1 * c2 * c3;
            return c4;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = Carp(Convert.ToInt16(textBox1.Text),
                   Convert.ToInt16(textBox2.Text),
                   Convert.ToInt16(textBox3.Text)).ToString();
        }
        // Klavyeden girilen bir sayının kübünü alma
        int Kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox4.Text);
            label10.Text = Kup(s).ToString();
        }
        // Klavyeden girilen iki sayının toplanması

        int Topl(int t1, int t2)
        {
            int t3 = t1 + t2;
            return t3;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int t1 = Convert.ToInt16(textBox5.Text);
            int t2 = Convert.ToInt16(textBox6.Text);
            label11.Text = Topl(t1, t2).ToString();
        }
    }
}

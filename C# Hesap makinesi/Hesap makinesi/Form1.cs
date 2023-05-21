using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int sonuç;

                sayı1 = Convert.ToInt32(textBox1.Text); 
                sayı2 = Convert.ToInt32(textBox2.Text);

            sonuç = sayı1 + sayı2;
            label4.Text = sonuç.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int sonuç;

            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);

            sonuç = sayı1 - sayı2;
            label4.Text = sonuç.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int sonuç;

            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);

            sonuç = sayı1 * sayı2;
            label4.Text = sonuç.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int sonuç;

            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);

            sonuç = sayı1 / sayı2;
            label4.Text = sonuç.ToString();
        }
    } // TÜM BU ATANILMIŞ DEĞİŞKENLERDE BUTON 1 İÇİN TOPLAMA, BUTON 2 İÇİN ÇIKARMA, BUTON 3 İÇİN ÇARPMA VE BUTON 4 İÇİN BÖLME İŞLEMİ YAPLILMASI İSTENİLMİŞTİR.
}

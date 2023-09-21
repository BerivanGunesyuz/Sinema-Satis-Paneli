using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİNEMA_SATIŞ_PANELİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misirAdet, suAdet, cayAdet, biletAdet, toplam ;
            misirAdet = Convert.ToInt32(textBox1.Text);
            suAdet = Convert.ToInt32(textBox2.Text);
            cayAdet = Convert.ToInt32(textBox3.Text);
            biletAdet = Convert.ToInt32(textBox4.Text);

            toplam = misirAdet * 10 + suAdet * 2 + cayAdet * 5 + biletAdet * 15;
            kasa = kasa + toplam;
            label12.Text = toplam.ToString()+"TL";
            label13.Text = kasa.ToString()+ "TL";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label12.Text = "0,00 TL";

        }
    }
}

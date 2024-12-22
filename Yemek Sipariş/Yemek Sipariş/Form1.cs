using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemek_Sipariş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal toplamTutar = 0;
            decimal çorba = numericUpDown1.Value;
            if (çorba > 0) 
            {
                toplamTutar = toplamTutar + çorba * 30;
            }
            decimal salata = numericUpDown2.Value;
            if (salata > 0) 
            {
                toplamTutar = toplamTutar + salata * 20;
            }
            decimal anaYemek = numericUpDown3.Value;
            if (anaYemek > 0) 
            {
                toplamTutar = toplamTutar + anaYemek * 50;
            }
            decimal tatlı = numericUpDown4.Value;
            if (tatlı > 0) 
            {
                toplamTutar = toplamTutar + tatlı * 10;
            }
            textBox4.Text = toplamTutar.ToString();
        }
    }
}

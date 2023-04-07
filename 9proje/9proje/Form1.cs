using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ağırlık, uzunluk, toplam;
        private void button1_Click(object sender, EventArgs e)
        {
            ağırlık = Convert.ToInt16(textBox1.Text);

            uzunluk = Convert.ToInt16(textBox2.Text);

            toplam = ağırlık / uzunluk * uzunluk * 2;

            label1.Text = toplam.ToString();

        }


    }
}

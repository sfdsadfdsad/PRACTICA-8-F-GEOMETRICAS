using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRACTICA_8_F_GEOMETRICAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            texBox3.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(textBox1.Text);
            area1 = 4 * pi * radio1 * radio1;
            volumen1 = 4 / 3 * pi * Math.Pow(radio1, 3);
            texBox3.Text = area1.ToString();
            textBox2.Text = volumen1.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Base;
            double altura, area;
            Base = double.Parse(textBox17.Text);
            altura = double.Parse(textBox4.Text);
            area = Base * altura / 2;
            textBox3.Text = area.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox17.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            double radio, altura;
            double pi = 3.1416;
            double volumen, area;
            radio = double.Parse(textBox9.Text);
            altura = double.Parse(textBox5.Text);
            volumen = pi * radio * radio * altura;
            area = (2 * pi * altura * radio) + (pi + pi * radio * radio * altura);
            textBox6.Text = area.ToString();
            textBox7.Text = volumen.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox6.Text = "";
            textBox9.Text = "";
            textBox5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a;
            double volumen, area;
            a = double.Parse(textBox8.Text);
            volumen = a * a * a;
            area = 6 * a * a;
            textBox11.Text = area.ToString();
            textBox10.Text = volumen.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
            textBox8.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double D, d;
            double area;
            D = double.Parse(textBox12.Text);
            d = double.Parse(textBox13.Text);
            area = (D * d) / 2;
            textBox14.Text = area.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox12.Text ="";
            textBox13.Text = "";
            textBox14.Text = "";


        }

        private void button13_Click(object sender, EventArgs e)
        {
            double a;
            double area, volumen;
            a = double.Parse(textBox15.Text);
            volumen = (1.41 / 3) * (a * a * a);
            area = (2 / 1.73) * (a * a);
            textBox18.Text = area.ToString();
            textBox16.Text = volumen.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox15.Text = "";
            textBox16.Text = "";
            textBox18.Text = "";
        }
    }
}

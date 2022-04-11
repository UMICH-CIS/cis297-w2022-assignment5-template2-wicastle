using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class Quad : Form
    {
        public Quad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double sqrt = b * b - 4 * a * c;

            double x1, x2;

            if (sqrt > 0)
            {

                x1 = (-b + System.Math.Sqrt(sqrt)) / (2 * a);
                label4.Text = x1.ToString();
                x2 = (-b - System.Math.Sqrt(sqrt)) / (2 * a);
                label5.Text = x2.ToString();
            }
            else if (sqrt < 0)
            {
                sqrt = -sqrt;
                x1 = -b / (2 * a);
                label4.Text = x1.ToString();
                x2 = System.Math.Sqrt(sqrt) / (2 * a);
                label5.Text = x2.ToString();
            }
            else
            {
                x1 = (-b + System.Math.Sqrt(sqrt)) / (2 * a);
                label4.Text = x1.ToString();
                label5.Text = x1.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

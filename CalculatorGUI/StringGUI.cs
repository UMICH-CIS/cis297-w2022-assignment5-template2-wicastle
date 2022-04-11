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
    public partial class StringGUI : Form
    {
        public StringGUI()
        {
            InitializeComponent();
        }

        string str = "";

        //Reverse
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = (textBox1.Text.Length - 1); i >= 0; i--)
            {
                str += textBox1.Text[i];
            }
            textBox1.Text = str;
            str = "";
        }

        //Remove
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text.Where(c => !Char.IsWhiteSpace(c)));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

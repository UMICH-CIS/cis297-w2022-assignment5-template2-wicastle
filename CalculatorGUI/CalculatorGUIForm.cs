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
   public partial class CalculatorGUIForm : Form
   {
      public CalculatorGUIForm()
      {
         InitializeComponent();
      }

        double resutlt = 0;
        char operation = ' ';
        bool dec = false;
       
        //Button -> 7
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        //Button -> 8
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        //Button -> 9
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        //Button -> MinMax
        private void button4_Click(object sender, EventArgs e)
        {
            MinMax f4 = new MinMax();
            f4.ShowDialog();
        }

        //Button -> 4
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        //Button -> 5
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        //Button -> 6
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        ////Button -> *
        private void button5_Click(object sender, EventArgs e)
        {
            operation = '*';
            label2.Text = "*";
            resutlt = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            textBox1.Text = "0";
            dec = false;
        }

        //Button -> 1
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }

        //Button -> 2
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        //Button -> 3
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        //Button -> /
        private void button9_Click(object sender, EventArgs e)
        {
            operation = '/';
            label2.Text = "/";
            resutlt = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            dec = false;
            textBox1.Text = "0";
        }

        //Button -> 0
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        //Button -> .
        private void button15_Click(object sender, EventArgs e)
        {
            if(dec == false)
            {
                dec = true;
                textBox1.Text += '.';
            }
        }

        //Button -> =
        private void button14_Click(object sender, EventArgs e)
        {
            dec = false;
            switch (operation)
            {
                case '+':
                    resutlt = resutlt + double.Parse(textBox1.Text);
                    label1.Text = resutlt.ToString();
                    break;
                case '-':
                    resutlt = resutlt - double.Parse(textBox1.Text);
                    label1.Text = resutlt.ToString();
                    break;
                case '*':
                    resutlt = resutlt * double.Parse(textBox1.Text);
                    label1.Text = resutlt.ToString();
                    break;
                case '/':
                    resutlt = resutlt / double.Parse(textBox1.Text);
                    label1.Text = resutlt.ToString();
                    break;
                case '%':
                    resutlt = resutlt % double.Parse(textBox1.Text);
                    label1.Text = resutlt.ToString();
                    break;
                case '√':
                    resutlt = Math.Sqrt(resutlt);
                    label1.Text = resutlt.ToString();
                    break;
                case '^':
                    resutlt = Math.Pow(resutlt, double.Parse(textBox1.Text));
                    label1.Text = resutlt.ToString();
                    break;
                case 'B':
                    resutlt = Math.Log(resutlt, double.Parse(textBox1.Text));
                    label1.Text = resutlt.ToString();
                    break;
                case 'L':
                    resutlt = Math.Log10(resutlt);
                    label1.Text = resutlt.ToString();
                    break;
            }
            textBox1.Text = "0";
        }

        //Button -> -
        private void button13_Click(object sender, EventArgs e)
        {
            operation = '-';
            label2.Text = "-";
            resutlt = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            textBox1.Text = "0";
            dec = false;
        }

        //InputTextFeild
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Button -> Revese string
        private void button19_Click(object sender, EventArgs e)
        {
            StringGUI f2 = new StringGUI();
            f2.ShowDialog();
        }

        //Button -> +
        private void button17_Click(object sender, EventArgs e)
        {
            operation = '+';
            label2.Text = "+";
            resutlt = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            textBox1.Text = "0";
            dec = false;
        }

        //Button -> sqrt
        private void button23_Click(object sender, EventArgs e)
        {
            operation = '√';
            label2.Text = "√";
            resutlt = double.Parse(textBox1.Text);
        }

        //Button -> pow
        private void button22_Click(object sender, EventArgs e)
        {
            operation = '^';
            label2.Text = "^";
            resutlt = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            textBox1.Text = "0";
            dec = false;
        }

        //Button -> logBaseX
        private void button21_Click(object sender, EventArgs e)
        {
            operation = 'B';
            label2.Text = "logBaseX";
            resutlt = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            textBox1.Text = "0";
            dec = false;
        }

        //Button -> logBase10
        private void button20_Click(object sender, EventArgs e)
        {
            operation = 'L';
            label2.Text = "logBase10";
            resutlt = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            dec = false;
        }

        //Button -> mod
        private void button25_Click(object sender, EventArgs e)
        {
            operation = '%';
            label2.Text = "%";
            resutlt = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text;
            textBox1.Text = "0";
            dec = false;
        }

        //Button -> quadratic
        private void button24_Click(object sender, EventArgs e)
        {
            Quad f3 = new Quad();
            f3.ShowDialog();
        }

        //Button -> remove white space
        private void button18_Click(object sender, EventArgs e)
        {
            StringGUI f2 = new StringGUI();
            f2.ShowDialog();
        }

        //Result TextFeild
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Button -> Clear entry
        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            dec = false;
        }

        //Operator TextFeild
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Button -> Clear all
        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            dec = false;
            resutlt = 0;
            label1.Text = "0";
        }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
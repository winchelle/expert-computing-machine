using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if(radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "TOTAL= "+c.ToString();
            }
            else if(radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "SUBTRACT= "+ c.ToString();
            }
            else if(radioButton3.Checked) 
            { 
             c= a * b;
                label4.Text = "MULTIPLE= "+ c.ToString();
            }
            else if(radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "DIVIDE= " + c.ToString();
            }
            else if(radioButton5.Checked)
            {
                c = a % b;
                label4.Text = "MOD= " + c.ToString();
            }

        }
    }
}

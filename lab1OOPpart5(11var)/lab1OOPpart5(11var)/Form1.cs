using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1OOPpart5_11var_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }

        private void TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "1";
        }

        private void TextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "2";
        }

        private void TextBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "3";
        }

        private void TextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = "4";
        }
    }
}

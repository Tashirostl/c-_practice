using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int value1;
        int value2;
        string label_value;

        private void button1_Click(object sender, EventArgs e)
        {
            label_value += 1;
            label1.Text = label_value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_value += 2;
            label1.Text = label_value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_value += 3;
            label1.Text = label_value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label_value += 4;
            label1.Text = label_value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label_value += 5;
            label1.Text = label_value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label_value += 6;
            label1.Text = label_value;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label_value += 7;
            label1.Text = label_value;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label_value += 8;
            label1.Text = label_value;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label_value += 9;
            label1.Text = label_value;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label_value += 0;
            label1.Text = label_value;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label_value += ".";
            label1.Text = label_value;
        }
    }
}

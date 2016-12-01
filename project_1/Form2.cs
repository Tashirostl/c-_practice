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
        float value1;
        int value2;
        int ButtonPushFlag;

        string LabelValue;

        private void button1_Click(object sender, EventArgs e)
        {
            LabelValue += 1;
            label1.Text = LabelValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabelValue += 2;
            label1.Text = LabelValue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LabelValue += 3;
            label1.Text = LabelValue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LabelValue += 4;
            label1.Text = LabelValue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LabelValue += 5;
            label1.Text = LabelValue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LabelValue += 6;
            label1.Text = LabelValue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LabelValue += 7;
            label1.Text = LabelValue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LabelValue += 8;
            label1.Text = LabelValue;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LabelValue += 9;
            label1.Text = LabelValue;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LabelValue += 0;
            label1.Text = LabelValue;
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            LabelValue += ".";
            label1.Text = LabelValue;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            value1 = float.Parse(LabelValue);
            label1.Text = value1.ToString();
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            value1 = 0;
            LabelValue = "";
            label1.Text = LabelValue;
        }
    }
}

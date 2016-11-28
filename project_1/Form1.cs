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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string L_name = textBox1.Text;
            string F_name = textBox2.Text;

            if (L_name.Length > 6)
            {
                label3.Text = "苗字は5文字以下までです。";
                return;
            }

            if (F_name.Length > 6)
            {
                label3.Text = "名前は5文字以下までです。";
                return;
            }

            label3.Text = L_name + " " + F_name;

        }
    }
}

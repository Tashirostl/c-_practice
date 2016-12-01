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

            if (CheckAlphabet.LowerAlphabet(L_name) == true || CheckAlphabet.LowerAlphabet(F_name) == true)
            {
                CheckAlphabet.ErrMsg("小文字の英数字を含んでいます。");
                return;
            }
            else if (CheckAlphabet.UpperAlphabet(L_name) == true || CheckAlphabet.UpperAlphabet(F_name) == true)
            {
                CheckAlphabet.ErrMsg("大文字の英数字を含んでいます。");
                return;
            }
            else if (CheckAlphabet.BothAlphabet(L_name) == true || CheckAlphabet.BothAlphabet(F_name) == true)
            {
                CheckAlphabet.ErrMsg("英数字を含んでいます。");
                return;
            }
            if (L_name.Length > 5)
            {
                CheckAlphabet.ErrMsg("苗字は5文字以下までです。");
                return;
            }

            if (F_name.Length > 5)
            {
                CheckAlphabet.ErrMsg("名前は5文字以下までです。");
                return;
            }

            label3.Text = L_name + " " + F_name;
            label5.Text = maskedTextBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

public class CheckAlphabet { };
//public class 
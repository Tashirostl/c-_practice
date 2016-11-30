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

            if (check_alphabet.lower_alphabet(L_name) == true || check_alphabet.lower_alphabet(F_name) == true)
            {
                check_alphabet.ErrMsg("小文字の英数字を含んでいます。");
                return;
            }
            else if (check_alphabet.upper_alphabet(L_name) == true || check_alphabet.upper_alphabet(F_name) == true)
            {
                check_alphabet.ErrMsg("大文字の英数字を含んでいます。");
                return;
            }
            else if (check_alphabet.both_alphabet(L_name) == true || check_alphabet.both_alphabet(F_name) == true)
            {
                check_alphabet.ErrMsg("英数字を含んでいます。");
                return;
            }
            if (L_name.Length > 5)
            {
                check_alphabet.ErrMsg("苗字は5文字以下までです。");
                return;
            }

            if (F_name.Length > 5)
            {
                check_alphabet.ErrMsg("名前は5文字以下までです。");
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

public class check_alphabet { };
//public class 
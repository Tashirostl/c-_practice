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

        KeisankiButton keisan = new KeisankiButton();

        private void Button1_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(1, ref label1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(2, ref label1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(3, ref label1);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(4, ref label1);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(5, ref label1);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(6, ref label1);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(7, ref label1);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(8, ref label1);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(9, ref label1);
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(0, ref label1);
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            keisan.NumberButton(10, ref label1);
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            keisan.ArithmeticOperatorButton(1,ref label1);
        }
        
        private void DifferenceButton_Click(object sender, EventArgs e)
        {
            keisan.ArithmeticOperatorButton(2,ref label1);
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            keisan.ArithmeticOperatorButton(3,ref label1);
        }


        private void QuotientButton_Click(object sender, EventArgs e)
        {
            keisan.ArithmeticOperatorButton(4, ref label1);
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            keisan.ResetButton(ref label1);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            keisan.AnswerDisplay(ref label1);
        }
    }
}
public class KeisankiButton { }

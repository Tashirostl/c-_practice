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
        float value1;                       //作業用変数
        int OperatorButtonFlag;             //演算子判定用フラグ
        static int ButtonPushFlag;                 //数字ボタン判定用フラグ

        string LabelValue;

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0) { LabelValue = ""; }
            LabelValue += 1;
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0) { LabelValue = ""; }
            LabelValue += 2;
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0) { LabelValue = ""; }
            LabelValue += 3;
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0) { LabelValue = ""; };
            LabelValue += 4;
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0) { LabelValue = ""; }
            LabelValue += 5;
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0) { LabelValue = ""; }
            LabelValue += 6;
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 1) { LabelValue = ""; };
            LabelValue += 7;
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0) { LabelValue = ""; };
            LabelValue += 8;
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0) { LabelValue = ""; }
            LabelValue += 9;
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if(LabelValue == "") { return; }
            if (ButtonPushFlag == 0) { LabelValue = ""; }
            LabelValue += 0;
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0) { LabelValue = ""; }
            if (LabelValue == "") { LabelValue += 0; }
            LabelValue += ".";
            label1.Text = LabelValue;
            ButtonPushFlag = 1;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0)                //数字ボタンを押さずに+ボタンを押した場合
            {
                //何もしない
            }
            else　                                  //数字ボタンを押してから+ボタンを押した場合
            {
                value1 += float.Parse(LabelValue); 
                ButtonPushFlag = 0;
                label1.Text = value1.ToString();
            }

            OperatorButtonFlag = 1;                 //演算子判定用フラグ（+ボタン)
        }
        
        private void DifferenceButton_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0)                //数字ボタンを押さずに-ボタンを押した場合
            {
                //何もしない
            }
            else　                                  //数字ボタンを押してから-ボタンを押した場合
            {
                if (value1 == 0)
                {
                    value1 = float.Parse(LabelValue);
                    ButtonPushFlag = 0;
                    OperatorButtonFlag = 2;
                    return;
                }
                value1 -= float.Parse(LabelValue);
                ButtonPushFlag = 0;
                label1.Text = value1.ToString();
            }

            OperatorButtonFlag = 2;                 //演算子判定用フラグ（-ボタン)
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0)                //数字ボタンを押さずに*ボタンを押した場合
            {
                //何もしない
            }
            else　                                  //数字ボタンを押してから*ボタンを押した場合
            {
                if(value1 == 0)
                {
                    value1 = float.Parse(LabelValue);
                    ButtonPushFlag = 0;
                    OperatorButtonFlag = 3;
                    return;
                }
                value1 *= float.Parse(LabelValue);
                ButtonPushFlag = 0;
                label1.Text = value1.ToString();
            }

            OperatorButtonFlag = 3;                 //演算子判定用フラグ（*ボタン)
        }


        private void QuotientButton_Click(object sender, EventArgs e)
        {
            if (ButtonPushFlag == 0)                //数字ボタンを押さずに/ボタンを押した場合
            {
                //何もしない
            }
            else　                                  //数字ボタンを押してから/ボタンを押した場合
            {
                if (value1 == 0)
                {
                    value1 = float.Parse(LabelValue);
                    ButtonPushFlag = 0;
                    OperatorButtonFlag = 4;
                    return;
                }
                value1 /= float.Parse(LabelValue);
                ButtonPushFlag = 0;
                label1.Text = value1.ToString();
            }

            OperatorButtonFlag = 4;                 //演算子判定用フラグ（/ボタン)
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            value1 = 0;
            LabelValue = "";
            label1.Text = LabelValue;
            ButtonPushFlag = 0;
            OperatorButtonFlag = 0;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            switch (OperatorButtonFlag)
            {
                case 1:         //  +演算子
                    value1 += float.Parse(LabelValue);
                    label1.Text = value1.ToString();
                    ButtonPushFlag = 0;
                    break;
                case 2:         //  -演算子
                    value1 -= float.Parse(LabelValue);
                    label1.Text = value1.ToString();
                    ButtonPushFlag = 0;
                    break;
                case 3:         //  *演算子
                    value1 *= float.Parse(LabelValue);
                    label1.Text = value1.ToString();
                    ButtonPushFlag = 0;
                    break;
                case 4:         //  /演算子
                    value1 /= float.Parse(LabelValue);
                    label1.Text = value1.ToString();
                    ButtonPushFlag = 0;
                    break;
                default:
                    break;
            }
        }
    }
}

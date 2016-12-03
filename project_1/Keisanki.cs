using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public class KeisankiButton
    {
        public int ButtonPushFlag { get; private set; }
        public int OperatorButtonFlag { get; private set; }
        public string LabelValue { get; private set; }
        public float value1 { get; private set; }
        
        #region


        /// <summary>
        /// ラベルに表示します
        /// </summary>
        /// <param name="Display">labelを参照渡しで渡します。</param>
        public void AnswerDisplay(ref Label Display)
        {
            switch(OperatorButtonFlag)
            {
                case 1:
                    value1 += float.Parse(LabelValue);
                    break;
                case 2:
                    value1 -= float.Parse(LabelValue);
                    break;
                case 3:
                    value1 *= float.Parse(LabelValue);
                    break;
                case 4:
                    value1 /= float.Parse(LabelValue);
                    break;
            }
            ButtonPushFlag = 0;
            Display.Text = value1.ToString();
        }
        /// <summary>
        /// 数字ボタンの処理
        /// </summary>
        /// <param name="NumberId">押した番号のidを渡します。</param>
        /// <param name="Display">labelを参照渡しで渡します。</param>
        public void NumberButton(int NumberId,ref Label Display)
        {
            if (ButtonPushFlag == 0) { LabelValue = ""; }
            switch (NumberId)
            {
                case 0:
                    if (LabelValue == "") { return; }
                    LabelValue += 0;
                    break;

                case 1:
                    LabelValue += 1;
                    break;

                case 2:
                    LabelValue += 2;
                    break;

                case 3:
                    LabelValue += 3;
                    break;

                case 4:
                    LabelValue += 4;
                    break;

                case 5:
                    LabelValue += 5;
                    break;

                case 6:
                    LabelValue += 6;
                    break;

                case 7:
                    LabelValue += 7;
                    break;

                case 8:
                    LabelValue += 8;
                    break;

                case 9:
                    LabelValue += 9;
                    break;

                case 10:
                    if (ButtonPushFlag == 0) { LabelValue = ""; }
                    if (LabelValue == "") { LabelValue += 0; }
                    LabelValue += ".";
                    break;

                default:
                    break;
            }
            Display.Text = LabelValue;
            ButtonPushFlag = 1;
        }


        /// <summary>
        /// 演算子のボタンの処理
        /// </summary>
        /// <param name="OperaterId">どの演算子を押したか判定するためのidを渡します。</param>
        /// <param name="Display">labelを参照渡しで渡します。</param>
        public void ArithmeticOperatorButton(int OperaterId,ref Label Display)
        {
            OperatorButtonFlag = OperaterId;                

            if (ButtonPushFlag == 0){ }
            else　                                  
            {
                if (value1 == 0)
                {
                    value1 = float.Parse(LabelValue);
                    ButtonPushFlag = 0;
                    return;
                }
                AnswerDisplay(ref Display);
            }
        }

        /// <summary>
        /// リセットボタンの処理
        /// </summary>
        /// <param name="Display">labelを参照渡しで渡します。</param>
        public void ResetButton(ref Label Display)
        {
            value1 = 0;
            LabelValue = "";
            Display.Text = LabelValue;
            ButtonPushFlag = 0;
            OperatorButtonFlag = 0;
        }

        
        #endregion
    }
}

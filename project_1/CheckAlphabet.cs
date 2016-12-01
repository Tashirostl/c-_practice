using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public class CheckAlphabet
    {
        #region
        /// <summary>
        /// "小文字の英数字を判定します。"
        /// </summary>
        /// <param name="target">"判定したい文字列をstring型で渡します"</param>
        /// <returns>"小文字の英数字のみの場合はtrue、小文字の英数字以外を使用した場合はfalseを返します。"</returns>
        public static bool LowerAlphabet(string target)
        {
            return new System.Text.RegularExpressions.Regex("^[0-9a-z]+$").IsMatch(target);
        }

        /// <summary>
        /// "大文字の英数字を判定します。"
        /// </summary>
        /// <param name="target">"判定したい文字列をstring型で渡します"</param>
        /// <returns>"大文字の英数字のみの場合はtrue、大文字の英数字以外を使用した場合はfalseを返します。"</returns>
        public static bool UpperAlphabet(string target)
        {
            return new System.Text.RegularExpressions.Regex("^[0-9A-Z]+$").IsMatch(target);
        }

        /// <summary>
        /// "小文字大文字の英数字を判定します。"
        /// </summary>
        /// <param name="target">"判定したい文字列をstring型で渡します"</param>
        /// <returns>"小文字大文字の英数字のみの場合はtrue、小文字大文字の英数字以外を使用した場合はfalseを返します。"</returns>
        public static bool BothAlphabet(string target)
        {
            return new System.Text.RegularExpressions.Regex("^[0-9a-zA-Z]+$").IsMatch(target);
        }
        /// <summary>
        /// "メッセージボックスでエラーメッセージを表示します。"
        /// </summary>
        /// <param name="errmsg">"表示したいエラーメッセージをstring型で渡します。"</param>
        public static void ErrMsg(string errmsg)
        {
            MessageBox.Show(errmsg, "エラー",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }

        #endregion
    }
}

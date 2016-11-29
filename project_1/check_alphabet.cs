using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public class check_alphabet
    {
        #region
        public static bool lower_alphabet(string target)
        {
            return new System.Text.RegularExpressions.Regex("^[0-9a-z]+$").IsMatch(target);
        }

        public static bool upper_alphabet(string target)
        {
            return new System.Text.RegularExpressions.Regex("^[0-9A-Z]+$").IsMatch(target);
        }

        public static bool both_alphabet(string target)
        {
            return new System.Text.RegularExpressions.Regex("^[0-9a-zA-Z]+$").IsMatch(target);
        }

        public static void ErrMsg(string errmsg)
        {
            MessageBox.Show(errmsg, "エラー",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlotteSoft.BLL
{
    public class UtilsBLL
    {
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                {
                    n = "";
                }
                n = n.PadLeft(4, '0');

                if (n.Length > 4 & n.Substring(0, 1) == "0")
                {
                    n = n.Substring(1, n.Length - 1);
                }

                v = Convert.ToDouble(n) / 100;

                txt.Text = string.Format("{0:N}", v);

                txt.SelectionStart = txt.Text.Length;
                

            }
            catch (Exception)
            {

            }

        }
    }
}

using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace liczydlo
{
    internal class dotbutton
    {
        public bool bylo;
        public string dotButton(object sender, Form1 frm)
        {
            string currentVal = frm.returneedVal().ToString();
            bylo = frm.bylo;

            if (!bylo)
            {
                bylo = true;
                if (currentVal.Length == 0)
                {
                    return "0.";
                }

                if ((currentVal.Length != 0) && (currentVal != "0."))
                {
                    char[] chars = { '%', '*', '/', '+', '-' };
                    if (chars.Any(x => currentVal.EndsWith(char.ToString(x))))
                    {
                        return currentVal + "0.";
                    }
                    else
                    {
                        /*dodajTresc(sender);*/

                        return currentVal + ".";
                    }
                }
            }
            return currentVal;
        }

    }
}

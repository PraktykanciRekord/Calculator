using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace liczydlo
{
    internal class dodajznakspecjalny
    {
        public bool bylo;
        public string dodaj_znak_specjalny(object ll, Form1 frm)
        {
            //Form1 frm = new Form1();
            string currentVal = frm.returneedVal();
            bylo = frm.bylo;

            var btn = ll as Button;
            //string test = textBox1.Text;
            if (currentVal.Length != 0)
            {
                char[] chars = { '+', '-', '/', '*', '%' };
                char last = currentVal[currentVal.Length - 1];

                if (chars.Any(x => currentVal.EndsWith(char.ToString(x))))
                {
                    bylo = false;
                    if (btn != null)
                    {
                        string current_text = currentVal;
                        return current_text.Remove(current_text.Length - 1, 1) + btn.Text;
                    }
                }
                else if (last != char.Parse(btn.Text))
                {
                    bylo = false;
                    if (btn != null)
                    {
                        return currentVal + btn.Text;
                    }
                }
            }
            return "";
        }
    }
}

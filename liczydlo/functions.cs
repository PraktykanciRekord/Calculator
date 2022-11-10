using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace liczydlo
{
    internal class functions
    {
        static Double Eval(String expression)
        {
            if (!(expression.Contains('E')))
            {
                try
                {
                    System.Data.DataTable table = new System.Data.DataTable();
                    return Convert.ToDouble(table.Compute(expression, String.Empty));
                }
                catch
                {

                    return 0;
                }
            }
            return 0;
        }


        public bool bylo;
        public string dodajTresc(object ll)
        {
            var btn = ll as Button;
            if (btn != null)
            {
                return btn.Text;
            }
            return "";
        }
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
        public string equalsButton(Form1 frm)
        {
            string currentVal = frm.returneedVal();

            if (currentVal.Length != 0)
            {
                string lastchar = currentVal[currentVal.Length - 1] + " ";
                bool b = new char[] { '%', '*', '/', '+', '-' }.Any(s => lastchar.Contains(s));
                if (!b)
                {
                    if (currentVal.Contains('E'))
                    {
                        return "Duża liczba";
                    }
                    if (currentVal.Contains(','))
                    {
                        for (int i = 0; i < currentVal.Length; i++)
                        {
                            if (currentVal[i] == ',')
                            {
                                return currentVal.Remove(i, 1).Insert(i, ".");
                            }
                        }
                    }
                    Double cnvrt = Eval(currentVal);
                    if (cnvrt.ToString() == "∞" || cnvrt.ToString() == "-∞" || cnvrt.ToString() == "NaN")
                    {
                        return "Nie dzielimy przez 0";
                    }
                    else
                    {
                        if (cnvrt.ToString().Contains(","))
                        {
                            bylo = true;
                        }
                        currentVal = cnvrt.ToString();
                        return currentVal;
                    }

                }

            }
            return "";
        }

    }
}

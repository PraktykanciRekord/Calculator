using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace liczydlo
{
    internal class equalsbutton
    {
        public bool bylo;
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

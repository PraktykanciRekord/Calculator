using System;
using System.Linq;

namespace liczydlo
{
    internal class funequalsbutton
    {
        public bool bylo;

        public string funequalsButton(Form1 frm)
        {
            string currentVal = frm.returneedVal();
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
            Double_Eval de = new Double_Eval();
            Double cnvrt = de.Eval(currentVal);
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
            return "";
        }
    }
}
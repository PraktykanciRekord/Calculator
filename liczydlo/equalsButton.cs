using System;
using System.Linq;
using Calculator.Core;

namespace liczydlo
{
    internal class equalsbutton
    {
        /*ReturnSolution de = new ReturnSolution();*/
        CalculatorReturnSolution crs = new CalculatorReturnSolution();
        public string equalsButton(Form1 frm)
        {
            string currentVal = frm.returneedVal();
            if (currentVal.Length != 0)
            {
                string lastchar = currentVal[currentVal.Length - 1] + " ";
                bool b = new char[] { '%', '*', '/', '+', '-' }.Any(s => lastchar.Contains(s));
                if (!b)
                {
                    string cnvrt = crs.showSolution(currentVal);
                    return cnvrt;
                }
            }
            return "";
        }
    }
}
using System.Linq;

namespace liczydlo
{
    internal class equalsbutton
    {
        public bool bylo;
        Double_Eval de = new Double_Eval();
        public string equalsButton(Form1 frm)
        {
            string currentVal = frm.returneedVal();
            if (currentVal.Length != 0)
            {
                string lastchar = currentVal[currentVal.Length - 1] + " ";
                bool b = new char[] { '%', '*', '/', '+', '-' }.Any(s => lastchar.Contains(s));
                if (!b)
                {
                    funequalsbutton feb = new funequalsbutton();
                    return (feb.funequalsButton(frm));
                }
            }
            return "";
        }
    }
}
using System.Linq;


namespace liczydlo
{
    internal class fundotbutton
    {
        public bool bylo;
        public string fundotButton(object sender, Form1 frm)
        {
            string currentVal = frm.returneedVal().ToString();
            // Jeżeli ostatni znak jest operatorem to dodaje 0 przed .
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
            return currentVal;
        }

    }
}

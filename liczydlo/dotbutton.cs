using System.Linq;


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
                // Jeżeli wyrażenie jest puste i naciśniemy . to dodaje 0 przed nią
                if (currentVal.Length == 0)
                {
                    return "0.";
                }

                if ((currentVal.Length != 0) && (currentVal != "0."))
                {
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
                }
            }
            return currentVal;
        }

    }
}

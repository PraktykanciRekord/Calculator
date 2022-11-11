using System.Linq;
using System.Windows.Forms;


namespace liczydlo
{
    internal class dodajznakspecjalny
    {
        public bool bylo;
        public string dodaj_znak_specjalny(object ll, Form1 frm)
        {
            string currentVal = frm.returneedVal();
            bylo = frm.bylo;

            var btn = ll as Button;
            if (currentVal.Length != 0)
            {
                
                char[] chars = { '+', '-', '/', '*', '%' };
                char lastChar = currentVal[currentVal.Length - 1];

                if (chars.Any(x => currentVal.EndsWith(char.ToString(x))))
                {
                    bylo = false;
                    if (btn != null)
                    {
                        return currentVal.Remove(currentVal.Length - 1, 1) + btn.Text;
                    }
                }
                else if (lastChar != char.Parse(btn.Text))
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

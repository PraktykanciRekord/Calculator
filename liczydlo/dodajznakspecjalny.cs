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
                fundodajznakspecjalny fdzs = new fundodajznakspecjalny();
                return (fdzs.fun_dodaj_znak_specjalny(ll, frm));
            }
            return "";
        }
    }
}

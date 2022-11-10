using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace liczydlo
{
    internal class dodajTresc
    {
        public string dodajTresc1(object ll)
        {
            var btn = ll as Button;
            if (btn != null)
            {
                return btn.Text;
            }
            return "";
        }

    }
}

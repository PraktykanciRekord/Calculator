using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liczydlo
{
    internal class functions
    { 
        public string dodajTresc(object ll)
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

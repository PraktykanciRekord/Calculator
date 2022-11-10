using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;


namespace liczydlo
{
    internal class DoubleEval
    {
        // Wykonywanie działań
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

        

    }
}

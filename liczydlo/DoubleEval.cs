using System;
using System.Linq;

namespace liczydlo
{
    internal class Double_Eval
    {
        // Wykonywanie działań
        public Double Eval(String expression)
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
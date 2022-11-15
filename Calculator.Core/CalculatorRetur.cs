using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core
{
    public class CalculatorReturnSolution
    { 
            // Wykonywanie działań
        public string showSolution(String expression)
        {
            string[] errors = { "Duża liczba", "Nie dzielimy przez 0", "error" };
            string expr = expression.ToString();
            if (!(expression.Contains('E')))
            {
                try
                {
                    System.Data.DataTable table = new System.Data.DataTable();
                    double cnvrt = Convert.ToDouble(table.Compute(expr, String.Empty));
                    string resault = cnvrt.ToString();

                    if (resault.Contains('E'))
                    {
                        return "Duża liczba";
                    }

                    if (resault.ToString() == "∞" || resault.ToString() == "-∞" || resault.ToString() == "NaN")
                    {
                        return "Nie dzielimy przez 0";
                    }

                    if (resault.Contains(','))
                    {
                        resault = resault.Replace(',', '.');
                    }


                    return resault;

                }

                catch
                {

                    return "error";
                }
            }
            else
            {
                return "Duża liczba";
            }
        }
    }
}

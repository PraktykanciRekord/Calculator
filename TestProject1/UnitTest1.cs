global using liczydlo;



namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public double Test1()
        {
            Double_Eval de = new Double_Eval();
            double a = de.Eval("2+2");
            double b = de.Eval("2-1");
            double c = de.Eval("22/4");
            double d = de.Eval("21*10");
            double e = de.Eval("");
            double f = de.Eval("-");
            double g = de.Eval("+");
            double h = de.Eval("/");
            double i = de.Eval("*");
            double j = de.Eval("%");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            return j;
        }
    }
}
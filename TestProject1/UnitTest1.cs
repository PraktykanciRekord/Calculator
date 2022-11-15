global using liczydlo;
using System.Numerics;
using Xunit;


namespace MyTestes
{
    public class UnitTest
    {
        [Fact]
        public double Test1()
        {
            // arrange
            Double_Eval de = new Double_Eval();

            // act


            // assert
            Assert.Equal("4", de.Eval("2+2"));
            Assert.Equal("6", de.Eval("3+3"));
            Assert.Equal("6", de.Eval("2+2*2"));
            Assert.Equal("0", de.Eval("0"));
            Assert.Equal("12", de.Eval("12"));
            return 0;
        }

    }
}

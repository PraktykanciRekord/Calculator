global using liczydlo;
using Calculator.Core;
using System.Numerics;
using Xunit;


namespace MyTestes
{
    public class UnitTest
    {
        [Theory]
        [InlineData("4","2+2")]
        [InlineData("1", "2/2")]
        [InlineData("Nie dzielimy przez 0", "9/0")]
        [InlineData("Du¿a liczba", "1,7976931348623157E+308")]
        [InlineData("error", "3.2/0")]
        [InlineData("2.5", "5/2")]
        public double Test1(string result, string operation)
        {
            // arrange
            var de = new CalculatorReturnSolution();

            // act


            // assert
            Assert.Equal(result, de.showSolution(operation));
            return 0;
        }

    }
}

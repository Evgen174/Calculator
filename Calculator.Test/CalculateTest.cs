using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Test
{
    public class CalculateTest
    {
        [Theory]
        [InlineData("(8-6)+(8-7)")]
        [InlineData("-(8-6)+5")]
        public void CalculateReshTest(string value)
        {

            var res = Calculate.CalculatePrimer(value);

            Assert.Equal("3", res);
        }
    }
}

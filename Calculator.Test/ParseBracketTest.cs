using Xunit;

namespace Calculator.Test
{
    public class ParseBracketTest
    {
        [Theory]
        [InlineData("(8-6)+(5-7)")]
        [InlineData("(3+(8-6))+4")]
        [InlineData("-(8-6)+1")]
        public void ParsInStringTest(string value)
        {
            
            var res = ParseBracket.ParsInString(value).Length;

            Assert.Equal(3, res);
        }

        

    }
}

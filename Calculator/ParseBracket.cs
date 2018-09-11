using System.Linq;

namespace Calculator
{
    public class ParseBracket
    {
        public static string[] ParsInString(string str)
        {
            str = str.Replace(" ", "");
            str = str.Replace("=", "");
            var split = str.Split('(', ')');
            var result = split.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            return result;

        }
    }
}

using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Decision
    {
        
        public static string SimpleDecision(string str, string pattern, IMethods[] methods, IRuleMethods[] rules)
        {
            try
            {
                while (true)
                {

                    int precedence = 0;
                    foreach (var k in str)
                    {
                        if (!Char.IsDigit(k))
                        {
                            foreach (IMethods t in methods)
                            {
                                if (k.ToString() == t.Value)
                                {
                                    if (precedence < t.Precedence) precedence = t.Precedence;
                                }
                            }
                        }
                    }

                    str = ConflictMethods.CheckConflictMethods(str, rules);
                    Regex regex = new Regex(pattern);
                    string[] substrings = regex.Split(str, 10);
                    var result = substrings.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                    result = ConflictMethods.CheckInkrementMethodsInPrimer(result, methods);
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (!IsNumber(result[i]))
                        {
                            var flagResh = 0;
                            foreach (IMethods t in methods)
                            {
                                if (result[i] == t.Value && precedence == t.Precedence)
                                {
                                    result[i] = t.Action(Convert.ToDouble(result[i - 1]), Convert.ToDouble(result[i + 1])).ToString(CultureInfo.InvariantCulture);
                                    result[i - 1] = "";
                                    result[i + 1] = "";

                                    flagResh = 1;
                                    break;

                                }
                            }
                            if (flagResh == 1) break;
                        }
                    }
                    result = result.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                    str = "";
                    foreach (var h in result)
                    {
                        str += h;
                    }
                    if (result.Length == 1) break;



                }
                return str;
            }
            catch
            {
                return str;
            }
            
            
        }

        private static bool IsNumber(string str)
        {
            try
            {
                var d = Convert.ToDouble(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    class ConflictMethods
    {
        public static string CheckConflictMethods(string str, IRuleMethods[] rulers)
        {
            
            Regex regex = new Regex(@"(\d)");
            string[] substrings = regex.Split(str, 10);
            str = "";
            foreach (string t1 in substrings)
            {
                var flagzamena = 0;
                foreach (var t in rulers)
                {
                    if (t1 == t.Conflict)
                    {
                        str += t.Rule;
                        flagzamena++;
                    }
                }
                if (flagzamena == 0) str += t1;
            }
            return str;
        }

        public static string[] CheckInkrementMethodsInPrimer(string[] str, IMethods[] methods)
        {
            if (str.Length > 2)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    foreach (var t in methods)
                    {
                        if (str[i] == t.Value)
                        {
                            if (i == 0 || i != 0 && !IsNumber(str[i - 1]))
                                if (t.Inkrement)
                                {
                                    str[i + 1] = str[i] + str[i + 1];
                                    str[i] = "";
                                }
                                else
                                {
                                    str[i] = "";
                                }
                        }

                    }
                }
                return str.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            }
            return str;
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

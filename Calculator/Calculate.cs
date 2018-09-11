using System;

namespace Calculator
{
    public class Calculate
    {
        public static string CalculatePrimer(string str)
        {
            IMethods[] methods = CollectionMethods.GetCollectMethods();
            String pattern = CollectionMethods.GetPatternString(methods);
            IRuleMethods[] rules = CollectRules.GetCollectRules();

            var result = ParseBracket.ParsInString(str);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Decision.SimpleDecision(result[i], pattern, methods, rules);
            }
            str = "";
            foreach (var h in result)
            {
                str += h;
            }
            str = Decision.SimpleDecision(str, pattern, methods, rules);
            return str;


        }
    }
}

using Calculator.SimpleMethods;

namespace Calculator
{
    class CollectionMethods
    {
        public static IMethods[] GetCollectMethods()
        {
            IMethods[] methods = new IMethods[4];
            methods[0] = new MethodPlus();
            methods[1] = new MethodDivision();
            methods[2] = new MethodMinus();
            methods[3] = new MethodMultiplication();
            return methods;
        }

        public static string GetPatternString(IMethods[] collectMethods)
        {
            var patternString = "";
            for (int i = 0; i < collectMethods.Length; i++)
            {
                if(i != collectMethods.Length-1) patternString += $"{collectMethods[i].PatternString}|";
                else patternString += $"{collectMethods[i].PatternString}";

            }
            
            return patternString;
        }
    }
}



namespace Calculator.SimpleMethods
{
    public class MethodDivision : IMethods
    {
        public string Value
        {
            get { return "/"; }
        }

        public string PatternString
        {
            get { return "(/)"; }
        }

        public bool Inkrement
        {
            get { return false; }
        }
        public int Precedence
        {
            get { return 2; }
        }

        public double Action(double x, double y)
        {
            return x / y;
        }
    }
}

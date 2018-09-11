namespace Calculator.SimpleMethods
{
    class MethodMinus : IMethods
    {
        public string Value
        {
            get { return "-"; }
        }
        public string PatternString
        {
            get { return "(-)"; }
        }

        public bool Inkrement
        {
            get { return true; }
        }
        public int Precedence
        {
            get { return 1; }
        }

        public double Action(double x, double y)
        {
            return x - y;
        }
    }
}

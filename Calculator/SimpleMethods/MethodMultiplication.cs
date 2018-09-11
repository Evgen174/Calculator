using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SimpleMethods
{
    class MethodMultiplication : IMethods
    {
        public string Value
        {
            get { return "*"; }
        }

        public string PatternString
        {
            get { return @"(\*)"; }
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
            return x * y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.SimpleMethods
{
    class MethodPlus : IMethods
    {
        public string Value
        {
            get { return "+"; }
        }
        public string PatternString
        {
            get { return @"(\+)"; }
        }
        public int Precedence
        {
            get { return 1; }
        }

        public bool Inkrement
        {
            get { return false; }
        }

        public double Action(double x, double y)
        {
            return x + y;
            
        }
    }
}

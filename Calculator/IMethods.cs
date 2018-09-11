using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IMethods
    {
        string Value { get; }
        int Precedence { get; }
        string PatternString { get; }

        bool Inkrement { get; }
        double Action(double x, double y);
    }
}

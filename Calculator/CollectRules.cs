using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Rule;

namespace Calculator
{
    class CollectRules
    {
        public static IRuleMethods[] GetCollectRules()
        {
            IRuleMethods[] rules = new IRuleMethods[4];
            rules[0] = new RuleMinusMinus();
            rules[1] = new RuleMinusPlus();
            rules[2] = new RulePlusMinus();
            rules[3] = new RulePlusPlus();
            return rules;
        }
    }
}

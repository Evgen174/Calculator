﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Rule
{
    class RulePlusMinus:IRuleMethods
    {
        public string Conflict
        {
            get { return "+-"; }
        }
        public string Rule
        {
            get { return "-"; }
        }
    }
}

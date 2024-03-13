using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Client
{
    internal class CalculateValue
    {
        double a, b;

        public double B { get { return b; } set { b = 7 * (Math.Sqrt(2)); } }
        public double A { get { return a; } set { a = (5 * Math.PI) / 2; } }
    }
}

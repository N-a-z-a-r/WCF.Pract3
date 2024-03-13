using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Project
{
    public class ServiceCalculate : IServiceCalculate
    {
        public double Calculate(double a, double b, double c)
        {
            double result = 1;
            for (int i = 1; i <= 5; i++)
            {
                double expression = (Math.Log(b) * c + Math.Cos(a) + 5) / Factorial(i);
                result *= expression;
            }
            return result;
        }

        private int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}

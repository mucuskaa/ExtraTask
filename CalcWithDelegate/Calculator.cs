using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWithDelegate
{
    static class Calculator
    {
        public static event EventHandler DivideByZeroEvent = null;

        public static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;

        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                DivideByZeroEvent.Invoke(null, EventArgs.Empty);
                return 0;
            }
                return a/b;
        }

    }
}

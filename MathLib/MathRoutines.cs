using System;

namespace MathLib
{
    public class MathRoutines
    {
        public static decimal Add(decimal one, decimal two)
        {
            return one+two;
        }

        public static decimal Ceiling(decimal number)
        {
            
            return Math.Ceiling(number);
        }

        public static decimal Floor(decimal number)
        {
            
            return Math.Floor(number);
        }

        public static decimal Subtract(decimal one, decimal two)
        {
            return one-two;
        }

        public static decimal Multiply(decimal one, decimal two)
        {
            return one*two;
        }

        public static decimal Divide(decimal one, decimal two)
        {
            return one/two;
        }

        public static double Power(double number, double power)
        {
            return Math.Pow(number, power);
        }

    }
}

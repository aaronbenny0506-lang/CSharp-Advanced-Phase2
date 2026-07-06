using System;

namespace SimpleCalculator
{
    // A class that groups together all the calculator's operations.
    // Each method takes two numbers (parameters) and returns a result (return type).
    class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Division needs extra care: dividing by zero is not allowed.
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("You can't divide by zero.");
            }
            return a / b;
        }
    }
}

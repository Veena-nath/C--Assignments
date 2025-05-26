using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask2.Model
{
    public class Calculator
    {
         
        // Method to divide two integers
        public int Divide(int numerator, int denominator)
        {
            // This may throw ArithmeticException (e.g., divide by zero)
            return numerator / denominator;
        }
    }
}

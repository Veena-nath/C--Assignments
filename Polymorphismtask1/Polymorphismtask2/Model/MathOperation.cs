using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismtask2.Model
{
    public class MathOperation
    {
        // Add methods
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        // Subtract methods
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiply methods
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Divide methods with validation
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return double.NaN;
            }
            return (double)a / b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0.0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return double.NaN;
            }
            return a / b;
        }
    }
}

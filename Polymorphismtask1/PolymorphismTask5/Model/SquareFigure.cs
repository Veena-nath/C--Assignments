using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTask5.Model
{
    internal class SquareFigure : GeometricFigure
    {
        // Side of the square
        protected double side;

        //  input for square
        public override void Accept()
        {
            numberOfSides = 4; // Square has 4 sides
            Console.Write("Enter side of square: ");
            side = Convert.ToDouble(Console.ReadLine());
        }

        // Display square details
        public override void Display()
        {
            Console.WriteLine("Square - Side: " + side);
        }

        // Compute and display area of the square
        public override void ComputeArea()
        {
            double area = side * side;
            Console.WriteLine("Area of Square: " + area);
        }
    }
}

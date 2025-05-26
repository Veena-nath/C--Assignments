
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTask5.Model
{
    // RectangleFigure class
    public class RectangleFigure :GeometricFigure
    {
        // Length and breadth of the rectangle
        protected double length;
        protected double breadth;

        // Accept input for rectangle
        public override void Accept()
        {
            numberOfSides = 4; // Rectangle has 4 sides

            Console.Write("Enter length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth: ");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

        // Display rectangle 
        public override void Display()
        {
            Console.WriteLine("Rectangle - Length: " + length + ", Breadth: " + breadth);
        }

        // Compute and display area of the rectangle
        public override void ComputeArea()
        {
            double area = length * breadth;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
}
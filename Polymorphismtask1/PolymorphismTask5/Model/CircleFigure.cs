using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTask5.Model
{
    public class CircleFigure : GeometricFigure
    {
        // Radius of the circle
        protected double radius;

        // Accept input for circle
        public override void Accept()
        {
            numberOfSides = 0; // Circle has no sides
            Console.Write("Enter radius of circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        // Display circle 
        public override void Display()
        {
            Console.WriteLine("Circle - Radius: " + radius);
        }

        // Compute and display area of the circle
        public override void ComputeArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }

    }
}

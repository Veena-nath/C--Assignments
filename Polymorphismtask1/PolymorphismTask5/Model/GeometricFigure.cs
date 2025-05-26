using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTask5.Model
{
    public class GeometricFigure
    {
        // Number of sides
        protected int numberOfSides;

        // Accept input
        public virtual void Accept()
        {
            Console.Write("Enter number of sides: ");
            numberOfSides = Convert.ToInt32(Console.ReadLine());
        }

        // Display
        public virtual void Display()
        {
            Console.WriteLine("Number of sides: " + numberOfSides);
        }

        // Compute area 
        public virtual void ComputeArea()
        {
            Console.WriteLine("Area: Not defined in base class.");
        }

    }
}

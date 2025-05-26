using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTask4.Model
{
    public class Height
    {
        public int Feet { get; set; }
        public int Inches { get; set; }

        // Constructor
        public Height(int feet, int inches)
        {
            Feet = feet;
            Inches = inches;
            Normalize(); 
        }

        // Method 
        private void Normalize()
        {
            if (Inches >= 12)
            {
                Feet += Inches / 12;
                Inches = Inches % 12;
            }
        }

        // Overload + operator to increment inches by 1
        public static Height operator +(Height h, int increment)
        {
            h.Inches += increment;
            h.Normalize();
            return h;
        }

        // Display height 
        public void Display()
        {
            Console.WriteLine($"Height: {Feet} feet, {Inches} inches");
        }
    }
}

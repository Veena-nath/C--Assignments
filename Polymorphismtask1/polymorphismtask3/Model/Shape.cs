using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismtask3.Model
{
    public class Shape
    {
        // Volume with no arguments — default cube with side = 10
        public double Volume()
        {
            double side = 10;
            Console.WriteLine("No arguments passed. Assuming cube with side = 10.");
            return Math.Pow(side, 3);
        }

        // Volume for sphere: V = (4/3) * π * r^3
        public double Volume(string shapeType, double radius)
        {
            if (shapeType.ToLower() == "sphere")
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            }
            else if (shapeType.ToLower() == "cube")
            {
                return Math.Pow(radius, 3); // Here 'radius' is treated as side
            }
            else
            {
                Console.WriteLine("Invalid shape or insufficient data.");
                return -1;
            }
        }

        // Volume for shapes that need radius and height (cylinder, cone)
        public double Volume(string shapeType, double radius, double height)
        {
            switch (shapeType.ToLower())
            {
                case "cylinder":
                    return Math.PI * Math.Pow(radius, 2) * height;

                case "cone":
                    return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;

                default:
                    Console.WriteLine("Invalid shape for radius and height.");
                    return -1;
            }
        }
    }
}
using System.ComponentModel;
using System.Drawing;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
           // Write a C# program to accept a coordinate point in an XY 
           //coordinate system and determine in which quadrant the
           //coordinate point lies.
        {
            Console.Write("Enter the first quadrant:");
            //initilizing variable
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second quadrant:");
            int y=Convert.ToInt32(Console.ReadLine());
            //checking conditions
            if (x >= 0 && y >= 0)
            {
                Console.WriteLine("quadrate lies in first quadrant");
            }
            else if (x >= 0 && y <= 0)
            {
                Console.WriteLine("quadrant  lies in second quadrant");

            }
            else if (x <= 0 && y <= 0)
            {
                Console.WriteLine("quadrant lies in third quadrant");
            }
            else if (x<=0 && y>=0)
            {
                Console.WriteLine("quadrant lies in fourth quadrant");
            }
            else
            {
                Console.WriteLine("something is wrong");

            }


        }
    }
}

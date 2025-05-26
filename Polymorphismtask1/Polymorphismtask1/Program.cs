using Polymorphismtask1.Model;

namespace Polymorphismtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter width (x-coordinate) of the rectangle:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter height (y-coordinate) of the rectangle:");
                int y = Convert.ToInt32(Console.ReadLine());

                // Create rectangle using parameterized constructor
                Rectangle rect = new Rectangle(x, y);

                Console.WriteLine("\nRectangle Details:");
                Console.WriteLine("Width (X): " + rect.GetX());
                Console.WriteLine("Height (Y): " + rect.GetY());
                Console.WriteLine("Area: " + rect.GetArea());
            }
        }
    }


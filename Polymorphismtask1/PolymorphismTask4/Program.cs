using PolymorphismTask4.Model;

namespace PolymorphismTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Take input from user
            Console.Write("Enter feet: ");
            int feet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter inches: ");
            int inches = Convert.ToInt32(Console.ReadLine());

            // Create Height object
            Height height = new Height(feet, inches);

            Console.WriteLine("\nOriginal Height:");
            height.Display();

            // Increment inches by 1 
            height = height + 1;

            Console.WriteLine("\nAfter incrementing inches by 1:");
            height.Display();
        }
    }
}

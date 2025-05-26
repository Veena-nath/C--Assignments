using Polymorphismtask2.Model;

namespace Polymorphismtask2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathOperation math = new MathOperation();

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nResults using polymorphism (method overloading):");
            Console.WriteLine("Add: " + math.Add(num1, num2));
            Console.WriteLine("Subtract: " + math.Subtract(num1, num2));
            Console.WriteLine("Multiply: " + math.Multiply(num1, num2));
            Console.WriteLine("Divide: " + math.Divide(num1, num2));
        }
    }
}

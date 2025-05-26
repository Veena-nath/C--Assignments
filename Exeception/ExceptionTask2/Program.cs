using System;
namespace ExceptionTask2
{
    public class Program
    {
        static void Main(string[] args)
        { 
                Calculator calc = new Calculator();

                try
                {
                    Console.Write("Enter numerator: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.Write("Enter denominator: ");
                    int den = int.Parse(Console.ReadLine());

                    // Attempt division
                    int result = calc.Divide(num, den);
                    Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException ex)
                {
                    // Handle divide-by-zero error
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                catch (ArithmeticException ex)
                {
                    // Handle other arithmetic errors
                    Console.WriteLine($"Arithmetic error: {ex.Message}");
                }
                catch (FormatException)
                {
                    // Handle non-numeric input
                    Console.WriteLine("Error: Please enter valid numbers.");
                }
                catch (Exception ex)
                {
                    // Catch-all for any other errors
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }

            }
    }
}

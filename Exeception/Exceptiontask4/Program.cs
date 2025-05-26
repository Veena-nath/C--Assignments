using System.Security.Cryptography;

namespace Exceptiontask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator rng = new RandomGenerator();

            try
            {
                // Attempt to get a random number
                int result = rng.GetRandomGenerator();
                Console.WriteLine($"Random number (not prime): {result}");
            }
            catch (PrimeException ex)
            {
                // Handle the case where a prime number was generated
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected exceptions
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

        }
    }
}

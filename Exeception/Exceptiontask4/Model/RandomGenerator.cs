using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptiontask4.Model
{
    public class RandomGenerator
    {
     
            private Random random;

            public RandomGenerator()
            {
                random = new Random();
            }

            // Method to check if a number is prime
            private bool IsPrime(int number)
            {
                if (number <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
            }

            // Method to generate a random number and throw exception if it's prime
            public int GetRandomNumber()
            {
                // Generate a random number between 1 and 100
                int num = random.Next(1, 101);

                Console.WriteLine($"Generated Number: {num}");

                if (IsPrime(num))
                {
                    // Throw exception if number is prime
                    throw new PrimeNumberException($"Prime number encountered: {num}");
                }

                return num;
            }
        }
}

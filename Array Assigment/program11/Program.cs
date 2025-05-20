namespace program11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  enter the number of elements
            Console.Write("Enter the number of elements: ");
            int size = int.Parse(Console.ReadLine());

            // Declare array to store the numbers
            int[] numbers = new int[size];

            // Declare 
            int[] frequency = new int[1000];

            // Ask user to input the numbers
            Console.Write("Enter the numbers:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()); // Read each number
                frequency[numbers[i]]++; // Count frequency of each number
            }

            // Display only odd numbers 
            Console.Write("Filtered List (odd and unique):");
            for (int i = 0; i < size; i++)
            {
                int num = numbers[i];

                // Checking 
                if (num % 2 != 0 && frequency[num] == 1)
                {
                    Console.Write(num + " "); // Print the number
                }
            }

        }
    }
}

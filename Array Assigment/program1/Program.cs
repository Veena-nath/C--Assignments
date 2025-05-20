using System.ComponentModel;
using System.Xml.Linq;

namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# to count a total number of 
            //duplicate elements in an array
            // Define an integer array with some duplicate elements
            int[] arr = { 1, 2, 3, 2, 4, 5, 1, 6, 3 };
            bool[] visited = new bool[arr.Length];

            // Variable to count the number of duplicate elements
            int duplicateCount = 0;

            // Loop 
            for (int i = 0; i < arr.Length; i++)
            {
                if (visited[i])
                    continue;

                // Initialize the count
                int count = 1;

                // Compare the current element with the rest of the elements
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        // Increase the count of this element
                        count++;
                    }
                }

                // If the count is more than 1, it's a duplicate
                if (count > 1)
                {
                    duplicateCount++;
                }
            }

            // Display the total number of duplicate elements found
            Console.WriteLine("Total number of duplicate elements: " + duplicateCount);
        }
    }
}

namespace program6
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
                // get input 
                Console.Write("Enter the size of the array (at least 2): ");
                int size = Convert.ToInt32(Console.ReadLine());

                // Check if the a the second smallest
                if (size < 2)
                {
                    Console.WriteLine("Array should have at least 2 elements.");
                    return; // Exit the program
                }

                // Create an array of the specified size
                int[] arr = new int[size];

                Console.WriteLine("Enter the elements:");

                // Read array elements from the user
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Initialize variables 
                int smallest = int.MaxValue;
                int secondSmallest = int.MaxValue;

                // Traverse the array to find the smallest and second smallest values
                for (int i = 0; i < size; i++)
                {
                    // If the current element is smaller than the current smallest
                    if (arr[i] < smallest)
                    {
                        // Update both smallest and second smallest
                        secondSmallest = smallest;
                        smallest = arr[i];
                    }
                    // If the current element is between the smallest and second smallest
                    else if (arr[i] > smallest && arr[i] < secondSmallest)
                    {
                        // Update second smallest only
                        secondSmallest = arr[i];
                    }
                }

                // Check  second smallest value
                if (secondSmallest == int.MaxValue)
                {
                    Console.WriteLine("There is no second smallest element (all elements may be equal).");
                }
                else
                {
                    Console.WriteLine($"The second smallest element is: {secondSmallest}");
                }
            }
        }

    }



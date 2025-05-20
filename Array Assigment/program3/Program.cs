namespace program3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //get input from user
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Count odd and even numbers to create arrays of appropriate size
            int oddCount = 0, evenCount = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            int[] evenArr = new int[evenCount];
            int[] oddArr = new int[oddCount];

            int eIndex = 0, oIndex = 0;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                    evenArr[eIndex++] = arr[i];
                else
                    oddArr[oIndex++] = arr[i];
            }

            Console.WriteLine("\nEven numbers:");
            for (int i = 0; i < evenCount; i++)
                Console.Write(evenArr[i] + " ");

            Console.WriteLine("\nOdd numbers:");
            for (int i = 0; i < oddCount; i++)
                Console.Write(oddArr[i] + " ");
        }
    }
    }


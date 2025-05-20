namespace program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array (at least 2): ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size < 2)
            {
                Console.WriteLine("Array should have at least 2 elements.");
                return;
            }

            int[] arr = new int[size];
            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] > smallest && arr[i] < secondSmallest)
                {
                    secondSmallest = arr[i];
                }
            }

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

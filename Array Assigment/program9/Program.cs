namespace program9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  enter the size of the square matrices
            Console.Write("Enter the size of the square matrices: ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Create three square matrices
            int[,] matrix1 = new int[size, size];
            int[,] matrix2 = new int[size, size];
            int[,] product = new int[size, size];

            // Input  first matrix
            Console.WriteLine("Enter elements of first matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Input second matrix
            Console.WriteLine("Enter elements of second matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Multiply the two matrices
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    product[i, j] = 0; // Initialize the product cell
                    for (int k = 0; k < size; k++)
                    {
                        // Multiply corresponding elements and add to the sum
                        product[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            // Display the result
            Console.WriteLine("\nProduct of the two matrices:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(product[i, j] + "\t"); 
                }
                Console.WriteLine(); // Move to the next line after each row
            }

        }
    }
}

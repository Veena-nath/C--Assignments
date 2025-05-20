namespace program10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enter number of rows
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            //  enter number of columns
            Console.Write("Enter the number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            // Declare two matrices of the same size
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];

            // Input first matrix
            Console.WriteLine("Enter elements of first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Input  second matrix
            Console.WriteLine("Enter elements of second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Assume matrices are equal initially
            bool areEqual = true;

            // Check if  is equal
            for (int i = 0; i < rows && areEqual; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        areEqual = false; // Found a mismatch
                        break; // Exit inner loop
                    }
                }
            }

            // Display result
            if (areEqual)
                Console.WriteLine("The matrices are equal.");
            else
                Console.WriteLine("The matrices are not equal.");

        }
    }
}

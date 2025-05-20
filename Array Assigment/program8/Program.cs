namespace program8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enter number of rows
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            //enter number of columns
            Console.Write("Enter the number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

           
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] sumMatrix = new int[rows, cols];

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

            // Add 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Display the resulting sum matrix
            Console.WriteLine("\nSum of the two matrices:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(sumMatrix[i, j] + "\t");
                }
                Console.WriteLine(); // Move to the next row
            }

        }
    }
}

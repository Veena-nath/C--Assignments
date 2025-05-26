using System;

namespace Exceptiontask3
{
     public class Program
    {
        static void Main(string[] args)
        {
            ArrayHandler arrayHandler = new ArrayHandler();

            try
            {
                // Attempt to access the 11th element (index 10)
                int value = arrayHandler.GetElement(10); // index 10 is out of bounds
                Console.WriteLine($"Value at index 10: {value}");
            }
            catch (IndexOutOfRangeException ex)
            {
                // Handle the error if the index is out of range
                Console.WriteLine("Error: Tried to access an index outside the array bounds.");
            }
            catch (Exception ex)
            {
                // Catch any unexpected exceptions
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}

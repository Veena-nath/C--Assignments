namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n===== Simple Calculator =====");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (choice >= 1 && choice <= 4)
                {
                    Console.Write("Enter first number: ");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Result = {firstNumber + secondNumber}");
                            break;

                        case 2:
                            Console.WriteLine($"Result = {firstNumber - secondNumber}");
                            break;

                        case 3:
                            Console.WriteLine($"Result = {firstNumber * secondNumber}");
                            break;

                        case 4:
                            if (choice != 0)
                                Console.WriteLine($"Result = {firstNumber / secondNumber}");
                            else
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            break;
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Exit ");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose between 1 and 5.");
                }

            } while (choice != 5);

        }
    }
}

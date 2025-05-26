namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get input
            Console.WriteLine("Enter the string");
            string input=Console.ReadLine();
            //reverse the string
            Console.WriteLine("Character in reverse Order");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }

        }
    }
}

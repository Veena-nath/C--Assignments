namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get input 
            Console.Write("Enter the original string:");
            string input=Console.ReadLine();

            Console.WriteLine("Enter the starting index(0 based):");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the length of the string:");
            int length =Convert.ToInt32(Console.ReadLine());

            string  result= "";
            if (start < 0 || start >= input.Length || (start + length) > (input.Length))
            {
                Console.WriteLine("Invalid start index or length");
            }
            for (int i = start; i < length; i++)
            {
                result += input[i];
            }
            Console.WriteLine($"Extract Substring:{result}");


        }
    }
}

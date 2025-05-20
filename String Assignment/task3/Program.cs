namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string input=Console.ReadLine();
            int alphabetCount = 0;
            int digitCount = 0;
            int specialcharCount = 0;
            foreach(char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(ch))
                {
                    digitCount++;
                }
                else if(!char.IsWhiteSpace(ch))
                {
                    specialcharCount++;
                }
                Console.WriteLine($"Total Alphabet:{alphabetCount}");
                Console.WriteLine($"Total Digits:{digitCount}");
                Console.WriteLine($"Total Special character:{specialcharCount}");
            }
        }
    }
}

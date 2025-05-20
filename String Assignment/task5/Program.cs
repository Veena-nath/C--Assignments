namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get input
            Console.Write("Enter the number of strings: ");
            int n = int.Parse(Console.ReadLine());

            string[] words = new string[n];

            Console.WriteLine("Enter the strings:");
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                string word = words[i];

                // Check if string is not empty and starts with 'a' or 'A'
                if (!string.IsNullOrEmpty(word) &&
                    (word[0] == 'a' || word[0] == 'A'))
                {
                    count++;
                }
            }

            Console.WriteLine("Count of strings starting with 'a' or 'A': " + count);
        }
    }
    }


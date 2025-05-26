namespace task1
{
     internal class Bank
  {
    static void Main(string[] args)
     {
        Account account = new Account();

        // Take user input
        account.AddCustomerDetails();

        // Show details
        account.DisplayCustomerDetails();
        account.ShowAccountBalance();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
     }
    }
}

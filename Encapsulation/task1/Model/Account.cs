namespace task1
{
    public class Account
    {

        //Private fields
        private int acNumber;
        private string acHolderName;
        private double acBalance;
        private string acType;
        private double acMinBalance;

        // Public properties
        public int AcNumber
        {
            get { return acNumber; }
            set { acNumber = value; }
        }

        public string AcHolderName
        {
            get { return acHolderName; }
            set { acHolderName = value; }
        }

        public double AcBalance
        {
            get { return acBalance; }
            private set { acBalance = value; }
        }

        public string AcType
        {
            get { return acType; }
            set { acType = value; }
        }

        public double AcMinBalance
        {
            get { return acMinBalance; }
            set { acMinBalance = value; }
        }

        // Method to input customer details from user
        public void AddCustomerDetails()
        {
            Console.Write("Enter Account Number: ");
            AcNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Holder Name: ");
            AcHolderName = Console.ReadLine();

            Console.Write("Enter Account Type (Savings/Current): ");
            AcType = Console.ReadLine();

            Console.Write("Enter Minimum Balance: ");
            AcMinBalance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Initial Balance: ");
            double initialBalance = Convert.ToDouble(Console.ReadLine());

            if (initialBalance >= AcMinBalance)
            {
                AcBalance = initialBalance;
            }
            else
            {
                Console.WriteLine("Initial balance must be greater than or equal to the minimum balance.");
                AcBalance = AcMinBalance; // Default to min balance
            }
        }

        // Method to display customer details
        public void DisplayCustomerDetails()
        {
            Console.WriteLine("\n--- Customer Details ---");
            Console.WriteLine("Account Number: " + AcNumber);
            Console.WriteLine("Account Holder Name: " + AcHolderName);
            Console.WriteLine("Account Type: " + AcType);
            Console.WriteLine("Minimum Balance: $" + AcMinBalance);
        }

        // Method to show account balance
        public void ShowAccountBalance()
        {
            Console.WriteLine("Account Balance: $" + AcBalance);
        }
    }
}
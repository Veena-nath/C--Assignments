
using EncapsulationTask2.Model;

namespace EncapsulationTask2
{
    internal class Program
    {
        static void Main(string[] args)

        { 

                string[] productIds = { "01", "02", "03", "04", "05" };

                Console.WriteLine("==== Available Products ====");
                Console.WriteLine("01 - Mouse");
                Console.WriteLine("02 - Keyboard");
                Console.WriteLine("03 - Monitor");
                Console.WriteLine("04 - Headset");
                Console.WriteLine("05 - Webcam");

                Order order = new Order();

                Console.Write("\nEnter Order ID: ");
                order.OrderId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Order Date (yyyy-mm-dd): ");
                order.OrderDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter Customer ID: ");
                order.CustomerId = Convert.ToInt32(Console.ReadLine());

                while (true)
                {
                    Console.Write("Enter Product ID from the list above: ");
                    string pid = Console.ReadLine();
                    if (Array.Exists(productIds, id => id == pid))
                    {
                        order.ProductId = pid;
                        switch (pid)
                        {
                            case "01": order.ProductName = "Mouse"; break;
                            case "02": order.ProductName = "Keyboard"; break;
                            case "03": order.ProductName = "Monitor"; break;
                            case "04": order.ProductName = "Headset"; break;
                            case "05": order.ProductName = "Webcam"; break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Invalid Product ID. Please choose from the list.");
                    }
                }

                Console.Write("Enter Quantity: ");
                order.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Rate: ");
                order.Rate = Convert.ToDouble(Console.ReadLine());

                order.DisplayOrder();
            }
        }
}
    


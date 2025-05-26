using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask2.Model
{
    internal class Order
    {
        private int orderId;
        private DateTime orderDate;
        private int customerId;
        private string productId;
        private string productName;
        private int quantity;
        private double rate;

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public void DisplayOrder()
        {
            Console.WriteLine("\n===== Order Summary =====");
            Console.WriteLine($"Order ID      : {OrderId}");
            Console.WriteLine($"Order Date    : {OrderDate.ToShortDateString()}");
            Console.WriteLine($"Customer ID   : {CustomerId}");
            Console.WriteLine($"Product ID    : {ProductId}");
            Console.WriteLine($"Product Name  : {ProductName}");
            Console.WriteLine($"Quantity      : {Quantity}");
            Console.WriteLine($"Rate          : {Rate:C}");
            Console.WriteLine($"Total Amount  : {(Quantity * Rate):C}");
        }
    }
}



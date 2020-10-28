using csharp_Exercise03_Orders;
using csharp_Exercise03_Orders.Entities;
using csharp_Exercise03_Orders.Entities.Enum;
using System;
using System.Globalization;

namespace Exercise03_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime brithDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(nameClient, email, brithDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantify: ");
                int quantify = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nameProduct, price);
                OrderItem orderItem = new OrderItem(quantify, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}

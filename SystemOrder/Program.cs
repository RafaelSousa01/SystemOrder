using System.Collections.Generic;
using System;
using SystemOrder.Entities;
using System.Reflection.Metadata.Ecma335;

namespace SystemOrder

{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: "); string name = Console.ReadLine();
            Console.Write("Email: "); string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): "); DateTime dateBirth = DateTime.Parse(Console.ReadLine());
            CLient client = new CLient(name, email, dateBirth);
            Console.WriteLine();
            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine();

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? "); int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product Price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantityProduct,priceProduct,new Product(nameProduct,priceProduct));

                order.OrderItems.Add(orderItem);
                Console.WriteLine();
            }

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine($"Order moment: {order.Moment}");
            Console.WriteLine($"Order Status: {order.Status}");
            Console.WriteLine($"Client: {client}");
            Console.WriteLine("Order Items: ");
            foreach(OrderItem obj in order.OrderItems)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"Total Price: ${order.Total().ToString("F2")}");
        }
    }
}
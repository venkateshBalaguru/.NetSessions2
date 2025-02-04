using OrderDetailsWithOrderItem.Models;
using System;

namespace OrderDetailsWithOrderItem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(1, "Venkat", DateTime.Now);
            order1.AddItem(new OrderItem(1, "Milk", 2, 40));
            order1.AddItem(new OrderItem(2, "Coco", 5, 200));
            order1.AddItem(new OrderItem(3, "Biscuts", 10, 150));

            PrintDetails(order1);
        }



        private static void PrintDetails(Order order)
        {
            Console.WriteLine($"Order ID: {order.OrderId}, Customer Name: {order.CustomerName}, Order Date: {order.OrderDate}");

            Console.WriteLine("Products:");
            foreach (OrderItem item in order.OrderItems)
            {
                Console.WriteLine($"  Product ID: {item.ProductId}, Product Name: {item.ProductName}, Price: {item.Price}, Quantity: {item.Quantity}, Total Price: {item.TotalPrice}");
            }

            Console.WriteLine($"Total Amount: {order.TotalAmount}");
        }
    }
    }
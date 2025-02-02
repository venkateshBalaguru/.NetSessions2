using GenericCollectionApp.Models;

namespace GenericCollectionApp
{
    internal class Program
    {
       static void Main(string[] args)
        {
            List<OrderItem> basket = new List<OrderItem>();
            basket.Add(new OrderItem { Name = "book", Quanity = 5, UnitPrice = 30, Id = 1 });
            basket.Add(new OrderItem { Name = "book", Quanity = 5, UnitPrice = 30, Id = 1 });//Property syntax initialization no constructor
            basket.Add(new OrderItem { UnitPrice = 10, Name = "Pen", Quanity = 5, Id = 2 });
            basket.Add(new OrderItem { Name = "Milk", Quanity = 3, UnitPrice = 35, Id = 3 });
            Console.WriteLine(basket.Count);
            double totalCost = 0;
            foreach (OrderItem item in basket)
            {
                Console.WriteLine(item); // the WriteLine method call the Tostring method we have to override the method.
                totalCost += item.LineItemCost;
            }
            Console.WriteLine("Total payment : " + totalCost);
        }
    }
}
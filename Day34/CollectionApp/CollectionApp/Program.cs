using System.Collections;
using CollectionApp.Models;

namespace CollectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var basket = new ArrayList();  //Here ArrayList is coming form system.collections 

            //This is we normally added the instance of class( OrderItem)
            //var orderItem1 = new OrderItem(1, "Milk", 40, 2);
            //var orderItem2 = new OrderItem(2, "Ragi", 60, 4);
            //var orderItem3 = new OrderItem(3, "Biscuts", 20, 10);
            //var orderItem4 = new OrderItem(4, "Rice", 65, 10);

            basket.Add(new OrderItem(1, "Milk", 40, 2));
            basket.Add(new OrderItem(2, "Ragi", 60, 4));
            basket.Add(new OrderItem(3, "Biscuts", 20, 10));
            basket.Add(new OrderItem(4, "Rice", 65, 10));

            basket.Add("Shalini"); // we can add anything in the basket because its derived from ArrayList we can add string , int ..etc...
            PrintDetails(basket);
        }

        public static void PrintDetails(ArrayList basket)
        {
            double totalAmount = 0;
            foreach (var item in basket)
            {
                OrderItem listItem = (OrderItem)item; //unboxing from Arraylist to orderitem
                //Console.WriteLine(item.Id); //This will get Error because we have to unboxing
                Console.WriteLine($"{listItem.Id}. | Name of Product is {listItem.Name} | No. of Quantity : {listItem.Quantity} | Price per Quantity : Rs.{listItem.Price} || LineItemCost : {listItem.LineItemCost} ");
                totalAmount += listItem.LineItemCost;
            }
            Console.WriteLine("Total Amount you purchased is : " + totalAmount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderDetailsWithOrderItem.Models;

namespace OrderDetailsWithOrderItem.Models
{
    public class OrderItem
    {
        private int _productId;
        private int _quantity;  
        private double _price;
        private string _productName;

        public OrderItem(int productId, string productName, int quantity, int price)
        {
            _price = price;
            _productId = productId;
            _quantity = quantity;
            _productName = productName;
        }

        public int ProductId { get { return _productId; } }
        public string ProductName { get { return _productName; } }

        public int Quantity { get { return _quantity; } }

        public double Price { get { return _price; } }

        public double TotalPrice
        {
            get { return Price * Quantity; }
        }
    }
}
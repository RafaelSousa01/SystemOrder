﻿
namespace SystemOrder.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }    

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity= quantity;
            Price= price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Product.Price.ToString("F2")}, Quantity: {Quantity}, SubTotal: ${SubTotal().ToString("F2")}";
        }

    }
}

using System.Collections.Generic;

namespace SystemOrder.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public CLient CLient { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, CLient client)
        {
            Moment = moment;
            Status = status;
            CLient = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in OrderItems)
            {
                total += item.SubTotal();
            }
    
            return total;
        }

        public override string ToString()
        {
            return $"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}\n Order Status: {Status} \n Client: {CLient.Name} {CLient.BirthDate.ToString("dd/MM/yyyy")} - {CLient.Email}";
        }
    }
}

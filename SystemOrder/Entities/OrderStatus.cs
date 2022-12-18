namespace SystemOrder.Entities
{
    public enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered,
    }
}

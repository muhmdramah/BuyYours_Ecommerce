namespace BuyYours.Domain.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal PriceAtOrder { get; set; }


        // Foreign key for the Order
        public int OrderId { get; set; }

        // Foreign key for the Product
        public int ProductId { get; set; }

        // Navigation property for many-to-one relationship with Order
        public Order Order { get; set; }

        // Navigation property for many-to-one relationship with Product
        public Product Product { get; set; }
    }
}

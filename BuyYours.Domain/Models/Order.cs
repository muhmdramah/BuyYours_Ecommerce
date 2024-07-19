namespace BuyYours.Domain.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } = "Pending";
        public DateTime OrderDate { get; set; }


        // Navigation property for one-to-one relationship with Payment
        public Payment Payment { get; set; }

        // Navigation property for one-to-many relationship with OrderItems
        public ICollection<OrderItem> OrderItems { get; set; }

        // Navigation property for many-to-one relationship with Customer
        public Customer Customer { get; set; }
    }
}

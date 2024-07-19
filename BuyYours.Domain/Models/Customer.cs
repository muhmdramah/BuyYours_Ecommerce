namespace BuyYours.Domain.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public bool IsDeleted { get; set; }


        // Navigation property for one-to-many relationship with Orders
        public ICollection<Order> Orders { get; set; }
    }
}

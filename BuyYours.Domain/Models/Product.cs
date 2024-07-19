namespace BuyYours.Domain.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }


        // Navigation property for many-to-many relationship with OrderItems
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

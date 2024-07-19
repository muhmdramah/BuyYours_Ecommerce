namespace BuyYours.Domain.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } = "Pending";
        public string PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }


        // Foreign key for the Order
        public int OrderId { get; set; }

        // Navigation property for one-to-one relationship with Order
        public Order Order { get; set; }
    }
}

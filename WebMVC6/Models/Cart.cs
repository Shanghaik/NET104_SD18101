namespace WebMVC6.Models
{
    public class Cart
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }
        // Quan hệ với User và CartDetails
        public virtual User User { get; set; }
        public virtual List<CartDetails> Details { get; set; }
    }
}

namespace WebMVC6.Models
{
    public class CartDetails
    {
        public Guid Id { get; set; }
        public Guid UserId  { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        // Quan hệ với Product và Cart
        public virtual Bill Product { get; set; }
        public virtual Cart Cart { get; set; }
    }
}

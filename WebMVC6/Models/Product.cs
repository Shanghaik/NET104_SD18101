namespace WebMVC6.Models
{
    public class Product
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AvailableQuantity { get; set; }
        public string Supplier { get; set; }
        public int Status { get; set; }
        // public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
    }
}

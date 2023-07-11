namespace WebMVC6.Models
{
    public class BillDetails
    {
        public Guid Id { get; set; }
        public Guid BillId { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }
    }
}

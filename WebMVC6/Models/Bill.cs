using Microsoft.AspNetCore.SignalR;

namespace WebMVC6.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid UserId { get; set; }
        public int Status { get; set; }
        // Quan hệ với BillDetails và User
        public virtual IEnumerable<BillDetails> Details { get; set; }
        public virtual User User { get; set; }
    }
}

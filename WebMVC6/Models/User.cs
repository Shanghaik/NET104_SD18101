namespace WebMVC6.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }
        public int Status { get; set; }
        // Thể hiện mối quan hệ với bảng Role
        public virtual Role UserRole { get; set; }
        public virtual List<Bill> Bills { get; set;}
        public virtual Cart Cart { get;set; }
    }
}

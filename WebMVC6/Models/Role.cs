using System.ComponentModel.DataAnnotations;

namespace WebMVC6.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public string? Description { get; set; }
        public Guid? ReportId { get; set; } // Để đệ quy
        public int Status { get; set; }
        // Thể hiện quan hệ với bảng User
        public virtual IEnumerable<User> Users { get; set; }
        public List<Role>? Roles { get; set; }
        // public Role? Rol { get; set; }
    }
}

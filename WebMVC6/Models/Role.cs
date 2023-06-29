using System.ComponentModel.DataAnnotations;

namespace WebMVC6.Models
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string RoleName { get; set; }      
        public string? Description { get; set; }
        public int Status { get; set; }
    }
}

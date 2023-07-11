﻿using System.ComponentModel.DataAnnotations;

namespace WebMVC6.Models
{
    public class Role
    { 
        public Guid Id { get; set; }
        public string RoleName { get; set; }      
        public string? Description { get; set; }
        public int Status { get; set; }
    }
}

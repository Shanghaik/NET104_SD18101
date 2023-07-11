﻿using Microsoft.AspNetCore.SignalR;

namespace WebMVC6.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid UserId { get; set; }
        public int Status { get; set; }
    }
}

﻿namespace Lend.API.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}

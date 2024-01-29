﻿namespace Lend.API.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }        

        public Category? Category { get; set; }

        public string? Image { get; set; }

        public bool? Availability { get; set; }

        public double LendValue { get; set;}

        public double LockValue { get; set; }

        public Guid CustomerId { get; set; }
    }
}

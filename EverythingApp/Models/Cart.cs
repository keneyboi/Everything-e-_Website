using System;
using System.Collections.Generic;

namespace EverythingE.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


        public User? User { get; set; }
        public List<CartItem> Items { get; set; } = new();
    }

    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Cart? Cart { get; set; }
        public Product? Product { get; set; }
    }
}
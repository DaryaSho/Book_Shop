using System;

namespace BookShop.Models
{
    public class Losses
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public string Cause { get; set; }
        public DateTime Data { get; set; }
    }
}

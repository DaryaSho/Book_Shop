using System;

namespace BookShop.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public Seller Seller { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}

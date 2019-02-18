using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public Seller Seller { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}

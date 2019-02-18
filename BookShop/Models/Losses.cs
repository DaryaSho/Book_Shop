using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

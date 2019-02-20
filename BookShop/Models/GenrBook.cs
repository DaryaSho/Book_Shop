using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class GenrBook
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int GenrId { get; set; }
        public Genr Genr { get; set; }
    }
}

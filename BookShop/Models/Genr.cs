
using System.Collections.Generic;

namespace BookShop.Models
{
    public class Genr
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public ICollection<GenrBook> GenrBooks { get; set; }
    }
}

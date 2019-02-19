
using System.Collections.Generic;

namespace BookShop.Models
{ 
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public Image Photo { get; set; }
        public int Price { get; set; }
        public Categor Category { get; set; }
        public List<Genr> Genre { get; set; }
        public Publisher Publisher { get; set; }
    }
}

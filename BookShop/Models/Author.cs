using System;

namespace BookShop.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Info { get; set; }
        public Image Photo { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime? Born { get; set; }
    }
}

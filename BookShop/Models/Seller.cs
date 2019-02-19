
namespace BookShop.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Address { get; set; }
        public Image Photo { get; set; }
    }
}

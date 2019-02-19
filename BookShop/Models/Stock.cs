
namespace BookShop.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;

namespace BookShop.Models
{
    public class ShopContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Categor> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genr> Genrs { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Losses> Losseses { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using BookShop.Models;
using System;
using System.Collections.Generic;

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
        public DbSet<GenrBook> GenrBooks { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenrBook>()
                .HasKey(bc => new { bc.BookId, bc.GenrId });

            modelBuilder.Entity<GenrBook>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.GenrBooks)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<GenrBook>()
                .HasOne(bc => bc.Genr)
                .WithMany(c => c.GenrBooks)
                .HasForeignKey(bc => bc.GenrId);
        }
    }
}

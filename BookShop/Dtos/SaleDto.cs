using System;
using BookShop.Models;

namespace BookShop.Dtos
{
    public class SaleDto
    {
        public int Id { get; set; }
        public SellerDto Seller { get; set; }
        public CustomerDto Customer { get; set; }
        public BookDto Book { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }

    public static class SaleExtensions
    {
        public static Sale ToSale(this SaleDto dto)
        {
            return new Sale()
            {
                Id = dto.Id,
                Book = dto.Book.ToBook(),
                Customer = dto.Customer.ToCustomer(),
                Date = dto.Date,
                Quantity = dto.Quantity,
                Seller = dto.Seller.ToSeller()
            };
        }

        public static SaleDto FroSale(this SaleDto dto, Sale a)
        {
            dto.Id = a.Id;
            dto.Book = a.Book.ToBookDto();
            dto.Customer = a.Customer.ToCustomerDto();
            dto.Date = a.Date;
            dto.Quantity = a.Quantity;
            dto.Seller = a.Seller.ToDto();
            return dto;
        }
    }
}

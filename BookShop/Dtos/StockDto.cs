using System.ComponentModel.DataAnnotations;
using BookShop.Models;

namespace BookShop.Dtos
{
    public class StockDto
    {
        public int Id { get; set; }
        [Required]
        public BookDto Book { get; set; }
        [Required]
        public int Quantity { get; set; }
    }

    public static class StockExtensions
    {
        public static Stock ToStock(this StockDto dto)
        {
            var st = new Stock()
            {
                Id = dto.Id,
                Book = dto.Book.ToBook(),
                Quantity = dto.Quantity
            };
            return st;
        }

        public static StockDto FroStock(this StockDto dto, Stock a)
        {
            dto.Id = a.Id;
            dto.Book = a.Book.ToBookDto();
            dto.Quantity = a.Quantity;
            return dto;
        }
    }
}

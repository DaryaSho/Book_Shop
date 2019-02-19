using System;
using System.ComponentModel.DataAnnotations;
using BookShop.Models;

namespace BookShop.Dtos
{
    public class LossesDto
    {
        public int Id { get; set; }
        [Required]
        public BookDto Book { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Cause { get; set; }
        [Required]
        public DateTime Data { get; set; }
    }

    public static class LossesExtensions
    {
        public static Losses ToLosses(this LossesDto dto)
        {
            var loss = new Losses()
            {
                Id = dto.Id,
                Book = dto.Book.ToBook(),
                Cause = dto.Cause,
                Data = dto.Data,
                Quantity = dto.Quantity
            };
            return loss;
        }

        public static LossesDto FroLosses(this LossesDto dto, Losses a)
        {
            dto.Id = a.Id;
            dto.Book = a.Book.ToBookDto();
            dto.Cause = a.Cause;
            dto.Data = a.Data;
            dto.Quantity = a.Quantity;
            return dto;
        }
    }
}

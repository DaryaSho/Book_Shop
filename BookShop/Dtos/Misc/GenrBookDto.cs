using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;

namespace BookShop.Dtos.Misc
{
    public class GenrBookDto
    {
        public int BookId { get; set; }
        public BookDto Book { get; set; }
        public int GenrId { get; set; }
        public GenrDto Genr { get; set; }
    }
    public static class GenrBookDtoExtensions
    {
        public static GenrBook ToGenrBook(this GenrBookDto dto)
        {
            return new GenrBook()
            {
                Book = dto.Book.ToBook(),
                Genr = dto.Genr.ToGenr()
            };
        }

        public static GenrDto ToGenrDto(this GenrBook a)
        {
            return new GenrDto
            {
                Title = a.Genr.Title,
                Info = a.Genr.Info
            };
        }
        public static GenrBookDto FroGenrBookDto(this GenrBookDto dto, GenrBook a)
        {
            dto.Book = a.Book.ToBookDto();
            dto.Genr = a.Genr.ToGenrDto();

            return dto;
        }
    }
}

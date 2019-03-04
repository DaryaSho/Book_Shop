using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookShop.Const;
using BookShop.Dtos.Misc;
using BookShop.Models;

namespace BookShop.Dtos
{
    public class GenrDto
    {
        public int Id { get; set; }
        [RegularExpression(RegExps.Name)]
        public string Title { get; set; }
        [Required]
        public string Info { get; set; }
      //  [Required]
      //  public ICollection<GenrBookDto> GenrBooks { get; set; }
    }
    public static class GenrDtoExtensions
    {
        public static Genr ToGenr(this GenrDto dto)
        {
            var b =  new Genr()
            {
                Id = dto.Id,
                Title = dto.Title,
                Info = dto.Info,

            };
            //ICollection<GenrBookDto> genre = dto.GenrBooks;
            //b.GenrBooks = new List<GenrBook>();
            //foreach (var p in genre)
            //{
            //    b.GenrBooks.Add(p.ToGenrBook());
            //}
            return b;
        }

        public static GenrDto ToGenrDto(this Genr a)
        {
            var b = new GenrDto
            {
                Id = a.Id,
                Title = a.Title,
                Info = a.Info
            };
            //ICollection<GenrBook> genre = a.GenrBooks;
            //b.GenrBooks = new List<GenrBookDto>();
            //foreach (var p in genre)
            //{
            //    b.GenrBooks.Add(p.ToGenrBookDto());
            //}
            return b;
        }
        public static GenrDto FroGenr(this GenrDto dto, Genr a)
        {
            dto.Id = a.Id;
            dto.Title = a.Title;
            dto.Info = a.Info;
            //foreach (var p in a.GenrBooks)
            //{
            //    dto.GenrBooks.Add(p.ToGenrBookDto());
            //}
            return dto;
        }
    }
}

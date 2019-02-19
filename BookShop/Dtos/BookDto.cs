using BookShop.Models;
using System.ComponentModel.DataAnnotations;
using BookShop.Dtos.Misc;
using System.Collections.Generic;


namespace BookShop.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Info { get; set; }
        [Required]
        public ImageDto Photo { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public CategorDto Category { get; set; }
        [Required]
        public List<GenrDto> Genre { get; set; }
        [Required]
        public PublisherDto Publisher { get; set; }
    }

    public static class BookDtoExtensions
    {
        public static Book ToBook(this BookDto dto)
        {
            var b = new Book()
            {
                Id=dto.Id,
                Title = dto.Title,
                Info = dto.Info,
                Photo = dto.Photo.ToImage(),
                Price = dto.Price,
                Category = dto.Category.ToCategor(),
                Publisher = dto.Publisher.ToPublisc()
            };
            List<GenrDto> genre = dto.Genre;
            b.Genre = new List<Genr>();
            foreach (var p in genre)
            {
                b.Genre.Add(p.ToGenr());
            }
            return b;
        }

        public static BookDto FroBook(this BookDto dto, Book a)
        {
            dto.Id = a.Id;
            dto.Title = a.Title;
            dto.Info = a.Info;
            dto.Photo = a.Photo.ToImageDto();
            dto.Price = a.Price;
            dto.Publisher = a.Publisher.ToPublisherDto();
            dto.Category = a.Category.ToCategorDto();
            foreach (var p in a.Genre)
            {
                dto.Genre.Add(p.ToGenrDto());
            }
            return dto;
        }
        public static BookDto ToBookDto(this Book a)
        {
           var b = new BookDto()
            {

                Id = a.Id,
                Title = a.Title,
                Info = a.Info,
                Photo = a.Photo.ToImageDto(),
                Price = a.Price,
                Publisher = a.Publisher.ToPublisherDto(),
                Category = a.Category.ToCategorDto()
            };
           List<Genr> genre = a.Genre;
            b.Genre = new List<GenrDto>();
            foreach (var p in genre)
            {
                b.Genre.Add(p.ToGenrDto());
            }
            return b;

        }
    }
}

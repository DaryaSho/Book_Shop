using System;
using System.ComponentModel.DataAnnotations;
using BookShop.Const;
using BookShop.Dtos.Misc;
using BookShop.Models;

namespace BookShop.Dtos
{
    public class AuthorDto
    {
        public int Id { get; set; }
        [RegularExpression(RegExps.Name)]
        public string FirstName { get; set; }
        [RegularExpression(RegExps.Name)]
        public string LastName { get; set; }
        [RegularExpression(RegExps.Name)]
        public string MiddleName { get; set; }
        [Required]
        public string Info { get; set; }
        [Required]
        public ImageDto Photo { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public DateTime? Born { get; set; }
    }

    public static class AuthorDtoExtensions
    {
        public static Author ToAuthor(this AuthorDto dto)
        {
            var author = new Author
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                MiddleName = dto.MiddleName,
                Info = dto.Info,
                Photo = dto.Photo.ToImage(),
                Birthday = dto.Birthday,
                Born = dto.Born
            };
            return author;
        }

        public static AuthorDto FroAuthor(this AuthorDto dto, Author a)
        {
            dto.Id = a.Id;
            dto.FirstName = a.FirstName;
            dto.LastName = a.LastName;
            dto.MiddleName = a.MiddleName;
            dto.Info = a.Info;
            dto.Photo = a.Photo.ToImageDto();
            dto.Birthday = a.Birthday;
            dto.Born = a.Born;

            return dto;
        }
    }
}

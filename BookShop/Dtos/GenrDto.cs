using System.ComponentModel.DataAnnotations;
using BookShop.Const;
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
    }
    public static class GenrDtoExtensions
    {
        public static Genr ToGenr(this GenrDto dto)
        {
            return new Genr()
            {
                Id = dto.Id,
                Title = dto.Title,
                Info = dto.Info
            };
        }

        public static GenrDto ToGenrDto(this Genr a)
        {
            return new GenrDto
            {
                Id = a.Id,
                Title = a.Title,
                Info = a.Info
            };
        }
        public static GenrDto FroGenr(this GenrDto dto, Genr a)
        {
            dto.Id = a.Id;
            dto.Title = a.Title;
            dto.Info = a.Info;

            return dto;
        }
    }
}

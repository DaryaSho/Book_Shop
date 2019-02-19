using System.ComponentModel.DataAnnotations;
using BookShop.Const;
using BookShop.Models;

namespace BookShop.Dtos
{
    public class CategorDto
    {
        public int Id { get; set; }
        [RegularExpression(RegExps.Name)] public string Title { get; set; }
        [Required] public string Info { get; set; }
    }

    public static class CategorDtoExtensions
    {
        public static Categor ToCategor(this CategorDto dto)
        {
            var cat = new Categor
            {
                Id = dto.Id,
                Title = dto.Title,
                Info = dto.Info
            };
            return cat;
        }

        public static CategorDto FroCategor(this CategorDto dto, Categor a)
        {
            dto.Id = a.Id;
            dto.Title = a.Title;
            dto.Info = a.Info;

            return dto;
        }

        public static CategorDto ToCategorDto(this Categor a)
        {
            return new CategorDto
            {
                Id = a.Id,
                Title = a.Title,
                Info = a.Info
            };
        }
    }
}
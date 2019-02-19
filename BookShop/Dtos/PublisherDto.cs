using System.ComponentModel.DataAnnotations;
using BookShop.Const;
using BookShop.Models;

namespace BookShop.Dtos
{
    public class PublisherDto
    {
        public int Id { get; set; }
        [RegularExpression(RegExps.Name)]
        public string Title { get; set; }
        [Required]
        public string Info { get; set; }
    }

    public static class PublishDtoExtensions
    {
        public static Publisher ToPublisc(this PublisherDto dto)
        {
            return new Publisher
            {
                Id = dto.Id,
                Title = dto.Title,
                Info = dto.Info
            };
        }

        public static PublisherDto FroPublisc(this PublisherDto dto, Publisher a)
        {
            dto.Id = a.Id;
            dto.Title = a.Title;
            dto.Info = a.Info;

            return dto;
        }

        public static PublisherDto ToPublisherDto(this Publisher a)
        {
            return new PublisherDto
            {
                Id = a.Id,
                Title = a.Title,
                Info = a.Info
            };
        }
    }
}
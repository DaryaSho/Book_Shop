using BookShop.Models;

namespace BookShop.Dtos.Misc
{
    public class ImageDto
    {
        public string Original { get; set; }
        public string Title { get; set; }

    }

    public static class ImageExtensions
    {
        public static Image ToImage(this ImageDto dto)
        {
            return new Image(){Original = dto.Original,Title = dto.Title};
        }

        public static ImageDto ToImageDto(this Image image)
        {
            return new ImageDto() { Original = image.Original, Title = image.Title };
        }
    }
}

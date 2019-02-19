using System.ComponentModel.DataAnnotations;
using BookShop.Const;
using BookShop.Models;
using BookShop.Dtos.Misc;

namespace BookShop.Dtos
{
    public class SellerDto
    {
        public int Id { get; set; }
        [RegularExpression(RegExps.Name)]
        public string FirstName { get; set; }
        [RegularExpression(RegExps.Name)]
        public string LastName { get; set; }
        [RegularExpression(RegExps.Phone)]
        public string Phone { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int Address { get; set; }
        [Required]
        public ImageDto Photo { get; set; }
    }

    public static class SellerDtoExtensions
    {
        public static Seller ToSeller(this SellerDto dto)
        {
            return new Seller()
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Login = dto.Login,
                Password = dto.Password,
                Address = dto.Address,
                Phone = dto.Phone,
                Photo = dto.Photo.ToImage()
            };
        }

        public static SellerDto FroSeller(this SellerDto dto, Seller a)
        {
            dto.Id = a.Id;
            dto.FirstName = a.FirstName;
            dto.LastName = a.LastName;
            dto.Login = a.Login;
            dto.Password = a.Password;
            dto.Address = a.Address;
            dto.Phone = a.Phone;
            dto.Photo = a.Photo.ToImageDto();
            return dto;
        }
        public static SellerDto ToDto(this Seller a)
        {
            return new SellerDto()
            {
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Login = a.Login,
                Password = a.Password,
                Address = a.Address,
                Phone = a.Phone,
                Photo = a.Photo.ToImageDto()
            };
        }
    }
}

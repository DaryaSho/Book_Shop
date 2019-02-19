using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Const;
using BookShop.Models;

namespace BookShop.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [RegularExpression(RegExps.Name)]
        public string FirstName { get; set; }
        [RegularExpression(RegExps.Name)]
        public string LastName { get; set; }
        [RegularExpression(RegExps.Phone)]
        public string Phone { get; set; }
        [RegularExpression(RegExps.Email)]
        public string Email { get; set; }
        [Required]
        public int Discount { get; set; }
    }

    public static class CustomerDtoExtensions
    {
        public static Customer ToCustomer(this CustomerDto dto)
        {
            return new Customer()
            {
                Id =  dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                Email = dto.Email,
                Discount = dto.Discount
            };
        }

        public static CustomerDto FroCustomer(this CustomerDto dto, Customer a)
        {
            dto.Id = a.Id;
            dto.FirstName = a.FirstName;
            dto.LastName = a.LastName;
            dto.Phone = a.Phone;
            dto.Email = a.Email;
            dto.Discount = a.Discount;

            return dto;
        }
        public static CustomerDto ToCustomerDto(this Customer dto)
        {
            return new CustomerDto()
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                Email = dto.Email,
                Discount = dto.Discount
            };
        }
    }
}

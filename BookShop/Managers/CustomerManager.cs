using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Dtos;
using BookShop.Managers.Interfaces;
using BookShop.Models;

namespace BookShop.Managers
{
    public class CustomerManager : IBase<CustomerDto>
    {
        private ShopContext db;
        IImageStorageManager manager;
        public CustomerManager(ShopContext context)
        {
            db = context;
        }

        public IQueryable<CustomerDto> GetAll()
        {
            return db.Customers.Select(x => new CustomerDto().FroCustomer(x));
        }

        public CustomerDto Save(CustomerDto customer)
        {
            var m = db.Customers.Add(customer.ToCustomer());
            db.SaveChanges();
            return new CustomerDto().FroCustomer(m.Entity);
        }

        public CustomerDto Update(CustomerDto customer)
        {
            var m = db.Customers.Update(customer.ToCustomer());
            db.SaveChanges();
            return new CustomerDto().FroCustomer(m.Entity);
        }

        public void Delete(CustomerDto customer)
        {
            var m = db.Customers.Remove(customer.ToCustomer());
            db.SaveChanges();
        }
    }
}

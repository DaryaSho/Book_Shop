using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Dtos;
using BookShop.Managers.Interfaces;
using BookShop.Models;

namespace BookShop.Managers
{
    public class AuthorManager : IBase<AuthorDto>
    {
        private ShopContext db;
        IImageStorageManager manager;
        public AuthorManager(ShopContext context)
        {
            db = context;
        }

        public IQueryable<AuthorDto> GetAll()
        {
            return db.Authors.Select(x => new AuthorDto().FroAuthor(x));
        }

        public AuthorDto Save(AuthorDto author)
        {
            var m = db.Authors.Add(author.ToAuthor());
            db.SaveChanges();
            return new AuthorDto().FroAuthor(m.Entity);
        }

        public AuthorDto Update(AuthorDto author)
        {
            var m = db.Authors.Update(author.ToAuthor());
            db.SaveChanges();
            return new AuthorDto().FroAuthor(m.Entity);
        }

        public void Delete(AuthorDto author)
        {
            var m = db.Authors.Remove(author.ToAuthor());
            db.SaveChanges();
        }
    }
}

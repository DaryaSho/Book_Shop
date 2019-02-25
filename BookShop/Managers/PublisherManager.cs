using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Dtos;
using BookShop.Managers.Interfaces;
using BookShop.Models;

namespace BookShop.Managers
{
    public class PublisherManager : IBase<PublisherDto>
    {
        private ShopContext db;
        IImageStorageManager manager;
        public PublisherManager(ShopContext context)
        {
            db = context;
        }

        public IQueryable<PublisherDto> GetAll()
        {
            return db.Publishers.Select(x => new PublisherDto().FroPublisc(x));
        }

        public PublisherDto Save(PublisherDto publisher)
        {
            var m = db.Publishers.Add(publisher.ToPublisc());
            db.SaveChanges();
            return new PublisherDto().FroPublisc(m.Entity);
        }

        public PublisherDto Update(PublisherDto publisher)
        {
            var m = db.Publishers.Update(publisher.ToPublisc());
            db.SaveChanges();
            return new PublisherDto().FroPublisc(m.Entity);
        }

        public void Delete(PublisherDto publisher)
        {
            var m = db.Publishers.Remove(publisher.ToPublisc());
            db.SaveChanges();
        }
    }
}

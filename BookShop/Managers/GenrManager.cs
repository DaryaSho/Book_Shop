using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Dtos;
using BookShop.Managers.Interfaces;
using BookShop.Models;

namespace BookShop.Managers
{
    public class GenrManager : IBase<GenrDto>
    {
        private ShopContext db;
        IImageStorageManager manager;
        public GenrManager(ShopContext context)
        {
            db = context;
        }

        public IQueryable<GenrDto> GetAll()
        {
            return db.Genrs.Select(x => new GenrDto().FroGenr(x));
        }

        public GenrDto Save(GenrDto genr)
        {
            var m = db.Genrs.Add(genr.ToGenr());
            db.SaveChanges();
            return new GenrDto().FroGenr(m.Entity);
        }

        public GenrDto Update(GenrDto genr)
        {
            var m = db.Genrs.Update(genr.ToGenr());
            db.SaveChanges();
            return new GenrDto().FroGenr(m.Entity);
        }

        public void Delete(GenrDto genr)
        {
            var m = db.Genrs.Remove(genr.ToGenr());
            db.SaveChanges();
        }
    }
}

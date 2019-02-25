using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Dtos;
using BookShop.Managers.Interfaces;
using BookShop.Models;

namespace BookShop.Managers
{
    public class CategorManager : IBase<CategorDto>
    {
        private ShopContext db;
        IImageStorageManager manager;
        public CategorManager(ShopContext context)
        {
            db = context;
        }

        public IQueryable<CategorDto> GetAll()
        {
            return db.Categories.Select(x => new CategorDto().FroCategor(x));
        }

        public CategorDto Save(CategorDto categor)
        {
            var m = db.Categories.Add(categor.ToCategor());
            db.SaveChanges();
            return new CategorDto().FroCategor(m.Entity);
        }

        public CategorDto Update(CategorDto categor)
        {
            var m = db.Categories.Update(categor.ToCategor());
            db.SaveChanges();
            return new CategorDto().FroCategor(m.Entity);
        }

        public void Delete(CategorDto categor)
        {
            var m = db.Categories.Remove(categor.ToCategor());
            db.SaveChanges();
        }
    }
}

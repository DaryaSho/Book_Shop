using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Dtos;
using BookShop.Managers.Interfaces;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Managers
{
    //public class BookManager : BaseManager, IBase<BookDto>
    //{
    //    public BookManager(ShopContext context, IImageStorageManager m) : base(context, m)
    //    {
    //    }

    //    public IQueryable<BookDto> GetAll()
    //    {
    //        return db.Books.Include(a => a.Photo)
    //            .Include(a=>a.Category)
    //            .Include(a=>a.Publisher)
    //            .Include(a=>a.Author)
    //            .Include(a=>a.Genre)

    //            .Select(x => new BookDto().FroBook(x));
    //    }

    //    public BookDto Save(BookDto actor)
    //    {
    //        actor.Photo = manager.MoveToPersistentLocation(actor.Photo);

    //        var entity = actor.ToBook();

    //        MovePhotosToPersistentLocation(entity);

    //        var a = db.Books.Add(entity);
    //        db.SaveChanges();
    //        return new BookDto().FroBook(a.Entity);
    //    }

    //    public BookDto Update(BookDto actor)
    //    {
    //        var newEntity = actor.ToBook();

    //        MovePhotosToPersistentLocation(newEntity);

    //        var prevEntity = db.Books.AsNoTracking().Include(x => x.Photo).Include(x => x.Photos).Where(x => x.Id == newEntity.Id).Single();

    //        RemoveObsoletePhotos(newEntity, prevEntity);

    //        newEntity.Photo = prevEntity.Photo.OverwriteIfNeed(newEntity.Photo, manager);

    //        var a = db.Books.Update(newEntity);
    //        db.SaveChanges();
    //        return new BookDto().FroBook(a.Entity);
    //    }
    //}
}

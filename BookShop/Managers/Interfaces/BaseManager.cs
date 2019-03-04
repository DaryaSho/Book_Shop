using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;

namespace BookShop.Managers.Interfaces
{
    public abstract class BaseManager
    {
        //    protected ShopContext db;
        //    protected IImageStorageManager manager;

        //    public BaseManager(ShopContext context, IImageStorageManager m)
        //    {
        //        db = context;
        //        manager = m;
        //    }
        //    protected void RemoveObsoletePhotos(IPhotoCollection photos, IPhotoCollection prevPhotos)
        //    {
        //        var photoIds = photos.Photos.Select(x => x.Id).ToList();
        //        foreach (var p in prevPhotos.Photos)
        //        {
        //            if (!photoIds.Contains(p.Id))
        //            {
        //                db.Remove(p);
        //                manager.DeleteFileFromPersistentLocation(p.Base64);
        //            }
        //        }
        //    }

        //    protected void MovePhotosToPersistentLocation(IPhotoCollection photos)
        //    {
        //        photos.Photos.MoveToPersistentLocation(manager);
        //    }
        //}
    }
}

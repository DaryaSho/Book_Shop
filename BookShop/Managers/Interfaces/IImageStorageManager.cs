using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Dtos.Misc;
using BookShop.Models;

namespace BookShop.Managers.Interfaces
{
    interface IImageStorageManager
    {
        ImageDto CreateTempFiles(ImageDto dto);
        ImageDto CreateTempFile(string base64);
        ImageDto MoveToPersistentLocation(ImageDto dto);
        string MoveToPersistentLocation(string name);
        Image OverwritePersistentLocation(Image src, Image dst);

    }
}

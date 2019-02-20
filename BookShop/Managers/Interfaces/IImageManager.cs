using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Managers.Interfaces
{
   public interface IImageManager
    {
        ImageDescription ConvertImage(string base64);
    }
}

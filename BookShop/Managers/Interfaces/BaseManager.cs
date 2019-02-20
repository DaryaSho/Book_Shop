using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;

namespace BookShop.Managers.Interfaces
{
    public abstract class BaseManager
    {
        protected ShopContext db;
        protected IImageStorageManager manager;

        public BaseManager(ShopContext context, IImageStorageManager m)
        {
            db = context;
            manager = m;
        }
    }
}

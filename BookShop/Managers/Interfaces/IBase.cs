using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Managers.Interfaces
{
    public interface IBase<T>
    {
        IQueryable<T> GetAll();

        T Save(T member);
        T Update(T member);
      //  void Delete(T member);

    }
}

using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IRepositroy<T> where T: IEntity
    {

        bool Create(T entity);

        bool Delete(T entity);

        bool Update(T entity);

        T GetOne(Predicate<T>filter=null);
        List<T> GetAll(Predicate<T>filter=null);

    }
}

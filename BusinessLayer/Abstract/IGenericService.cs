using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class, new()
    {
        void TAdd(T t);

        void TRemove(T t);

        void TUpdate(T t);

        List<T> GetAll();

        T GetById(int id);

        //List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}

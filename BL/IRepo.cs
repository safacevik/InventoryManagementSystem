using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BL
{
    interface IRepo<T> //generic type
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        T Get(int id);
        T Find(Expression<Func<T, bool>> expression);
        int Add(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}

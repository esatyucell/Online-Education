using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        T GetByFilter(Expression<Func<T , bool>> predicate);

        List<T> GetList();

        T GetById(int id);

        void Create(T entity);

        void Update(T entity);

        void Delete(int id);

        int Count();

        int GetFilteredCount(Expression<Func<T, bool>> predicate);

        List<T> GetFilteredList(Expression<Func<T, bool>> predicate);
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineEdu.Business.Abstract
{
    public interface IGenericService<T>  where T : class
    {
        T TGetByFilter(Expression<Func<T, bool>> predicate);

        List<T> TGetList();

        T TGetById(int id);

        void TCreate(T entity);

        void TUpdate(T entity);

        void TDelete(int id);

        int TCount();

        int TGetFilteredCount(Expression<Func<T, bool>> predicate);

        List<T> TGetFilteredList(Expression<Func<T, bool>> predicate);
    }
}

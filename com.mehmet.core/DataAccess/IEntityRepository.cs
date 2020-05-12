using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using com.mehmet.core.DataAccess.Entity;

namespace com.mehmet.core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new() // T tipi için nesne kısıtı eklenir
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        
        List<string> GetSinyalAboneNo();
       
    }
}
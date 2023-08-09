using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
         T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);                                      //C - Create
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //R - Read
        void Update(T entity);                                   //U - Update
        void Delete(T entity);                                   //D - Delete
    }
}

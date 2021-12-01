using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
 //generic constraint 
 //class : referans tip olabilir demek
 // IEntity : olabilir veya IEntity implemente eden bir nesne olabilir
 //new(): new'lenebilir olmalı 
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        public List<T> GetAll(Expression<Func<T, bool>> filter = null);

        public T Get(Expression<Func<T, bool>> filter); //Read

        public void Add(T entity);  //Create

        public void Update(T entity); //Update

        public void Delete(T entity); //Delete
    

    }
}

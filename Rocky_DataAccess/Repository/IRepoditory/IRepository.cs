﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Rocky_DataAccess.Repository.IRepoditory
{
    public interface IRepository<T> where T : class 
    {
        T Find(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
            string includeProperties = null,
            bool isTracking = true
            );

        T FirstOrDefault(
            Expression<Func<T, bool>> filter = null,          
            string includeProperties = null,
            bool isTracking = true);

        void Add(T entity);

        void Remove(T entity);

        void Save();
    }
}

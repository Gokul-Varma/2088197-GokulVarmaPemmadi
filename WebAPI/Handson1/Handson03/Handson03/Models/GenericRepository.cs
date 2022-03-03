﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Handson03.Models
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly APIContext context;


        public GenericRepository(APIContext context)
        {
            this.context=context;
        }

         public T Add(T item)
        {
            return context.Add(item).Entity;
        }


        public T Update(T item)
        {
            return context.Update(item).Entity;
        }

        public T Delete(T item)
        {
            return context.Remove(item).Entity;
        }

        public IReadOnlyList<T> Get(Expression<Func<T, bool>> condition)
        {
            var Entities=context.Set<T>();
            if (condition != null)
                return Entities.Where(condition).ToList();
            return Entities.ToList();
        }

       public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }


    }
}

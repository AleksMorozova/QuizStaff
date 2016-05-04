﻿using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer.DAL
{
    public class EFRepository<T> : IRepository<T> where T : Entity, new()
    {
        protected QuizDBContext dbContext = new QuizDBContext();

        public virtual void Create(T entity)
        {
            dbContext.Set<T>().Add(entity);
            dbContext.SaveChanges();
        }

        public virtual T Read(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> ReadAll()
        {
            return dbContext.Set<T>();
        }

        public void Remove(int id)
        {
            var ent = Read(id);
            Remove(ent);
            dbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            dbContext.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
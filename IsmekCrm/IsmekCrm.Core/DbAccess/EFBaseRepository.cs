using IsmekCrm.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace IsmekCrm.Core.DbAccess
{
    public class EFBaseRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (var context=new TContext())
            {
                var addedData = context.Entry(entity);
                addedData.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedData = context.Entry(entity);
                deletedData.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public ICollection<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context=new TContext())
            {
                if (filter==null)
                {
                    return context.Set<TEntity>().ToList();
                }
                else
                {
                    return context.Set<TEntity>().Where(filter).ToList();
                }
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedData = context.Entry(entity);
                updatedData.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

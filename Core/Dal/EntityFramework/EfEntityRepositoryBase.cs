using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.Dal.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            try
            {
                using (TContext context = new TContext())
                {
                    var result = context.Entry(entity);
                    result.State = EntityState.Added;
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Delete(TEntity entity)
        {
            try
            {
                using (TContext context = new TContext())
                {
                    var result = context.Entry(entity);
                    result.State = EntityState.Deleted;
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                using (TContext context=new TContext())
                {
                    return context.Set<TEntity>().SingleOrDefault(filter);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            try
            {
                using (TContext context = new TContext())
                {
                    return filter == null
                         ? context.Set<TEntity>().ToList()
                         : context.Set<TEntity>().Where(filter).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
                
            
           
        }

        public void Update(TEntity entity)
        {
            try
            {
                using (TContext context = new TContext())
                {
                    var result = context.Entry(entity);
                    result.State = EntityState.Modified;
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

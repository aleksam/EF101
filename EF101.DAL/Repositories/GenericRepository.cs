using EF101.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF101.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        internal EF101DBContext _dbContext;
        internal DbSet<T> _dbSet;

        public GenericRepository(EF101DBContext ef101DbContext)
        {
            _dbContext = ef101DbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            // Defensive programming
            if (entity == null)
            {
                throw new ArgumentNullException(string.Format("{0} is missing.", nameof(entity)));
            }

            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbSet.Remove(entity);
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            var entitiesQuery = _dbSet.AsQueryable();
            if (predicate != null)
            { entitiesQuery = entitiesQuery.Where(predicate); }
            return entitiesQuery;
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        private object[] GetPrimaryKeys(T entity)
        {
            var keys = (from property in entity.GetType().GetProperties()
                        where Attribute.IsDefined(property, typeof(KeyAttribute))
                        select property.GetValue(entity)).ToArray();
            return keys;
        }
    }
}

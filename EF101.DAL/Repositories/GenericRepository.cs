using EF101.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EF101.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        private readonly EF101DBContext _ef101DbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(EF101DBContext ef101DbContext)
        {
            _ef101DbContext = ef101DbContext;
            _dbSet = _ef101DbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Edit(T entity)
        {
            var entityToUpdate = _dbSet.Find(entity);
            if (entityToUpdate == null)
            {
                return;
            }

            _ef101DbContext.Entry(entityToUpdate).CurrentValues.SetValues(entity);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

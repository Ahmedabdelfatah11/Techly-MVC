using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Techly.BLL.Interfaces;
using Techly.DAL.Context;

namespace Techly.BLL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            this.dbSet = _dbContext.Set<T>();   
        }

        public void Add(T entity)
        {
           dbSet.Add(entity);
        }
        public T Get(Expression<Func<T, bool>> filter)
        {
           IQueryable<T> query = dbSet.AsQueryable();
            query = query.Where(filter);
            return query.FirstOrDefault();
       
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet.AsQueryable();
            return query.ToList();
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }


        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

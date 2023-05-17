using DataAccess.Interface;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MyAppDbContext _db;
        DbSet<T> _dbSet;
        public GenericRepository(MyAppDbContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            var obj = _dbSet.Find(id);
            if (obj != null) { 
                _dbSet.Remove(obj);
                _db.SaveChanges();
            }
        }
            //Delete multiple recode
        public void DeleteInRang(IEnumerable<T> entities)
        {
            foreach (var item in entities)
            {
                _dbSet.Remove(item);
            }
        }

        public T Get(int id)
        {
          
           return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void UpdateInRang(IEnumerable<T> entities)
        {
            _dbSet.UpdateRange(entities);   
        }
    }
}

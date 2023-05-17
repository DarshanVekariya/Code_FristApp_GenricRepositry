using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
        void Delete(int id);
        void Update(T entity);
        void DeleteInRang(IEnumerable<T> entities);
        void UpdateInRang(IEnumerable<T> entities);

    }
}

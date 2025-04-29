using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsADO.DAL
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string stringFind);
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);

    }
}

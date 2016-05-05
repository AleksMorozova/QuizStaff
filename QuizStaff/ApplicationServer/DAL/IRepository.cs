using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServer.DAL
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(int id);
        T Read(int id);
        IEnumerable<T> ReadAll();
    }
}

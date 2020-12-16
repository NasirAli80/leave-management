using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        T FindById(int Id);
        bool Create(T entty);
        bool Update(T entity);
        bool Delete(T entity);

        bool Save();
    }
}

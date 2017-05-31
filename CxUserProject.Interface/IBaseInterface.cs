using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.Interface
{
    public interface IBaseInterface<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T Create(T entity);
        bool Delete(int id);
        bool Update(int id, T entity);
    }
}

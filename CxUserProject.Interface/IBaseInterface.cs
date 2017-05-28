using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.Interface
{
    public interface IBaseInterface<T>
    {
        IList<T> GetAll();
        T GetById(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensitech.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Retrieve();
        bool Save(T product);
    }
}

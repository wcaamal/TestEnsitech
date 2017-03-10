using Ensitech.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensitech.BusinessLogic.Interfaces
{
    public interface IService<T>
    {
        List<T> Get();
        bool Create(T product);
    }
}

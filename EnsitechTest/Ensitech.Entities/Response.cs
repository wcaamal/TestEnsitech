using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensitech.Entities
{
    public class Response<T>
    {
        public T Data { get; set; }
        int Code { get; set; }
        string Message { get; set; }
    }
}

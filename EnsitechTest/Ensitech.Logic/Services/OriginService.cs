using Ensitech.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ensitech.Entities;
using Ensitech.DataAccess.Interfaces;
using Ensitech.DataAccess.Repositories;

namespace Ensitech.BusinessLogic.Services
{
    public class OriginService : IService<string>
    {
        IRepository<string> _originRepository;
        public OriginService()
        {
            _originRepository = new OriginRepository();
        }

        public bool Create(string product)
        {
            throw new NotImplementedException();
        }

        public List<string> Get()
        {
            return _originRepository.Retrieve();
        }
    }
}

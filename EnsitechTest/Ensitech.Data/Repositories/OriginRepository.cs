using Ensitech.DataAccess.Interfaces;
using Ensitech.DataAccess.Tools;
using Ensitech.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ensitech.DataAccess.Repositories
{
    public class OriginRepository : IRepository<string>
    {
        public List<string> Retrieve()
        {
            try
            {
                var service = new CountryService.country();
                service.Url = AppSettingsTools.GetCountryService();
                var countries = service.GetCountries();
                XDocument doc = XDocument.Parse(countries);
                var origins = doc.Root.Elements("Table")
                               .Select(element => element.Value)
                               .ToList();
                return origins;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron obtener los paises de origen. " + ex.Message);
            }
        }

        public bool Save(string product)
        {
            throw new NotImplementedException();
        }
    }
}

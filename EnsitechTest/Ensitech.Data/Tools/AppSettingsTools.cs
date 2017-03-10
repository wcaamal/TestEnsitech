using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensitech.DataAccess.Tools
{
    public static class AppSettingsTools
    {
        public static string GetCountryService()
        {
            //Conexion al servicio web de paises
            string countryService = ConfigurationManager.AppSettings["CountryService"];
            return countryService;
        }
        public static string GetYahooFinanceService()
        {
            //Coneexion al servicio web finanzas de Yahoo 
            string yahooFinanceService = ConfigurationManager.AppSettings["YahooFinanceService"];
            return yahooFinanceService;
        }
        public static string GetFilePath()
        {
            //Ruta del archivo txt
            string filePath = ConfigurationManager.AppSettings["FilePath"];
            return filePath;
        }
    }
}

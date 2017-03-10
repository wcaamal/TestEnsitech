using Ensitech.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ensitech.DataAccess.Repositories
{
    public class CurrencyRepository
    {
        public string[] ChangeCurrency(string s, string f)
        {
            try
            {
                string[] arryResponse = new string[] { };
                using (WebClient client = new WebClient())
                {
                    string _url = AppSettingsTools.GetYahooFinanceService();
                    string url = string.Format(_url + "?s={0}&f={1}&e=.csv", s, f);
                    var response = client.DownloadString(url);
                    arryResponse = response.Split(',');
                }

                return arryResponse;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo obtener el cambio de moneda. " + ex.Message);
            }
        }
    }
}

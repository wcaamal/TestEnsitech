using Ensitech.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Ensitech.DataAccess.Tools
{
    public class TxtTools
    {
        public static List<Product> RetrieveProducts()
        {
            List<Product> products = new List<Product>();
            string pathTxt = AppSettingsTools.GetFilePath();
            if (File.Exists(pathTxt))
            {
                using (StreamReader reader = new StreamReader(pathTxt, true))
                {
                    var serializer = new JavaScriptSerializer();
                    while (reader.Peek() >= 0)
                    {
                        string jProduct = reader.ReadLine();
                        var product = serializer.Deserialize<Product>(jProduct);
                        products.Add(product);
                    }
                    reader.Close();
                }
            }

            return products;
        }

        public static bool SaveProduct(Product product)
        {
            try
            {
                string pathTxt = AppSettingsTools.GetFilePath();
                using (StreamWriter writer = new StreamWriter(pathTxt, true))
                {
                    var serializer = new JavaScriptSerializer();
                    var jProduct = serializer.Serialize(product);
                    writer.WriteLine(jProduct);
                    writer.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar el guardado de informacion. " + ex.Message);
            }
        }
    }
}

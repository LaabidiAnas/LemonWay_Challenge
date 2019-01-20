using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Threading;


namespace LemonWebService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 1; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;

        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string json = JsonConvert.SerializeXmlNode(doc);
            return json;
        }
    }
}
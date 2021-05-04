using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AT9_EX1_Web
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://ChaimaeMazzouz.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public float addition(float nbre1, float nbre2)
        {
            return nbre1 + nbre2;
        }
        [WebMethod]
        public float soustraction(float nbre1, float nbre2)
        {
            return nbre1 - nbre2;
        }
        [WebMethod]
        public float multiplication(float nbre1, float nbre2)
        {
            return nbre1 * nbre2;
        }
        [WebMethod]
        public float division(float nbre1, float nbre2)
        {
            return nbre1 / nbre2;
        }
    }
}

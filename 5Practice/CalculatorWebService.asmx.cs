using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _5Practice
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public float Add(float a, float b)
        {
            return a + b;
        }

        [WebMethod]
        public float Subtract(float a, float b)
        {
            return a - b;
        }


        [WebMethod]
        public float Multiply(float a, float b)
        {
            return a * b;
        }

        [WebMethod]
        public float Divide(float a, float b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Second Value can not be equal zero");
            }
            return a / b;
        }
    }
}

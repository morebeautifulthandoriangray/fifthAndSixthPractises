using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _5Practice
{
    /// <summary>
    /// Summary description for DataBaseWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataBaseWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataSet GetCustomers()
        {
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            SqlConnection connect = new SqlConnection(str);
            SqlDataAdapter myDataAdapter = new SqlDataAdapter("SELECT * FROM Customers", connect);
            DataSet dataSet = new DataSet();
            myDataAdapter.Fill(dataSet, "Customers");
            return dataSet;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataBaseWebApplication
{
    public partial class DataBaseWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetCustomers_Click(object sender, EventArgs e)
        {
            /* 6th practice*/
            DataSet Source;
            Source = (DataSet) Cache["MyCache"];
            if (Source == null)
            {
                DataBaseServiceReference.DataBaseWebServiceSoapClient client =
                    new DataBaseServiceReference.DataBaseWebServiceSoapClient();
                Source = client.GetCustomers();
                Customers.DataSource = Source;
                Cache["MyCache"] = Source;
                Customers.DataBind();
                Result.Text = "Data was taken from table";

            }
            else
            {
                Result.Text = "Data was taken from cache";
            }

            /* 5th practice*/
            
            /*
            DataBaseServiceReference.DataBaseWebServiceSoapClient client =
                new DataBaseServiceReference.DataBaseWebServiceSoapClient();
            Customers.DataSource = client.GetCustomers();
            Customers.DataBind();

            Result.Text = "Data was taken from table";
             
            */

            
            
        }
    }
}
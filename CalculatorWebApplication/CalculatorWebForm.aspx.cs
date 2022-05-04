using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class CalculatorWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            ServiceReference5Practice.CalculatorWebServiceSoapClient client =
                new ServiceReference5Practice.CalculatorWebServiceSoapClient();

            Result.Text = client.Add(Convert.ToSingle(FirstValue.Text), Convert.ToSingle(SecondValue.Text)).ToString();
        }

        protected void Subtract_Click(object sender, EventArgs e)
        {
            ServiceReference5Practice.CalculatorWebServiceSoapClient client =
                new ServiceReference5Practice.CalculatorWebServiceSoapClient();

            Result.Text = client.Subtract(Convert.ToSingle(FirstValue.Text), Convert.ToSingle(SecondValue.Text)).ToString();
        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            ServiceReference5Practice.CalculatorWebServiceSoapClient client =
                new ServiceReference5Practice.CalculatorWebServiceSoapClient();

            Result.Text = client.Multiply(Convert.ToSingle(FirstValue.Text), Convert.ToSingle(SecondValue.Text)).ToString();
        }

        protected void Divide_Click(object sender, EventArgs e)
        {
            ServiceReference5Practice.CalculatorWebServiceSoapClient client =
                new ServiceReference5Practice.CalculatorWebServiceSoapClient();

            Result.Text = client.Divide(Convert.ToSingle(FirstValue.Text), Convert.ToSingle(SecondValue.Text)).ToString();
        }
    }
}
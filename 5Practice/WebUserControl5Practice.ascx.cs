using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5Practice
{
    public partial class WebUserControl5Practice : System.Web.UI.UserControl
    {

        public string MyText
        {
            get { return FirstValue.Text; }
            set { FirstValue.Text = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickButton_Click(object sender, EventArgs e)
        {
            Result.Text = FirstValue.Text + " " + SecondValue.Text;
        }
    }
}
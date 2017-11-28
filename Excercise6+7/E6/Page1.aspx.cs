using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E6
{
    public partial class Page11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str_name = Convert.ToString(Session["name"]);
            Name.Text = str_name;

            string str_email = Convert.ToString(Session["email"]);
            Email.Text = str_email;
        }
    }
}
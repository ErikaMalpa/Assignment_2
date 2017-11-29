using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E6
{
    /// <summary>
    /// Class for Page1
    /// </summary>
    public partial class Page11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strName = Convert.ToString(Session["name"]);
            Name.Text = strName;

            string strEmail = Convert.ToString(Session["email"]);
            Email.Text = strEmail;
        }
    }
}
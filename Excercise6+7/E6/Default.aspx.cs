using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E6
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Pg1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextName.Text;
            Session["email"] = TextEmail.Text;
            Response.Redirect("Page1.aspx");
        }

        protected void Pg2_Click(object sender, EventArgs e)
        {
            string strName = TextName.Text;
            string strEmail = TextEmail.Text;
            Response.Redirect("Page2.aspx?name=" + strName + "&email=" + strEmail);
        }

        protected void Pg3_Click(object sender, EventArgs e)
        {
            Person person = Person.Instance;
            string username = person.Name = TextName.Text;
            string email = person.Email = TextEmail.Text;

            Session["username"] = username;
            Session["email"] = email;
            Response.Redirect("Page3.aspx");
        }
    }
}
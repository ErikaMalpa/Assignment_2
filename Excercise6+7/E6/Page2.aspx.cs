﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E6
{
    /// <summary>
    /// Class for Page 2
    /// </summary>
    public partial class Page2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string strName = Request.QueryString["name"];
            string strEmail = Request.QueryString["email"];

            Name.Text = strName;
            Email.Text = strEmail;

        }
    }
}
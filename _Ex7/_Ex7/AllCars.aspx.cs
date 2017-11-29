using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Ex7
{
    public partial class AllCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new CarsDBEntities();

            var query = (from car in db.CarsTables
                select car).ToList();

            GridAll.DataSource = query;
            GridAll.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Ex7
{
    public partial class Audis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarsDBEntities db = new CarsDBEntities();

            var query = (from car in db.CarsTables
                where car.brand == "Audi"
                select car).ToList();

            GridAudis.DataSource = query;
            GridAudis.DataBind();
        }
    }
}
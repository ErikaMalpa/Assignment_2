using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Ex7
{
    public partial class BlackCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarsDBEntities db = new CarsDBEntities();

            var query = (from car in db.CarsTables
                where car.color == "Black"
                select car).ToList();

            GridBlack.DataSource = query;
            GridBlack.DataBind();
        }
    }
}
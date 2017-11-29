using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Ex7
{
    /// <summary>
    /// Class for black cars
    /// </summary>
    public partial class BlackCars : System.Web.UI.Page
    {
        /// <summary>
        /// Linq for black cars and in the datagrid
        /// it will show only black cars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
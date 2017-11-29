using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Ex7
{
    /// <summary>
    /// Class for all Cars
    /// </summary>
    public partial class AllCars : System.Web.UI.Page
    {
        /// <summary>
        /// LINQ to show all cars in the data grid
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// </summary>
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
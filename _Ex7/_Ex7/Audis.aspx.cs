using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _Ex7
{
    /// <summary>
    /// Class for AUdis
    /// </summary>
    public partial class Audis : System.Web.UI.Page
    {
        /// <summary>
        /// Linq for Audi cars and in the datagrid
        /// it will show only Audi cars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BakeryManager.Pages.DBManagement
{
    public partial class ManageDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grd_Products_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = grd_Products.Rows[e.NewEditIndex];

            //Get Id of selected product
            int rowId = Convert.ToInt32(row.Cells[1].Text);

            //Redirect user to ManageProducts along with the selected rowId
            Response.Redirect("~/Pages/DBManagement/ManageProduct.aspx?id=" + rowId);
        }


    }
}
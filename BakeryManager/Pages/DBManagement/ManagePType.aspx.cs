using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BakeryManager.Models;

namespace BakeryManager.Pages.DBManagement
{
    public partial class ManagePType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_TName_Click(object sender, EventArgs e)
        {
            ProductTypeTypeModel model = new ProductTypeTypeModel();
            ProductType pt = CreateProductType();

            lbl_Result.Text = model.InsertProductType(pt);
        }

        private ProductType CreateProductType()
        {
            ProductType p = new ProductType();
            p.TName = txtbox_TName.Text;

            return p;
        }
    }
}
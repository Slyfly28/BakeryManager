using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BakeryManager.Models;
using Microsoft.AspNet.Identity;

namespace BakeryManager.Pages
{
    public partial class ProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }
       

        protected void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string clientId = Context.User.Identity.GetUserId();

                if (clientId != null)
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    int amount = Convert.ToInt32(ddlAmount.SelectedValue);

                    Cart myCart = new Cart
                    {
                        Amount = amount,
                        ClientId = clientId,
                        DatePurchased = DateTime.Now,
                        IsInCart = true,
                        PId = id
                    };

                    CartModel model = new CartModel();
                    lblResult.Text = model.InsertCart(myCart);
                }
                else
                {
                    lblResult.Text = "Please log in to order items";
                }

               
            }
        }
        private void FillPage()
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ProductModel productModel = new ProductModel();
                Product product = productModel.GetProduct(id);

                //Fill page with data
                lblPrice.Text = "Price per unit: <br/>$ " + product.Price;
                lblTitle.Text = product.PName;
                lblInfo.Text = product.Info;
                lblItemNmbr.Text = id.ToString();
                imgProduct.ImageUrl = "~/Images/MenuProducts/" + product.Image;

                //Fill Amount dropdownList with numbers 1-20
                int[] amount = Enumerable.Range(1, 20).ToArray();
                ddlAmount.DataSource = amount;
                ddlAmount.AppendDataBoundItems = true;
                ddlAmount.DataBind();

            }
        }
    }
}
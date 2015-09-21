using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BakeryManager.Models;

namespace BakeryManager
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {
            //Get a list of all products in DB
            ProductModel productModel = new ProductModel();
            List<Product> products = productModel.GetAllProducts();

            //Check to see if the products exists in the DB
            if (products != null)
            {
                foreach (Product p in products)
                {
                    Panel productPanel = new Panel();
                    ImageButton imageButton = new ImageButton();
                    Label lblName = new Label();
                    Label lblPrice = new Label();

                    //Set child control properties
                    imageButton.ImageUrl = "~/Images/MenuProducts/" + p.Image;
                    imageButton.CssClass = "productImage";
                    imageButton.PostBackUrl = "~/Pages/ProductPage.aspx?id=" + p.Id;

                    lblName.Text = p.PName;
                    lblName.CssClass = "productName";

                    lblPrice.Text = "$ " + p.Price;
                    lblPrice.CssClass = "productPrice";

                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal{Text = "<br />"});
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblPrice);

                    panelProducts.Controls.Add(productPanel);
                }
            }
            else
            {
                panelProducts.Controls.Add(new Literal { Text = "No products found!" });
            }
        }
    }
}
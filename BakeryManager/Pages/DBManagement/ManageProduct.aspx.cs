using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BakeryManager.Models;

namespace BakeryManager.Pages.DBManagement
{
    public partial class ManageProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchImages();

                if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    FillPage(id);
                }
            }
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            ProductModel productModel = new ProductModel();
            Product product = CreateProduct();

            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                lbl_Result.Text = productModel.UpdateProduct(id,product);
            }
            else
            {
                lbl_Result.Text = productModel.InsertProduct(product);
            }

            
        } 

        private void FillPage(int id)
        {
            ProductModel productModel = new ProductModel();
            Product product = productModel.GetProduct(id);

            txtBox_Info.Text = product.Info;
            txtBox_Name.Text = product.PName;
            txtBox_Price.Text = product.Price.ToString();

            ddlImage.SelectedValue = product.Image;
            ddlType.SelectedValue = product.TypeId.ToString();
        }

        private void FetchImages()
        {
            try
            {
                //Get all filepath
                string[] images = Directory.GetFiles(Server.MapPath("~/Images/MenuProducts/"));

                //Get all filenames and add them to an arraylist
                ArrayList imageList = new ArrayList();
                foreach (var image in images )
                {
                    string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    imageList.Add(imageName);
                }

                //set the arrayList as the dropdownview's datasource and refresh
                ddlImage.DataSource = imageList;
                ddlImage.AppendDataBoundItems = true;
                ddlImage.DataBind();
            }
            catch (Exception e)
            {

                lbl_Result.Text = e.Message;
            }
        }

        private Product CreateProduct()
        {
            Product product = new Product
            {
                PName = txtBox_Name.Text, 
                Price = Convert.ToInt32(txtBox_Price.Text),
                TypeId = Convert.ToInt32(ddlType.SelectedValue),
                Info = txtBox_Info.Text,
                Image = ddlImage.SelectedValue
            };

            return product;

        }

       
    }
}
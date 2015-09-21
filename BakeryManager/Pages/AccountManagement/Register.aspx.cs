using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BakeryManager.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace BakeryManager.Pages.AccountManagement
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();
            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["BakeryDBConnectionString"].ConnectionString;

            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

            //Create a new user account and store it in the database
            IdentityUser user = new IdentityUser();
            user.UserName = txtBox_UsrName.Text;

            if (txtBox_Psswrd.Text == txtBox_CPsswrd.Text)
            {
                try
                {
                    //Create user object
                    //Database will be changed / expanded automatically
                    IdentityResult result = manager.Create(user, txtBox_Psswrd.Text);

                    if (result.Succeeded)
                    {

                        UserInfo info = new UserInfo
                        {
                            Address =  txtBox_Address.Text,
                            FirstName = txtBox_FName.Text,
                            LastName = txtBox_LName.Text,
                            PostalCode = Convert.ToInt32(txtBox_PostalCode.Text),
                            GUID = user.Id
                        };

                        UserInfoModel model = new UserInfoModel();
                        model.InsertUserInformation(info);

                        //Store user in DB
                        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                        //Set to log in new user by cookie
                        var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                        //Log in new user and redirect to homepage
                        authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                        Response.Redirect("~/Index.aspx");
                    }
                    else
                    {
                        litStatus.Text = result.Errors.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {

                    litStatus.Text = ex.Message;
                }
            }
            else
            {
                litStatus.Text = "Passwords must match";
            }
        }
    }
}
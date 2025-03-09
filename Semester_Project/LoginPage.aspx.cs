using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;

using System.Web.UI.WebControls;

namespace Semester_Project
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           if(Session["UAccessLevel"] != null)
            {
               lblError.Text = "Already Logged In";
                lblError.ForeColor = System.Drawing.Color.Red;
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
                btnLogin.Enabled = false;
                
            }
        }

        LoginBLL LBLL = new LoginBLL();
        public void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            AppProps.Login LoginUser = new AppProps.Login
            {
                UEmail = email,
                UPassword = password
            };

            DataTable loginResult = LBLL.LoginSearchBLL(LoginUser);
            if (loginResult.Rows.Count > 0)
            {
                // ill  Retrieve UName from the database
                string UName = loginResult.Rows[0]["UName"].ToString();

                //Now  Retrievng LAccessLevel from the database and convertgn it to an integer
                int accessLevel = Convert.ToInt32(loginResult.Rows[0]["UAccessLevel"]);

                int uid= Convert.ToInt32(loginResult.Rows[0]["UID"]);

                // Storingg values in the session hhere:
                Session["UName"] = UName;
                Session["UAccessLevel"] = accessLevel;
                Session["UID"]= uid;


                int accessLevels = accessLevel;
                if (Session["UAccessLevel"] != null)
                {

                    //Session["LName"] = LName;
                    //Session["user"] = accessLevel;

                    switch (accessLevels)
                    {//C:\Users\Dell\Desktop\Semester_Project\Semester_Project\Admin.aspx
                        case 1:
                            Response.Redirect("~/Admin.aspx");
                            break;
                        case 2:
                            //C:\Users\Dell\Tourism Management System\Home.aspx

                            Response.Redirect("~/Home.aspx");

                            break;
                        // Add additional roles as needed
                        default:
                            lblError.Text = "Access level not recognized.";
                            lblError.ForeColor = System.Drawing.Color.Red;
                            break;
                    }
                }
            }

            else
            {
                lblError.Text = "Login Failed.";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
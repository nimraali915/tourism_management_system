using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Semester_Project
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void btnSignUp_Click(object sender, EventArgs e)
        {
            string Uname = txtName.Text;
            string Uemail = txtEmail.Text;
            string Upass = txtPassword.Text;
            string Cpass = txtCPass.Text;
            string Ucontact = txtContact.Text;

            if (Upass == Cpass)
            {
                AppProps.Users newUser = new AppProps.Users
                {

                    UName = Uname,
                    UEmail = Uemail,
                    UPassword = Upass,
                    UContact = Ucontact,
                    UAccessLevel = 2
                };

                UsersBLL userBLL = new UsersBLL();
                bool isInserted = userBLL.UserInsertBLL(newUser);

                if (isInserted)
                {
                    Response.Redirect("~/LoginPage.aspx");
                }
                else
                {
                    lblError.Text = "Error saving data.";
                }
                lblError.Visible = true;
            }
            else
            {
                lblError.Text = "Passwords Mismatched";
                txtPassword.Text = "";
                txtCPass.Text = "";
            }

        }
    }
}

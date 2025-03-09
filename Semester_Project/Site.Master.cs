using System;
using System.Web;
using System.Web.UI;

namespace Semester_Project
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //again that page 
            if (!IsPostBack)
            {
                if (HttpContext.Current.Session["UName"] != null)
                {
                    PlaceholderUser.Visible = true;
                    PlaceholderGuest.Visible = false;
                    lblUsername.Text = HttpContext.Current.Session["UName"].ToString();

                   
                }
                else
                {
                    PlaceholderUser.Visible = false;
                    PlaceholderGuest.Visible = true;
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            HttpContext.Current.Session.Abandon();
            Response.Redirect("Home.aspx");
        }
    }
}

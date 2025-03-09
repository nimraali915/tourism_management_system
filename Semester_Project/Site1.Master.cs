using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Semester_Project
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UName"] == null || Session["UAccessLevel"] == null)
            {
                // Session has expired so weeee ll redirect to login page
                Response.Redirect("~/LoginPage.aspx");
            }
        }
        public void Logout_Click(object sender, EventArgs e)
        {

            Session.Clear();  // Clears all session variables
            Session.Abandon(); //to terminate the session completely
            Response.Redirect("~/LoginPage.aspx");
        }
    }
}
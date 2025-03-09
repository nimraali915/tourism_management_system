using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Semester_Project
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UName"] == null || Session["UAccessLevel"] == null)
            {
                // Session has expired so weeee ll redirect to login page
                Response.Redirect("~/LoginPage.aspx");
            }
        }
       
    }
}
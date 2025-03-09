using AppProps;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Semester_Project
{
    public partial class UService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDestinations();
            }
        }

        private void LoadDestinations()
        {
            ServicesBLL serBll = new ServicesBLL();
            List<Services> services = serBll.ServiceSearchUBLL();

            foreach (var ser in services)
            {
                string imagePath = $"{ser.S_Image}";
                Console.WriteLine($"Image Path: {imagePath}");

                // Create a Bootstrap card dynamically
                HtmlGenericControl card = new HtmlGenericControl("div");
                card.Attributes["class"] = "col-md-4 mb-4";

                card.InnerHtml = $@"
                    <div class='card' style='width: 18rem;'>
                        <img src='{ResolveUrl(imagePath)}' class='card-img-top' alt='Destination Image' style='height: 200px; object-fit: cover;'>
                        <div class='card-body'>
                            <h5 class='card-title'>{ser.S_Name}</h5>
                            <p class='card-text'>{ser.S_Description}</p>
                            <a href='#' class='btn btn-primary'>{ser.S_Price}</a>

                            
                        </div>
                    </div>";

                // Add the card to the container
                CardsContainer.Controls.Add(card);
            }
        }

    }
}
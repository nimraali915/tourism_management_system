using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using AppProps;
using BLL;
using System.Runtime.ConstrainedExecution;

namespace Semester_Project
{
    public partial class UDestination : System.Web.UI.Page
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
            DestinationBLL destinationBLL = new DestinationBLL();
            List<Destination> destinations = destinationBLL.DestinationSearchUBLL();

            foreach (var destination in destinations)
            {
                string imagePath = $"{destination.Dimage}";
                Console.WriteLine($"Image Path: {imagePath}");

                // Create a Bootstrap card dynamically
                HtmlGenericControl card = new HtmlGenericControl("div");
                card.Attributes["class"] = "col-md-4 mb-4";

                card.InnerHtml = $@"
                    <div class='card' style='width: 18rem;'>
                        <img src='{ResolveUrl(imagePath)}' class='card-img-top' alt='Destination Image' style='height: 200px; object-fit: cover;'>
                        <div class='card-body'>
                            <h5 class='card-title'>{destination.Ddame}</h5>
                            <p class='card-text'>{destination.Ddescription}</p>
                           
                            
                        </div>
                    </div>";

                // Add the card to the container
                CardsContainer.Controls.Add(card);
            }
        }
    }
}

using AppProps;
using BLL;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Semester_Project
{
    public partial class Car : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null)
            {
                lblMessage.CssClass = "alert alert-danger";
                lblMessage.Text = "Please Login for Booking";
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session["UID"] != null)
            {
                try
                {
                    // Create a CarBook object
                    CarBook car = new CarBook();

                    // Set the UID from the session
                    car.UID1 = Convert.ToInt32(Session["UID"]);

                    // Assign other properties from form inputs
                    car.CDestinataion1 = ddlDes.SelectedValue;
                    car.CFrom1 = ddlFrom.SelectedValue;

                    if (!DateTime.TryParse(txtDate.Text, out DateTime bookingDate))
                    {
                        lblMessage.CssClass = "alert alert-danger";
                        lblMessage.Text = "Please enter a valid booking date.";
                        lblMessage.Visible = true;
                        return;
                    }
                    car.CDate1 = bookingDate;

                    car.Remarks1 = txtRemarks.Text;

                    // Instantiate BLL and call insertion method
                    CarBLL cBLL = new CarBLL();
                    if (cBLL.CarInsertBLL(car))
                    {
                        lblMessage.CssClass = "alert alert-success";
                        lblMessage.Text = "Your booking is confirmed!";
                        lblMessage.Visible = true;
                        ClearFields();
                    }
                    else
                    {
                        lblMessage.CssClass = "alert alert-danger";
                        lblMessage.Text = "An error occurred while booking.";
                        lblMessage.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.CssClass = "alert alert-danger";
                    lblMessage.Text = $"An error occurred: {ex.Message}";
                    lblMessage.Visible = true;
                }
            }
        }

        private void ClearFields()
        {
            txtDate.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            ddlDes.SelectedIndex = 0;
            ddlFrom.SelectedIndex = 0;
        }
    }
}

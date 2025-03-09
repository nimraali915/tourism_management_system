using AppProps;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Semester_Project
{
    public partial class Room : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null)
            {
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
                    RoomBook rb = new RoomBook();

                    // Retrieve and assign UID from Session
                    if (int.TryParse(Session["UID"].ToString(), out int userId))
                    {
                        rb.UID1 = userId;
                    }
                    else
                    {
                        lblMessage.CssClass = "alert alert-danger";
                        lblMessage.Text = "Invalid user session. Please log in again.";
                        lblMessage.Visible = true;
                        Response.Redirect("LoginPage.aspx");
                        return;
                    }

                    // Assign other properties
                    rb.UhbRoomType = ddlRoomType.SelectedValue;

                    if (!int.TryParse(txtDuration.Text, out int duration))
                    {
                        lblMessage.CssClass = "alert alert-danger";
                        lblMessage.Text = "Please enter a valid duration.";
                        lblMessage.Visible = true;
                        return;
                    }
                    rb.UhbDuration = duration;

                    if (!DateTime.TryParse(txtDate.Text, out DateTime bookingDate))
                    {
                        lblMessage.CssClass = "alert alert-danger";
                        lblMessage.Text = "Please enter a valid date.";
                        lblMessage.Visible = true;
                        return;
                    }
                    rb.UhbDate = bookingDate;

                    rb.UhbRemarks = txtRemarks.Text;

                    int roomPrice = 0;
                    switch (rb.UhbRoomType)
                    {
                        case "Single Room": roomPrice = 6000; break;
                        case "Double Room": roomPrice = 8000; break;
                        case "Family Room": roomPrice = 12000; break;
                        case "Wooden Hut": roomPrice = 8000; break;
                        case "Camps": roomPrice = 7000; break;
                        default:
                            lblMessage.CssClass = "alert alert-danger";
                            lblMessage.Text = "Invalid room type selected.";
                            lblMessage.Visible = true;
                            return;
                    }

                    rb.UhbPrice = roomPrice * rb.UhbDuration;

                    // Call BLL to insert data
                    RoomBLL rbll = new RoomBLL();
                    if (rbll.InsertRoomBLL(rb))
                    {
                        lblMessage.CssClass = "alert alert-success";
                        lblMessage.Text = $"Room booked successfully! Total Price: {rb.UhbPrice} PKR";
                        lblMessage.Visible = true;
                        ClearFields();
                    }
                    else
                    {
                        lblMessage.CssClass = "alert alert-danger";
                        lblMessage.Text = "Failed to book the room.";
                        lblMessage.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.CssClass = "alert alert-danger";
                    lblMessage.Text = $"Error: {ex.Message}";
                    lblMessage.Visible = true;
                }
            }
            else
            {
                lblMessage.Text = "Please Login for Booking";
                Response.Redirect("LoginPage.aspx");
            }
        }





        private void ClearFields()
        {
            ddlRoomType.SelectedIndex = 0;
            txtDuration.Text = "";
            txtDate.Text = "";
            txtRemarks.Text = "";
        }
    }
}
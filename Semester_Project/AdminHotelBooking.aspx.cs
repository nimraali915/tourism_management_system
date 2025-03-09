using AppProps;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Semester_Project
{
    public partial class AdminHotelBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UName"] == null || Session["UAccessLevel"] == null)
            {
                // Session has expired so weeee ll redirect to login page
                Response.Redirect("~/LoginPage.aspx");
            }
            else
            {
                BookingTable.Visible = false;
                CloseBtn.Visible = false;
            }
        }
        
        public void InsertButton_Click(object sender, EventArgs e)
        {
            string Date = UHB_Date.Text;
            string Price = UHB_Price.Text;
            string Duration = UHB_Duration.Text;
            string RoomType = ddlRoomType.Text;
            //int id = Int32.Parse(UHB_ID.Text);
           

            AppProps.HotelBooking NewBooking = new AppProps.HotelBooking
            {
                //  UID = UID,
                UHB_date = Date,
                UHB_price = Price,
                UHB_duration = Duration,
                UHB_room = RoomType,
               // UHB_id = URole
            };

            HotelBookingBLL bookingBLL = new HotelBookingBLL();
            bool isInserted = bookingBLL.HotelBookInsertBLL(NewBooking);

            if (isInserted)
            {
                MessageLabel.Text = "Data saved successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageLabel.Text = "Error saving data.";
            }
            MessageLabel.Visible = true;
        }

        public void ViewAll_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            MessageLabel.Visible = false;
            TableContainer.Visible = true;
            BookingTable.Visible = true;
            FormContainer.Visible = false;
            ButtonContainer.Visible = false;
            CloseBtn.Visible = true;
            HotelBookingBLL BookingBLL = new HotelBookingBLL();

            DataTable dt = BookingBLL.HotelBookSearchAllBLL();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                //DataRow represents a single row of data in a DataTable.
                //Each row contains multiple columns.
                {
                    TableRow row = new TableRow();
                    row.Cells.Add(new TableCell { Text = dataRow["UHB_ID"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["UHB_RoomType"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["UHBDate"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["UHB_Price"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["UHB_Duration"].ToString() });

                    BookingTable.Rows.Add(row);
                }
            }
            else
            {
                Response.Write("No data to show");
            }
        }

        public void closeBtn_click(object sender, EventArgs e)
        {
            TableContainer.Visible = false;
            BookingTable.Visible = false;
            FormContainer.Visible = true;
            ButtonContainer.Visible = true;
            CloseBtn.Visible = false;
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(UHB_ID.Text);

            HotelBookingBLL bookingBLL = new HotelBookingBLL();
            bool isDeleted = bookingBLL.HotelBookDeleteBLL(id);

            if (isDeleted)
            {
                MessageLabel.Text = "Data deleted successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
                UHB_ID.Text = "";
            }
            else
            {
                MessageLabel.Text = "Error deleting data.";
            }
            MessageLabel.Visible = true;
        }

        public void clearButton_Click(Object sender, EventArgs e)
        {
            UHB_Date.Text = "";
            UHB_Price.Text = "";
            UHB_Duration.Text = "";
            ddlRoomType.Text = "";
            UHB_ID.Text = "";
            MessageLabel.Text = "";
            MessageLabel.Visible = false;
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(UHB_ID.Text);
            HotelBookingBLL bookingBLL = new HotelBookingBLL();


            DataTable dt = bookingBLL.HotelBookSearchBLL(id);

            if (dt != null && dt.Rows.Count == 1)
            {
                UHB_Date.Text = dt.Rows[0]["UHBDate"].ToString();
                UHB_Price.Text = dt.Rows[0]["UHB_Price"].ToString();
                UHB_Duration.Text = dt.Rows[0]["UHB_Duration"].ToString();
                // ddlRole.Text = dt.Rows[0]["UAccessLevel"].ToString();

            }
            else if (dt != null && dt.Rows.Count > 0)
            {
                ViewAll_Click(sender, e);
            }
            else
            {
                MessageLabel.Text = "Error searching data or no data found!";
            }
            MessageLabel.Visible = true;

        }

        public void UpdateButton_Click(object obj, EventArgs e)
        {
            string Date = UHB_Date.Text;
            string Price = UHB_Price.Text;
            string Duration = UHB_Duration.Text;
            string RoomType = ddlRoomType.Text;
            int id = Int32.Parse(UHB_ID.Text);


            AppProps.HotelBooking NewBooking = new AppProps.HotelBooking
            {
                //  UID = UID,
                UHB_date = Date,
                UHB_price = Price,
                UHB_duration = Duration,
                UHB_room = RoomType,
                // UHB_id = URole
            };

            HotelBookingBLL bookingBLL = new HotelBookingBLL();
            bool isUpdated = bookingBLL.HotelBookUpdateBLL(id, RoomType, Date, Price, Duration);
            if (isUpdated)
            {
                MessageLabel.Text = "Data updated successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
                UHB_Date.Text = "";
                UHB_Price.Text = "";
                UHB_Duration.Text = "";
                ddlRoomType.Text = "";
                UHB_ID.Text = "";
               
            }
            else
            {
                MessageLabel.Text = "Error updating data.";
            }
            MessageLabel.Visible = true;
        }

    }

    }

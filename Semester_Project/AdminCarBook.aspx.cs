using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Semester_Project
{
    public partial class AdminCarBook : System.Web.UI.Page
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
                CarBookingTable.Visible = false;
                CloseBtn.Visible = false;
            }
        }

      
        public void InsertButton_Click(object sender, EventArgs e)
        {
            string CBDestination = Destination.Text;
            string CBFrom = From.Text;
            string CBDescription = Description.Text;
            string CBDate = Date.Text;

           


            AppProps.CarBooking newCarBooking = new AppProps.CarBooking
            {
                C_Destination = CBDestination,
                C_From = CBFrom,
                C_Date = CBDate,
                C_Description = CBDescription

            };

            CarBookingBLL carBLL = new CarBookingBLL();
            bool isInserted = carBLL.CarBookingInsertBLL(newCarBooking);

            if (isInserted)
            {
                MessageLabel.Text = "Record saved successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageLabel.Text = "Error saving Data.";
            }
            MessageLabel.Visible = true;
        }

        public void ViewAll_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            MessageLabel.Visible = false;
            TableContainer.Visible = true;
            CarBookingTable.Visible = true;
            FormContainer.Visible = false;
            ButtonContainer.Visible = false;
            CloseBtn.Visible = true;
            CarBookingBLL carBLL = new CarBookingBLL();

            DataTable dt = carBLL.CarBookingSearchAllBLL();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                //DataRow represents a single row of data in a DataTable.
                //Each row contains multiple columns.
                {
                    TableRow row = new TableRow();
                    row.Cells.Add(new TableCell { Text = dataRow["CID"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["CDestinataion"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["CFrom"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["CDate"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["CDescription"].ToString() });

                    CarBookingTable.Rows.Add(row);
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
            CarBookingTable.Visible = false;
            FormContainer.Visible = true;
            ButtonContainer.Visible = true;
            CloseBtn.Visible = false;
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(id.Text);

            CarBookingBLL carBLL = new CarBookingBLL();


            bool isDeleted = carBLL.CarBookingDeleteBLL(ID);

            if (isDeleted)
            {
                MessageLabel.Text = "Record deleted successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
                id.Text = "";
            }
            else
            {
                MessageLabel.Text = "Error deleting Record.";
            }
            MessageLabel.Visible = true;
        }

        public void clearButton_Click(Object sender, EventArgs e)
        {
            id.Text = "";
            Destination.Text = "";
            From.Text = "";
            Description.Text = "";
            Date.Text = "";
            MessageLabel.Text = "";
            MessageLabel.Visible = false;
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(id.Text);
            CarBookingBLL carbll = new CarBookingBLL();


            DataTable dt = carbll.CarBookingSearchBLL(ID);

            if (dt != null && dt.Rows.Count == 1)
            {
                
                From.Text = dt.Rows[0]["CFrom"].ToString();
                Date.Text = dt.Rows[0]["CDate"].ToString();
                Destination.Text = dt.Rows[0]["CDestinataion"].ToString();
                Description.Text = dt.Rows[0]["CDescription"].ToString();
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
            string CBDestination = Destination.Text;
            string CBFrom = From.Text;
            string CBDescription = Description.Text;
            string CBDate = Date.Text;
            int ID = Int32.Parse(id.Text);



            AppProps.CarBooking newCarBooking = new AppProps.CarBooking
            {
                C_Destination = CBDestination,
                C_From = CBFrom,
                C_Date = CBDate,
                C_Description = CBDescription

            };

            CarBookingBLL carBLL = new CarBookingBLL();
            bool isUpdated = carBLL.CarBookingUpdateBLL(ID, CBDestination, CBFrom, CBDate, CBDescription);
            if (isUpdated)
            {
                MessageLabel.Text = "Record updated successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
                Destination.Text = "";
                id.Text = "";
                From.Text = "";
                Description.Text = "";
                Date.Text = "";


            }
            else
            {
                MessageLabel.Text = "Error updating data.";
            }
            MessageLabel.Visible = true;
        }

    }
}
using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Semester_Project
{
    public partial class AdminDestinationEdit : System.Web.UI.Page
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
                DestinationTable.Visible = false;
                CloseBtn.Visible = false;
            }
        }
        public void InsertButton_Click(object sender, EventArgs e)
        {
            string Name = DName.Text;

            string DDescription = Description.Text;
            string DImage = "";
            if (ImageUpload.HasFile)
            {
                string fileName = Path.GetFileName(ImageUpload.FileName);
                string filePath = Server.MapPath("~/images/") + fileName;
                ImageUpload.SaveAs(filePath);
                DImage = "~/images/" + fileName; // Store relative file path
            }

            //int id = Int32.Parse(UHB_ID.Text);


            AppProps.Destination NewDestination = new AppProps.Destination
            {
                Ddame = Name,
                Dimage = DImage,
                Ddescription = DDescription

            };

            DestinationBLL desBLL = new DestinationBLL();
            bool isInserted = desBLL.DestinationInsertBLL(NewDestination);

            if (isInserted)
            {
                MessageLabel.Text = "Destination saved successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageLabel.Text = "Error saving Destination Data.";
            }
            MessageLabel.Visible = true;
        }

        public void ViewAll_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            MessageLabel.Visible = false;
            TableContainer.Visible = true;
            DestinationTable.Visible = true;
            FormContainer.Visible = false;
            ButtonContainer.Visible = false;
            CloseBtn.Visible = true;
            DestinationBLL desBLL = new DestinationBLL();

            DataTable dt = desBLL.DestinationSearchAllBLL();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                //DataRow represents a single row of data in a DataTable.
                //Each row contains multiple columns.
                {
                    TableRow row = new TableRow();
                    row.Cells.Add(new TableCell { Text = dataRow["DID"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["DName"].ToString() });

                    // Display the image in the table cell
                    TableCell imageCell = new TableCell();
                    Image img = new Image { ImageUrl = dataRow["DImage"].ToString(), Height = 70, Width = 70 };
                    imageCell.Controls.Add(img);
                    row.Cells.Add(imageCell);
                    row.Cells.Add(new TableCell { Text = dataRow["DDescription"].ToString() });

                    DestinationTable.Rows.Add(row);
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
            DestinationTable.Visible = false;
            FormContainer.Visible = true;
            ButtonContainer.Visible = true;
            CloseBtn.Visible = false;
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(DID.Text);

            DestinationBLL desBLL = new DestinationBLL();

            bool isDeleted = desBLL.DestinationDeleteBLL(id);

            if (isDeleted)
            {
                MessageLabel.Text = "Destination deleted successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
                DID.Text = "";
            }
            else
            {
                MessageLabel.Text = "Error deleting Destination.";
            }
            MessageLabel.Visible = true;
        }

        public void clearButton_Click(Object sender, EventArgs e)
        {
            DID.Text = "";
            DName.Text = "";

            Description.Text = "";
            MessageLabel.Text = "";
            MessageLabel.Visible = false;
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(DID.Text);
            DestinationBLL desBLL = new DestinationBLL();


            DataTable dt = desBLL.DestinationSearchBLL(id);

            if (dt != null && dt.Rows.Count == 1)
            {
                DName.Text = dt.Rows[0]["DName"].ToString();

                Image img = new Image { ImageUrl = dt.Rows[0]["DImage"].ToString(), Height = 70, Width = 70 };

                Description.Text = dt.Rows[0]["DDescription"].ToString();
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
            string Name = DName.Text;

            string DDescription = Description.Text;
            if (int.TryParse(DID.Text, out int id))
            {
                // Handle Image Upload for Update
                string DImage = "";
                if (ImageUpload.HasFile)
                {
                    string fileName = Path.GetFileName(ImageUpload.FileName);
                    string filePath = Server.MapPath("~/images/") + fileName;
                    ImageUpload.SaveAs(filePath);
                    DImage = "~/images/" + fileName; // Store relative file path
                }


                AppProps.Destination NewDestination = new AppProps.Destination
                {
                    Ddame = Name,
                    Dimage = DImage,
                    Ddescription = DDescription

                };

                DestinationBLL desBLL = new DestinationBLL();
                bool isUpdated = desBLL.DestinationUpdateBLL(id, Name, DImage, DDescription);
                if (isUpdated)
                {
                    MessageLabel.Text = "Data updated successfully!";
                    MessageLabel.ForeColor = System.Drawing.Color.Green;
                    DName.Text = "";
                    DID.Text = "";

                    Description.Text = "";


                }
                else
                {
                    MessageLabel.Text = "Error updating data.";
                }
                MessageLabel.Visible = true;
            }

        }
    }
}

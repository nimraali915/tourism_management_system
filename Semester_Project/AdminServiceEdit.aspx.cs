using BLL;
using System;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Semester_Project
{
    public partial class AdminServiceEdit : System.Web.UI.Page
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
                ServicesTable.Visible = false;
                CloseBtn.Visible = false;
            }
        }

        public void InsertButton_Click(object sender, EventArgs e)
        {
            string Name = SName.Text;
            string SPrice = Price.Text;
            string SDescription = Description.Text;

            // Handle Image Upload
            string SImage = "";
            if (ImageUpload.HasFile)
            {
                string fileName = Path.GetFileName(ImageUpload.FileName);
                string filePath = Server.MapPath("~/images/") + fileName;
                ImageUpload.SaveAs(filePath);
                SImage = "~/images/" + fileName; // Store relative file path
            }

            AppProps.Services newService = new AppProps.Services
            {
                S_Name = Name,
                S_Image = SImage,
                S_Price = SPrice,
                S_Description = SDescription,
            };

            ServicesBLL serviceBLL = new ServicesBLL();
            bool isInserted = serviceBLL.ServicesInsertBLL(newService);

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
            ServicesTable.Visible = true;
            FormContainer.Visible = false;
            ButtonContainer.Visible = false;
            CloseBtn.Visible = true;
            ServicesBLL serviceBLL = new ServicesBLL();

            DataTable dt = serviceBLL.ServicesSearchAllBLL();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                {
                    TableRow row = new TableRow();
                    row.Cells.Add(new TableCell { Text = dataRow["SID"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["SName"].ToString() });

                    // Display the image in the table cell
                    TableCell imageCell = new TableCell();
                    Image img = new Image { ImageUrl = dataRow["SImage"].ToString(), Height = 70, Width = 70 };
                    imageCell.Controls.Add(img);
                    row.Cells.Add(imageCell);

                    row.Cells.Add(new TableCell { Text = dataRow["SPrice"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["SDescription"].ToString() });

                    ServicesTable.Rows.Add(row);
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
            ServicesTable.Visible = false;
            FormContainer.Visible = true;
            ButtonContainer.Visible = true;
            CloseBtn.Visible = false;
        }

        public void deleteButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SID.Text, out int id))
            {
                ServicesBLL serviceBLL = new ServicesBLL();

                bool isDeleted = serviceBLL.ServicesDeleteBLL(id);

                if (isDeleted)
                {
                    MessageLabel.Text = "Data deleted successfully!";
                    MessageLabel.ForeColor = System.Drawing.Color.Green;
                    SID.Text = "";
                }
                else
                {
                    MessageLabel.Text = "Error deleting data.";
                }
                MessageLabel.Visible = true;
            }
            else
            {
                MessageLabel.Text = "Please enter a valid ID.";
                MessageLabel.ForeColor = System.Drawing.Color.Red;
                MessageLabel.Visible = true;
            }
        }

        public void clearButton_Click(Object sender, EventArgs e)
        {
            SName.Text = "";
            Price.Text = "";
            Description.Text = "";
            SID.Text = "";
            MessageLabel.Text = "";
            MessageLabel.Visible = false;
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SID.Text, out int id))
            {
                ServicesBLL serviceBLL = new ServicesBLL();

                DataTable dt = serviceBLL.ServicesSearchBLL(id);

                if (dt != null && dt.Rows.Count == 1)
                {
                    SName.Text = dt.Rows[0]["SName"].ToString();
                    Price.Text = dt.Rows[0]["SPrice"].ToString();
                    Description.Text = dt.Rows[0]["SDescription"].ToString();
                    // Set the image path if it's found
                    Image img = new Image { ImageUrl = dt.Rows[0]["SImage"].ToString(), Height = 70, Width = 70 };
                }
                else
                {
                    MessageLabel.Text = "Error searching data or no data found!";
                }
                MessageLabel.Visible = true;
            }
            else
            {
                MessageLabel.Text = "Please enter a valid ID.";
                MessageLabel.ForeColor = System.Drawing.Color.Red;
                MessageLabel.Visible = true;
            }
        }

        public void UpdateButton_Click(object obj, EventArgs e)
        {
            string Name = SName.Text;
            string SPrice = Price.Text;
            string SDescription = Description.Text;
            if (int.TryParse(SID.Text, out int id))
            {
                // Handle Image Upload for Update
                string SImage = "";
                if (ImageUpload.HasFile)
                {
                    string fileName = Path.GetFileName(ImageUpload.FileName);
                    string filePath = Server.MapPath("~/images/") + fileName;
                    ImageUpload.SaveAs(filePath);
                    SImage = "~/images/" + fileName; // Store relative file path
                }
                

                AppProps.Services newService = new AppProps.Services
                {
                    S_Name = Name,
                    S_Image = SImage,
                    S_Price = SPrice,
                    S_Description = SDescription,
                };

                ServicesBLL serviceBLL = new ServicesBLL();
                bool isUpdated = serviceBLL.ServicesUpdateBLL(id, Name, SImage, SPrice, SDescription);

                if (isUpdated)
                {
                    MessageLabel.Text = "Data updated successfully!";
                    MessageLabel.ForeColor = System.Drawing.Color.Green;
                    SName.Text = "";
                    Price.Text = "";
                    Description.Text = "";
                    SID.Text = "";
                }
                else
                {
                    MessageLabel.Text = "Error updating data.";
                }
                MessageLabel.Visible = true;
            }
            else
            {
                MessageLabel.Text = "Please enter a valid ID.";
                MessageLabel.ForeColor = System.Drawing.Color.Red;
                MessageLabel.Visible = true;
            }
        }
    }
}

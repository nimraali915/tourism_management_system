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
    public partial class AdminUserEdit : System.Web.UI.Page
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
                UserTable.Visible = false;
                CloseBtn.Visible = false;
            }
        }

        public void InsertButton_Click(object sender, EventArgs e)
        {
            string Uname = UName.Text;
            string Uemail = UEmail.Text;
            string Upass = UPassword.Text;
            string Ucontact = UContact.Text;
            int URole = Int32.Parse(ddlRole.Text);
           // int UID = Int32.Parse(Uid.Text);

            AppProps.Users newUser = new AppProps.Users
            {
              //  UID = UID,
                UName = Uname,
                UEmail = Uemail,
                UPassword = Upass,
                UContact = Ucontact,
                UAccessLevel = URole
            };

            UsersBLL userBLL = new UsersBLL();
            bool isInserted = userBLL.UserInsertBLL(newUser);

            if (isInserted)
            {
                MessageLabel.Text = "User data saved successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageLabel.Text = "Error saving User data.";
            }
            MessageLabel.Visible = true;
        }

        public void ViewAll_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            MessageLabel.Visible = false;
            TableContainer.Visible = true;
            UserTable.Visible = true;
            FormContainer.Visible = false;
            ButtonContainer.Visible = false;
            CloseBtn.Visible = true;
            UsersBLL userBLL = new UsersBLL();

            DataTable dt = userBLL.UserSearchAllBLL();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dt.Rows)
                //DataRow represents a single row of data in a DataTable.
                //Each row contains multiple columns.
                {
                    TableRow row = new TableRow();
                    row.Cells.Add(new TableCell { Text = dataRow["UID"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["UName"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["UEmail"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["UPassword"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["UContact"].ToString() });
                    row.Cells.Add(new TableCell { Text = dataRow["UAccessLevel"].ToString() });

                    UserTable.Rows.Add(row);
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
            UserTable.Visible = false;
            FormContainer.Visible = true;
            ButtonContainer.Visible = true;
            CloseBtn.Visible = false;
        }

        public void deleteButton_Click(Object sender, EventArgs e)
        {
            string UId = Uid.Text;

            UsersBLL userBLL = new UsersBLL();
            bool isDeleted = userBLL.UserDeleteBLL(UId);

            if (isDeleted)
            {
                MessageLabel.Text = "User data deleted successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
                Uid.Text = "";
            }
            else
            {
                MessageLabel.Text = "Error deleting User data.";
            }
            MessageLabel.Visible = true;

        }

        public void clearButton_Click(object sender, EventArgs e)
        {
            UName.Text = "";
            UEmail.Text = "";
            UPassword.Text = "";
            UContact.Text = "";
            ddlRole.Text = "";
            Uid.Text = "";
            MessageLabel.Text = "";
            MessageLabel.Visible = false;
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            string uID = Uid.Text;

            UsersBLL userBLL = new UsersBLL();

           DataTable dt = userBLL.UserSearchBLL(uID);

            if (dt != null && dt.Rows.Count == 1)
            {
                UName.Text = dt.Rows[0]["UName"].ToString();
                UEmail.Text = dt.Rows[0]["UEmail"].ToString();
                UPassword.Text = dt.Rows[0]["UPassword"].ToString();
               // ddlRole.Text = dt.Rows[0]["UAccessLevel"].ToString();
                UContact.Text = dt.Rows[0]["UContact"].ToString();

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

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            string Uname = UName.Text;
            string Uemail = UEmail.Text;
            string Upass = UPassword.Text;
            string Ucontact = UContact.Text;
            int URole = int.Parse(ddlRole.SelectedValue);
            int UID = Int32.Parse(Uid.Text);

            AppProps.Users newUser = new AppProps.Users
            {
                UID = UID,
                UName = Uname,
                UEmail = Uemail,
                UPassword = Upass,
                UContact = Ucontact,
                UAccessLevel = URole
            };

            UsersBLL userBLL = new UsersBLL();

            bool isUpdated = userBLL.UserUpdateBLL(UID, Uname, Uemail,Upass,Ucontact,URole);
            if (isUpdated)
            {
                MessageLabel.Text = "User data updated successfully!";
                MessageLabel.ForeColor = System.Drawing.Color.Green;
                UName.Text = "";
                UEmail.Text = "";
                UPassword.Text = "";
                UContact.Text = "";
                ddlRole.Text = "";
                Uid.Text = "";
            }
            else
            {
                MessageLabel.Text = "Error updating User data.";
            }
            MessageLabel.Visible = true;
        }
    }
    }

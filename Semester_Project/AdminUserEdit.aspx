<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminUserEdit.aspx.cs" Inherits="Semester_Project.AdminUserEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <style>
        body {
            min-height: 100vh;
            display: flex;
            flex-direction: column;
            margin: 0;
            background-image: url('../images/Usersignup.jpg');
            background-size: cover;
            background-repeat: no-repeat;
            background-position: center;
        }

        .form-container {
            background-color: rgba(255, 255, 255, 0.5); 
        }
     
         </style>
      <div id="form2" runat="server" class="d-flex flex-column align-items-center " style="min-height: calc(100vh - 120px);">
<br /> <h3 class=" text-black align-items-center">User Record</h3> 
   
        <div class="table-container mb-4" runat="server" id="TableContainer">
            <asp:Table runat="server" ID="UserTable" BorderWidth="1" CssClass="table table-striped table-bordered">
                <asp:TableHeaderRow>
                    <asp:TableCell><b>ID</b></asp:TableCell>
                    <asp:TableCell><b>Name</b></asp:TableCell>
                    <asp:TableCell><b>Email</b></asp:TableCell>
                    <asp:TableCell><b>Password</b></asp:TableCell>
                    <asp:TableCell><b>Contact</b></asp:TableCell>
                    <asp:TableCell><b>Access Level</b></asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>

        <asp:Button ID="CloseBtn" runat="server" CssClass="btn btn-success mb-4" OnClick="closeBtn_click" Text="Close" />

        <!-- Form Container -->
        <div class="form-container p-4 rounded shadow" runat="server" id="FormContainer" style="width: 50%;">
            <div class="form-group row mb-3">
                <label for="UName" class="col-sm-4 col-form-label text-end">Name:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="UName" runat="server" CssClass="form-control" Placeholder="Name" style="margin-right: 5px;background-color: rgba(255, 255, 255, 0.5); "></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="UEmail" class="col-sm-4 col-form-label text-end">Email:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="UEmail" runat="server" CssClass="form-control" Placeholder="Email" style="margin-right: 5px;background-color: rgba(255, 255, 255, 0.5); "></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="UPassword" class="col-sm-4 col-form-label text-end">Password:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="UPassword" runat="server" CssClass="form-control" Placeholder="Password" style="margin-right: 5px;background-color: rgba(255, 255, 255, 0.5); "></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="UContact" class="col-sm-4 col-form-label text-end">Contact:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="UContact" runat="server" CssClass="form-control" Placeholder="Contact" style="margin-right: 5px;background-color: rgba(255, 255, 255, 0.5); "></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="ddlRole" class="col-sm-4 col-form-label text-end">Role:</label>
                <div class="col-sm-8">
                    <asp:DropDownList ID="ddlRole" runat="server" CssClass="form-control" style="width: 100%; margin-right: 5px;background-color: rgba(255, 255, 255, 0.5); ">
                        <asp:ListItem Text="Select Role" Value="" />
                        <asp:ListItem Text="Admin" Value="1" />
                        <asp:ListItem Text="User" Value="2" />
                        <asp:ListItem Text="Hotel Manager" Value="3" />
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="Uid" class="col-sm-4 col-form-label text-end">ID:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="Uid" runat="server" CssClass="form-control" Placeholder="ID" style="margin-right: 5px;background-color: rgba(255, 255, 255, 0.5); "></asp:TextBox>
                </div>
            </div>

            <!-- Button Container inside Form -->
            <div class="button-group d-flex justify-content-center mt-4 gap-2" runat="server" id="ButtonContainer" style="margin-bottom: 0px;">
                <asp:Button ID="insertButton" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="InsertButton_Click" />
                <asp:Button ID="ViewAll" runat="server" CssClass="btn btn-secondary" Text="View All" OnClick="ViewAll_Click" />
                <asp:Button ID="deleteButton" runat="server" CssClass="btn btn-danger" Text="Delete" OnClick="deleteButton_Click" />
                <asp:Button ID="clearAll" runat="server" CssClass="btn btn-warning" Text="Clear All" OnClick="clearButton_Click" />
                <asp:Button ID="searchButton" runat="server" CssClass="btn btn-info" Text="Search" OnClick="searchButton_Click" />
                <asp:Button ID="updateButton" runat="server" CssClass="btn btn-success" Text="Update" OnClick="UpdateButton_Click" />
            </div>
        </div>

        <!-- Error Message Label -->
        <div class="text-center mt-4">
            <asp:Label ID="MessageLabel" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        </div>
    </div>

</asp:Content>

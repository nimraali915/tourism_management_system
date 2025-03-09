<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="AdminDestinationEdit.aspx.cs" Inherits="Semester_Project.AdminDestinationEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <div id="form1" runat="server" class="d-flex flex-column align-items-center " style="min-height: calc(100vh - 120px);">
        <br />
        <h3 class=" text-black align-items-center">Destination Record</h3>

        <div class="table-container mb-4" runat="server" id="TableContainer">
            <asp:Table runat="server" ID="DestinationTable" BorderWidth="1" CssClass="table table-striped table-bordered bg-light">
                <asp:TableHeaderRow>
                    <asp:TableCell><b>ID</b></asp:TableCell>
                    <asp:TableCell><b>Name</b></asp:TableCell>
                    <asp:TableCell><b>Image</b></asp:TableCell>
                    <asp:TableCell><b>Description</b></asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>

        <asp:Button ID="CloseBtn" runat="server" CssClass="btn btn-success mb-4" OnClick="closeBtn_click" Text="Close" />

        <!-- Form Container -->
        <div class="form-container p-4 rounded shadow" runat="server" id="FormContainer" style="width: 50%;">
            <div class="form-group row mb-3">
                <label for="DName" class="col-sm-4 col-form-label text-end">Name:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="DName" runat="server" CssClass="form-control" Placeholder="Name" style="margin-right: 5px; background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
    <label for="ImageUpload" class="col-sm-4 col-form-label text-end">Upload Image:</label>
    <div class="col-sm-8">
        <asp:FileUpload ID="ImageUpload" runat="server" CssClass="form-control" style="background-color: rgba(255, 255, 255, 0.5);"/>
    </div>
</div>
           
            <div class="form-group row mb-3">
    <label for="Description" class="col-sm-4 col-form-label text-end">Description:</label>
    <div class="col-sm-8">
        <asp:TextBox ID="Description" runat="server"  CssClass="form-control" Placeholder="Description" style="margin-right: 5px; background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
    </div>
</div>
            <div class="form-group row mb-3">
                <label for="DID" class="col-sm-4 col-form-label text-end">ID:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="DID" runat="server" CssClass="form-control" Placeholder="ID" style="margin-right: 5px; background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
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
     <style>
     body {
         min-height: 100vh;
         display: flex;
         flex-direction: column;
         margin: 0;
         background-image: url('../images/img3.jpg');
         background-size: cover;
         background-repeat: no-repeat;
         background-position: center;
     }

     .form-container {
         background-color: rgba(255, 255, 255, 0.5); 
     }
 </style>
</asp:Content>
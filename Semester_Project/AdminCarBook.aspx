<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminCarBook.aspx.cs" Inherits="Semester_Project.AdminCarBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <style>
        body {
            min-height: 100vh;
         display: flex;
         flex-direction: column;
         margin: 0;
          background-image: url('../images/Admin.jpg'); /* Set your image path here */
background-size: cover; 
background-repeat: no-repeat; 
background-position: center;
   
}
        .form-container {
            background-color: rgba(255, 255, 255, 0.5); /* Adjust the last value (0.5) to set the transparency level */
        }
     
         </style>
     <div class="d-flex flex-column align-items-center " style="min-height: calc(100vh - 120px);">
 <br /> <h3 class=" text-black align-items-center">Car Booking Record</h3> 
    

     <div class="table-container mb-4" runat="server" id="TableContainer">
         <asp:Table runat="server" ID="CarBookingTable" BorderWidth="1" CssClass="table table-striped table-bordered bg-light">
             <asp:TableHeaderRow>
                 <asp:TableCell><b>ID</b></asp:TableCell>
                 <asp:TableCell><b>Destination</b></asp:TableCell>
                 <asp:TableCell><b>From</b></asp:TableCell>
                 <asp:TableCell><b>Date</b></asp:TableCell>
                 <asp:TableCell><b>Description</b></asp:TableCell>
             </asp:TableHeaderRow>
         </asp:Table>
     </div>

     <asp:Button ID="CloseBtn" runat="server" CssClass="btn btn-success mb-4" OnClick="closeBtn_click" Text="Close" />

     <!-- Form Container -->
     <div class="form-container p-4 rounded shadow" runat="server" id="FormContainer" style="width: 50%;">
         <div class="form-group row mb-3">
                <label for="Destination" class="col-sm-4 col-form-label text-end">Destination:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="Destination" runat="server" CssClass="form-control" Placeholder="Destination" style="margin-right: 5px;background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="From" class="col-sm-4 col-form-label text-end">From:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="From" runat="server" CssClass="form-control" Placeholder="From" style="margin-right: 5px; background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="Date" class="col-sm-4 col-form-label text-end">Date:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="Date" runat="server" TextMode="Date" CssClass="form-control" Placeholder="Date" style="margin-right: 5px; background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="Description" class="col-sm-4 col-form-label text-end">Description:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="Description" runat="server" CssClass="form-control" Placeholder="Description" style="margin-right: 5px; background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
                </div>
            </div>
            
            <div class="form-group row mb-3">
                <label for="id" class="col-sm-4 col-form-label text-end">ID:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="id" runat="server" CssClass="form-control" Placeholder="ID" style="margin-right: 5px; background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
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


<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminHotelBooking.aspx.cs" Inherits="Semester_Project.AdminHotelBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
      <div id="form2" runat="server" class="d-flex flex-column align-items-center " style="min-height: calc(100vh - 120px);">
<br /> <h3 class=" text-black align-items-center">Hotel Booking Record</h3> 
   

        <div class="table-container mb-4" runat="server" id="TableContainer">
            <asp:Table runat="server" ID="BookingTable" BorderWidth="1" CssClass="table table-striped table-bordered bg-light">
                <asp:TableHeaderRow>
                    <asp:TableCell><b>ID</b></asp:TableCell>
                    <asp:TableCell><b>Room Type</b></asp:TableCell>
                    <asp:TableCell><b>Date</b></asp:TableCell>
                    <asp:TableCell><b>Price</b></asp:TableCell>
                    <asp:TableCell><b>Duration</b></asp:TableCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>

        <asp:Button ID="CloseBtn" runat="server" CssClass="btn btn-success mb-4" OnClick="closeBtn_click" Text="Close" />

        <!-- Form Container -->
        <div class="form-container p-4 rounded shadow" runat="server" id="FormContainer" style="width: 50%;">
            <div class="form-group row mb-3">
                <label for="UHB_Date" class="col-sm-4 col-form-label text-end">Date:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="UHB_Date" runat="server" TextMode="Date" CssClass="form-control" Placeholder="Date" style="margin-right: 5px;background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="UHB_Price" class="col-sm-4 col-form-label text-end">Price:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="UHB_Price" runat="server" CssClass="form-control" Placeholder="Price" style="margin-right: 5px;background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="UHB_Duration" class="col-sm-4 col-form-label text-end">Duration:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="UHB_Duration" runat="server" CssClass="form-control" Placeholder="Duration" style="margin-right: 5px; background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
                </div>
            
            </div>
            <div class="form-group row mb-3">
                <label for="UHB_Room" class="col-sm-4 col-form-label text-end">Room Type:</label>
                <div class="col-sm-8">
                    <asp:DropDownList ID="ddlRoomType" runat="server" CssClass="form-control" style="width: 100%; margin-right: 5px; background-color: rgba(255, 255, 255, 0.5);">
                        <asp:ListItem Text="Select Role" Value="" />
                        <asp:ListItem Text="Single Room" Value="Single" />
                        <asp:ListItem Text="Double Room" Value="Double" />
                        <asp:ListItem Text="Triple Room" Value="Triple" />
                        <asp:ListItem Text="Standard Room" Value="Standard" />
                        <asp:ListItem Text="Suite" Value="Suite" />
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group row mb-3">
                <label for="UHB_ID" class="col-sm-4 col-form-label text-end">ID:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="UHB_ID" runat="server" CssClass="form-control" Placeholder="ID" style="margin-right: 5px; background-color: rgba(255, 255, 255, 0.5);"></asp:TextBox>
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
        background-image: url('../images/img4.jpg');
        background-size: cover;
        background-repeat: no-repeat;
        background-position: center;
    }

    .form-container {
        background-color: rgba(255, 255, 255, 0.5); 
    }
 
     </style>
</asp:Content>
 
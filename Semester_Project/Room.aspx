<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="Semester_Project.Room" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="container mt-5 d-flex flex-column align-items-center" style="min-height: calc(100vh - 120px);">
        <h3 class="text-black text-center">Room Booking Form</h3><br />
        <div class="form-container">
            <!-- Room Type -->
            <div class="form-group row mb-3">
                <label for="ddlRoomType" class="col-sm-4 col-form-label text-end">Room Type:</label>
                <div class="col-sm-8">
                    <asp:DropDownList ID="ddlRoomType" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Select Room Type" Value="" />
                        <asp:ListItem Text="Single Room" />
                        <asp:ListItem Text="Double Room" />
                        <asp:ListItem Text="Family Room" />
                        <asp:ListItem Text="Camps" />
                        <asp:ListItem Text="Wooden Hut" />
                    </asp:DropDownList>
                </div>
            </div>

            <!-- Booking Date -->
            <div class="form-group row mb-3">
                <label for="txtDate" class="col-sm-4 col-form-label text-end">Booking Date:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" TextMode="Date" placeholder="Enter Booking Date"></asp:TextBox>
                </div>
            </div>

            <!-- Duration -->
            <div class="form-group row mb-3">
                <label for="txtDuration" class="col-sm-4 col-form-label text-end">Duration (Days):</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtDuration" runat="server" CssClass="form-control" TextMode="Number" placeholder="Enter Duration (in days)"></asp:TextBox>
                </div>
            </div>

            <!-- Remarks -->
            <div class="form-group row mb-3">
                <label for="txtRemarks" class="col-sm-4 col-form-label text-end">Remarks:</label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtRemarks" runat="server" CssClass="form-control form-control-lg" TextMode="MultiLine" Rows="3" placeholder="Enter Remarks"></asp:TextBox>
                </div>
            </div>

            <!-- Button Group -->
            <div class="button-group d-flex justify-content-center mt-4 gap-2">
                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-success" Text="Book" OnClick="btnSubmit_Click" />
            </div>

            <!-- Feedback Message -->
            <div class="text-center mt-4">
                <asp:Label ID="lblMessage" runat="server" CssClass="text-center mt-3"></asp:Label>
            </div>

        </div>
        <br />
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
background-position: bottom center;
background-attachment: fixed;
    }

    .form-container {
        background-color: rgba(255, 255, 255, 0.5);
        width: 50%;
        margin: auto;
        padding: 2rem;
        border-radius: 8px;
        box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    }

    .form-label {
        color: #5d4037;
        font-weight: bold;
    }

    .btn {
        margin-right: 10px;
    }
</style>
</asp:Content>

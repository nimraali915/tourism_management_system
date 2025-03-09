<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UService.aspx.cs" Inherits="Semester_Project.UService" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .card-text {
            font-size: 18px; /* Adjust the font size as needed */
        }
    </style>
    <div class="container mt-5">
        <h1 class="text-center mb-4">Services</h1>
        <div class="row" id="CardsContainer" runat="server">
            <!-- Dynamic Content will be loaded here -->
        </div>
    </div>
    <style>
                body {
        min-height: 100vh;
display: flex;
flex-direction: column;
margin: 0;
background-image: url('../images/car.jpg');
background-size: cover;
background-repeat: no-repeat;
background-position: bottom center; /* Aligns the background image to the bottom */
background-attachment: fixed;
    }
        </style>
</asp:Content>

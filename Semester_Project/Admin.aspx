<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Semester_Project.Admin" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         

    <div> 
 <h1 class="welcome-text d-flex justify-content-center align-items-center" style="height: 80vh;">
    <b>HI ADMIN</b>
</h1>
    </div>

             <style>
     body {
         min-height: 100vh;
         display: flex;
         flex-direction: column;
         margin: 0;
         background-image: url('../images/img2.jpg');
         background-size: cover; 
         background-repeat: no-repeat; 
         background-position: center;
     }

     .welcome-text {
    opacity: 0; 
    transform: translateY(-20px); /* Start slightly above its final position */
    animation: fadeIn 2s ease-out forwards; /* Apply the animation */
}

@keyframes fadeIn {
    0% {
        opacity: 0;
        transform: translateY(-20px);
    }
    100% {
        opacity: 1;
        transform: translateY(0);
    }
}
                 </style>
</asp:Content>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Semester_Project.SignUp" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up Now</title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
 <link href="MasterCSS.css" rel="stylesheet" type="text/css" />
 <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
  
</head>
<body>
   <header class="bg-success text-white py-2 d-flex align-items-center px-3 position-relative">
    <a class="navbar-brand d-flex align-items-center position-absolute start-0" href="Home.aspx">
        <img src="images/l.jpg" alt="Logo" style="height: 40px; width: 40px; border-radius: 50%;" class="me-2" />
        <span style="font-size: 0.9rem;">Rama Adventure Club</span>
    </a>
    <h2 class="m-0 text-center w-100">User SignUp</h2>
</header>


 <form id="form1" runat="server">
     <div class="form-container">

         <div class="form-group row mb-3">
    <label for="txtName" class="col-sm-4 col-form-label text-end">Name:</label>
    <div class="col-sm-8">
        <asp:TextBox ID="txtName" runat="server" CssClass="form-control" style="background-color: rgba(248, 249, 250, 0.8);"  Placeholder="Enter Name"></asp:TextBox>
    </div>
</div>

                  <div class="form-group row mb-3">
    <label for="txtContact" class="col-sm-4 col-form-label text-end">Contact no:</label>
    <div class="col-sm-8">
        <asp:TextBox ID="txtContact" runat="server" CssClass="form-control" style=" background-color: rgba(248, 249, 250, 0.8);" Placeholder="Enter Contact No"></asp:TextBox>
    </div>
</div>

         <div class="form-group row mb-3">
             <label for="txtEmail" class="col-sm-4 col-form-label text-end">Email:</label>
             <div class="col-sm-8">
                 <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" style=" background-color: rgba(248, 249, 250, 0.8);" Placeholder="Enter Email"></asp:TextBox>
             </div>
         </div>

         <div class="form-group row mb-3">
             <label for="txtPassword" class="col-sm-4 col-form-label text-end">Password:</label>
             <div class="col-sm-8">
                 <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" style=" background-color: rgba(248, 249, 250, 0.8);" Placeholder="Enter Password"></asp:TextBox>
             </div>
         </div>

          <div class="form-group row mb-3">
     <label for="txtCPass" class="col-sm-4 col-form-label text-end">Confirm Password:</label>
     <div class="col-sm-8">
         <asp:TextBox ID="txtCPass" runat="server" TextMode="Password" CssClass="form-control" style=" background-color: rgba(248, 249, 250, 0.8);" Placeholder="Re-enter Password"></asp:TextBox>
     </div>
 </div>

         <div class="form-group text-center mt-3">
             <asp:Button ID="btnSignup" runat="server" Text="SignUp" CssClass="btn btn-success w-50" OnClick="btnSignUp_Click" />
         </div>

         <div class="text-center mt-3">
             <asp:Label runat="server">Already have Account? <a href="LoginPage.aspx" >Login Now</a></asp:Label>
         </div>

         <div class="text-center mt-3">
             <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
         </div>
     </div>
 </form>

 <footer class="bg-success text-white text-center py-2">
     <p>&copy; 2024 My Website. All Rights Reserved.</p>
 </footer>
</body>
      <style>
      body {
          min-height: 100vh;
          display: flex;
          flex-direction: column;
          margin: 0;
          background-image: url('../images/formImg2.jpg');
          background-size: cover;
          background-repeat: no-repeat;
          background-position: center;
      }

    form {
        flex: 1;
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .form-container {
        width: 100%;
 max-width: 500px;
 background-color: rgba(248, 249, 250, 0.8);
 padding: 20px;
 border-radius: 10px;
 box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    }

    footer {
        position: fixed;
        width: 100%;
        bottom: 0;
    }
</style>
</html>

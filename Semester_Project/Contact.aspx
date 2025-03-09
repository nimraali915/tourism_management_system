<%@ Page Language="C#"MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Semester_Project.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* Page Styling */
        body {
            background-color: #f8f9fa; /* Light background */
            margin: 0;
            font-family: Arial, sans-serif;
        }

        /* Header Styling */
        h1.display-3 {
            font-weight: bold;
            text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.2);
        }

        /* Card Styling */
        .card {
            border: 2px solid #28a745; /* Green border */
            border-radius: 12px;
            transition: transform 0.3s ease, box-shadow 0.3s ease;
            overflow: hidden;
        }

        .card img {
            object-fit: cover;
            height: 250px;
        }

        .card:hover {
            transform: translateY(-10px);
            box-shadow: 0 8px 16px rgba(0, 0, 0, 0.3);
        }

        .card-title {
            margin-bottom: 0.5rem;
        }

        /* Link Hover Effects */
        a {
            color: #28a745;
            text-decoration: none;
            transition: color 0.3s ease;
        }

        a:hover {
            color: #1e7e34; /* Darker green */
            text-decoration: underline;
        }

        /* Buttons Styling */
        .btn-green {
            background-color: #28a745;
            color: #fff;
            border: none;
            transition: background-color 0.3s ease;
        }

        .btn-green:hover {
            background-color: #218838;
        }

        /* Spacing Adjustments */
        .container {
            padding-bottom: 3rem;
        }

        .contact-heading {
            font-size: 2rem;
            font-weight: bold;
            color: #28a745;
        }
    </style>

    <div class="container mt-5">
        <!-- Contact Information Heading -->
        <div class="text-center mb-5">
            <h1 class="display-3 text-success">Contact Us</h1>
            <p class="lead text-muted" style="font-size: 1.25rem;">Get in touch with us for more information or inquiries.</p>
        </div>
            <!-- Basic Contact Information -->
<div class="row mb-5 text-center">
    <div class="col-6">
        <h3 class="contact-heading">Our Contact Information</h3>
        <p class="lead text-muted">Email: <a href="mailto:info@ramaadventure.com">info@ramaadventure.com</a></p>
        <p class="lead text-muted">Phone: +92 300 1234567</p>
        <p class="lead text-muted">Telephone: 4447192</p>
        <p class="lead text-muted">Address: Planet Earth</p>
        <p class="lead text-muted">Team Members:</p>
        <p class="lead text-muted">Ashna Wasif</p>
        <p class="lead text-muted">Nimra Ali</p>




    </div>
    <div class="col-6">
        <img src="images/contact.jpg" class="img-fluid" alt="Contact Image">
    </div>
</div>

        

       
        <!-- Team Member Contact Information -->
        <div class="row mb-5">
            <div class="col-12 text-center">
                <h3 class="contact-heading mb-4">Meet Our Team </h3>
            </div>

            <!-- Team Member 1 -->
            <div class="col-md-4 mb-4">
                <div class="card shadow-sm">
                    <img src="images/julan.png" class="card-img-top" alt="Julan">
                    <div class="card-body text-center">
                        <h5 class="card-title text-success">JULAN</h5>
                        <p class="card-text">Founder and CEO</p>
                        <p>Phone: +92 300 7654321</p>
                        <p>Email: <a href="mailto:julan@ramaadventure.com">julan@ramaadventure.com</a></p>
                        <button class="btn btn-green">Contact</button>
                    </div>
                </div>
            </div>

            <!-- Team Member 2 -->
            <div class="col-md-4 mb-4">
                <div class="card shadow-sm">
                    <img src="images/Andy.jpeg" class="card-img-top" alt="Andy">
                    <div class="card-body text-center">
                        <h5 class="card-title text-success">ANDY</h5>
                        <p class="card-text">Operations Manager</p>
                        <p>Phone: +92 300 9876543</p>
                        <p>Email: <a href="mailto:andy@ramaadventure.com">andy@ramaadventure.com</a></p>
                        <button class="btn btn-green">Contact</button>
                    </div>
                </div>
            </div>

            <!-- Team Member 3 -->
            <div class="col-md-4 mb-4">
                <div class="card shadow-sm">
                    <img src="images/johanas.jpg" class="card-img-top" alt="Johnson">
                    <div class="card-body text-center">
                        <h5 class="card-title text-success">JOHNSON</h5>
                        <p class="card-text">Activity Coordinator</p>
                        <p>Phone: +92 300 5432109</p>
                        <p>Email: <a href="mailto:johnson@ramaadventure.com">johnson@ramaadventure.com</a></p>
                        <button class="btn btn-green">Contact</button>
                    </div>
                </div>
            </div>

        </div>
    </div>
   


    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>

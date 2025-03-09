<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="Semester_Project.AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
  <div class="img-center mb-5">
    <img src="images/AboutUs.jpg" class="img-fluid full-width-img" alt="Gilgit Baltistan">
</div>
    <div class="container mt-5">
        <!-- About Us Heading -->
        <div class="text-center mb-5">
            <h1 class=" text-success">Overview - Rama Adventure Club Astore</h1>
            <p class="lead text-muted">Located at Astore Rama Meadows near PWD Rest House, on the way to Rama, we offer thrilling adventure activities in a serene natural setting.</p>
        </div>

        <!-- Top Services Section -->
        <div class="row text-center mb-5">
            <h2 class="col-12 mb-4 text-success">Top Services</h2>
            <div class="col-md-4">
                <div class="card shadow-sm border-success">
                    <div class="card-body">
                        <h5 class="card-title text-success"><i class="bi bi-zipline"></i> Rama Zipline</h5>
                        <p class="card-text">Enjoy a thrilling zipline experience over breathtaking landscapes.</p>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card shadow-sm border-success">
                    <div class="card-body">
                        <h5 class="card-title text-success"><i class="bi bi-boat"></i> Boating</h5>
                        <p class="card-text">Relax and explore the waters with our fun-filled boating experience.</p>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card shadow-sm border-success">
                    <div class="card-body">
                        <h5 class="card-title text-success"><i class="bi bi-horse"></i> Horse Riding</h5>
                        <p class="card-text">Saddle up and ride through the scenic trails of Astore Meadows.</p>
                    </div>
                </div>
            </div>
        </div>

        <!-- Charges for Our Services -->
       <div class="row mb-5">
    <div class="col-12 text-center">
        <h3 class="text-success mb-4" style="font-size: 2rem; font-weight: bold;">Our Charges</h3>
        <ul class="list-unstyled" style="font-size: 1.2rem;">
            <li><strong style="color: #28a745;">Camping:</strong> <span style="color: #6c757d;">6000 per night</span></li>
            <li><strong style="color: #28a745;">Normal Room:</strong> <span style="color: #6c757d;">5000 per night</span></li>
            <li><strong style="color: #28a745;">Luxury Room:</strong> <span style="color: #6c757d;">25000 per night</span></li>
            <li><strong style="color: #28a745;">Zipline:</strong> <span style="color: #6c757d;">3500 per person (3 different lengths)</span></li>
            <li><strong style="color: #28a745;">Bonfire:</strong> <span style="color: #6c757d;">1500 per hour</span></li>
        </ul>
    </div>
</div>


        <!-- Meet Our Team Section -->
      <div class="row">
    <div class="col-12 text-center mb-4">
        <h2 class="text-success">Meet Our Team</h2>
    </div>

    <!-- Team Member 1 -->
    <div class="col-md-4 mb-4">
        <div class="card shadow-lg border-success">
            <img src="images/1.jpg" class="card-img-top team-img" alt="Julan">
            <div class="card-body text-center">
                <h5 class="card-title text-success">JULAN</h5>
                <p class="card-text">Founder and CEO. Passionate about adventure and outdoor activities.</p>
            </div>
        </div>
    </div>

    <!-- Team Member 2 -->
    <div class="col-md-4 mb-4">
        <div class="card shadow-lg border-success">
            <img src="images/2.jpg" class="card-img-top team-img" alt="Team Member 2">
            <div class="card-body text-center">
                <h5 class="card-title text-success">ANDY</h5>
                <p class="card-text">Operations Manager. Ensures smooth operations and customer satisfaction.</p>
            </div>
        </div>
    </div>

    <!-- Team Member 3 -->
    <div class="col-md-4 mb-4">
        <div class="card shadow-lg border-success">
            <img src="images/3.jpg" class="card-img-top team-img" alt="Team Member 3">
            <div class="card-body text-center">
                <h5 class="card-title text-success">Johnson</h5>
                <p class="card-text">Activity Coordinator. Expert in organizing thrilling outdoor activities.</p>
            </div>
        </div>
    </div>
</div>


    <!-- Optional Bootstrap JS and dependencies -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-rbsJmHq9GjA3D3+1l8axkL6vVJdXjTojUsC1MEYjvSOy3Q=="></script>
    <!-- Icons -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap-icons/font/bootstrap-icons.min.js"></script>
     <style>
     .container {
         padding: 2rem 1rem;
     }
     .text-success {
         color: #28a745 !important;
     }
     .card {
         border-radius: 10px;
         transition: transform 0.3s ease, box-shadow 0.3s ease;
     }
     .card:hover {
         transform: translateY(-10px);
         box-shadow: 0 15px 25px rgba(0, 0, 0, 0.1);
     }
     .card-img-top {
         border-top-left-radius: 10px;
         border-top-right-radius: 10px;
     }
     .card-title {
         font-size: 1.5rem;
         font-weight: bold;
     }
     .card-text {
         font-size: 1.1rem;
     }
     h1, h2, h3, p {
         margin: 0 0 1rem;
     }
     .row {
         margin-bottom: 2rem;
     }
     .text-center {
         text-align: center;
     }
     .img-center{
          display: flex;
    justify-content: center;
    align-items: center;
    width: 100%;
    height: 400px; 
    object-fit: cover; 
    margin: 0;
    transition: transform 0.3s ease;
     }
     .team-img {
    width: 100%; /* Maintain responsiveness */
    height: 200px; /* Set a fixed height */
    object-fit: cover; /* Ensures the image scales without distortion */
    border-top-left-radius: 10px;
    border-top-right-radius: 10px;
}
 </style>
</asp:Content>

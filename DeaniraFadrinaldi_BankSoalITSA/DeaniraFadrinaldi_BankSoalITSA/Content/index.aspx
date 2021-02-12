<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="DeaniraFadrinaldi_BankSoalITSA.index" %>

 <% If Session("id") Then
        Session.Abandon()
%>
<script>alert('Anda berhasil Logout!');</script>
<% End If %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta content="width=device-width, initial-scale=1.0" name="viewport">

    <title>Bank Soal ITSA</title>
    <meta content="" name="description">
    <meta content="" name="keywords">

    <!-- Favicons -->
    <link href="~/Content/assets/img/favicon.png" rel="icon">
    <link href="~/Content/assets/img/apple-touch-icon.png" rel="apple-touch-icon">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Montserrat:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">

    <!-- Vendor CSS Files -->
    <link href="~/Content/assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!--<link href="~/Content/bootstrap-lumen.css" rel="stylesheet">-->
    <link href="~/Content/assets/vendor/icofont/icofont.min.css" rel="stylesheet">
    <link href="~/Content/assets/vendor/boxicons/css/boxicons.min.css" rel="stylesheet">
    <link href="~/Content/assets/vendor/venobox/venobox.css" rel="stylesheet">
    <link href="~/Content/assets/vendor/remixicon/remixicon.css" rel="stylesheet">
    <link href="~/Content/assets/vendor/owl.carousel/assets/owl.carousel.min.css" rel="stylesheet">
    <link href="~/Content/assets/vendor/aos/aos.css" rel="stylesheet">

    <!-- Template Main CSS File -->
    <link href="~/Content/assets/css/style.css" rel="stylesheet">

    <!-- =======================================================
    * Template Name: Bootslander - v3.0.0
    * Template URL: https://bootstrapmade.com/bootslander-free-bootstrap-landing-page-template/
    * Author: BootstrapMade.com
    * License: https://bootstrapmade.com/license/
    ======================================================== -->
    <style>
        .gambar1 {
            width: 1000px;
            margin-left: -300px;
            margin-top: -100px;
            margin-bottom: -80px;
        }

        .gambar2 {
            width: 900px;
            margin-left: -300px;
            margin-right: -300px;
        }
    </style>
</head>

<body>

    <!-- ======= Header ======= -->
    <header id="header" class="fixed-top d-flex align-items-center header-transparent">
        <div class="container d-flex align-items-center justify-content-between">

            <div class="logo">
                <h1><a href="index.aspx"><span>Bank Soal ITSA</span></a></h1>
                <!-- Uncomment below if you prefer to use an image logo -->
                <!-- <a href="index.html"><img src="assets/img/logo.png" alt="" class="img-fluid"></a>-->
            </div>

            <nav class="nav-menu d-none d-lg-block">
                <ul>
                    <li class="active"><a href="index.aspx">Beranda depan</a></li>
                    <li><a href="#about">Login</a></li>
                </ul>
            </nav>
            <!-- .nav-menu -->

        </div>
    </header>
    <!-- End Header -->
    <!-- ======= Hero Section ======= -->
    <section id="hero">

        <div class="container">
            <div class="row justify-content-between">
                <div class="col-lg-7 pt-5 pt-lg-0 order-2 order-lg-1 d-flex align-items-center">
                    <div data-aos="zoom-out">
                        <h1>Cari referensi soal ujianmu di <span>Bank Soal ITSA</span></h1>
                        <h2>Kami telah mengumpulkan berbagai soal ujian dari tahun ke tahun yang bisa kamu gunakan sebagai referensi</h2>
                        <div class="text-center text-lg-start">
                            <a href="#about" class="btn-get-started scrollto">Login</a>
                        </div>
                    </div>
                </div>
                <div class="col-lg-4 order-1 order-lg-2 hero-img mx-auto" data-aos="zoom-out" data-aos-delay="300">
                    <div class="gambar1">
                        <img src="assets/img/hero-img.svg" class="img-fluid animated" alt="" />
                    </div>
                </div>
            </div>
        </div>

        <svg class="hero-waves" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" viewBox="0 24 150 28 " preserveAspectRatio="none">
            <defs>
                <path id="wave-path" d="M-160 44c30 0 58-18 88-18s 58 18 88 18 58-18 88-18 58 18 88 18 v44h-352z">
            </defs>
            <g class="wave1">
                <use xlink:href="#wave-path" x="50" y="3" fill="rgba(255,255,255, .1)">
            </g>
            <g class="wave2">
                <use xlink:href="#wave-path" x="50" y="0" fill="rgba(255,255,255, .2)">
            </g>
            <g class="wave3">
                <use xlink:href="#wave-path" x="50" y="9" fill="#fff">
            </g>
        </svg>

    </section>
    <!-- End Hero -->

    <main id="main">
        <form class="user" method="post" runat="server">
            <!-- ======= About Section ======= -->
            <section id="about" class="about">
                <div class="container">

                    <div class="row">
                        <div class="col-xl-7 col-lg-6 d-flex justify-content-center align-items-stretch" data-aos="fade-right">
                            <div class="gambar2">
                                <img src="assets/img/gambar2.svg" class="img-fluid animated" alt="" />
                            </div>
                        </div>

                        <div class="col-xl-5 col-lg-6 icon-boxes d-flex flex-column align-items-stretch justify-content-center py-5 px-lg-5" data-aos="fade-left">
                            <div class="col-md-8">
                                <% If passwordBenar = "0" Then %>
                                <div class="alert alert-danger" role="alert">
                                    Password Salah
                                </div>
                                <% End If
                                    If emailTerdaftar = "0" Then%>
                                <div class="alert alert-warning" role="alert">
                                    Email yang anda masukkan belum terdaftar
                                </div>
                                <% End If%>
                                <h3>Login</h3>
                                <p>Silahkan login untuk mulai mencari soal referensimu. Belum punya akun? <a href="#exampleModal" data-bs-toggle="modal" data-bs-target="#exampleModal">Daftar</a></p>
                            </div>

                            <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                                <p class="text-danger">
                                    <asp:Literal runat="server" ID="FailureText" />
                                </p>
                            </asp:PlaceHolder>
                            <div class="form-group">
                                <div class="col-md-8">
                                    <asp:TextBox runat="server" ID="tbEmail" CssClass="form-control" TextMode="Email" placeholder="Email" />
                                    <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="tbEmail"
                                        CssClass="text-danger" ErrorMessage="The email field is required." Font-Size="Smaller" />--%>
                                    <br />
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-8">
                                    <asp:TextBox runat="server" ID="tbPassword" TextMode="Password" CssClass="form-control" placeholder="Password" />
                                    <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="tbPassword" CssClass="text-danger" ErrorMessage="The password field is required." Font-Size="Smaller" />--%>
                                    <br />
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="d-grid gap-2 col-8">
                                    <asp:Button ID="btnLogin" runat="server" CausesValidation="False" Text="Login" CssClass="btn btn-outline-success" />
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </section>

            <!-- Modal -->
            <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Daftar</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            <div class="mb-3">
                                <label for="recipient-name" class="col-form-label">Nama:</label>
                                <input type="text" class="form-control" id="tbDaftarNama" runat="server">
                            </div>
                            <div class="mb-3">
                                <label for="recipient-name" class="col-form-label">Email:</label>
                                <input type="text" class="form-control" id="tbDaftarEmail" runat="server">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbDaftarEmail"   
ErrorMessage="Hanya gunakan email mahasiswa" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@(?:mahasiswa).pcr.ac.id">  
</asp:RegularExpressionValidator>  
                            </div>
                            <div class="mb-3">
                                <label for="recipient-name" class="col-form-label">Password:</label>
                                <input type="password" class="form-control" id="tbDaftarPassword" runat="server">
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Batal</button>
                            <asp:Button CssClass="btn btn-primary" CausesValidation="true" ID="btnDaftar" runat="server" OnClick="btnDaftar_Click" Text="Daftar"></asp:Button>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </main><!-- End #main -->
    <!-- ======= Footer ======= -->
    <footer id="footer">
        <div class="container">
            <div class="copyright">
                &copy; Copyright <strong><span>Deanira</span></strong>. All Rights Reserved
            </div>
            <div class="credits">
                <!-- All the links in the footer should remain intact. -->
                <!-- You can delete the links only if you purchased the pro version. -->
                <!-- Licensing information: https://bootstrapmade.com/license/ -->
                <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/bootslander-free-bootstrap-landing-page-template/ -->
                Designed by <a href="https://www.instagram.com/deanira123">Deanira</a>
            </div>
        </div>
    </footer>
    <!-- End Footer -->

    <a href="#" class="back-to-top"><i class="icofont-simple-up"></i></a>
    <div id="preloader"></div>

    <!-- Vendor JS Files -->
    <script src="assets/vendor/jquery/jquery.min.js"></script>
    <script src="assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="assets/vendor/jquery.easing/jquery.easing.min.js"></script>
    <script src="assets/vendor/php-email-form/validate.js"></script>
    <script src="assets/vendor/venobox/venobox.min.js"></script>
    <script src="assets/vendor/waypoints/jquery.waypoints.min.js"></script>
    <script src="assets/vendor/counterup/counterup.min.js"></script>
    <script src="assets/vendor/owl.carousel/owl.carousel.min.js"></script>
    <script src="assets/vendor/aos/aos.js"></script>

    <!-- Template Main JS File -->
    <script src="assets/js/main.js"></script>

</body>

</html>

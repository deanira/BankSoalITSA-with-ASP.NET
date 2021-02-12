<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="gantiPassword.aspx.vb" Inherits="DeaniraFadrinaldi_BankSoalITSA.gantiPassword" %>

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
    <header id="header" class="fixed-top d-flex align-items-center">
        <div class="container d-flex align-items-center justify-content-between">

            <div class="logo">
                <h1><a href="index.aspx"><span>Bank Soal ITSA</span></a></h1>
                <!-- Uncomment below if you prefer to use an image logo -->
                <!-- <a href="index.html"><img src="assets/img/logo.png" alt="" class="img-fluid"></a>-->
            </div>

            <nav class="nav-menu d-none d-lg-block">
                <ul>
                    <li><a href="cariSoal.aspx">Cari soal</a></li>
                    <li class="drop-down active">
                        <a href="">Akun</a>
                        <ul>
                            <li class="active"><a href="gantiPassword.aspx">Ganti Password</a></li>
                            <li><a href="../index.aspx">Logout</a></li>
                        </ul>
                    </li>
                </ul>
            </nav>
            <!-- .nav-menu -->

        </div>
    </header>
    <!-- End Header -->

    <main id="main">
        <!-- ======= Contact Section ======= -->
        <section id="contact" class="contact">
            <div class="container my-5">

                <div class="section-title" data-aos="fade-up">
                    <h2>Pengaturan akun</h2>
                    <p>Ganti Password</p>
                </div>

                <div class="row">

                    <div class="col-lg-4" data-aos="fade-right" data-aos-delay="100">

                        <div class="info">
                            <div class="address">
                                <i class="icofont-ui-user"></i>
                                <h4>Nama:</h4>
                                <p><%= Session("nama_user").ToString %></p>
                            </div>

                            <div class="email">
                                <i class="icofont-envelope"></i>
                                <h4>Email:</h4>
                                <p><%= Session("email_user").ToString %></p>
                            </div>
                        </div>

                    </div>

                    <div class="col-lg-8 mt-5 mt-lg-0" data-aos="fade-left" data-aos-delay="200">

                        <form runat="server" class="php-email-form">
                            <div class="form-group mt-3">
                                <asp:TextBox ID="password" CssClass="form-control" runat="server" Placeholder="Current password" TextMode="Password"></asp:TextBox>
                                <%--<input type="password" class="form-control" name="password" id="password" placeholder="Current password" data-rule="minlen:4" runat="server"/>
                                <div class="validate"></div>--%>
                            </div>
                            <div class="form-group mt-3">
                                <asp:TextBox ID="new_password" CssClass="form-control" runat="server" Placeholder="New password" TextMode="Password"></asp:TextBox>
                                <%--<input type="password" class="form-control" name="new_password" id="new_password" placeholder="New password" data-rule="minlen:4" runat="server"/>
                                <div class="validate"></div>--%>
                            </div>
                            <div class="form-group mt-3">
                                <asp:TextBox ID="new_password2" CssClass="form-control" runat="server" Placeholder="Confirm new password" TextMode="Password"></asp:TextBox>
                                <%--<input type="password" class="form-control" name="new_password2" id="new_password2" placeholder="Confirm new password" data-rule="minlen:4" runat="server"/>
                                <div class="validate"></div>--%>
                            </div>
                            <%If passwordSalah = "1" Then%>
                            <div class="alert alert-warninng" role="alert">
                                Password salah!
                            </div>
                            <%End If %>
                            <%If success = "1" Then%>
                            <div class="alert alert-warninng" role="alert">
                                Password berhasil diganti!
                            </div>
                            <%End If %>
                            <%If success = "0" Then%>
                            <div class="alert alert-warninng" role="alert">
                                Password tidak match!
                            </div>
                            <%End If %>
                            <div class="text-center">
                                <asp:LinkButton ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" CssClass="btn btn-outline-success"></asp:LinkButton>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </section>
        <!-- End Contact Section -->

    </main><!-- End #main -->
    <!-- ======= Footer ======= -->
    <footer id="footer" class="fixed-bottom">
        <div class="container ">
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
    <script src="../assets/vendor/jquery/jquery.min.js"></script>
    <script src="../assets/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="../assets/vendor/jquery.easing/jquery.easing.min.js"></script>
    <script src="../assets/vendor/php-email-form/validate.js"></script>
    <script src="../assets/vendor/venobox/venobox.min.js"></script>
    <script src="../assets/vendor/waypoints/jquery.waypoints.min.js"></script>
    <script src="../assets/vendor/counterup/counterup.min.js"></script>
    <script src="../assets/vendor/owl.carousel/owl.carousel.min.js"></script>
    <script src="../assets/vendor/aos/aos.js"></script>

    <!-- Template Main JS File -->
    <script src="../assets/js/main.js"></script>
    <script>
        $.ajaxPrefilter(function (options, original_Options, jqXHR) {
            options.async = true;
        });
    </script>
</body>

</html>

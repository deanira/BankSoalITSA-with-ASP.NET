<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="pilihDosen.aspx.vb" Inherits="DeaniraFadrinaldi_BankSoalITSA.pilihDosen" %>

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
                <h1><a href="../index.aspx"><span>Bank Soal ITSA</span></a></h1>
                <!-- Uncomment below if you prefer to use an image logo -->
                <!-- <a href="index.html"><img src="assets/img/logo.png" alt="" class="img-fluid"></a>-->
            </div>

            <nav class="nav-menu d-none d-lg-block">
                <ul>
                    <li class="active"><a href="cariSoal.aspx">Cari soal</a></li>
                    <li class="drop-down">
                        <a href="">Akun</a>
                        <ul>
                            <li><a href="gantiPassword.aspx">Ganti Password</a></li>
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
        <form runat="server" id="form1">
            <!-- ======= Team Section ======= -->
            <section id="team" class="team">
                <div class="container">

                    <div class="section-title mt-5" data-aos="fade-up">
                        <h2>Dosen</h2>
                        <p>Pilih Dosen</p>
                    </div>

                    <div id="dosen" class="row" data-aos="fade-left">
                        <%Dim i = 0
                            For Each itemDosen In listDosen
                                If i > 3 Then
                                    i = i + 1%>
                        <div class="col-lg-3 col-md-6 mt-5 mt-md-0">
                            <%Else
                                    i = i + 1%>
                            <div class="col-lg-3 col-md-6">
                                <%End If %>
                                <div class="member" data-aos="zoom-in" data-aos-delay="100">
                                    <div class="pic">
                                        <img src="assets/img/team/team-1.jpg" class="img-fluid" alt="">
                                    </div>
                                    <div class="member-info">
                                        <h4>
                                            <a href="pilihSoal.aspx?id_matkul=<%= Session("matkul").ToString%>&id_dosen=<%=itemDosen.id %>">
                                                <%= itemDosen.nama_dosen %>
                                            </a>
                                        </h4>
                                        <span>Dosen</span>
                                        <div class="social">
                                            <%--<a href=""><i class="icofont-twitter"></i></a>
                                            <a href=""><i class="icofont-facebook"></i></a>
                                            <a href=""><i class="icofont-instagram"></i></a>
                                            <a href=""><i class="icofont-linkedin"></i></a>--%>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <%Next %>
                        </div>
                    </div>
                </div>
            </section>
        </form>
        <!-- End Team Section -->
    </main><!-- End #main -->
    <!-- ======= Footer ======= -->
    <footer id="footer" class="fixed-bottom">
        <div class="container">
            <div class="copyright">
                &copy; Copyright <strong><span>Deanira</span></strong>. All Rights Reserved
            </div>
            <div class="credits">
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
        const tampilDosen = (e) => {
            e.preventDefault()
            const a = e.target.parentNode.parentNode.children[2].innerText

            document.getElementById('id_matkul2').innerText = a
        }
    </script>
</body>

</html>

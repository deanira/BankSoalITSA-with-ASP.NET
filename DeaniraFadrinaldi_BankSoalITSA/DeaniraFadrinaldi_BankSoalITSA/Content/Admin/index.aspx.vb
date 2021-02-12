Imports System.Data.SqlClient

Public Class index1
    Inherits System.Web.UI.Page

    Public jmlPengguna As Integer
    Public jmlAdmin As Integer
    Public jmlSoal As Integer
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Session("justLogin") = True Then
                Response.Write(
            "<script language=""javascript"">
            alert('Anda berhasil Login');
            </script>")
                Session("justLogin") = False
            End If

            con.ConnectionString = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
            con.Open()
            cmd.Connection = con

            cmd.CommandText = "SELECT COUNT(id) FROM soal"
            jmlSoal = Convert.ToInt32(cmd.ExecuteScalar())

            cmd.CommandText = "SELECT COUNT(id) FROM pengguna WHERE role = '0'"
            jmlPengguna = Convert.ToInt32(cmd.ExecuteScalar())

            cmd.CommandText = "SELECT COUNT(id) FROM pengguna WHERE role = '1'"
            jmlAdmin = Convert.ToInt32(cmd.ExecuteScalar())


        Catch ex As Exception
            'MessageBox.Show("Error while connecting to SQL Server." & ex.Message)

        End Try
    End Sub

End Class
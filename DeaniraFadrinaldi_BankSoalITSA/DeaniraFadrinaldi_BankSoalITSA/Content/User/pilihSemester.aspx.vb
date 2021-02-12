Imports System.Data.SqlClient

Public Class pilihSemester
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("justLogin") = True Then
            Response.Write(
        "<script language=""javascript"">
            alert('Anda berhasil Login');
            </script>")
            Session("justLogin") = False
        End If
    End Sub

    Protected Sub semester1_Click(sender As Object, e As EventArgs)
        Session("semester") = "1"
        Response.Redirect("pilihMatkul.aspx")
    End Sub

    Protected Sub semester3_Click(sender As Object, e As EventArgs)
        Session("semester") = "3"
        Response.Redirect("pilihMatkul.aspx")
    End Sub

    Protected Sub semester4_Click(sender As Object, e As EventArgs)
        Session("semester") = "4"
        Response.Redirect("pilihMatkul.aspx")
    End Sub

    Protected Sub semester2_Click(sender As Object, e As EventArgs)
        Session("semester") = "2"
        Response.Redirect("pilihMatkul.aspx")
    End Sub

    Protected Sub semester5_Click(sender As Object, e As EventArgs)
        Session("semester") = "5"
        Response.Redirect("pilihMatkul.aspx")
    End Sub

    Protected Sub semester6_Click(sender As Object, e As EventArgs)
        Session("semester") = "6"
        Response.Redirect("pilihMatkul.aspx")
    End Sub

    Protected Sub semester7_Click(sender As Object, e As EventArgs)
        Session("semester") = "7"
        Response.Redirect("pilihMatkul.aspx")
    End Sub

    Protected Sub semester8_Click(sender As Object, e As EventArgs)
        Session("semester") = "8"
        Response.Redirect("pilihMatkul.aspx")
    End Sub

End Class
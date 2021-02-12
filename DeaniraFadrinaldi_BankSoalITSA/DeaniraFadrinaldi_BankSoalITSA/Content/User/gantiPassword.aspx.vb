Imports System.Data.SqlClient

Public Class gantiPassword
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public success As String
    Public passwordSalah As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs)
        con.ConnectionString = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
        con.Open()

        cmd.Connection = con

        If Session("password_user").ToString = password.Text Then
            passwordSalah = "0"
            If new_password.Text = new_password2.Text Then
                cmd.CommandText = "UPDATE pengguna
                                          SET password_user = '" + new_password.Text + "'
                                          WHERE id = " & Session("id").ToString

                success = "1"
            Else
                success = "0"
            End If
        Else
            passwordSalah = "1"
        End If
    End Sub
End Class
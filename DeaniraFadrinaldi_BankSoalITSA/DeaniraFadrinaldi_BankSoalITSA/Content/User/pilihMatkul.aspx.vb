Imports System.Data.SqlClient

Public Class pilihMatkul
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public itemMatkul
    Public listMatkul As List(Of objekMatkul) = New List(Of objekMatkul)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            con.ConnectionString = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
            con.Open()

            cmd.Connection = con

            cmd.CommandText = "SELECT * FROM  matkul WHERE semester = '" & Session("semester").ToString & "'"

            Dim lrd As SqlDataReader = cmd.ExecuteReader()

            If lrd.HasRows Then
                While lrd.Read()
                    listMatkul.Add(New objekMatkul(lrd.GetInt32(0), lrd.GetString(1), lrd.GetString(2), lrd.GetString(3)))
                End While
            End If

        Catch ex As Exception
            'MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        End Try
    End Sub

End Class
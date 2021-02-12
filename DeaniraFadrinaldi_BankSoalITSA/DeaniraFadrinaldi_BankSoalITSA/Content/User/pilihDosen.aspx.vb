Imports System.Data.SqlClient

Public Class pilihDosen
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public itemDosen
    Public listDosen As List(Of objekDosen) = New List(Of objekDosen)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            con.ConnectionString = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
            con.Open()

            cmd.Connection = con

            Dim id_matkul As String = Request.QueryString("id_matkul")
            Session("matkul") = id_matkul
            cmd.CommandText = "SELECT * FROM  dosen 
                            INNER JOIN ampu ON dosen.id = ampu.id_dosen 
                            INNER JOIN matkul ON ampu.id_matkul = matkul.id
                            WHERE matkul.id = " & id_matkul

            Dim lrd As SqlDataReader = cmd.ExecuteReader()
            If lrd.HasRows Then
                While lrd.Read()
                    listDosen.Add(New objekDosen(lrd.GetInt32(0), lrd.GetString(1)))
                End While
            End If

        Catch ex As Exception
            'MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        End Try
    End Sub

End Class
Imports System.Data.SqlClient

Public Class ampu
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public listAmpu As List(Of objekAmpu) = New List(Of objekAmpu)
    Public itemAmpu
    Dim id_ampu As New Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Try
                con.ConnectionString = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
                con.Open()

                cmd.Connection = con

                cmd.CommandText = "SELECT id, nama_matkul FROM matkul"

                Dim sdaMatkul As New SqlDataAdapter(cmd)
                Dim dtMatkul As New DataTable
                sdaMatkul.Fill(dtMatkul)
                DropDownListMatkul.DataSource = dtMatkul
                DropDownListMatkul.DataValueField = "id"
                DropDownListMatkul.DataTextField = "nama_matkul"
                DropDownListMatkul.DataBind()

                cmd.CommandText = "SELECT * FROM dosen"

                Dim sdaDosen As New SqlDataAdapter(cmd)
                Dim dtDosen As New DataTable

                sdaDosen.Fill(dtDosen)
                DropDownListDosen.DataSource = dtDosen
                DropDownListDosen.DataValueField = "id"
                DropDownListDosen.DataTextField = "nama_dosen"
                DropDownListDosen.DataBind()

            Catch ex As Exception
                'MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
            Finally
                con.Close() 'Whether there Is Error Or Not. Close the connection.
            End Try
        End If
    End Sub

    Protected Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ampuAdapter As New DataSetMataKuliahTableAdapters.ampuTableAdapter
        ampuAdapter.Insert(DropDownListMatkul.SelectedValue, DropDownListDosen.SelectedValue)
        GridView1.DataBind()
    End Sub
End Class
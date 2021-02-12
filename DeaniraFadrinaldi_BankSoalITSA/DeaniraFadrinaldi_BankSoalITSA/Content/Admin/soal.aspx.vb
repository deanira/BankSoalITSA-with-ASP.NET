Imports System.Data.SqlClient
Imports System.IO

Public Class soal
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public listAmpu As List(Of objekAmpu) = New List(Of objekAmpu)
    Public itemAmpu

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

    Protected Sub btnTambah_Click(sender As Object, e As EventArgs)
        Upload()
        GridView1.DataBind()
    End Sub

    Protected Sub Upload()

        Dim semester As String = semester_soal.SelectedValue
        Dim matkul As String = DropDownListMatkul.SelectedValue
        Dim dosen As String = DropDownListDosen.SelectedValue
        Dim desk As String = deskripsi_soal.Text
        Dim ta As String = tbTahunAjaran.Text

        Dim fileStreamSoal As Stream = fileSoal.PostedFile.InputStream

        Dim binaryReaderSoal As New BinaryReader(fileStreamSoal)

        Dim bytesSoal As Byte() = binaryReaderSoal.ReadBytes(DirectCast(fileStreamSoal.Length, Long))

        Dim constString As String = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
        Using con As New SqlConnection(constString)
            Dim query As String = "INSERT INTO soal values (@file,@deskripsi,@semester,@idMatkul,@idDosen,@thnAjaran)"
            Using cmd As New SqlCommand(query)
                cmd.Connection = con
                cmd.Parameters.Add("@file", SqlDbType.Binary).Value = bytesSoal
                cmd.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester
                cmd.Parameters.Add("@idMatkul", SqlDbType.VarChar).Value = matkul
                cmd.Parameters.Add("@idDosen", SqlDbType.VarChar).Value = dosen
                cmd.Parameters.Add("@deskripsi", SqlDbType.VarChar).Value = desk
                cmd.Parameters.Add("@thnAjaran", SqlDbType.VarChar).Value = ta

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

    Protected Sub DeleteQuerySoal(id As Integer, original_id As Integer)
        Dim mhsadapter As New DataSetMataKuliahTableAdapters.DataTable2TableAdapter
        mhsadapter.DeleteQuerySoal(id)
        GridView1.DataBind()
    End Sub
End Class
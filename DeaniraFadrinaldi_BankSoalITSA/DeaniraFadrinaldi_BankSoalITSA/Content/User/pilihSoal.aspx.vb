Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class pilihSoal
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public itemSoal
    Public listSoal As List(Of objekSoal) = New List(Of objekSoal)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            con.ConnectionString = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
            con.Open()

            cmd.Connection = con

            Dim id_matkul As String = Request.QueryString("id_matkul")
            Dim id_dosen As String = Request.QueryString("id_dosen")

            Session("matkul") = id_matkul
            Session("dosen") = id_dosen
            cmd.CommandText = "SELECT * FROM  soal 
                            WHERE id_matkul = '" & id_matkul & "'
                            AND id_dosen = '" & id_dosen & "'
                            AND semester = '" & Session("semester").ToString & "'"

            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd.CommandText, con)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            Repeater1.DataSource = dt
            Repeater1.DataBind()
        Catch ex As Exception
            'MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        End Try
    End Sub

    Protected Sub View(sender As Object, e As EventArgs)
        Dim id As Integer = Integer.Parse(TryCast(sender, LinkButton).CommandArgument)
        Dim embed As String = "<object data=""{0}{1}"" type=""application/pdf"" width=""500px"" height=""600px"">"
        embed += "If you are unable to view file, you can download from <a href = ""{0}{1}&download=1"">here</a>"
        embed += " or download <a target = ""_blank"" href = ""http://get.adobe.com/reader/"">Adobe PDF Reader</a> to view the file."
        embed += "</object>"
        ltEmbed.Text = String.Format(embed, ResolveUrl("~/FileVB.ashx?Id="), id)
    End Sub

    Protected Sub DownloadFile(sender As Object, e As EventArgs)
        Dim id As Integer = Integer.Parse(TryCast(sender, LinkButton).CommandArgument)
        Dim bytes As Byte()
        Dim fileName As String, contentType As String
        Dim desk As String, ta As String
        Dim constr As String = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand()
                cmd.CommandText = "SELECT file_soal, deskripsi, tahun_ajaran FROM soal WHERE id=@Id"
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.Connection = con
                con.Open()
                Using sdr As SqlDataReader = cmd.ExecuteReader()
                    sdr.Read()
                    bytes = DirectCast(sdr("file_soal"), Byte())
                    'fileName = sdr("deskripsi").ToString + " " + sdr("tahun_ajaran").ToString
                    'contentType = sdr("ContentType").ToString()
                    'fileName = sdr("Name").ToString()
                    desk = sdr("deskripsi")
                    ta = sdr("tahun_ajaran")
                    fileName = desk + " " + ta
                End Using
                con.Close()
            End Using
        End Using
        Response.Clear()
        Response.Buffer = True
        Response.Charset = ""
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.ContentType = contentType
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName + ".pdf")
        Response.BinaryWrite(bytes)
        Response.Flush()
        Response.End()
    End Sub
End Class
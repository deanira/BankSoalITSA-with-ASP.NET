Imports System.Data.SqlClient

Public Class cariSoal
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public itemMatkul
    Public itemDosen
    Public listMatkul As List(Of objekMatkul) = New List(Of objekMatkul)
    Public listDosen As List(Of objekDosen) = New List(Of objekDosen)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            con.ConnectionString = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
            con.Open()

            cmd.Connection = con

        Catch ex As Exception
            'MessageBox.Show("Error while connecting to SQL Server." & ex.Message)
        End Try

    End Sub

    Protected Sub semester1_Click(sender As Object, e As EventArgs)
        'change the data fields names And table according to your database
        cmd.CommandText = "SELECT * FROM  matkul WHERE semester = '1'"

        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                listMatkul.Add(New objekMatkul(lrd.GetInt32(0), lrd.GetString(1), lrd.GetString(2), lrd.GetString(3)))
            End While
        End If
    End Sub

    Protected Sub semester3_Click(sender As Object, e As EventArgs)
        'change the data fields names And table according to your database
        cmd.CommandText = "SELECT * FROM  matkul WHERE semester = '3'"

        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                listMatkul.Add(New objekMatkul(lrd.GetInt32(0), lrd.GetString(1), lrd.GetString(2), lrd.GetString(3)))
            End While
        End If
    End Sub

    Protected Sub semester4_Click(sender As Object, e As EventArgs)
        'change the data fields names And table according to your database
        cmd.CommandText = "SELECT * FROM  matkul WHERE semester = '4'"

        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                listMatkul.Add(New objekMatkul(lrd.GetInt32(0), lrd.GetString(1), lrd.GetString(2), lrd.GetString(3)))
            End While
        End If
    End Sub

    Protected Sub semester2_Click(sender As Object, e As EventArgs)
        'change the data fields names And table according to your database
        cmd.CommandText = "SELECT * FROM  matkul WHERE semester = '2'"

        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                listMatkul.Add(New objekMatkul(lrd.GetInt32(0), lrd.GetString(1), lrd.GetString(2), lrd.GetString(3)))
            End While
        End If
    End Sub

    Protected Sub semester5_Click(sender As Object, e As EventArgs)
        'change the data fields names And table according to your database
        cmd.CommandText = "SELECT * FROM  matkul WHERE semester = '5'"

        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                listMatkul.Add(New objekMatkul(lrd.GetInt32(0), lrd.GetString(1), lrd.GetString(2), lrd.GetString(3)))
            End While
        End If
    End Sub

    Protected Sub semester6_Click(sender As Object, e As EventArgs)
        'change the data fields names And table according to your database
        cmd.CommandText = "SELECT * FROM  matkul WHERE semester = '6'"

        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                listMatkul.Add(New objekMatkul(lrd.GetInt32(0), lrd.GetString(1), lrd.GetString(2), lrd.GetString(3)))
            End While
        End If
    End Sub

    Protected Sub semester7_Click(sender As Object, e As EventArgs)
        'change the data fields names And table according to your database
        cmd.CommandText = "SELECT * FROM  matkul WHERE semester = '7'"

        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                listMatkul.Add(New objekMatkul(lrd.GetInt32(0), lrd.GetString(1), lrd.GetString(2), lrd.GetString(3)))
            End While
        End If
    End Sub

    Protected Sub semester8_Click(sender As Object, e As EventArgs)
        'change the data fields names And table according to your database
        cmd.CommandText = "SELECT * FROM  matkul WHERE semester = '8'"

        Dim lrd As SqlDataReader = cmd.ExecuteReader()

        If lrd.HasRows Then
            While lrd.Read()
                listMatkul.Add(New objekMatkul(lrd.GetInt32(0), lrd.GetString(1), lrd.GetString(2), lrd.GetString(3)))
            End While
        End If
    End Sub

    Protected Sub btnNamaMatkul_Click(sender As Object, e As EventArgs) Handles btnNamaMatkul.Click
        Response.Write("tes onclick")

        cmd.CommandText = "SELECT * FROM  dosen 
                            INNER JOIN ampu ON dosen.id = ampu.id_dosen 
                            INNER JOIN matkul ON ampu.id_matkul = matkul.id
                            WHERE matkul.id = " & id_matkul2.InnerText

        Dim lrd As SqlDataReader = cmd.ExecuteReader()
        'Dim a = ""
        If lrd.HasRows Then
            While lrd.Read()
                'a += "<div class=""col-lg-3 col-md-6 mt-5 mt-md-0"">
                '           <div class=""member"" data-aos=""zoom-in"" data-aos-delay=""200"">
                '              <div class=""member-info"">
                '                 <h4>" & lrd.GetString(1) & "</h4>
                '            </div>
                '       </div>
                '  </div>"
                listDosen.Add(New objekDosen(lrd.GetInt32(0), lrd.GetString(1)))
                'Response.Write(lrd.GetString(1))
            End While
        End If
        'Response.Write("<script>
        'const ambilListDosen = document.getElementById('dosen')
        'ambilListDosen.inneHTML = " + a + "
        '</script>")
    End Sub
End Class
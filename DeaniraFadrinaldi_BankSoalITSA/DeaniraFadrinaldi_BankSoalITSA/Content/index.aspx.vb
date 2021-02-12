Imports System.Data.SqlClient

Public Class index
    Inherits System.Web.UI.Page
    Public passwordBenar As String
    Public emailTerdaftar As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = tbEmail.Text
        Dim password As String = tbPassword.Text
        Dim auth As Boolean = False
        Dim connectionString As String = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
        Dim conn As New SqlConnection(connectionString)
        Dim isAdmin As Boolean = False
        conn.Open()
        Dim comm As New SqlCommand("select * from pengguna where email_user='" + email + "'", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                If reader.GetString(3) = password Then
                    passwordBenar = "1"
                    auth = True
                    Session("id") = reader.GetInt32(0)
                    Session("nama_user") = reader.GetString(1)
                    Session("email_user") = reader.GetString(2)
                    Session("password_user") = reader.GetString(3)
                    Session("role_id") = reader.GetInt32(4)
                    If reader.GetInt32(4) = 0 Then
                        Session("role") = "User"
                    Else
                        Session("role") = "Admin"
                    End If
                Else
                    passwordBenar = "0"
                End If
            End While
        Else
            emailTerdaftar = "0"
        End If

        reader.Close()
        conn.Close()

        If Session("role_id") = "1" Then
            isAdmin = True
        End If

        If auth And isAdmin Then
            Session("justLogin") = True
            Response.Redirect("Admin/index.aspx")
        ElseIf auth And isAdmin = False Then
            Session("justLogin") = True
            Response.Redirect("User/pilihSemester.aspx")
        Else
            'Response.Redirect("index.aspx")
        End If
    End Sub

    Function alihkan(message As String, link As String)
        Response.Redirect(link)
        Response.Write(
            "<script language=""javascript"">
            alert('" + message + "');
            window.location='" + link + "';
            </script>")
    End Function

    Protected Sub daftar()
        Dim nama As String = tbDaftarNama.Value
        Dim email As String = tbDaftarEmail.Value
        Dim pwd As String = tbDaftarPassword.Value

        Dim constString As String = "Data Source=TOKIO\SQLEXPRESS01;Initial Catalog=BankSoalITSA;Integrated Security=True"
        Using con As New SqlConnection(constString)
            Dim query As String = "INSERT INTO pengguna values (@nama,@email,@pwd,@role)"
            Using cmd As New SqlCommand(query)
                cmd.Connection = con
                cmd.Parameters.Add("@nama", SqlDbType.VarChar).Value = nama
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email
                cmd.Parameters.Add("@pwd", SqlDbType.VarChar).Value = pwd
                cmd.Parameters.Add("@role", SqlDbType.Int).Value = 0

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

    Protected Sub btnDaftar_Click(sender As Object, e As EventArgs)
        daftar()
    End Sub
End Class
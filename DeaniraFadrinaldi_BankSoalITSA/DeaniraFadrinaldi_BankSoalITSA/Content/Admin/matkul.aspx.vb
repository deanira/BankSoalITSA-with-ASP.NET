Public Class matkul
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnTambah_click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim matkulAdapter As New DataSetMataKuliahTableAdapters.matkulTableAdapter
        matkulAdapter.Insert(namaMatkul_tambahMatkul.Text, tipe_tambahMatkul.Text, semester_tambahMatkul.Text)
        GridView1.DataBind()
    End Sub

End Class
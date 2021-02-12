Public Class dosen
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim dosenAdapter As New DataSetMataKuliahTableAdapters.dosenTableAdapter
        dosenAdapter.Insert(namaDosen.Text)
        GridView1.DataBind()
    End Sub
End Class
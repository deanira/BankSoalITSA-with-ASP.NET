Public Class objekAmpu
    Public Property id As Integer
    Public Property nama_matkul As String
    Public Property nama_dosen As String

    Public Sub New(id As Integer, nama_matkul As String, nama_dosen As String)
        Me.id = id
        Me.nama_matkul = nama_matkul
        Me.nama_dosen = nama_dosen
    End Sub
End Class

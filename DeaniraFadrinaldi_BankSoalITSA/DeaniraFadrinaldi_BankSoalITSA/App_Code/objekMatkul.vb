Public Class objekMatkul
    Public Property id As Integer
    Public Property nama_matkul As String
    Public Property semester As String
    Public Property tipe As String

    Public Sub New(id As Integer, nama_matkul As String, tipe As String, semester As String)
        Me.id = id
        Me.nama_matkul = nama_matkul
        Me.semester = semester
        Me.tipe = tipe
    End Sub
End Class

Public Class objekSoal
    Public Property id As Integer
    Public Property file As Byte()
    Public Property deskripsi As String
    Public Property semester As String
    Public Property ta As String

    Public Sub New(id As Integer, file() As Byte, deskripsi As String, semester As String, ta As String)
        Me.id = id
        Me.file = file
        Me.deskripsi = deskripsi
        Me.semester = semester
        Me.ta = ta
    End Sub
End Class

﻿Public Class objekDosen
    Public Property id As Integer
    Public Property nama_dosen As String

    Public Sub New(id As Integer, nama_dosen As String)
        Me.id = id
        Me.nama_dosen = nama_dosen
    End Sub
End Class

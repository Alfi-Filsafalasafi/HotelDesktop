Imports System.Data.SqlClient
Module Module1
    Public koneksi As SqlConnection = Nothing
    Public Sub konek_db()
        Dim server As String
        server = "server=DESKTOP-B79MF2K;database=PC_10;integrated security = true"
        koneksi = New SqlConnection(server)
        koneksi.Open()
    End Sub
End Module

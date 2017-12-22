Imports System.Data.SqlClient
Module koneksi
    Public conn As SqlConnection
    Public da As SqlDataAdapter
    Public ds As New DataSet
    Public cmd As SqlCommand
    Public build As SqlCommandBuilder


    Sub koneksinya()
        Dim str As String = "Data Source=ndiappink-pc\sqlexpress;Initial Catalog=tes;Integrated Security=True"
        conn = New SqlConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If
    End Sub
End Module

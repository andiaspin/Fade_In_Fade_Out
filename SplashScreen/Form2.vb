Imports System.Data.SqlClient
Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As Integer
        For a = 10 To 100 Step +1
            Me.Opacity = a / 100
            Me.Refresh()
            Threading.Thread.Sleep(15)
        Next

        Call koneksinya()
        da = New SqlDataAdapter("select kode as KODE, nama as NAMA, alamat as ALAMAT, hp as TELEPON from pegawai", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns("KODE").Width = 50
        DataGridView1.Columns("NAMA").Width = 150
        DataGridView1.Columns("ALAMAT").Width = 150
        DataGridView1.Columns("TELEPON").Width = 100
        'DataGridView1.Columns("JABATAN").Width = 150
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call koneksinya()
        build = New SqlCommandBuilder(da)
        da.Update(ds)
        MsgBox("Data Berhasil Diubah")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As Integer
        For a = 100 To 10 Step -1
            Me.Opacity = a / 100
            Me.Refresh()
            Threading.Thread.Sleep(15)
        Next
        Me.Close()
    End Sub
End Class
Imports System.Data.OleDb

Public Class UploadFrm
    Private Sub LinkFile_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkFile.LinkClicked
        Dim file As New OpenFileDialog
        file.Filter = "XLS files|*.Xls;"
        If file.ShowDialog() = DialogResult.OK Then
            TxtFile.Text = System.IO.Path.GetFullPath(file.FileName).ToString
        End If
    End Sub

    Private Sub CmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOK.Click
        If TxtFile.Text = "" Then
            MsgBox("Pilih File")
            Exit Sub
        End If

        Dim conn As System.Data.OleDb.OleDbConnection
        Dim dta As System.Data.OleDb.OleDbDataAdapter
        Dim dts As DataSet
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TxtFile.Text + ";Extended Properties=Excel 12.0;")
        dta = New OleDbDataAdapter("Select *,'' as Status From [Sheet1$]", conn)
        dts = New DataSet
        dta.Fill(dts, "[Sheet1$]")
        GridView.DataSource = dts
        GridView.DataMember = "[Sheet1$]"
        conn.Close()
    End Sub

    Private Sub CmdVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdVerify.Click
        Dim DT, DT1 As New DataTable
        Dim ErrStr As String = ""

        For i As Integer = 0 To GridView.Rows.Count - 1
            SQL = "Select Surat_Jalan From Barang_Keluar_H a, Barang_Keluar_D b Where a.id=b.id_referensi and a.Surat_Jalan = '" & tostr(GridView.Rows(i).Cells("Surat_Jalan").Value) & "' And b.Jenis = '" & tostr(GridView.Rows(i).Cells("Jenis").Value) & "' And b.Warna = '" & tostr(GridView.Rows(i).Cells("Warna").Value) & "' And b.Ukuran = '" & tostr(GridView.Rows(i).Cells("Ukuran").Value) & "'"
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count > 0 Then
                ErrStr = "Verifikasi Berhasil"
            Else
                ErrStr = "Baris(" & i + 1 & ") Verifikasi Gagal, Cek Surat Jalan " & vbCrLf
            End If

            SQL = "Select Jumlah From Barang_Keluar_H a, Barang_Keluar_D b Where a.id=b.id_referensi and a.Surat_Jalan = '" & tostr(GridView.Rows(i).Cells("Surat_Jalan").Value) & "' And b.Jenis = '" & tostr(GridView.Rows(i).Cells("Jenis").Value) & "' And b.Warna = '" & tostr(GridView.Rows(i).Cells("Warna").Value) & "' And b.Ukuran = '" & tostr(GridView.Rows(i).Cells("Ukuran").Value) & "' And b.Jumlah >= " & toval(GridView.Rows(i).Cells("Jumlah_Terjual").Value) & ""
            GetDataTable(SQL, DT1, ErrMsg)
            If DT1.Rows.Count > 0 Then
                ErrStr = "Verifikasi Berhasil"
            Else
                ErrStr = ErrStr & "Baris(" & i + 1 & ") Verifikasi Gagal, Jumlah Terjual tidak boleh melebihi Jumlah Barang Keluar"
            End If

            GridView.Rows(i).Cells(0).Value = ErrStr
            DT.Clear() : DT1.Clear()
        Next
    End Sub

    Private Sub UploadFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
    End Sub

    Private Sub CmdProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdProcess.Click
        For i As Integer = 0 To GridView.Rows.Count - 1
            If GridView.Rows(i).Cells(0).Value = "Verifikasi Berhasil" Then
                SQL = "Update Barang_Keluar_D Set Jumlah_Terjual = Jumlah_Terjual + " & toval(GridView.Rows(i).Cells("Jumlah_Terjual").Value) & " Where Jenis = '" & tostr(GridView.Rows(i).Cells("Jenis").Value) & "' And Warna = '" & tostr(GridView.Rows(i).Cells("Warna").Value) & "' And Ukuran = '" & tostr(GridView.Rows(i).Cells("Ukuran").Value) & "'"
                If ExecuteSQL(SQL, ErrMsg) Then
                    GridView.Rows(i).Cells(0).Value = "Upload Berhasil"
                Else
                    GridView.Rows(i).Cells(0).Value = "Upload Gagal"
                End If
            End If
        Next

    End Sub

    Private Sub GridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView.CellDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        ErrorFrm.ErrorString = tostr(GridView.Rows(e.RowIndex).Cells("Status").Value)
        ErrorFrm.Show()
    End Sub
End Class
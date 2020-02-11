Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Globalization
Imports System.Threading


Public Class ListTempoFrm

    Private Sub ListTempoFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        DTP1.Value = Today.Date

        BtnTampil_Click(Me, e)

    End Sub

    Private Sub BtnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampil.Click
        Dim DT As New DataTable

        SQL = "SELECT Tanggal_Transaksi, Nama_Pembeli, JatuhTempo_kredit, Total_Jumlah, Total_Harga, datediff('d', '" & Format(Today.Date, "MM/dd/yyyy") & "', JatuhTempo_kredit) as Selisih_hari FROM Barang_Keluar_H where Jenis_Bayar = 'Tempo' and JatuhTempo_kredit >= #" & Format(Today.Date, "MM/dd/yyyy") & "# and JatuhTempo_kredit <= #" & Format(DTP1.Value, "MM/dd/yyyy") & "#"
        GetDataTable(SQL, DT, ErrMsg)
        DataGridView1.DataSource = DT
        DataGridView1.Refresh()

        If DT.Rows.Count = 0 Then
            MsgBox("Data tidak ada")
        Else

            MsgBox("Tagihan yang akan jatuh tempo sebanyak " & DT.Rows.Count & " Tagihan")
        End If
    End Sub

    Private Sub BtnExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExcel.Click
        If DataGridView1.RowCount = 0 Then Exit Sub

        Dim APP As New Excel.Application
        Dim worksheet As Excel.Worksheet
        Dim workbook As Excel.Workbook
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim sd As New SaveFileDialog
        Dim columnsCount As Integer = DataGridView1.Columns.Count

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

        workbook = APP.Workbooks.Add()
        worksheet = workbook.Worksheets("sheet1")

        For Each column In DataGridView1.Columns
            worksheet.Cells(1, column.Index + 1).Value = column.Name
        Next 
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim columnIndex As Integer = 0
            Do Until columnIndex = columnsCount
                worksheet.Cells(i + 2, columnIndex + 1).Value = DataGridView1.Item(columnIndex, i).Value.ToString
                columnIndex += 1
            Loop
        Next

        If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
            workbook.SaveAs(sd.FileName & ".xls")
            workbook.Close()
            APP.Quit()
        Else
            workbook.c()
            APP.Quit()
        End If
    End Sub

    Private Sub TxtHari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
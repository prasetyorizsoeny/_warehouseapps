Imports System.Globalization
Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Configuration

Public Class QueryHFrm

    Sub ClearTP1()
        TxtPO.Clear()
        TxtDO.Clear()
        TxtDok.Clear()
        TxtMkt.Clear()
        TxtGM.Clear()
        TxtSrtJln.Clear()
        SDate.Value = Date.Now
        EDate.Value = Date.Now
    End Sub

    Sub ClearTP2()
        TxtSJ.SelectedIndex = -1
        TxtToko.Clear()
        LstJenisHarga.SelectedIndex = -1
        LstPembayaran.SelectedIndex = -1
        SDate1.Value = Date.Now
        EDate1.Value = Date.Now
    End Sub

    Sub ClearTP3()
        TxtSJ1.SelectedIndex = -1
        SDate2.Value = Date.Now
        EDate2.Value = Date.Now
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        ClearTP1()
        ClearTP2()
        ClearTP3()
    End Sub

    Private Sub BtnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRetrieve.Click
        Dim SQL As String = ""
        Dim TabPage As String = ""

        If TP1.CanFocus Then
            TabPage = "TP1"
            SQL = "Select * From Barang_Masuk_H Where 1 = 1"

            If TxtPO.Text <> "" Then
                SQL = SQL & " And No_PO like '" & TxtPO.Text & "'"
            End If
            If TxtDO.Text <> "" Then
                SQL = SQL & " And No_DO like '" & TxtDO.Text & "'"
            End If
            If TxtSrtJln.Text <> "" Then
                SQL = SQL & " And Surat_Jalan like '" & TxtSrtJln.Text & "'"
            End If
            If TxtDok.Text <> "" Then
                SQL = SQL & " And No_Docno like '" & TxtDok.Text & "'"
            End If
            If TxtMkt.Text <> "" Then
                SQL = SQL & " And Nama_Marketing like '" & TxtMkt.Text & "'"
            End If
            If TxtGM.Text <> "" Then
                SQL = SQL & " And Nama_GM like '" & TxtGM.Text & "'"
            End If
            If IsDate(SDate.Value) And IsDate(EDate.Value) Then
                SQL = SQL & " And Tanggal_Transaksi >=#" & Format(todate(SDate.Value), "MM/dd/yyyy") & "# And Tanggal_Transaksi <=#" & Format(todate(EDate.Value), "MM/dd/yyyy") & "#"
            End If
        ElseIf TP2.CanFocus Then
            TabPage = "TP2"
            SQL = "Select * From Barang_Keluar_H Where 1 = 1"

            If TxtSJ.SelectedIndex <> -1 Then
                SQL = SQL & " And Surat_Jalan like '" & TxtSJ.Text & "'"
            End If
            If TxtToko.Text <> "" Then
                SQL = SQL & " And Nama_Pembeli like '" & TxtToko.Text & "'"
            End If
            If LstPembayaran.Text <> "" Then
                SQL = SQL & " And Jenis_Bayar like '" & LstPembayaran.Text & "'"
            End If
            If LstJenisHarga.Text <> "" Then
                SQL = SQL & " And Tipe_Harga like '" & LstJenisHarga.Text & "'"
            End If
            If IsDate(SDate1.Value) And IsDate(EDate1.Value) Then
                SQL = SQL & " And Tanggal_Transaksi >=#" & Format(todate(SDate1.Value), "MM/dd/yyyy") & "# And Tanggal_Transaksi <=#" & Format(todate(EDate1.Value), "MM/dd/yyyy") & "#"
            End If
        ElseIf TP3.CanFocus Then
            TabPage = "TP3"
            SQL = "Select * From Retur_H Where 1 = 1"
            If TxtSJ1.SelectedIndex <> -1 Then
                SQL = SQL & " And Surat_Jalan like '" & TxtSJ1.Text & "'"
            End If
            If IsDate(SDate2.Value) And IsDate(EDate2.Value) Then
                SQL = SQL & " And Tanggal_Transaksi >=#" & Format(todate(SDate2.Value), "MM/dd/yyyy") & "# And Tanggal_Transaksi <=#" & Format(todate(EDate2.Value), "MM/dd/yyyy") & "#"
            End If
        End If

        QueryDFrm.dSQL = SQL
        QueryDFrm.TabPage = TabPage
        QueryDFrm.Show()
    End Sub

    Private Sub QueryFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim AppSource As String = ConfigurationManager.AppSettings("AppSource")
        Dim DT As New DataTable

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        BtnNew.PerformClick()

        LstJenisHarga.Items.Clear()
        If UCase(AppSource) = "GUDANG" Then
            CmdGudang.Visible = False
            LstJenisHarga.Items.Add("Agen")
        Else
            LstJenisHarga.Items.Add("Reseller")
            LstJenisHarga.Items.Add("Toko")
            LstJenisHarga.Items.Add("EndUser")
        End If

        TxtSJ.Items.Clear()
        SQL = "SELECT Surat_Jalan FROM Barang_Keluar_H Where Surat_Jalan <> ''"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i)("Surat_Jalan").ToString <> "" Then
                TxtSJ.Items.Add(DT.Rows(i)("Surat_Jalan"))
            End If
        Next
        TxtSJ.SelectedIndex = -1
        DT.Clear()

        TxtSJ1.Items.Clear()
        SQL = "SELECT Surat_Jalan FROM Retur_H Where Surat_Jalan <> ''"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i)("Surat_Jalan").ToString <> "" Then
                TxtSJ1.Items.Add(DT.Rows(i)("Surat_Jalan"))
            End If
        Next
        TxtSJ1.SelectedIndex = -1

    End Sub

    Private Sub CmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExcel.Click
        Dim DT As New DataTable

        If TP1.CanFocus Then
            SQL = "Select a.Tanggal_Transaksi, a.No_PO, a.No_DO, a.No_DocNo, a.Surat_Jalan, a.Nama_Pengirim, a.No_Plat_Pengirim, a.Alamat_Pengirim, a.ID_Petugas, a.Nama_Satpam, a.Nama_Supir, a.Nama_Marketing, a.Nama_GM, a.Alamat_Cabang"
            SQL = SQL & " ,b.Jenis as Jenis_Barang, b.warna as Warna_Barang, b.Ukuran, b.catatan, b.jumlah, b.Harga"
            SQL = SQL & " From Barang_Masuk_H a Left Join Barang_Masuk_D b On a.id=b.id_referensi Where 1 = 1"
            If TxtPO.Text <> "" Then
                SQL = SQL & " And a.No_PO like '" & TxtPO.Text & "'"
            End If
            If TxtDO.Text <> "" Then
                SQL = SQL & " And a.No_DO like '" & TxtDO.Text & "'"
            End If
            If TxtDok.Text <> "" Then
                SQL = SQL & " And a.No_Docno like '" & TxtDok.Text & "'"
            End If
            If TxtSrtJln.Text <> "" Then
                SQL = SQL & " And Surat_Jalan like '" & TxtSrtJln.Text & "'"
            End If
            If TxtMkt.Text <> "" Then
                SQL = SQL & " And a.Nama_Marketing like '" & TxtMkt.Text & "'"
            End If
            If TxtGM.Text <> "" Then
                SQL = SQL & " And a.Nama_GM like '" & TxtGM.Text & "'"
            End If
            If IsDate(SDate.Value) And IsDate(EDate.Value) Then
                SQL = SQL & " And Tanggal_Transaksi >=#" & Format(todate(SDate2.Value), "MM/dd/yyyy") & "# And Tanggal_Transaksi <=#" & Format(todate(EDate2.Value), "MM/dd/yyyy") & "#"
            End If
        ElseIf TP2.CanFocus Then
            SQL = "Select a.Tanggal_Transaksi, a.Surat_Jalan, a.Nama_Pembeli, a.Nama_Penerima, a.Jenis_Bayar, a.Periode_Kredit, a.JatuhTempo_Kredit, a.Tipe_Harga,"
            SQL = SQL & " b.Jenis as Jenis_Barang, b.warna as Warna_Barang, b.Catatan, b.Ukuran, b.Jumlah, b.Harga, b.Jumlah_Terjual"
            SQL = SQL & " From Barang_Keluar_H a left join Barang_Keluar_D b on a.id=b.id_referensi Where 1 = 1"
            If TxtSJ.SelectedIndex <> -1 Then
                SQL = SQL & " And a.Surat_Jalan like '" & TxtSJ.Text & "'"
            End If
            If TxtToko.Text <> "" Then
                SQL = SQL & " And a.Nama_Pembeli like '" & TxtToko.Text & "'"
            End If
            If LstPembayaran.Text <> "" Then
                SQL = SQL & " And a.Jenis_Bayar like '" & LstPembayaran.Text & "'"
            End If
            If LstJenisHarga.Text <> "" Then
                SQL = SQL & " And a.Tipe_Harga like '" & LstJenisHarga.Text & "'"
            End If
            If IsDate(SDate1.Value) And IsDate(EDate1.Value) Then
                SQL = SQL & " And Tanggal_Transaksi >=#" & Format(todate(SDate2.Value), "MM/dd/yyyy") & "# And Tanggal_Transaksi <=#" & Format(todate(EDate2.Value), "MM/dd/yyyy") & "#"
            End If
        ElseIf TP3.CanFocus Then
            SQL = "Select a.Tanggal_Transaksi, a.Tipe_Retur, a.ID_Petugas, a.Surat_Jalan, b.Warna, b.Jumlah as Jumlah_Retur, b.Ukuran, b.Catatan From Retur_H a left join Retur_D b on a.id=b.id_referensi Where 1 = 1"
            If TxtSJ1.SelectedIndex <> -1 Then
                SQL = SQL & " And a.Surat_Jalan like '" & TxtSJ1.Text & "'"
            End If
            If IsDate(SDate2.Value) And IsDate(EDate2.Value) Then
                SQL = SQL & " And Tanggal_Transaksi >=#" & Format(todate(SDate2.Value), "MM/dd/yyyy") & "# And Tanggal_Transaksi <=#" & Format(todate(EDate2.Value), "MM/dd/yyyy") & "#"
            End If
        End If

        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count <> 0 Then

            Dim APP As New Excel.Application
            Dim worksheet As Excel.Worksheet
            Dim workbook As Excel.Workbook
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim sd As New SaveFileDialog

            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

            workbook = APP.Workbooks.Add()
            worksheet = workbook.Worksheets("sheet1")

            Dim name(DT.Columns.Count) As String
            Dim i As Integer = 0
            For Each column As DataColumn In DT.Columns
                worksheet.Cells(1, i + 1).Value = column.ColumnName
                i += 1
            Next

            For i = 0 To DT.Rows.Count - 1
                For j = 0 To DT.Columns.Count - 1
                    worksheet.Cells(i + 2, j + 1) = DT.Rows(i).Item(j)
                Next
            Next

            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(sd.FileName & ".xls")
                workbook.Close()
                MessageBox.Show("Simpan Ke Excel Berhasil", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                APP.Quit()
            Else
                APP.Quit()
            End If
        End If
    End Sub

    Private Sub CmdGudang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGudang.Click
        If TxtSJ.SelectedIndex = -1 Then Exit Sub

        Dim DT As New DataTable

        SQL = "Select Distinct a.Surat_Jalan, b.Jenis, b.warna, b.Ukuran, b.Jumlah_Terjual"
        SQL = SQL & " From Barang_Keluar_H a left join Barang_Keluar_D b on a.id=b.id_referensi Where 1 = 1"
        If TxtSJ.SelectedIndex <> -1 Then
            SQL = SQL & " And a.Surat_Jalan like '" & TxtSJ.Text & "'"
        End If

        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count <> 0 Then

            Dim APP As New Excel.Application
            Dim worksheet As Excel.Worksheet
            Dim workbook As Excel.Workbook
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim sd As New SaveFileDialog

            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

            workbook = APP.Workbooks.Add()
            worksheet = workbook.Worksheets("sheet1")

            Dim name(DT.Columns.Count) As String
            Dim i As Integer = 0
            For Each column As DataColumn In DT.Columns
                worksheet.Cells(1, i + 1).Value = column.ColumnName
                i += 1
            Next

            For i = 0 To DT.Rows.Count - 1
                For j = 0 To DT.Columns.Count - 1
                    worksheet.Cells(i + 2, j + 1) = DT.Rows(i).Item(j)
                Next
            Next

            If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(sd.FileName & ".xls")
                workbook.Close()
                MessageBox.Show("Simpan Ke Excel Berhasil", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                APP.Quit()
            Else
                APP.Quit()
            End If
        End If

    End Sub
End Class
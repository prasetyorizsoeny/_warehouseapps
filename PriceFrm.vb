Imports System.Globalization
Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Configuration

Public Class hargaFrm
    Dim Mode As String
    Dim Row_Index As Integer

    Private Sub hargaFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As New DataTable
        Dim AppSource As String = ConfigurationManager.AppSettings("AppSource")

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        BtnSimpan.Enabled = False
        BtnBatal.Enabled = False

        Txt_Enable(False)

        CbxTipeHarga.Items.Clear()
        If UCase(AppSource) = "GUDANG" Then
            CbxTipeHarga.Items.Add("Agen")
        Else
            CbxTipeHarga.Items.Add("Reseller")
            CbxTipeHarga.Items.Add("Toko")
            CbxTipeHarga.Items.Add("EndUser")
        End If

        SQL = "SELECT * FROM harga where 1 = 1"
        Load_Grid(SQL)
        DisplayData(0)
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Then Exit Sub
        TxtJenis.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Jenis").Value)
        CbxTipeHarga.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Tipe_Harga").Value)
        TxtHarga.Text = FormatNumber(toval(DataGridView1.Rows(e.RowIndex).Cells("Harga").Value), 0)

        LblInfo.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("User_Update").Value) & " - " & Format(todate(DataGridView1.Rows(e.RowIndex).Cells("Tanggal_Update").Value), "dd MMM yyyy")
        Row_Index = e.RowIndex
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        BtnTambah.Enabled = False
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
        BtnBatal.Enabled = True
        BtnTampil.Enabled = False
        BtnExcel.Enabled = False
        DataGridView1.Enabled = False

        Txt_Enable(True)
        Clear()
        Mode = "ADD"
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        BtnTambah.Enabled = False
        BtnEdit.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
        BtnBatal.Enabled = True
        BtnTampil.Enabled = False
        BtnExcel.Enabled = False
        DataGridView1.Enabled = False

        Txt_Enable(True)
        TxtJenis.Enabled = False
        CbxTipeHarga.Enabled = False
        Mode = "EDIT"
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim DT As New DataTable

        If Error_Field() Then Exit Sub

        SQL = "Select * from harga where jenis = '" & TxtJenis.Text & "' and Tipe_harga = '" & CbxTipeHarga.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)

        If Mode = "ADD" Then
            If DT.Rows.Count <> 0 Then
                MsgBox("Proses simpan gagal, karena jenis `" & TxtJenis.Text & "` tipe harga `" & CbxTipeHarga.Text & "` sudah terdaftar", vbOKOnly, "Information")
                Exit Sub
            Else
                SQL = "INSERT INTO harga VALUES('" & TxtJenis.Text & "','" & CbxTipeHarga.Text & "'," & toval(TxtHarga.Text) & ",'" & Today.Date & "','" & UserId & "')"
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If
            End If
        ElseIf Mode = "EDIT" Then

            SQL = "UPDATE harga SET harga = '" & toval(TxtHarga.Text) & "', tanggal_update = '" & Today.Date & "', user_update = '" & UserId & "' where jenis = '" & tostr(TxtJenis.Text) & "' and Tipe_Harga = '" & tostr(CbxTipeHarga.Text) & "'"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If
        End If

        SQL = "SELECT * FROM harga where 1 = 1"
        Load_Grid(SQL)

        BtnTambah.Enabled = True
        BtnEdit.Enabled = True
        BtnHapus.Enabled = True
        BtnSimpan.Enabled = False
        BtnBatal.Enabled = False
        BtnTampil.Enabled = True
        BtnExcel.Enabled = True
        DataGridView1.Enabled = True

        Txt_Enable(False)
        DisplayData(Row_Index)
        MsgBox("Data sudah tersimpan")
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        BtnTambah.Enabled = True
        BtnEdit.Enabled = True
        BtnHapus.Enabled = True
        BtnSimpan.Enabled = False
        BtnBatal.Enabled = False
        BtnTampil.Enabled = True
        BtnExcel.Enabled = True
        DataGridView1.Enabled = True

        Txt_Enable(False)

        If DataGridView1.Rows.Count <> 0 Then
            DataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected)
            DisplayData(Row_Index)
        End If

    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim result As DialogResult
        Dim DT As New DataTable

        result = MsgBox("Anda yakin mau menghapus jenis `" & TxtJenis.Text & "` tipe harga `" & CbxTipeHarga.Text & "` ?", vbYesNo)
        If result = DialogResult.Yes Then

            SQL = "Select * from Harga  H, barang_keluar_H H1, barang_keluar_D D where H1.ID = D.ID_Referensi and H.jenis = '" & TxtJenis.Text & "' and H.Tipe_harga = '" & CbxTipeHarga.Text & "' and  H.jenis = D.jenis and H.Tipe_harga = H1.Tipe_Harga "
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count <> 0 Then
                MsgBox("Jenis `" & TxtJenis.Text & "` dengan tipe harga `" & CbxTipeHarga.Text & "` Tidak bisa dihapus, karena sudah digunakan")
                Exit Sub
            End If

            SQL = "DELETE FROM harga WHERE Jenis ='" & tostr(TxtJenis.Text) & "' and tipe_harga = '" & CbxTipeHarga.Text & "'"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If

            SQL = "SELECT * FROM harga where 1 = 1"
            Load_Grid(SQL)
            DisplayData(0)

            MsgBox("Data berhasil dihapus")
        End If
    End Sub

    Private Sub Txt_Enable(ByVal Flag As Boolean)
        TxtJenis.Enabled = Flag
        CbxTipeHarga.Enabled = Flag
        TxtHarga.ReadOnly = Not Flag
    End Sub

    Private Sub Clear()
        TxtJenis.Text = ""
        CbxTipeHarga.SelectedIndex = 0
        TxtHarga.Text = "0"
    End Sub

    Private Sub DisplayData(ByVal ROW As Integer)
        If DataGridView1.Rows.Count = 0 Then
            Clear()
            Exit Sub
        End If

        TxtJenis.Text = tostr(DataGridView1.Rows(ROW).Cells("Jenis").Value)
        CbxTipeHarga.Text = tostr(DataGridView1.Rows(ROW).Cells("Tipe_Harga").Value)
        TxtHarga.Text = FormatNumber(toval(DataGridView1.Rows(ROW).Cells("Harga").Value), 0)

        LblInfo.Text = tostr(DataGridView1.Rows(ROW).Cells("User_Update").Value) & " - " & Format(todate(DataGridView1.Rows(ROW).Cells("Tanggal_Update").Value), "dd MMM yyyy")

    End Sub

    Private Function Error_Field() As Boolean
        Dim Error_Msg As String = ""

        If TxtJenis.Text = "" Then
            TxtJenis.Focus()
            Error_Msg = "Jenis wajib diinput"
            GoTo Error_Message
        End If

        If Not IsNumeric(TxtHarga.Text) Then
            TxtHarga.Focus()
            Error_Msg = "Harga wajib diinput dengan angka"
            GoTo Error_Message
        ElseIf CbxTipeHarga.SelectedIndex <> 2 And toval(TxtHarga.Text) <= 0 Then
            TxtHarga.Focus()
            Error_Msg = "Harga wajib diinput dengan nilai lebih besar dari 0"
            GoTo Error_Message
        End If

        Error_Field = False
        Exit Function
Error_Message:
        Error_Field = True
        MsgBox(Error_Msg)
    End Function

    Private Sub Load_Grid(ByVal SQL As String)
        Dim DT As New DataTable

        GetDataTable(SQL, DT, ErrMsg)
        DataGridView1.DataSource = DT
        DataGridView1.Refresh()
    End Sub

    Private Sub BtnTampil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTampil.Click
        SQL = "SELECT * FROM harga where 1 = 1"

        If tostr(TxtCariJenis.Text) <> "" Then
            SQL = SQL & " and Jenis LIKE '%" & TxtCariJenis.Text & "%'"
        End If

        If tostr(CbxCariTipe.Text) <> "" Then
            SQL = SQL & " and Tipe_Harga LIKE '%" & CbxCariTipe.Text & "%'"
        End If

        Load_Grid(SQL)
        If DataGridView1.Rows.Count = 0 Then MsgBox("Data tidak ada")
    End Sub

    Private Sub BtnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcel.Click
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
            APP.Quit()
        End If
    End Sub

    Private Sub TxtHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHarga.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
Imports System.Globalization
Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel

Public Class produkFrm
    Dim Mode As String
    Dim Row_Index As Integer

    Private Sub produkFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As New DataTable

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        BtnSimpan.Enabled = False
        BtnBatal.Enabled = False
        BtnTampil.Enabled = True
        BtnExcel.Enabled = True

        Txt_Enable(False)

        SQL = "SELECT * FROM produk where 1 = 1"
        Load_Grid(SQL)
        DisplayData(0)
        CbxJenis.SelectedIndex = 0
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Then Exit Sub
        TxtWarna.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("warna").Value)
        CbxUkuran.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Ukuran").Value)
        TxtJumlah.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Jumlah").Value)

        LblInfo.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("User_Update").Value) & " - " & Format(todate(DataGridView1.Rows(e.RowIndex).Cells("Tanggal_Update").Value), "dd MMM yyyy")
        Row_Index = e.RowIndex
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        BtnTambah.Enabled = False
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

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim DT As New DataTable

        If Error_Field() Then Exit Sub

        SQL = "Select * from produk where warna = '" & TxtWarna.Text & "' and ukuran = '" & CbxUkuran.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)

        If Mode = "ADD" Then
            If DT.Rows.Count <> 0 Then
                MsgBox("Proses simpan gagal, karena warna `" & TxtWarna.Text & "` dengan ukuran `" & CbxUkuran.Text & "` sudah terdaftar", vbOKOnly, "Information")
                Exit Sub
            Else
                SQL = "INSERT INTO produk VALUES('" & TxtWarna.Text & "','" & CbxUkuran.Text & "','" & CbxJenis.Text & "','" & toval(TxtJumlah.Text) & "','" & Today.Date & "','" & UserId & "')"
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If
            End If
        ElseIf Mode = "EDIT" Then

            SQL = "UPDATE produk SET jumlah = '" & toval(TxtJumlah.Text) & "', ukuran = '" & CbxUkuran.Text & "', tanggal_update = '" & Today.Date & "', user_update = '" & UserId & "' where warna = '" & tostr(TxtWarna.Text) & "' and ukuran = '" & CbxUkuran.Text & "'"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If
        End If

        SQL = "SELECT * FROM produk where 1 = 1"
        Load_Grid(SQL)

        BtnTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnSimpan.Enabled = False
        BtnBatal.Enabled = False
        BtnTampil.Enabled = True
        BtnExcel.Enabled = True
        DataGridView1.Enabled = True

        Txt_Enable(False)
        MsgBox("Data sudah tersimpan")
        Clear()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        BtnTambah.Enabled = True
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

        result = MsgBox("Anda yakin mau menghapus warna `" & TxtWarna.Text & "` dengan ukuran `" & CbxUkuran.Text & "` ?", vbYesNo)
        If result = DialogResult.Yes Then

            SQL = "Select top 1 * from (Select * from produk  P, barang_keluar_D D where P.warna = '" & TxtWarna.Text & "' and P.ukuran = '" & CbxUkuran.Text & "' and  P.warna = D.warna and P.ukuran = D.ukuran UNION ALL Select * from produk  P, barang_masuk_D D where P.warna = '" & TxtWarna.Text & "' and P.ukuran = '" & CbxUkuran.Text & "' and  P.warna = D.warna and P.ukuran = D.ukuran )"
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count <> 0 Then
                MsgBox("Warna `" & TxtWarna.Text & "` dengan ukuran `" & CbxUkuran.Text & "` Tidak bisa dihapus, karena sudah digunakan")
                Exit Sub
            End If

            SQL = "DELETE FROM produk WHERE warna ='" & tostr(TxtWarna.Text) & "' and ukuran ='" & CbxUkuran.Text & "'"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox("Warna `" & TxtWarna.Text & "` dengan ukuran `" & CbxUkuran.Text & "` Tidak bisa dihapus, karena sudah digunakan")
                Exit Sub
            End If

            SQL = "SELECT * FROM produk where 1 = 1"
            Load_Grid(SQL)
            DisplayData(0)

            MsgBox("Data berhasil dihapus")
        End If
    End Sub

    Private Sub Txt_Enable(ByVal Flag As Boolean)
        TxtWarna.ReadOnly = Not Flag
        CbxUkuran.Enabled = Flag
        TxtJumlah.ReadOnly = Not Flag
        CbxJenis.Enabled = Flag
    End Sub

    Private Sub Clear()
        TxtWarna.Text = ""
        CbxUkuran.SelectedIndex = 0
        TxtJumlah.Text = "0"
    End Sub

    Private Sub DisplayData(ByVal ROW As Integer)
        If DataGridView1.Rows.Count = 0 Then Exit Sub

        TxtWarna.Text = tostr(DataGridView1.Rows(ROW).Cells("Warna").Value)
        CbxUkuran.Text = tostr(DataGridView1.Rows(ROW).Cells("Ukuran").Value)
        TxtJumlah.Text = tostr(DataGridView1.Rows(ROW).Cells("Jumlah").Value)

        LblInfo.Text = tostr(DataGridView1.Rows(ROW).Cells("User_Update").Value) & " - " & Format(todate(DataGridView1.Rows(ROW).Cells("Tanggal_Update").Value), "dd MMM yyyy")

    End Sub

    Private Function Error_Field() As Boolean
        Dim Error_Msg As String = ""

        If TxtWarna.Text = "" Then
            TxtWarna.Focus()
            Error_Msg = "Warna wajib diinput"
            GoTo Error_Message
        End If

        If Not IsNumeric(TxtJumlah.Text) Then
            TxtJumlah.Focus()
            Error_Msg = "Jumlah harus diinput dengan angka"
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
        SQL = "SELECT * FROM Produk where 1 = 1"

        If tostr(TxtCariWarna.Text) <> "" Then
            SQL = SQL & " and warna LIKE '%" & TxtCariWarna.Text & "%'"
        End If

        If tostr(CbxCariUkuran.Text) <> "" Then
            SQL = SQL & " and ukuran LIKE '%" & CbxCariUkuran.Text & "%'"
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

    Private Sub TxtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJumlah.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
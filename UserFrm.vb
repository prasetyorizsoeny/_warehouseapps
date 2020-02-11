Imports System.Globalization
Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Configuration

Public Class UserFrm
    Dim Mode As String
    Dim Row_Index As Integer

    Private Sub UserFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As New DataTable
        Dim AppSource As String = ConfigurationManager.AppSettings("AppSource")

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        BtnSimpan.Enabled = False
        BtnBatal.Enabled = False

        Txt_Enable(False)

        SQL = "SELECT ID, Nama, Tipe, Tanggal_Update, User_Update FROM users where 1 = 1"
        Load_Grid(SQL)
        DisplayData(0)

        If AppSource = "GUDANG" Then
            CbxTipe.Items.Clear()
            CbxTipe.Items.Add("GUDANG")
            CbxTipe.Items.Add("SPV")
            CbxCariTipe.Items.Clear()
            CbxCariTipe.Items.Add("GUDANG")
            CbxCariTipe.Items.Add("SPV")
        Else
            CbxTipe.Items.Clear()
            CbxTipe.Items.Add("AGEN")
            CbxTipe.Items.Add("SPV")
            CbxCariTipe.Items.Clear()
            CbxCariTipe.Items.Add("AGEN")
            CbxCariTipe.Items.Add("SPV")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Then Exit Sub
        TxtID.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("ID").Value)
        TxtNama.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Nama").Value)
        CbxTipe.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Tipe").Value)

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
        TxtID.Enabled = False
        Mode = "EDIT"
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim DT As New DataTable

        If Error_Field() Then Exit Sub

        SQL = "Select * from Users where ID = '" & TxtID.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)

        If Mode = "ADD" Then
            If DT.Rows.Count <> 0 Then
                MsgBox("Proses simpan gagal, karena ID `" & TxtID.Text & "` sudah terdaftar", vbOKOnly, "Information")
                Exit Sub
            Else
                SQL = "INSERT INTO users VALUES('" & TxtID.Text & "','" & TxtNama.Text & "','" & encrypt("rsv123") & "' ,'" & CbxTipe.Text & "','" & Today.Date & "','" & UserId & "')"
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If
            End If
        ElseIf Mode = "EDIT" Then

            SQL = "UPDATE users SET Nama = '" & tostr(TxtNama.Text) & "', Tipe = '" & CbxTipe.Text & "', tanggal_update = '" & Today.Date & "', user_update = '" & UserId & "' where ID = '" & tostr(TxtID.Text) & "'"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If
        End If

        SQL = "SELECT ID, Nama, Tipe, Tanggal_Update, User_Update FROM users where 1 = 1"
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

        result = MsgBox("Anda yakin mau menghapus ID `" & TxtID.Text & "` ?", vbYesNo)
        If result = DialogResult.Yes Then

            SQL = "Select Top 1 * from users where id = '" & TxtID.Text & "' and (id in (select id_petugas from barang_masuk_H) or id in (select id_petugas from barang_keluar_H) or id in (select id_petugas from retur_H)) "
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count <> 0 Then
                MsgBox("ID `" & TxtID.Text & "` Tidak bisa dihapus, karena sudah digunakan")
                Exit Sub
            End If

            SQL = "DELETE FROM users WHERE ID ='" & tostr(TxtID.Text) & "'"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If

            SQL = "SELECT ID, Nama, Tipe, Tanggal_Update, User_Update FROM users where 1 = 1"
            Load_Grid(SQL)
            DisplayData(0)

            MsgBox("Data berhasil dihapus")
        End If
    End Sub

    Private Sub Txt_Enable(ByVal Flag As Boolean)
        TxtID.Enabled = Flag
        TxtNama.ReadOnly = Not Flag
        CbxTipe.Enabled = Flag
    End Sub

    Private Sub Clear()
        TxtID.Text = ""
        TxtNama.Text = ""
        CbxTipe.Text = "Staff"
        LblInfo.Text = ""
    End Sub

    Private Sub DisplayData(ByVal ROW As Integer)
        If DataGridView1.Rows.Count = 0 Then
            Clear()
            Exit Sub
        End If

        TxtID.Text = tostr(DataGridView1.Rows(ROW).Cells("ID").Value)
        TxtNama.Text = tostr(DataGridView1.Rows(ROW).Cells("Nama").Value)
        CbxTipe.Text = tostr(DataGridView1.Rows(ROW).Cells("Tipe").Value)

        LblInfo.Text = tostr(DataGridView1.Rows(ROW).Cells("User_Update").Value) & " - " & Format(todate(DataGridView1.Rows(ROW).Cells("Tanggal_Update").Value), "dd MMM yyyy")
    End Sub

    Private Function Error_Field() As Boolean
        Dim Error_Msg As String = ""

        If TxtID.Text = "" Then
            TxtID.Focus()
            Error_Msg = "ID wajib diinput"
            GoTo Error_Message
        End If

        If TxtNama.Text = "" Then
            TxtNama.Focus()
            Error_Msg = "Nama wajib diinput"
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

    Private Sub BtnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampil.Click
        SQL = "SELECT ID, Nama, Tipe, Tanggal_Update, User_Update FROM users where 1 = 1"

        If tostr(TxtCariNama.Text) <> "" Then
            SQL = SQL & " and (ID LIKE '%" & TxtCariNama.Text & "%' or Nama LIKE '%" & TxtCariNama.Text & "%')"
        End If

        If tostr(CbxCariTipe.Text) <> "" Then
            SQL = SQL & " and Tipe LIKE '%" & CbxCariTipe.Text & "%'"
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

End Class
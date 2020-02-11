Imports System.Globalization
Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Configuration

Public Class profilFrm
    Dim Mode As String
    Dim Row_Index As Integer

    Private Sub profilFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim AppSource As String = ConfigurationManager.AppSettings("AppSource")

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        BtnSimpan.Enabled = False
        BtnBatal.Enabled = False
        BtnTampil.Enabled = True
        BtnExcel.Enabled = True

        Txt_Enable(False)

        CbxTipe.Items.Clear()
        CbxCariTipe.Items.Clear()
        If UCase(AppSource) = "GUDANG" Then
            CbxTipe.Items.Add("Agen")
            CbxCariTipe.Items.Add("Agen")
        Else
            CbxTipe.Items.Add("Reseller")
            CbxTipe.Items.Add("Toko")
            CbxTipe.Items.Add("EndUser")
            CbxCariTipe.Items.Add("Reseller")
            CbxCariTipe.Items.Add("Toko")
            CbxCariTipe.Items.Add("EndUser")
        End If
        TxtHarga.Text = 0

        SQL = "SELECT * FROM profil where 1 = 1"
        Load_Grid(SQL)
        DisplayData(0)
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Then Exit Sub
        TxtID.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("ID").Value)
        TxtNama.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Nama").Value)
        CbxTipe.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Tipe").Value)
        TxtCabang.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Cabang").Value)
        TxtHarga.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Harga").Value)

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

        SQL = "Select * from profil where ID = '" & TxtID.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)

        If Mode = "ADD" Then
            If DT.Rows.Count <> 0 Then
                MsgBox("Proses simpan gagal, karena ID `" & TxtID.Text & "` sudah terdaftar", vbOKOnly, "Information")
                Exit Sub
            Else
                SQL = "INSERT INTO profil VALUES('" & TxtID.Text & "','" & TxtNama.Text & "','" & CbxTipe.Text & "','" & TxtAlamat.Text & "','" & TxtTelepon.Text & "','" & TxtEmail.Text & "','" & TxtCabang.Text & "','" & Today.Date & "','" & UserId & "','" & TxtHarga.Text & "')"
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If
            End If
        ElseIf Mode = "EDIT" Then

            SQL = "UPDATE profil SET Nama = '" & tostr(TxtNama.Text) & "', Alamat = '" & TxtAlamat.Text & "', Cabang = '" & TxtCabang.Text & "', Telepon = '" & TxtTelepon.Text & "', Email = '" & TxtEmail.Text & "', Tipe = '" & CbxTipe.Text & "', Harga = '" & TxtHarga.Text & "', tanggal_update = '" & Today.Date & "', user_update = '" & UserId & "' where ID = '" & tostr(TxtID.Text) & "'"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If
        End If

        SQL = "SELECT * FROM profil where 1 = 1"
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

            SQL = "Select Top 1 * from profil where id = '" & TxtID.Text & "' and id in (select id_pembeli from barang_keluar_H)"
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count <> 0 Then
                MsgBox("ID `" & TxtID.Text & "` Tidak bisa dihapus, karena sudah digunakan")
                Exit Sub
            End If

            SQL = "DELETE FROM profil WHERE ID ='" & tostr(TxtID.Text) & "'"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If

            SQL = "SELECT * FROM profil where 1 = 1"
            Load_Grid(SQL)
            DisplayData(0)

            MsgBox("Data berhasil dihapus")
        End If
    End Sub

    Private Sub Txt_Enable(ByVal Flag As Boolean)
        TxtID.Enabled = Flag
        TxtNama.ReadOnly = Not Flag
        TxtAlamat.ReadOnly = Not Flag
        TxtTelepon.ReadOnly = Not Flag
        TxtEmail.ReadOnly = Not Flag
        CbxTipe.Enabled = Flag
        TxtHarga.Enabled = Flag
        TxtCabang.ReadOnly = Not Flag
    End Sub

    Private Sub Clear()
        TxtID.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtCabang.Text = ""
        TxtTelepon.Text = ""
        TxtEmail.Text = ""
        CbxTipe.SelectedIndex = 0
        LblInfo.Text = ""
        TxtHarga.Text = 0
    End Sub

    Private Sub DisplayData(ByVal ROW As Integer)
        If DataGridView1.Rows.Count = 0 Then Exit Sub

        TxtID.Text = tostr(DataGridView1.Rows(ROW).Cells("ID").Value)
        TxtNama.Text = tostr(DataGridView1.Rows(ROW).Cells("Nama").Value)
        TxtAlamat.Text = tostr(DataGridView1.Rows(ROW).Cells("Alamat").Value)
        TxtCabang.Text = tostr(DataGridView1.Rows(ROW).Cells("Cabang").Value)
        TxtTelepon.Text = tostr(DataGridView1.Rows(ROW).Cells("Telepon").Value)
        TxtEmail.Text = tostr(DataGridView1.Rows(ROW).Cells("Email").Value)
        CbxTipe.Text = tostr(DataGridView1.Rows(ROW).Cells("Tipe").Value)
        TxtHarga.Text = tostr(DataGridView1.Rows(ROW).Cells("Harga").Value)

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
        SQL = "SELECT * FROM profil where 1 = 1"

        If tostr(TxtCariNama.Text) <> "" Then
            SQL = SQL & " and (ID LIKE '%" & TxtCariNama.Text & "%' or Nama LIKE '%" & TxtCariNama.Text & "%')"
        End If

        If tostr(CbxCariTipe.Text) <> "" Then
            SQL = SQL & " and Tipe LIKE '%" & CbxCariTipe.Text & "%'"
        End If

        If tostr(TxtCariAlamat.Text) <> "" Then
            SQL = SQL & " and Alamat LIKE '%" & TxtCariAlamat.Text & "%'"
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
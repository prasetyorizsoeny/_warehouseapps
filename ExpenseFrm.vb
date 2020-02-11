Imports System.Globalization
Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ExpenseFrm
    Private Function Error_Field() As Boolean
        Dim Error_Msg As String = ""

        If TxtNama.Text = "" Then
            TxtNama.Focus()
            Error_Msg = "Nama Transaksi wajib diinput"
            GoTo Error_Message
        End If

        If CbxKategori.SelectedIndex = -1 Then
            CbxKategori.Focus()
            Error_Msg = "Kategori wajib diinput"
            GoTo Error_Message
        End If

        If Not IsNumeric(TxtNominal.Text) Then
            TxtNominal.Focus()
            Error_Msg = "Nominal wajib diinput dengan angka"
            GoTo Error_Message
        End If

        Error_Field = False
        Exit Function
Error_Message:
        Error_Field = True
        MsgBox(Error_Msg)
    End Function

    Sub SetField(ByVal Value As Boolean)
        DTP.Enabled = Value
        TxtNama.Enabled = Value
        CbxKategori.Enabled = Value
        TxtNominal.Enabled = Value
    End Sub

    Sub Clear()
        DTP.Value = Date.Now
        SDate.Value = Date.Now
        EDate.Value = Date.Now
        TxtNama.Clear()
        TxtNama.Focus()
        CbxKategori.SelectedIndex = -1
        TxtNominal.Text = 0
    End Sub

    Sub GetKategori()
        Dim DT As New DataTable

        CbxKategori.Items.Clear()

        SQL = "SELECT Deskripsi FROM Kategori Order By ID"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            CbxKategori.Items.Add(DT.Rows(i)("Deskripsi"))
        Next
    End Sub

    Private Sub FinanceFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        GetKategori()
        Clear()
        SetField(False)

        CmdTambah.Enabled = False
        CmdHapus.Enabled = False
        CmdSimpan.Enabled = False
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        If GridView.Rows.Count = 0 Then Exit Sub

        Dim RowSelected As Integer = GridView.CurrentCell.RowIndex
        GridView.Rows.RemoveAt(RowSelected)

        Dim total As Double = 0

        For Each row As DataGridViewRow In GridView.Rows
            total += row.Cells(3).Value
            TxtTotal.Text = total
        Next

        If GridView.Rows.Count = 0 Then
            TxtTotal.Text = 0
        End If
    End Sub

    Private Sub CmdTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTambah.Click
        If Error_Field() Then Exit Sub

        GridView.Rows.Add(todate(DTP.Value), TxtNama.Text, CbxKategori.Text, toval(TxtNominal.Text))
        Clear()

        Dim total As Double = 0
        Dim total1 As Double = 0

        For Each row As DataGridViewRow In GridView.Rows
            total += row.Cells(3).Value
            TxtTotal.Text = total
        Next

        If GridView.Rows.Count = 0 Then
            TxtTotal.Text = 0
        End If
    End Sub

    Private Sub CmdHTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHTambah.Click
        SetField(True)
        TxtNama.Focus()
        CmdTambah.Enabled = True
        CmdHapus.Enabled = True
        CmdSimpan.Enabled = True
    End Sub

    Private Sub TxtNominal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNominal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (e.KeyChar.ToString <> "-") And (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        Dim DT As New DataTable
        Dim Kategori_ID As Double

        For i = 0 To GridView.Rows.Count - 1
            SQL = "Select ID From Kategori Where Deskripsi = '" & tostr(GridView.Rows(i).Cells(2).Value) & "'"
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count <> 0 Then
                Kategori_ID = toval(DT.Rows(0)(0))
            End If

            SQL = "INSERT INTO Biaya (Tanggal_Transaksi, Deskripsi, Kategori_ID, Nominal, Tanggal_Update, User_Update) VALUES ('" & Format(todate(DTP.Value), "MM/dd/yyyy") & "','" & tostr(GridView.Rows(i).Cells(1).Value) & "'," & Kategori_ID & "," & toval(GridView.Rows(i).Cells(3).Value) & ", '" & Format(todate(Today.Date), "MM/dd/yyyy") & "','" & UserId & "')"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If
        Next

        CmdTambah.Enabled = False
        CmdHapus.Enabled = False
        CmdSimpan.Enabled = False
        
        MsgBox("Data sudah tersimpan")

        SetField(False)
        TxtTotal.Text = 0
        Clear()
        GridView.Rows.Clear()
    End Sub

    Private Sub CmdCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCetak.Click
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
            MessageBox.Show("Simpan Ke Excel Berhasil", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            APP.Quit()
        Else
            APP.Quit()
        End If
    End Sub

    Private Sub Load_Grid(ByVal SQL As String)
        Dim DT As New DataTable

        GetDataTable(SQL, DT, ErrMsg)
        DataGridView1.DataSource = DT
        DataGridView1.Refresh()
    End Sub

    Private Sub CmdTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTampil.Click
        SQL = "SELECT Biaya.Tanggal_Transaksi, Kategori.Deskripsi As Kategori, Biaya.Deskripsi As Pengeluaran, Biaya.Nominal FROM Biaya, Kategori where 1=1 And Biaya.Kategori_ID=Kategori.ID And Biaya.Tanggal_Transaksi >=#" & Format(todate(SDate.Value), "MM/dd/yyyy") & "# And Tanggal_Transaksi <=#" & Format(todate(EDate.Value), "MM/dd/yyyy") & "#"
        Load_Grid(SQL)
        If DataGridView1.Rows.Count = 0 Then MsgBox("Data tidak ada")
    End Sub
End Class
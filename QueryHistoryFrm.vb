Imports System.Globalization
Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel

Public Class QueryHistoryFrm

    Public dSQL As String
    Public TabPage As String

    Private Sub QueryHistoryFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        Dim DT, DT1 As New DataTable
        GridView.DataSource = DT
        GridView.Refresh()
        GetDataTable(dSQL, DT, ErrMsg)
        If GridView.Rows.Count <> 0 Then
            Dim btn As New DataGridViewButtonColumn()
            btn.HeaderText = "Detail"
            btn.Text = "Lihat Detail"
            btn.Name = "CmdQDet"
            btn.UseColumnTextForButtonValue = True
            GridView.Columns.Add(btn)

            If TabPage = "TP1" Or TabPage = "TP2" Then
                Dim btn1 As New DataGridViewButtonColumn()
                btn1.HeaderText = "Ubah Data"
                btn1.Text = "Ubah Data"
                btn1.Name = "CmdEdit"
                btn1.UseColumnTextForButtonValue = True
                btn1.Visible = False
                GridView.Columns.Add(btn1)
            End If
            If TabPage = "TP2" Then
                Dim btn2 As New DataGridViewButtonColumn()
                btn2.HeaderText = "history"
                btn2.Text = "Lihat history"
                btn2.Name = "CmdHistory"
                btn2.UseColumnTextForButtonValue = True
                GridView.Columns.Add(btn2)
                btn2.Visible = False
            End If
        End If
    End Sub

    Private Sub GridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView.CellClick
        If GridView.Rows.Count = 0 Then Exit Sub

        If TabPage = "TP1" Or TabPage = "TP2" Then
            Dim BtnHistory As Integer = GridView.ColumnCount - 1
            Dim BtnEdit As Integer = GridView.ColumnCount - 2
            Dim BtnQryD1 As Integer = GridView.ColumnCount - 3
            If e.ColumnIndex = BtnQryD1 Then
                Dim SQL As String = ""

                'SQL = "Select * From Barang_Masuk_D Where 1 = 1 And ID_Referensi = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                If TabPage = "TP1" Then
                    SQL = "Select * From Barang_Masuk_D Where 1 = 1 And ID_Referensi = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                ElseIf TabPage = "TP2" Then
                    SQL = "Select * From Barang_Keluar_D Where 1 = 1 And ID_Referensi = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                ElseIf TabPage = "TP3" Then
                    SQL = "Select * From Retur_D Where 1 = 1 And ID_Referensi = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                End If
                QueryD1Frm.d1SQL = SQL
                QueryD1Frm.Show()
            ElseIf e.ColumnIndex = BtnHistory Then
                QueryDFrm.dSQL = SQL
                QueryDFrm.TabPage = TabPage
                QueryDFrm.Show()
            ElseIf e.ColumnIndex = BtnEdit Then
                Dim DT, DTOrder, DTDetail As New DataTable

                SQL = "Select Tipe from Users where id ='" & UserId & "'"
                GetDataTable(SQL, DT, ErrMsg)
                If UCase(DT.Rows(0)("Tipe").ToString) = "SPV" Then
                    If TabPage = "TP1" Then
                        SQL = "Select * From Barang_Masuk_H Where 1=1 And ID = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                        GetDataTable(SQL, DTOrder, ErrMsg)
                        If DTOrder.Rows.Count > 0 Then
                            OrdersInFrm.EditMode = True
                            OrdersInFrm.BtnHTambah.Text = "Edit"
                            OrdersInFrm.NextID = toval(GridView.Rows(e.RowIndex).Cells(0).Value)
                            OrdersInFrm.DTPO.Value = DTOrder.Rows(0)("Tanggal_Transaksi")
                            OrdersInFrm.TxtPO.Text = DTOrder.Rows(0)("No_PO")
                            OrdersInFrm.TxtDO.Text = DTOrder.Rows(0)("No_DO")
                            OrdersInFrm.TxtDocNo.Text = DTOrder.Rows(0)("No_DocNo")
                            OrdersInFrm.TxtSJ.Text = DTOrder.Rows(0)("Surat_Jalan")
                            OrdersInFrm.TxtNmPgr.Text = DTOrder.Rows(0)("Nama_Pengirim")
                            OrdersInFrm.TxtPlatNo.Text = DTOrder.Rows(0)("No_Plat_Pengirim")
                            OrdersInFrm.TxtAlmt.Text = DTOrder.Rows(0)("Alamat_Pengirim")
                            OrdersInFrm.TxtStpm.Text = DTOrder.Rows(0)("Nama_Satpam")
                            OrdersInFrm.TxtNmSpr.Text = DTOrder.Rows(0)("Nama_Supir")
                            OrdersInFrm.txtmkt.Text = DTOrder.Rows(0)("Nama_Marketing")
                            OrdersInFrm.TxtGM.Text = DTOrder.Rows(0)("Nama_GM")
                            OrdersInFrm.TxtAlmtCbg.Text = DTOrder.Rows(0)("Alamat_Cabang")

                            SQL = "Select * From Barang_Masuk_D Where 1=1 And ID_Referensi = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                            GetDataTable(SQL, DTDetail, ErrMsg)
                            If DTDetail.Rows.Count > 0 Then
                                For x = 0 To DTDetail.Rows.Count - 1
                                    OrdersInFrm.GridView.Rows.Add(DTDetail.Rows(x)("warna"), DTDetail.Rows(x)("ukuran"), DTDetail.Rows(x)("Jenis"), DTDetail.Rows(x)("Jumlah"), DTDetail.Rows(x)("Catatan"))
                                Next
                            End If
                            OrdersInFrm.Show()
                        End If
                    Else
                        SQL = "Select * From Barang_Keluar_H Where 1=1 And ID = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                        GetDataTable(SQL, DTOrder, ErrMsg)
                        If DTOrder.Rows.Count > 0 Then
                            OrdersOutFrm.EditMode = True
                            OrdersOutFrm.BtnHTambah.Text = "Edit"
                            OrdersOutFrm.NextID = toval(GridView.Rows(e.RowIndex).Cells(0).Value)
                            OrdersOutFrm.DTP.Value = DTOrder.Rows(0)("Tanggal_Transaksi")
                            OrdersOutFrm.TxtSJ.Text = DTOrder.Rows(0)("Surat_Jalan")
                            OrdersOutFrm.LstRefNota.Text = IIf(IsDBNull(DTOrder.Rows(0)("pSurat_Jalan")), "", DTOrder.Rows(0)("pSurat_Jalan"))
                            OrdersOutFrm.LstJenisHarga.Text = DTOrder.Rows(0)("Tipe_Harga")
                            OrdersOutFrm.txtidpembeli.Text = DTOrder.Rows(0)("ID_Pembeli")
                            OrdersOutFrm.TxtNamaPembeli.Text = DTOrder.Rows(0)("Nama_Pembeli")
                            OrdersOutFrm.TxtPenerima.Text = DTOrder.Rows(0)("Nama_Penerima")
                            OrdersOutFrm.LstPembayaran.Text = DTOrder.Rows(0)("Jenis_Bayar")
                            OrdersOutFrm.TxtTempo.Text = DTOrder.Rows(0)("Periode_Kredit")
                            OrdersOutFrm.TxtTempoDate.Text = DTOrder.Rows(0)("JatuhTempo_Kredit")
                            OrdersOutFrm.TxtBiayaKirim.Text = DTOrder.Rows(0)("Biaya_Kirim")
                            SQL = "Select * From Barang_Keluar_D Where 1=1 And ID_Referensi = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                            GetDataTable(SQL, DTDetail, ErrMsg)
                            If DTDetail.Rows.Count > 0 Then
                                For x = 0 To DTDetail.Rows.Count - 1
                                    OrdersOutFrm.GridView.Rows.Add(DTDetail.Rows(x)("warna"), DTDetail.Rows(x)("ukuran"), DTDetail.Rows(x)("Jenis"), DTDetail.Rows(x)("Jumlah"), DTDetail.Rows(x)("Catatan"))
                                Next
                            End If
                            OrdersOutFrm.Show()
                        End If
                    End If
                Else
                    MessageBox.Show("User Tidak Bisa Akses")
                End If
            End If
        Else
            Dim BtnQryD1 As Integer = GridView.ColumnCount - 1
            If e.ColumnIndex = BtnQryD1 Then
                Dim SQL As String = ""

                If TabPage = "TP1" Then
                    SQL = "Select * From Barang_Masuk_D Where 1 = 1 And ID_Referensi = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                ElseIf TabPage = "TP2" Then
                    SQL = "Select * From Barang_Keluar_D Where 1 = 1 And ID_Referensi = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                ElseIf TabPage = "TP3" Then
                    SQL = "Select * From Retur_D Where 1 = 1 And ID_Referensi = " & toval(GridView.Rows(e.RowIndex).Cells(0).Value) & ""
                End If

                QueryD1Frm.d1SQL = SQL
                QueryD1Frm.Show()
            End If
        End If

    End Sub

    Private Sub CmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExcel.Click
        If GridView.RowCount = 0 Then Exit Sub

        Dim APP As New Excel.Application
        Dim worksheet As Excel.Worksheet
        Dim workbook As Excel.Workbook
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim sd As New SaveFileDialog
        Dim columnsCount As Integer

        If TabPage = "TP1" Then
            columnsCount = GridView.Columns.Count - 2
        ElseIf TabPage = "TP2" Then
            columnsCount = GridView.Columns.Count - 1
        Else
            columnsCount = GridView.Columns.Count - 1
        End If

        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

        workbook = APP.Workbooks.Add()
        worksheet = workbook.Worksheets("sheet1")

        For Each column In GridView.Columns
            If column.Name <> "CmdQDet" And column.Name <> "CmdEdit" And column.Name <> "CmdHistory" Then
                worksheet.Cells(1, column.Index + 1).Value = column.Name
            End If
        Next
        For i As Integer = 0 To GridView.Rows.Count - 1
            Dim columnIndex As Integer = 0
            Do Until columnIndex = columnsCount
                worksheet.Cells(i + 2, columnIndex + 1).Value = GridView.Item(columnIndex, i).Value.ToString
                columnIndex += 1
            Loop
        Next
        If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
            workbook.SaveAs(sd.FileName & ".xls")
            workbook.Close()
            MessageBox.Show("Save Excel Berhasil", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            APP.Quit()
        Else
            APP.Quit()
        End If
    End Sub
End Class
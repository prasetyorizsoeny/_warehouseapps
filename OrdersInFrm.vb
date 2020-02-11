Imports System.Globalization
Imports System.Threading

Public Class OrdersInFrm
    Dim Mode As String
    Dim Row_Index As Integer
    Public EditMode As Boolean = False
    Public NextID As Double

    Sub TxtD_Mod(ByVal Mode As Boolean)
        TxtWarna.Enabled = Mode
        LstTipe.Enabled = Mode
        LstJenis.Enabled = Mode
        txtjml.Enabled = Mode
        TxtKeterangan.Enabled = Mode
    End Sub

    Sub TxtH_Mod(ByVal Mode As Boolean)
        DTPO.Enabled = Mode
        TxtPo.Enabled = Mode
        TxtDO.Enabled = Mode
        TxtSJ.Enabled = Mode
        TxtDocNo.Enabled = Mode
        TxtNmSpr.Enabled = Mode
        TxtNmPgr.Enabled = Mode
        TxtPlatNo.Enabled = Mode
        TxtAlmt.Enabled = Mode
        TxtStpm.Enabled = Mode
        txtmkt.Enabled = Mode
        TxtGM.Enabled = Mode
        TxtAlmtCbg.Enabled = Mode
    End Sub

    Sub ClearH()
        DTPO.Value = Date.Now
        TxtSJ.Text = ""
        TxtPO.Text = ""
        TxtDO.Text = ""
        TxtDocNo.Text = ""
        TxtNmSpr.Clear()
        TxtNmPgr.Clear()
        TxtPlatNo.Clear()
        TxtAlmt.Clear()
        TxtStpm.Clear()
        txtmkt.Clear()
        TxtGM.Clear()
        TxtAlmtCbg.Clear()
    End Sub

    Sub ClearD()
        TxtWarna.SelectedIndex = -1
        LstTipe.SelectedIndex = -1
        LstJenis.SelectedIndex = -1
        txtjml.Clear()
        TxtKeterangan.Clear()
    End Sub

    Private Function Error_Field() As Boolean
        Dim Error_Msg As String = ""

        If TxtPo.Text = "" Then
            TxtPo.Focus()
            Error_Msg = "No PO Wajib Diisi"
            GoTo Error_Message
        End If

        If TxtDO.Text = "" Then
            TxtDO.Focus()
            Error_Msg = "No DO Wajib Diisi"
            GoTo Error_Message
        End If

        If TxtDocNo.Text = "" Then
            TxtDocNo.Focus()
            Error_Msg = "No DocNo Wajib Diisi"
            GoTo Error_Message
        End If

        If TxtSJ.Text = "" Then
            TxtSJ.Focus()
            Error_Msg = "Surat Jalan Wajib Diisi"
            GoTo Error_Message
        End If

        Dim DT As New DataTable
        SQL = "SELECT No_DocNo FROM Barang_Masuk_H Where No_DocNo = '" & TxtDocNo.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("Buat Nomor Document Baru", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDocNo.Focus()
            TxtDocNo.Text = ""
            Exit Function
        End If
        DT.Clear()

        SQL = "SELECT No_DO FROM Barang_Masuk_H Where No_DO = '" & TxtDO.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("Buat Nomor DO Baru", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDO.Focus()
            TxtDO.Text = ""
            Exit Function
        End If
        DT.Clear()

        SQL = "SELECT No_PO FROM Barang_Masuk_H Where No_PO = '" & TxtPO.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("Buat Nomor PO Baru", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPO.Focus()
            TxtPO.Text = ""
            Exit Function
        End If
        DT.Clear()

        SQL = "SELECT Surat_Jalan FROM Barang_Masuk_H Where Surat_Jalan = '" & TxtSJ.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("Buat Surat Jalan Baru", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtSJ.Focus()
            TxtSJ.Text = ""
            Exit Function
        End If

        Error_Field = False
        Exit Function
Error_Message:
        Error_Field = True
        MsgBox(Error_Msg)
    End Function

    Private Sub OrdersInFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        TxtH_Mod(False)
        TxtD_Mod(False)
        BtnSimpan.Enabled = False
        BtnDTambah.Enabled = False
        BtnBatal.Enabled = False
        BtnHapus.Enabled = False

        Dim DT As New DataTable
        TxtWarna.Items.Clear()
        SQL = "SELECT Distinct Warna FROM Produk order by Warna"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i)("Warna").ToString <> "" Then
                TxtWarna.Items.Add(DT.Rows(i)("Warna"))
            End If
        Next
        TxtWarna.SelectedIndex = -1
        DT.Clear()

        TxtPO.Items.Clear()
        SQL = "SELECT No_PO FROM Barang_Masuk_H"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i)("No_PO").ToString <> "" Then
                TxtPO.Items.Add(DT.Rows(i)("No_PO"))
            End If
        Next
        TxtPO.SelectedIndex = -1
        DT.Clear()

        TxtDO.Items.Clear()
        SQL = "SELECT No_PO FROM Barang_Masuk_H"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i)("No_PO").ToString <> "" Then
                TxtDO.Items.Add(DT.Rows(i)("No_PO"))
            End If
        Next
        TxtDO.SelectedIndex = -1
        DT.Clear()

        TxtDocNo.Items.Clear()
        SQL = "SELECT No_DocNo FROM Barang_Masuk_H"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i)("No_DocNo").ToString <> "" Then
                TxtDocNo.Items.Add(DT.Rows(i)("No_DocNo"))
            End If
        Next
        TxtDocNo.SelectedIndex = -1
        DT.Clear()

        TxtSJ.Items.Clear()
        SQL = "SELECT Surat_Jalan FROM Barang_Masuk_H"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i)("Surat_Jalan").ToString <> "" Then
                TxtSJ.Items.Add(DT.Rows(i)("Surat_Jalan"))
            End If
        Next
        TxtSJ.SelectedIndex = -1
        DT.Clear()

        Dim total As Double = 0

        For Each row As DataGridViewRow In GridView.Rows
            total += row.Cells(3).Value
            txtsumqty.Text = total
        Next
    End Sub

    Private Sub BtnHTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHTambah.Click
        BtnHTambah.Enabled = False
        BtnDTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnSimpan.Enabled = True
        BtnBatal.Enabled = True

        TxtH_Mod(True)
        TxtD_Mod(True)
        If Not EditMode Then ClearH()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        GC.Collect()
        Me.Dispose()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim DT As New DataTable

        If Error_Field() Then Exit Sub

        If BtnHTambah.Text = "Buat Baru" Then
            SQL = "SELECT Top 1 ID from Barang_Masuk_H order by ID Desc"
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count = 0 Then
                NextID = 1
            Else
                NextID = toval(DT.Rows(0)(0)) + 1
            End If

            SQL = "INSERT INTO Barang_Masuk_H VALUES(" & NextID & ", '" & Format(todate(DTPO.Value), "MM/dd/yyyy") & "', '" & tostr(TxtPO.Text) & "', '" & tostr(TxtDO.Text) & "' , '" & tostr(TxtDocNo.Text) & "', '" & tostr(TxtSJ.Text) & "', '" & tostr(TxtNmPgr.Text) & "','" & tostr(TxtPlatNo.Text) & "','" & tostr(TxtAlmt.Text) & "', '" & UserId & "', '" & tostr(TxtStpm.Text) & "','" & tostr(TxtNmSpr.Text) & "','" & tostr(txtmkt.Text) & "','" & tostr(TxtGM.Text) & "', '" & tostr(TxtAlmtCbg.Text) & "', " & toval(IIf(txtsumqty.Text = "", 0, txtsumqty.Text)) & ", '" & Format(todate(Today.Date), "MM/dd/yyyy") & "','" & UserId & "')"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If

            For i = 0 To GridView.Rows.Count - 1
                SQL = "INSERT INTO Barang_Masuk_D (ID_Referensi, jenis, warna, ukuran, Jumlah, Catatan) VALUES ('" & NextID & "','" & tostr(GridView.Rows(i).Cells("jenis").Value) & "','" & tostr(GridView.Rows(i).Cells("warna").Value) & "','" & tostr(GridView.Rows(i).Cells("Ukuran").Value) & "','" & toval(GridView.Rows(i).Cells("Jumlah").Value) & "','" & tostr(GridView.Rows(i).Cells("Catatan").Value) & "')"
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If

                SQL = "Update produk Set Tanggal_Update = '" & Format(todate(Today.Date), "MM/dd/yyyy") & "', User_Update = '" & UserId & "', Jumlah = Jumlah+" & toval(GridView.Rows(i).Cells("Jumlah").Value) & " Where Jenis = '" & tostr(GridView.Rows(i).Cells("Jenis").Value) & "' And Warna = '" & tostr(GridView.Rows(i).Cells("warna").Value) & "' and ukuran = '" & tostr(GridView.Rows(i).Cells("Ukuran").Value) & "'"
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If
            Next

            SQL = "UPDATE Barang_Masuk_H SET Total_Jumlah = " & toval(txtsumqty.Text) & " where ID = " & NextID & ""
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If
        Else
            SQL = "Update Barang_Masuk_H Set Tanggal_Transaksi = '" & Format(todate(DTPO.Value), "MM/dd/yyyy") & "',No_PO ='" & tostr(TxtPO.Text) & "',No_DO ='" & tostr(TxtDO.Text) & "',No_DocNo ='" & tostr(TxtDocNo.Text) & "',Surat_Jalan= '" & tostr(TxtSJ.Text) & "',Nama_Pengirim ='" & tostr(TxtNmPgr.Text) & "', No_Plat_Pengirim ='" & tostr(TxtPlatNo.Text) & "',Alamat_Pengirim ='" & tostr(TxtAlmt.Text) & "',ID_Petugas ='" & UserId & "',Nama_Satpam ='" & tostr(TxtStpm.Text) & "',Nama_Supir ='" & tostr(TxtNmSpr.Text) & "',Nama_Marketing ='" & tostr(txtmkt.Text) & "',Nama_GM ='" & tostr(TxtGM.Text) & "', Alamat_Cabang ='" & tostr(TxtAlmtCbg.Text) & "', Total_Jumlah =" & toval(IIf(txtsumqty.Text = "", 0, txtsumqty.Text)) & ",Tanggal_Update= '" & Format(todate(Today.Date), "MM/dd/yyyy") & "',User_Update ='" & UserId & "' Where ID = " & NextID & ""
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If

            For i = 0 To GridView.Rows.Count - 1
                SQL = "Delete From Barang_Masuk_D Where ID_Referensi = " & NextID & ""
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If

                SQL = "INSERT INTO Barang_Masuk_D (ID_Referensi, jenis, warna, ukuran, Jumlah, Catatan) VALUES ('" & NextID & "','" & tostr(GridView.Rows(i).Cells("jenis").Value) & "','" & tostr(GridView.Rows(i).Cells("warna").Value) & "','" & tostr(GridView.Rows(i).Cells("Ukuran").Value) & "','" & toval(GridView.Rows(i).Cells("Jumlah").Value) & "','" & tostr(GridView.Rows(i).Cells("Catatan").Value) & "')"
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If

                SQL = "Update produk Set Tanggal_Update = '" & Format(todate(Today.Date), "MM/dd/yyyy") & "', User_Update = '" & UserId & "', Jumlah = Jumlah+" & toval(GridView.Rows(i).Cells("Jumlah").Value) & " Where Warna = '" & tostr(GridView.Rows(i).Cells(1).Value) & "' and ukuran = '" & tostr(GridView.Rows(i).Cells(2).Value) & "' and Jenis = '" & tostr(GridView.Rows(i).Cells(0).Value) & "'"
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If
            Next

            SQL = "UPDATE Barang_Masuk_H SET Total_Jumlah = " & toval(txtsumqty.Text) & " where ID = " & NextID & ""
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If
        End If


        BtnHTambah.Enabled = True
        BtnDTambah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = False
        BtnBatal.Enabled = True

        MsgBox("Data sudah tersimpan")

        TxtH_Mod(False)
        TxtD_Mod(False)
        txtsumqty.Clear()

        ClearH()
        ClearD()

        GridView.Rows.Clear()
    End Sub

    Private Sub BtnDTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDTambah.Click
        If TxtWarna.Text = "" Then
            MessageBox.Show("Warna harus diisi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim DT As New DataTable
        SQL = "Select * From produk Where Jenis = '" & LstJenis.Text & "' And Warna = '" & TxtWarna.Text & "' And Ukuran = '" & LstTipe.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("Warna, Jenis dan Ukuran tidak ada")
            Exit Sub
        End If

        GridView.Rows.Add(TxtWarna.Text, LstTipe.Text, LstJenis.Text, toval(txtjml.Text), TxtKeterangan.Text)
        ClearD()

        Dim total As Double = 0

        For Each row As DataGridViewRow In GridView.Rows
            total += row.Cells(3).Value
            txtsumqty.Text = total
        Next
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If GridView.Rows.Count = 0 Then Exit Sub
        Dim RowSelected As Integer = GridView.CurrentCell.RowIndex
        GridView.Rows.RemoveAt(RowSelected)

        Dim total As Double = 0

        For Each row As DataGridViewRow In GridView.Rows
            total += row.Cells(3).Value
            txtsumqty.Text = total
        Next
    End Sub

    Private Sub GridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView.CellClick
        If e.RowIndex = -1 Then Exit Sub
        TxtWarna.Text = tostr(GridView.Rows(e.RowIndex).Cells("warna").Value)
        LstTipe.Text = tostr(GridView.Rows(e.RowIndex).Cells("ukuran").Value)
        LstJenis.Text = tostr(GridView.Rows(e.RowIndex).Cells("jenis").Value)
        txtjml.Text = toval(GridView.Rows(e.RowIndex).Cells("Jumlah").Value)
        TxtKeterangan.Text = tostr(GridView.Rows(e.RowIndex).Cells("catatan").Value)
        Row_Index = e.RowIndex
    End Sub

    Private Sub TxtWarna_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtWarna.TextChanged
        Dim DT As New DataTable

        LstJenis.Items.Clear()
        SQL = "SELECT Distinct Jenis FROM Produk Where Warna = '" & TxtWarna.Text & "' order by Jenis"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i)("Jenis").ToString <> "" Then
                LstJenis.Items.Add(DT.Rows(i)("Jenis"))
            End If
        Next

        LstTipe.Items.Clear()
        SQL = "SELECT Distinct Ukuran FROM Produk Where Warna = '" & TxtWarna.Text & "' order by Ukuran"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i)("Ukuran").ToString <> "" Then
                LstTipe.Items.Add(DT.Rows(i)("Ukuran"))
            End If
        Next
    End Sub

    Private Sub txtjml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjml.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
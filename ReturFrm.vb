Imports System.Globalization
Imports System.Threading

Public Class ReturFrm
    Dim Row_Index As Integer
    Dim DTTemp As New DataTable

    Private Sub ReturFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        DGVRetur.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DGVRetur.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DGVRetur.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DGVRetur.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DGVRetur.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

        DTP.Value = Today.Date
    End Sub

    Private Sub BtnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampil.Click
        Dim DT As New DataTable

        If CbxJenis.Text = "Barang Masuk" Then
            SQL = "SELECT D.Warna, D.Ukuran, D.Jumlah, D.Jumlah as Sisa, D.Harga, D.Jenis, D.Ukuran FROM Barang_Masuk_H H, Barang_Masuk_D D where H.ID = D.ID_Referensi and H.Surat_Jalan ='" & CbxSuratJalan.Text & "'"
            GetDataTable(SQL, DT, ErrMsg)
            DGVItem.DataSource = DT
            DGVItem.Refresh()

            If DT.Rows.Count <> 0 Then
                CbxJenis.Enabled = False
                CbxSuratJalan.Enabled = False
                DGVItem.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            Else
                MsgBox("Nomor Surat Jalan tidak ditemukan atau tidak ada item pada Nomor Surat Jalan ini")
                Exit Sub
            End If
        ElseIf CbxJenis.Text = "Barang Keluar" Then
            SQL = "SELECT * FROM Barang_Keluar_H where Surat_Jalan ='" & CbxSuratJalan.Text & "'"
            GetDataTable(SQL, DTTemp, ErrMsg)

            SQL = "SELECT D.Warna, D.Ukuran, (D.Jumlah - D.Jumlah_terjual) as Jumlah, (D.Jumlah - D.Jumlah_terjual) as Sisa, Harga , D.Jenis, D.Ukuran FROM Barang_Keluar_H H, Barang_Keluar_D D where H.ID = D.ID_Referensi and H.Surat_Jalan ='" & CbxSuratJalan.Text & "'"
            GetDataTable(SQL, DT, ErrMsg)
            DGVItem.DataSource = DT
            DGVItem.Refresh()

            If DT.Rows.Count <> 0 Then
                CbxJenis.Enabled = False
                CbxSuratJalan.Enabled = False
                DGVItem.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                DGVItem.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            Else
                MsgBox("Nomor Surat Jalan tidak ditemukan atau tidak ada item pada Nomor Surat Jalan ini")
                Exit Sub
            End If
        Else
            MsgBox("Pilih Jenis Retur")
        End If
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        Dim RowSelected As Integer

        If DGVItem.Rows.Count <= 0 Then Exit Sub

        RowSelected = DGVItem.CurrentCell.RowIndex
        If DGVItem.Rows(RowSelected).Cells(0).Style.BackColor = Color.LightSkyBlue Then
            MsgBox("Item ini sudah ada di list Retur")
            Exit Sub
        End If

        DGVRetur.Rows.Add(DGVItem.Rows(RowSelected).Cells("warna").Value, DGVItem.Rows(RowSelected).Cells("Ukuran").Value, DGVItem.Rows(RowSelected).Cells("Jumlah").Value, "", "", RowSelected)
        TxtWarna.Text = tostr(DGVRetur.Rows(DGVRetur.Rows.Count - 1).Cells("warna").Value)
        TxtUkuran.Text = tostr(DGVRetur.Rows(DGVRetur.Rows.Count - 1).Cells("Ukuran").Value)
        TxtJumlah.Text = toval(DGVRetur.Rows(DGVRetur.Rows.Count - 1).Cells("Jumlah").Value)
        TxtKeterangan.Text = tostr(DGVRetur.Rows(DGVRetur.Rows.Count - 1).Cells("Catatan").Value)

        DGVItem.Rows(RowSelected).Cells(3).Value = 0

        DGVItem.Rows(RowSelected).Cells(0).Style.BackColor = Color.LightSkyBlue
        DGVItem.Rows(RowSelected).Cells(1).Style.BackColor = Color.LightSkyBlue
        DGVItem.Rows(RowSelected).Cells(2).Style.BackColor = Color.LightSkyBlue
        DGVItem.Rows(RowSelected).Cells(3).Style.BackColor = Color.LightSkyBlue
        DGVItem.Rows(RowSelected).Cells(4).Style.BackColor = Color.LightSkyBlue
        DGVItem.Rows(RowSelected).Cells(5).Style.BackColor = Color.LightSkyBlue
        DGVItem.Rows(RowSelected).Cells(6).Style.BackColor = Color.LightSkyBlue

        Row_Index = DGVRetur.Rows.Count - 1
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Dim RowSelected As Integer
        Dim OrderNo As Integer
        If DGVRetur.Rows.Count <= 0 Then Exit Sub

        RowSelected = DGVRetur.CurrentCell.RowIndex
        OrderNo = DGVRetur.Rows(RowSelected).Cells("OrderNo").Value

        DGVItem.Rows(OrderNo).Cells("Sisa").Value() = toval(DGVItem.Rows(RowSelected).Cells("Jumlah").Value)
        DGVItem.Rows(OrderNo).Cells(0).Style.BackColor = Color.White
        DGVItem.Rows(OrderNo).Cells(1).Style.BackColor = Color.White
        DGVItem.Rows(OrderNo).Cells(2).Style.BackColor = Color.White
        DGVItem.Rows(OrderNo).Cells(3).Style.BackColor = Color.White
        DGVItem.Rows(OrderNo).Cells(4).Style.BackColor = Color.White
        DGVItem.Rows(OrderNo).Cells(5).Style.BackColor = Color.White
        DGVItem.Rows(OrderNo).Cells(6).Style.BackColor = Color.White
        DGVRetur.Rows.RemoveAt(RowSelected)

        If DGVRetur.Rows.Count = 0 Then
            TxtWarna.Text = ""
            TxtUkuran.Text = ""
            TxtJumlah.Text = "0"
            TxtKeterangan.Text = ""
        Else
            TxtWarna.Text = tostr(DGVRetur.Rows(DGVRetur.Rows.Count - 1).Cells("warna").Value)
            TxtUkuran.Text = tostr(DGVRetur.Rows(DGVRetur.Rows.Count - 1).Cells("Ukuran").Value)
            TxtJumlah.Text = toval(DGVRetur.Rows(DGVRetur.Rows.Count - 1).Cells("Jumlah").Value)
            TxtKeterangan.Text = tostr(DGVRetur.Rows(DGVRetur.Rows.Count - 1).Cells("Catatan").Value)
        End If

    End Sub

    Private Sub DGVRetur_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVRetur.CellClick
        If e.RowIndex = -1 Then Exit Sub
        TxtWarna.Text = tostr(DGVRetur.Rows(e.RowIndex).Cells("warna").Value)
        TxtUkuran.Text = tostr(DGVRetur.Rows(e.RowIndex).Cells("Ukuran").Value)
        TxtJumlah.Text = toval(DGVRetur.Rows(e.RowIndex).Cells("Jumlah").Value)
        TxtKeterangan.Text = tostr(DGVRetur.Rows(e.RowIndex).Cells("Catatan").Value)

        Row_Index = e.RowIndex
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim RowSelected As Integer

        RowSelected = DGVRetur.Rows(Row_Index).Cells("OrderNo").Value()

        If Not IsNumeric(TxtJumlah.Text) Or toval(TxtJumlah.Text) <= 0 Then
            MsgBox("Jumlah harus diisi dengan angka yang lebih besar dari 0")
            Exit Sub
        ElseIf TxtJumlah.Text > DGVItem.Rows(RowSelected).Cells("Jumlah").Value() Then
            MsgBox("Jumlah Retur harus lebih kecil dari jumlah item")
            Exit Sub
        ElseIf CbxKondisi.Text = "" Then
            MsgBox("Kondisi Retur harus diisi")
            Exit Sub
        End If

        DGVItem.Rows(RowSelected).Cells("Sisa").Value() = toval(DGVItem.Rows(RowSelected).Cells("Jumlah").Value) - toval(TxtJumlah.Text)
        DGVRetur.Rows(Row_Index).Cells("Jumlah").Value() = TxtJumlah.Text
        DGVRetur.Rows(Row_Index).Cells("Catatan").Value() = TxtKeterangan.Text
        DGVRetur.Rows(Row_Index).Cells("Kondisi").Value() = CbxKondisi.Text
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim DT As New DataTable
        Dim NextID As Double

        If DGVRetur.Rows.Count = 0 Then
            MsgBox("Item yang di retur belum diinput")
            Exit Sub
        End If
        If TxtNota.Text = "" Then
            MsgBox("Nomor nota baru, belum diinput")
            Exit Sub
        End If

        For i = 0 To DGVRetur.Rows.Count - 1
            If DGVRetur.Rows(i).Cells("Kondisi").Value = "" Then
                MsgBox("Kondisi untuk item ke '" & i + 1 & "' belum diinput")
                Exit Sub
            End If
        Next

        SQL = "SELECT Top 1 ID from Retur_H order by ID Desc"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then
            NextID = 1
        Else
            NextID = toval(DT.Rows(0)(0)) + 1
        End If

        SQL = "INSERT INTO Retur_H VALUES('" & NextID & "', '" & DTP.Value & "','" & CbxJenis.Text & "','" & UserId & "','" & CbxSuratJalan.Text & "','" & Today.Date & "','" & UserId & "')"
        If Not ExecuteSQL(SQL, ErrMsg) Then
            MsgBox(ErrMsg)
            Exit Sub
        End If

        For i = 0 To DGVRetur.Rows.Count - 1
            SQL = "INSERT INTO Retur_D (ID_Referensi, warna, jumlah, ukuran, catatan) VALUES ('" & NextID & "','" & tostr(DGVRetur.Rows(i).Cells("warna").Value) & "','" & toval(DGVRetur.Rows(i).Cells("Jumlah").Value) & "','" & tostr(DGVRetur.Rows(i).Cells("Ukuran").Value) & "','" & TxtKeterangan.Text & "')"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If

            If CbxJenis.Text = "Barang Masuk" Then
                If tostr(DGVRetur.Rows(i).Cells("kondisi").Value) = "Barang tidak laku" Then
                    SQL = "UPDATE produk SET jumlah = jumlah - '" & toval(DGVRetur.Rows(i).Cells("Jumlah").Value) & "' where warna = '" & tostr(DGVRetur.Rows(i).Cells("warna").Value) & "' and ukuran = '" & tostr(DGVRetur.Rows(i).Cells("Ukuran").Value) & "'"
                    If Not ExecuteSQL(SQL, ErrMsg) Then
                        MsgBox(ErrMsg)
                        Exit Sub
                    End If
                End If
            ElseIf CbxJenis.Text = "Barang Keluar" Then
                If tostr(DGVRetur.Rows(i).Cells("kondisi").Value) = "Barang tidak laku" Then
                    SQL = "UPDATE produk SET jumlah = jumlah + '" & toval(DGVRetur.Rows(i).Cells("Jumlah").Value) & "' where warna = '" & tostr(DGVRetur.Rows(i).Cells("warna").Value) & "' and ukuran = '" & tostr(DGVRetur.Rows(i).Cells("Ukuran").Value) & "'"
                    If Not ExecuteSQL(SQL, ErrMsg) Then
                        MsgBox(ErrMsg)
                        Exit Sub
                    End If
                End If
            End If
        Next

        If CbxJenis.Text = "Barang Keluar" Then
            SQL = "SELECT Top 1 ID from Barang_Keluar_H order by ID Desc"
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count = 0 Then
                NextID = 1
            Else
                NextID = toval(DT.Rows(0)(0)) + 1
            End If

            SQL = "INSERT INTO Barang_Keluar_H VALUES(" & NextID & ", '" & Format(todate(DTP.Value), "MM/dd/yyyy") & "', '" & TxtNota.Text & "', '" & UserId & "', '" & DTTemp.Rows(0)("ID_Pembeli") & "','" & DTTemp.Rows(0)("Nama_Pembeli") & "' , '" & DTTemp.Rows(0)("Jenis_Bayar") & "', " & DTTemp.Rows(0)("Periode_Kredit") & ", '" & Format(todate(DTTemp.Rows(0)("JatuhTempo_Kredit")), "MM/dd/yyyy") & "','" & DTTemp.Rows(0)("Tipe_Harga") & "', " & DTTemp.Rows(0)("Total_Jumlah") & ", " & DTTemp.Rows(0)("Total_Harga") & ", " & toval(DTTemp.Rows(0)("Biaya_Kirim")) & ", '" & Format(todate(Today.Date), "MM/dd/yyyy") & "','" & UserId & "','" & DTTemp.Rows(0)("Nama_Penerima") & "', '" & CbxSuratJalan.Text & "', '" & DTTemp.Rows(0)("oSurat_Jalan") & "',0)"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If

            Dim TotalQty As Double = 0
            Dim TotalHarga As Double = 0

            For i = 0 To DGVItem.Rows.Count - 1
                SQL = "INSERT INTO Barang_Keluar_D (ID_Referensi, warna, ukuran, jenis, Jumlah, Harga, Catatan, konsinyasiF) VALUES ('" & NextID & "','" & tostr(DGVItem.Rows(i).Cells(0).Value) & "','" & tostr(DGVItem.Rows(i).Cells("Ukuran").Value) & "','" & tostr(DGVItem.Rows(i).Cells("Jenis").Value) & "','" & toval(DGVItem.Rows(i).Cells("Sisa").Value) & "','" & tostr(DGVItem.Rows(i).Cells("Harga").Value) & "','',True)"
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If

                TotalQty = TotalQty + DGVItem.Rows(i).Cells("Sisa").Value
                TotalHarga = TotalHarga + (DGVItem.Rows(i).Cells("Sisa").Value * DGVItem.Rows(i).Cells("Harga").Value)
            Next

            SQL = "UPDATE Barang_Keluar_H SET Total_Jumlah = " & toval(TotalQty) & ", Total_Harga = " & toval(TotalHarga) & " where ID = " & NextID & ""
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If
        End If

        MsgBox("Data berhasil disimpan")
        Clear()
    End Sub
    Private Sub Clear()
        DTP.Value = Today.Date
        CbxJenis.Enabled = True
        CbxJenis.Text = ""
        CbxSuratJalan.Items.Clear()
        CbxSuratJalan.Text = ""
        CbxSuratJalan.Enabled = True
        TxtWarna.Text = ""
        TxtUkuran.Text = ""
        TxtJumlah.Text = ""
        TxtKeterangan.Text = ""

        DGVItem.DataSource = Nothing
        DGVRetur.Rows.Clear()

        BtnTampil.Enabled = True
        BtnSimpan.Enabled = True
    End Sub
    Private Sub CbxJenis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxJenis.SelectedIndexChanged
        Dim DT As New DataTable

        CbxSuratJalan.Items.Clear()
        If CbxJenis.Text = "Barang Masuk" Then
            SQL = "SELECT Distinct Surat_Jalan FROM Barang_Masuk_H order by surat_jalan Desc"
        ElseIf CbxJenis.Text = "Barang Keluar" Then
            SQL = "Select Distinct Surat_Jalan from Barang_Keluar_H where surat_Jalan not in (Select pSurat_Jalan from Barang_Keluar_H) order by surat_jalan Desc"
        End If

        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            CbxSuratJalan.Items.Add(DT.Rows(i)("Surat_Jalan"))
        Next
    End Sub

    Private Sub TxtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJumlah.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
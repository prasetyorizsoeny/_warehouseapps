Imports System.Globalization
Imports System.Threading

Public Class OrdersOutFrm
    Public EditMode As Boolean = False
    Public NextID As Double
    Dim Row_Index As Integer
    Dim OriginalNota As String

    Sub TxtD_Mod(ByVal Mode As Boolean)
        LstJenis.Enabled = Mode
        TxtWarna.Enabled = Mode
        LstTipe.Enabled = Mode
        TxtJml.Enabled = Mode
        TxtKeterangan.Enabled = Mode
        TxtHarga.Enabled = Mode
    End Sub

    Sub TxtH_Mod(ByVal Mode As Boolean)
        DTP.Enabled = Mode
        TxtSJ.Enabled = Mode
        TxtTempo.Enabled = Mode
        TxtPenerima.Enabled = Mode
        LinkPembeli.Enabled = Mode
        LstJenisHarga.Enabled = Mode
        LstPembayaran.Enabled = Mode
        TxtBiayaKirim.Enabled = Mode
        LstRefNota.Enabled = Mode
    End Sub

    Sub ClearH()
        DTP.Value = Date.Now
        TxtSJ.Text = ""
        TxtPenerima.Clear()
        txtidpembeli.Clear()
        TxtNamaPembeli.Clear()
        TxtTempo.Clear()
        TxtHarga.Text = "0"
        LstJenisHarga.Text = ""
        LstPembayaran.Text = ""
        LstRefNota.Text = ""
        TxtBiayaKirim.Clear()
    End Sub

    Sub ClearD()
        LstJenis.SelectedIndex = -1
        TxtWarna.SelectedIndex = -1
        LstTipe.SelectedIndex = -1
        TxtJml.Clear()
        TxtByr.Clear()
        TxtKeterangan.Clear()
        TxtSisa.Clear()
    End Sub

    Private Function Error_Field() As Boolean
        Dim Error_Msg As String = ""

        If TxtSJ.Text = "" Then
            TxtSJ.Focus()
            Error_Msg = "Nomor Nota Wajib Diisi"
            GoTo Error_Message
        End If

        If TxtNamaPembeli.Text = "" Then
            LinkPembeli.Focus()
            Error_Msg = "Pembeli Wajib Diisi"
            GoTo Error_Message
        End If

        Dim DT As New DataTable
        SQL = "SELECT Surat_Jalan FROM Barang_Keluar_H Where Surat_Jalan = '" & TxtSJ.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count > 0 Then
            TxtSJ.Focus()
            Error_Msg = "Buat Nomor Nota Baru"
            TxtSJ.Text = ""
            GoTo Error_Message
        End If

        If GridView.Rows.Count = 0 Then
            Error_Msg = "Item belum diinput"
            GoTo Error_Message
        End If

        Error_Field = False
        Exit Function
Error_Message:
        Error_Field = True
        MsgBox(Error_Msg)
    End Function

    Private Sub OrdersOutFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        TxtH_Mod(False)
        TxtD_Mod(False)
        BtnDTambah.Enabled = False
        BtnSimpan.Enabled = False
        BtnBatal.Enabled = False
        BtnHapus.Enabled = False

        Dim DT As New DataTable

        TxtWarna.Items.Clear()
        SQL = "SELECT Distinct Warna FROM Produk Where Jumlah > 0 order by Warna"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            If DT.Rows(i)("Warna").ToString <> "" Then
                TxtWarna.Items.Add(DT.Rows(i)("Warna"))
            End If
        Next
        TxtWarna.SelectedIndex = -1
        DT.Clear()
    End Sub

    Private Sub BtnHTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHTambah.Click
        BtnHTambah.Enabled = True
        BtnDTambah.Enabled = True
        BtnHapus.Enabled = True
        BtnSimpan.Enabled = True
        BtnBatal.Enabled = True

        TxtH_Mod(True)
        TxtD_Mod(True)
        ClearH()
        GridView.Rows.Clear()
        TxtSJ.Focus()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        GC.Collect()
        Me.Dispose()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim DT As New DataTable
        Dim NextID As Double

        If Error_Field() Then Exit Sub

        SQL = "SELECT Top 1 ID from Barang_Keluar_H order by ID Desc"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then
            NextID = 1
        Else
            NextID = toval(DT.Rows(0)(0)) + 1
        End If

        SQL = "INSERT INTO Barang_Keluar_H VALUES(" & NextID & ", '" & Format(todate(DTP.Value), "MM/dd/yyyy") & "', '" & TxtSJ.Text & "', '" & UserId & "', '" & tostr(txtidpembeli.Text) & "','" & TxtNamaPembeli.Text & "' , '" & tostr(LstPembayaran.Text) & "', " & toval(TxtTempo.Text) & ", '" & Format(todate(TxtTempoDate.Text), "MM/dd/yyyy") & "','" & tostr(LstJenisHarga.Text) & "', " & toval(IIf(txtsumqty.Text = "", 0, txtsumqty.Text)) & ", " & toval(IIf(txttotal.Text = "", 0, txttotal.Text)) & ", " & toval(IIf(TxtBiayaKirim.Text = "", 0, TxtBiayaKirim.Text)) & ", '" & Format(todate(Today.Date), "MM/dd/yyyy") & "','" & UserId & "','" & TxtPenerima.Text & "', '" & LstRefNota.Text & "', '" & tostr(IIf(OriginalNota = "", TxtSJ.Text, OriginalNota)) & "',0,0)"
        If Not ExecuteSQL(SQL, ErrMsg) Then
            MsgBox(ErrMsg)
            Exit Sub
        End If

        For i = 0 To GridView.Rows.Count - 1
            SQL = "INSERT INTO Barang_Keluar_D (ID_Referensi, warna, ukuran, jenis, Jumlah, Bayar, Harga, Catatan, konsinyasiF) VALUES ('" & NextID & "','" & tostr(GridView.Rows(i).Cells(0).Value) & "','" & tostr(GridView.Rows(i).Cells(1).Value) & "','" & tostr(GridView.Rows(i).Cells(2).Value) & "','" & toval(GridView.Rows(i).Cells("Jumlah").Value) & "','" & toval(GridView.Rows(i).Cells("Bayar").Value) & "','" & toval(GridView.Rows(i).Cells("Harga").Value) & "','" & tostr(GridView.Rows(i).Cells("Catatan").Value) & "','" & tostr(GridView.Rows(i).Cells("KonsinyasiF").Value) & "')"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If

            If GridView.Rows(i).Cells("konsinyasif").Value <> 1 Then
                SQL = "Update produk Set Jumlah = Jumlah-" & toval(GridView.Rows(i).Cells("Jumlah").Value) & " Where Warna = '" & tostr(GridView.Rows(i).Cells("Warna").Value) & "' and ukuran = '" & tostr(GridView.Rows(i).Cells("ukuran").Value) & "' and Jenis = '" & tostr(GridView.Rows(i).Cells("jenis").Value) & "'"
                If Not ExecuteSQL(SQL, ErrMsg) Then
                    MsgBox(ErrMsg)
                    Exit Sub
                End If
            End If
        Next

        SQL = "UPDATE Barang_Keluar_H SET Total_Jumlah = " & toval(txtsumqty.Text) & ", Total_Harga = " & toval(txttotal.Text) & " where ID = " & NextID & ""
        If Not ExecuteSQL(SQL, ErrMsg) Then
            MsgBox(ErrMsg)
            Exit Sub
        End If

        BtnHTambah.Enabled = True
        BtnDTambah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = False
        BtnBatal.Enabled = True

        MsgBox("Data sudah tersimpan")
        txtsumqty.Clear()
        txttotal.Clear()

        TxtH_Mod(False)
        TxtD_Mod(False)

        ClearH()
        ClearD()

        GridView.Rows.Clear()
    End Sub

    Private Sub TxtTempo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTempo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtTempo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTempo.TextChanged
        If TxtTempo.Text = "" Then
            TxtTempoDate.Clear()
        Else
            TxtTempoDate.Text = todate(DateAdd(DateInterval.Day, toval(TxtTempo.Text), Today.Date))
        End If
    End Sub

    Private Sub BtnDTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDTambah.Click

        If TxtWarna.Text = "" Then
            MessageBox.Show("Warna harus diisi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf LstTipe.Text = "" Then
            MessageBox.Show("Ukuran harus diisi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf LstJenis.Text = "" Then
            MessageBox.Show("Jenis harus diisi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf toval(TxtHarga.Text) = 0 Then
            MessageBox.Show("Harga harus diisi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim DT As New DataTable
        SQL = "Select Jumlah From produk Where Warna = '" & TxtWarna.Text & "' And Ukuran = '" & LstTipe.Text & "' And Jenis = '" & LstJenis.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count <> 0 Then
            If (DT.Rows(0)(0) < toval(TxtJml.Text) Or TxtJml.Text = "") Then
                MessageBox.Show("Stok Tidak Boleh Kosong, Silahkan isi Stok")
                Exit Sub
            End If
        Else
            MessageBox.Show("Produk Tidak Ada")
            Exit Sub
        End If

        GridView.Rows.Add(TxtWarna.Text, LstTipe.Text, LstJenis.Text, toval(TxtJml.Text), toval(TxtHarga.Text), toval(TxtByr.Text), TxtKeterangan.Text, 0, 0)
        ClearD()

        Dim total As Double = 0
        Dim total1 As Double = 0

        For Each row As DataGridViewRow In GridView.Rows
            total += row.Cells(3).Value
            txtsumqty.Text = total
        Next

        For Each row As DataGridViewRow In GridView.Rows
            total1 += row.Cells(5).Value
            txttotal.Text = total1
        Next

        TxtWarna.Enabled = True
        LstTipe.Enabled = True
        LstJenis.Enabled = True
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If GridView.Rows.Count = 0 Then Exit Sub
        Dim RowSelected As Integer = GridView.CurrentCell.RowIndex

        If GridView.Rows(RowSelected).Cells("konsinyasiF").Value = 1 Then
            MsgBox("Item dari nota sebelumnya tidak bisa dihapus")
            Exit Sub
        End If
        GridView.Rows.RemoveAt(RowSelected)

        Dim total As Double = 0
        Dim total1 As Double = 0

        For Each row As DataGridViewRow In GridView.Rows
            total += row.Cells(3).Value
            txtsumqty.Text = total
        Next

        For Each row As DataGridViewRow In GridView.Rows
            total1 += row.Cells(5).Value
            txttotal.Text = total1
        Next
    End Sub

    Private Sub TxtHarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHarga.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtHarga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHarga.TextChanged, TxtJml.TextChanged
        TxtByr.Text = toval(TxtHarga.Text) * toval(TxtJml.Text)
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
        TxtSisa.Clear()
    End Sub

    Private Sub LstJenis_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstJenis.TextChanged, LstTipe.TextChanged, TxtWarna.TextChanged
        Dim DT As New DataTable
        TxtSisa.Clear()
        SQL = "Select Jumlah From Produk Where Warna = '" & TxtWarna.Text & "' And Ukuran = '" & LstTipe.Text & "' And Jenis = '" & LstJenis.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count <> 0 Then
            TxtSisa.Text = IIf(IsDBNull(DT.Rows(0)("Jumlah")), "", DT.Rows(0)("Jumlah") - toval(TxtJml.Text))
        Else
            Exit Sub
        End If
    End Sub

    Private Sub LstPembayaran_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstPembayaran.TextChanged
        If LstPembayaran.SelectedIndex = 0 Then
            TxtTempo.Text = 0
        End If
    End Sub

    Private Sub LinkPembeli_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkPembeli.LinkClicked
        If Not (LstJenisHarga.Text = "" Or LstJenisHarga.SelectedIndex = -1) Then
            SQL = "Select ID, Nama, Harga, Tipe, Alamat, Telepon, Email From Profil Where Tipe = '" & LstJenisHarga.Text & "'"
            FindFrm.SQL = SQL
            FindFrm.ObjFrm = "OrdersOutFrm"
            FindFrm.Show()
            SQL = ""
        Else
            MessageBox.Show("Tipe Harga Harus diisi", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub LstPembayaran_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstPembayaran.SelectedIndexChanged
        If UCase(LstPembayaran.Text) = "KONSINYASI" Then
            Dim DT As New DataTable

            SQL = "Select Distinct Surat_Jalan from Barang_Keluar_H where surat_Jalan not in (Select pSurat_Jalan from Barang_Keluar_H)"
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count <> 0 Then
                BtnKonsinyasi.Enabled = True
                LstRefNota.Enabled = True
                LstRefNota.Items.Clear()

                For i = 0 To DT.Rows.Count - 1
                    LstRefNota.Items.Add(DT.Rows(i)("Surat_Jalan"))
                Next
            End If
        Else
            BtnKonsinyasi.Enabled = False
            LstRefNota.Items.Clear()
            LstRefNota.Enabled = False
        End If
    End Sub

    Private Sub TxtBiayaKirim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBiayaKirim.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtByr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtByr.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BtnKonsinyasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKonsinyasi.Click
        If LstRefNota.Text = "" Then
            MessageBox.Show("Nomor Nota Konsinyasi belum diisi ")
            Exit Sub
        End If

        Dim DT As New DataTable
        Dim DTH As New DataTable

        SQL = "select Distinct * from Barang_Keluar_H where surat_Jalan = '" & LstRefNota.Text & "'"
        GetDataTable(SQL, DTH, ErrMsg)
        If DTH.Rows.Count <> 0 Then
            For y = 0 To DTH.Rows.Count - 1
                LstJenisHarga.Text = DTH.Rows(y)("Tipe_Harga")
                txtidpembeli.Text = DTH.Rows(y)("ID_Pembeli")
                TxtNamaPembeli.Text = DTH.Rows(y)("Nama_Pembeli")
            Next

            SQL = "Select ID, Warna, Ukuran, Jenis, Jumlah-Jumlah_Terjual As Jumlah, ((Jumlah-Jumlah_Terjual) * Harga) As Bayar, Harga, Catatan from Barang_Keluar_D where (Jumlah-Jumlah_Terjual) <> 0 And ID_Referensi in (select ID from Barang_Keluar_H where surat_Jalan = '" & LstRefNota.Text & "')"
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count <> 0 Then
                GridView.Rows.Clear()
                For i = 0 To DT.Rows.Count - 1
                    GridView.Rows.Add(DT.Rows(i)("Warna"), DT.Rows(i)("Ukuran"), DT.Rows(i)("Jenis"), DT.Rows(i)("Jumlah"), DT.Rows(i)("Harga"), DT.Rows(i)("Bayar"), DT.Rows(i)("Catatan"), 1, DT.Rows(i)("ID"))

                    GridView.Rows(i).Cells(0).Style.BackColor = Color.LightSkyBlue
                    GridView.Rows(i).Cells(1).Style.BackColor = Color.LightSkyBlue
                    GridView.Rows(i).Cells(2).Style.BackColor = Color.LightSkyBlue
                    GridView.Rows(i).Cells(3).Style.BackColor = Color.LightSkyBlue
                    GridView.Rows(i).Cells(4).Style.BackColor = Color.LightSkyBlue
                    GridView.Rows(i).Cells(5).Style.BackColor = Color.LightSkyBlue
                    GridView.Rows(i).Cells(6).Style.BackColor = Color.LightSkyBlue
                    GridView.Rows(i).Cells(7).Style.BackColor = Color.LightSkyBlue
                Next
            End If
        End If
        
    End Sub

    Private Sub GridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView.CellClick
        If e.RowIndex = -1 Then Exit Sub
        TxtWarna.Text = tostr(GridView.Rows(e.RowIndex).Cells("warna").Value)
        LstTipe.Text = tostr(GridView.Rows(e.RowIndex).Cells("Ukuran").Value)
        LstJenis.Text = tostr(GridView.Rows(e.RowIndex).Cells("Jenis").Value)
        TxtJml.Text = toval(GridView.Rows(e.RowIndex).Cells("Jumlah").Value)
        TxtByr.Text = toval(GridView.Rows(e.RowIndex).Cells("Bayar").Value)
        TxtHarga.Text = toval(GridView.Rows(e.RowIndex).Cells("Bayar").Value) / toval(GridView.Rows(e.RowIndex).Cells("Jumlah").Value)
        TxtKeterangan.Text = tostr(GridView.Rows(e.RowIndex).Cells("Catatan").Value)

        Row_Index = e.RowIndex
    End Sub 

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim RowSelected As Integer = GridView.CurrentCell.RowIndex

        If toval(RowSelected) < 0 Then
            MsgBox("Pilih dahulu item yang hendak diedit")
            Exit Sub
        End If

        If GridView.Rows(RowSelected).Cells("konsinyasiF").Value = 1 Then
            MsgBox("Item dari nota sebelumnya tidak bisa diupdate")
            Exit Sub
            'If GridView.Rows(RowSelected).Cells("warna").Value <> TxtWarna.Text Or GridView.Rows(RowSelected).Cells("Ukuran").Value <> LstTipe.Text Or GridView.Rows(RowSelected).Cells("Jenis").Value <> LstJenis.Text Then
            'MsgBox("Untuk item konsinyasi, yang boleh diedit hanya JUMLAH , HARGA dan KETERANGAN")
            'Exit Sub
            'End If
        End If

        GridView.Rows(RowSelected).Cells("warna").Value = TxtWarna.Text
        GridView.Rows(RowSelected).Cells("Ukuran").Value = LstTipe.Text
        GridView.Rows(RowSelected).Cells("Jenis").Value = LstJenis.Text
        GridView.Rows(RowSelected).Cells("Jumlah").Value = TxtJml.Text
        GridView.Rows(RowSelected).Cells("Bayar").Value = TxtByr.Text
        GridView.Rows(RowSelected).Cells("Catatan").Value = TxtKeterangan.Text

        TxtWarna.Enabled = True
        LstTipe.Enabled = True
        LstJenis.Enabled = True
    End Sub

    Private Sub LstRefNota_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstRefNota.LostFocus
        Dim DT As New DataTable
        SQL = "Select Distinct Surat_Jalan from Barang_Keluar_H where surat_Jalan not in (Select pSurat_Jalan from Barang_Keluar_H) and surat_jalan = '" & LstRefNota.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then
            LstRefNota.Text = ""
            MsgBox("Nomor nota tidak ada, masukkan nomor nota yang valid")
        End If
    End Sub

    Private Sub LstRefNota_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstRefNota.SelectedIndexChanged
        Dim DT As New DataTable
        SQL = "SELECT oSurat_Jalan FROM Barang_Keluar_H Where Surat_Jalan = '" & LstRefNota.Text & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count > 0 Then
            OriginalNota = DT.Rows(0)("oSurat_Jalan")
        End If
    End Sub

    Private Sub LstJenisHarga_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstJenisHarga.SelectedIndexChanged
        Select Case LstJenisHarga.SelectedIndex
            Case 2
                txtidpembeli.Clear()
                TxtNamaPembeli.Clear()
                txtidpembeli.Enabled = True
                TxtNamaPembeli.Enabled = True
                LinkPembeli.Text = "Pembeli"
            Case Else
                txtidpembeli.Enabled = False
                TxtNamaPembeli.Enabled = False
                MessageBox.Show("Reseller dan Toko Silahkan Klik Link", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                LinkPembeli.Text = LstJenisHarga.Text
                LinkPembeli.Focus()
                txtidpembeli.Clear()
                TxtNamaPembeli.Clear()
        End Select
    End Sub
End Class
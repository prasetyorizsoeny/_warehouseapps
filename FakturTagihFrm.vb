Public Class FakturTagihFrm

    Public No_Nota As String = ""
    Public NextID As Double = -1
    Dim RowID As Integer = -1
    Dim pRowID As Integer = -1
    Dim Tgl_Tagihan As Date = Now
    Dim Jenis As String = ""
    Dim Warna As String = ""
    Dim Ukuran As String = ""
    Dim CollectF As Boolean = False

    Private Function Error_Field() As Boolean
        Dim Error_Msg As String = ""

        If TxtTagihan.Text = "" Then
            TxtTagihan.Focus()
            Error_Msg = "Pilih Tombol Buat Tagihan!!!"
            GoTo Error_Message
        End If

        Error_Field = False
        Exit Function
Error_Message:
        Error_Field = True
        MsgBox(Error_Msg)
    End Function

    Sub GenerateListView()
        Dim DTH As New DataTable
        SQL = "Select Distinct Nama_Pembeli, B.Alamat, B.Telepon, A.Total_Jumlah, A.Tagihan, C.Tanggal_Tagihan From Barang_Keluar_H A,Profil B, Tagihan_H C Where A.ID_Pembeli=B.ID And A.ID=C.ID_Referensi And A.Surat_Jalan = '" & No_Nota & "'"
        GetDataTable(SQL, DTH, ErrMsg)
        If DTH.Rows.Count <> 0 Then
            TxtNmToko.Text = tostr(DTH.Rows(0)("Nama_Pembeli"))
            Txtalmttoko.Text = tostr(DTH.Rows(0)("Alamat"))
            txttlptoko.Text = tostr(DTH.Rows(0)("Telepon"))
            If toval(DTH.Rows(0)("Tagihan")) > 0 Then
                TxtTagihan.Text = toval(DTH.Rows(0)("Tagihan"))
            End If
            DTT.Value = todate(DTH.Rows(0)("Tanggal_Tagihan"))
        End If
        Dim DT As New DataTable
        SQL = "Select * From Tagihan_H Where ID_Referensi = " & toval(NextID)
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count <> 0 Then
            GridView.AutoGenerateColumns = True
            GridView.DataSource = DT
            GridView.Refresh()
        End If
    End Sub

    Sub GenerateListBarang(ByVal RowID As Integer)
        Dim DT2, DT3 As New DataTable
        Dim tSQL As String

        SQL = "Select ID_Referensi, CollectF, Jenis, Warna, Ukuran, Jumlah From Tagihan_D Where ID_Referensi = " & RowID
        tSQL = SQL
        GetDataTable(SQL, DT2, ErrMsg)
        If DT2.Rows.Count > 0 Then
            GridView2.AutoGenerateColumns = True
            GridView2.DataSource = DT2
            GridView2.Refresh()
        Else
            If toval(TxtTagihan.Text) <= 1 Then
                SQL = "Select B.Jenis, B.Warna, B.Ukuran, B.Jumlah From Barang_Keluar_H A, Barang_Keluar_D B Where A.ID=B.ID_Referensi And A.Surat_Jalan = '" & No_Nota & "'"
            Else
                SQL = "SELECT ID_Referensi, CollectF, Jenis, Warna, Ukuran, Jumlah FROM TAGIHAN_D B WHERE B.ID_REFERENSI = " & pRowID
            End If
            GetDataTable(SQL, DT2, ErrMsg)
            If DT2.Rows.Count > 0 Then
                For i = 0 To DT2.Rows.Count - 1
                    SQL = "INSERT INTO Tagihan_D (ID_Referensi, Jenis, Warna, Jumlah, Ukuran, CollectF, Jumlah_Terjual) VALUES(" & RowID & ",'" & tostr(DT2.Rows(i)("Jenis")) & "','" & tostr(DT2.Rows(i)("Warna")) & "','" & toval(DT2.Rows(i)("Jumlah")) & "','" & tostr(DT2.Rows(i)("Ukuran")) & "',0,0)"
                    If Not ExecuteSQL(SQL, ErrMsg) Then
                        MsgBox(ErrMsg)
                        Exit Sub
                    End If
                Next
                GetDataTable(tSQL, DT3, ErrMsg)
                GridView2.AutoGenerateColumns = True
                GridView2.DataSource = DT3
                GridView2.Refresh()
            End If
        End If
    End Sub

    Sub DisplayDefault()
        TxtNoNota.Text = No_Nota
        TxtUser.Text = UserId
        TxtTagihan.Clear()
        DTT.Value = Date.Now
    End Sub

    Sub GenerateFaktur(ByVal ID As Integer)
        SQL = "Delete From Cetak_FTagihan"
        If Not ExecuteSQL(SQL, ErrMsg) Then
            MsgBox(ErrMsg)
            Exit Sub
        End If

        If TxtTagihan.Text <> "" Then
            SQL = "Insert Into Cetak_FTagihan Select Distinct A.ID, A.Surat_Jalan As No_Nota, B.Tagihan, B.Tanggal_Tagihan, C.Nama As Nama_Toko, C.Alamat As Alamat_Toko, "
            SQL = SQL & " B1.Warna As Warna_Barang, B1.Ukuran As Ukuran_Barang, B1.Jumlah As Jumlah_Barang, IIF(A1.Harga=0,C.Harga,A1.Harga) As Harga_Barang, A.Nama_Penerima"
            SQL = SQL & " From Barang_Keluar_H A, Barang_Keluar_D A1, Tagihan_H B, Tagihan_D B1, Profil C Where B.ID=B1.ID_Referensi And A.ID=A1.ID_Referensi And A.ID=B.ID_Referensi And A.ID_Pembeli=C.ID And B.ID = " & RowID & ""
            SQL = SQL & " Order By A.Surat_Jalan"
        Else
            SQL = "Insert Into Cetak_FTagihan Select Distinct A.ID, A.Surat_Jalan As No_Nota, B.Tagihan, B.Tanggal_Tagihan, C.Nama As Nama_Toko, C.Alamat As Alamat_Toko, "
            SQL = SQL & " A1.Warna As Warna_Barang, A1.Ukuran As Ukuran_Barang, A1.Jumlah-A1.Jumlah_Terjual As Jumlah_Barang, IIF(A1.Harga=0,C.Harga,A1.Harga) As Harga_Barang, A1.Jumlah_Terjual As Jumlah_Barang_Terjual, A.Nama_Penerima"
            SQL = SQL & " From Barang_Keluar_H A, Barang_Keluar_D A1, Tagihan_H B, Profil C Where A.ID=A1.ID_Referensi And A.ID=B.ID_Referensi And A.ID_Pembeli=C.ID And B.Tanggal_Tagihan = #" & Format(todate(Tgl_Tagihan), "MM/dd/yyyy") & "# And A.ID = " & toval(NextID) & " And B.ID = " & toval(ID) & ""
            SQL = SQL & " Order By A.Surat_Jalan"
        End If

        If Not ExecuteSQL(SQL, ErrMsg) Then
            MsgBox(ErrMsg)
            Exit Sub
        End If

        PrintTagihanFrm.Show()
    End Sub

    Private Sub FakturTagihFrm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        GenerateListView()
        If Not RowID = -1 Then
            GenerateListBarang(RowID)
        End If
        TxtJmlTerjual.Clear()
    End Sub

    Private Sub FakturTagihFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        GC.Collect()
    End Sub

    Private Sub FakturTagihFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        DisplayDefault()
    End Sub

    Private Sub GridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView.CellClick
        If GridView.Rows.Count = 0 Then Exit Sub
        RowID = toval(GridView.Rows(e.RowIndex).Cells("ID").Value)
        Tgl_Tagihan = todate(GridView.Rows(e.RowIndex).Cells("Tanggal_Tagihan").Value)
        DTT.Value = todate(Tgl_Tagihan)
        TxtTagihan.Text = toval(GridView.Rows(e.RowIndex).Cells("Tagihan").Value)
        GenerateListBarang(RowID)
    End Sub

    Private Sub GridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView2.CellClick
        If GridView2.Rows.Count = 0 Then Exit Sub
        If toval(GridView2.Rows(e.RowIndex).Cells("Jumlah").Value) <> 0 Then
            Jenis = tostr(GridView2.Rows(e.RowIndex).Cells("Jenis").Value)
            Warna = tostr(GridView2.Rows(e.RowIndex).Cells("Warna").Value)
            Ukuran = tostr(GridView2.Rows(e.RowIndex).Cells("Ukuran").Value)
            CollectF = CBool(GridView2.Rows(e.RowIndex).Cells("CollectF").Value)
            If toval(GridView2.Rows(e.RowIndex).Cells("Jumlah").Value) = 0 Or CollectF = True Then
                TxtJmlTerjual.Enabled = False
                TxtJmlTerjual.Text = ""
            Else
                TxtJmlTerjual.Enabled = True
                TxtJmlTerjual.Text = toval(GridView2.Rows(e.RowIndex).Cells("Jumlah").Value)
            End If
        End If
    End Sub

    Private Sub txtstok_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LPrint_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LPrint.LinkClicked
        If RowID = -1 Then
            MessageBox.Show("Pilih Baris Yang Ingin Di Cetak", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GridView.Focus()
            Exit Sub
        Else
            GenerateFaktur(RowID)
        End If
    End Sub

    Private Sub LUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LUpdate.LinkClicked
        If RowID = -1 Then
            MessageBox.Show("Pilih Baris Tagihan", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If GridView.Rows.Count = 0 Then
                MessageBox.Show("Buat Tagihan Dahulu", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If TxtJmlTerjual.Text = "" Then
                MessageBox.Show("Pilih Baris Untuk Update Barang", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            SQL = "Update Tagihan_D Set CollectF = 1, Jumlah_Terjual = " & toval(TxtJmlTerjual.Text) & ", Jumlah = Jumlah - " & toval(TxtJmlTerjual.Text) & " Where ID_Referensi = " & RowID & " And Jenis = '" & Jenis & "' And Warna = '" & Warna & "' And Ukuran = '" & Ukuran & "'"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If
            MessageBox.Show("Update Berhasil", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LBuatTagihan_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LBuatTagihan.LinkClicked
        Dim DT, DTRow As New DataTable
        Dim Tagihan As Double

        SQL = "SELECT Top 1 Tagihan from Barang_Keluar_H Where Surat_Jalan = '" & tostr(No_Nota) & "' order by Tagihan Desc"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then
            Tagihan = 1
        Else
            Tagihan = toval(DT.Rows(0)(0)) + 1
        End If

        If Tagihan <> 0 Then
            TxtTagihan.Text = toval(Tagihan)
            DTT.Enabled = True
        End If

        If Error_Field() Then Exit Sub

        SQL = "Select TOP 1 ID From Tagihan_H Where No_Nota = '" & TxtNoNota.Text & "' Order By Tagihan Desc"
        GetDataTable(SQL, DTRow, ErrMsg)
        If DTRow.Rows.Count > 0 Then
            pRowID = CInt(DTRow.Rows(0)("ID"))
        End If

        SQL = "INSERT INTO Tagihan_H (ID_Referensi, No_Nota, Tagihan, Tanggal_Tagihan, Admin_Tagihan) VALUES(" & NextID & ",'" & tostr(TxtNoNota.Text) & "'," & toval(TxtTagihan.Text) & ",'" & Format(todate(DTT.Value), "MM/dd/yyyy") & "','" & UserId & "')"
        If Not ExecuteSQL(SQL, ErrMsg) Then
            MsgBox(ErrMsg)
            Exit Sub
        End If

        SQL = "Update Barang_Keluar_H Set Tagihan = " & toval(TxtTagihan.Text) & " Where ID = " & NextID
        If Not ExecuteSQL(SQL, ErrMsg) Then
            MsgBox(ErrMsg)
            Exit Sub
        End If

        MessageBox.Show("Tagihan Telah Dibuat, Blok Baris dan Klik Print Untuk Mencetak...", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LTutup_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LTutup.LinkClicked
        Dim DT, DT1, DT2 As New DataTable

        SQL = "Select A.No_Nota, B.Warna, B.Ukuran, B.Jenis, Sum(B.Jumlah_Terjual) As Jumlah From Tagihan_H A, Tagihan_D B Where A.ID = B.ID_Referensi And A.No_Nota = '" & TxtNoNota.Text & "' Group By A.No_Nota, B.Warna, B.Ukuran, B.Jenis"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count > 0 Then
            For i = 0 To DT.Rows.Count - 1
                SQL = "select A.ID, A.Surat_Jalan As No_Nota, B.Warna, B.Ukuran, B.Jenis, Sum(B.Jumlah_Terjual) As Jumlah from Barang_Keluar_H A, Barang_Keluar_D B Where A.ID=B.ID_Referensi and A.Surat_Jalan = '" & TxtNoNota.Text & "' Group by A.ID, A.Surat_Jalan, B.Warna, B.Ukuran, B.Jenis"
                GetDataTable(SQL, DT1, ErrMsg)
                If DT1.Rows.Count > 0 Then
                    SQL = "Update Barang_Keluar_D Set Jumlah_Terjual = " & toval(DT.Rows(i)("Jumlah")) & " Where ID_Referensi = " & toval(DT1.Rows(0)("ID")) & " And Warna = '" & tostr(DT.Rows(i)("Warna")) & "' And Jenis = '" & tostr(DT.Rows(i)("Jenis")) & "' And Ukuran = '" & tostr(DT.Rows(i)("Ukuran")) & "'"
                    If Not ExecuteSQL(SQL, ErrMsg) Then
                        MsgBox(ErrMsg)
                        Exit Sub
                    End If
                    SQL = "Update Barang_Keluar_D Set Bayar = (Harga * Jumlah_Terjual) - Bayar Where ID_Referensi = " & toval(DT1.Rows(0)("ID")) & " And Warna = '" & tostr(DT.Rows(i)("Warna")) & "' And Jenis = '" & tostr(DT.Rows(i)("Jenis")) & "' And Ukuran = '" & tostr(DT.Rows(i)("Ukuran")) & "'"
                    If Not ExecuteSQL(SQL, ErrMsg) Then
                        MsgBox(ErrMsg)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Tidak Ada Barang Keluar", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Next
        Else
            MessageBox.Show("Tidak Ada Tagihan", "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        SQL = "select A.ID, Sum(B.Jumlah_Terjual) As Jumlah, Sum(B.Bayar) As Bayar from Barang_Keluar_H A, Barang_Keluar_D B Where A.ID=B.ID_Referensi and A.Surat_Jalan = '" & TxtNoNota.Text & "' Group by A.ID"
        GetDataTable(SQL, DT2, ErrMsg)
        If DT2.Rows.Count > 0 Then
            SQL = "Update Barang_Keluar_H Set CloseF = 1, Total_Jumlah = " & toval(DT2.Rows(0)("Jumlah")) & ", Total_Harga = " & toval(DT2.Rows(0)("Bayar")) & " Where ID = " & toval(DT2.Rows(0)("ID")) & ""
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            End If
            MessageBox.Show("Tutup Transakti No. Nota " & TxtNoNota.Text, "RSA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        DT.Dispose()
        DT1.Dispose()
        DT2.Dispose()
        Me.Dispose()
    End Sub
End Class
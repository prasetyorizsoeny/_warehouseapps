Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms.DataVisualization
Imports System.Configuration

Public Class ListTerjual
    Dim Tipe As String

    Private Sub ListTerjual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        Dim DT As New DataTable

        DTP1.Value = Today.Date
        DTP2.Value = Today.Date

        CbxJenis.Items.Add("")
        SQL = "Select Distinct Jenis from Harga"
        GetDataTable(SQL, DT, ErrMsg)
        If DT.Rows.Count = 0 Then Exit Sub
        For i = 0 To DT.Rows.Count - 1
            CbxJenis.Items.Add(DT.Rows(i)("Jenis"))
        Next

        CbxKelompok.Text = "Warna"
    End Sub

    Private Sub BtnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampil.Click
        Dim DT As New DataTable
        Dim AppSource As String = ConfigurationManager.AppSettings("AppSource")

        If CbxKelompok.Text = "Warna" Then
            If UCase(AppSource) = "GUDANG" Then
                SQL = "SELECT D.Warna, Sum(D.Jumlah_Terjual) as Jumlah_terjual, (Select Sum(Jumlah_Terjual) from Barang_Keluar_D) as Total FROM Barang_Keluar_H H, Barang_Keluar_D D where H.ID = D.ID_Referensi and H.Tanggal_Transaksi between #" & Format(DTP1.Value, "MM/dd/yyyy") & "# and #" & Format(DTP2.Value, "MM/dd/yyyy") & "#"
            Else
                SQL = "SELECT D.Warna, Sum(D.Jumlah) as Jumlah, (Select Sum(Jumlah) from Barang_Keluar_D) as Total FROM Barang_Keluar_H H, Barang_Keluar_D D where H.ID = D.ID_Referensi and H.Tanggal_Transaksi between #" & Format(DTP1.Value, "MM/dd/yyyy") & "# and #" & Format(DTP2.Value, "MM/dd/yyyy") & "#"
            End If
        ElseIf CbxKelompok.Text = "Pembeli" Then
            If UCase(AppSource) = "GUDANG" Then
                SQL = "SELECT (H.Nama_Pembeli & ' (' &  H.ID_Pembeli & ')') as Pembeli, Sum(D.Jumlah_Terjual) as Jumlah_terjual, (Select Sum(Jumlah_Terjual) from Barang_Keluar_D) as Total FROM Barang_Keluar_H H, Barang_Keluar_D D where H.ID = D.ID_Referensi and H.Tanggal_Transaksi between #" & Format(DTP1.Value, "MM/dd/yyyy") & "# and #" & Format(DTP2.Value, "MM/dd/yyyy") & "#"
            Else
                SQL = "SELECT (H.Nama_Pembeli & ' (' &  H.ID_Pembeli & ')') as Pembeli, Sum(D.Jumlah) as Jumlah, (Select Sum(Jumlah) from Barang_Keluar_D) as Total FROM Barang_Keluar_H H, Barang_Keluar_D D where H.ID = D.ID_Referensi and H.Tanggal_Transaksi between #" & Format(DTP1.Value, "MM/dd/yyyy") & "# and #" & Format(DTP2.Value, "MM/dd/yyyy") & "#"
            End If
        End If

        If CbxJenis.Text <> "" Then
            SQL = SQL & " and D.Jenis = '" & CbxJenis.Text & "'"
        End If

        If CbxKelompok.Text = "Warna" Then
            SQL = SQL & " Group by Warna"
        ElseIf CbxKelompok.Text = "Pembeli" Then
            SQL = SQL & " group by H.Nama_Pembeli & ' (' &  H.ID_Pembeli & ')'"
        End If

        GetDataTable(SQL, DT, ErrMsg)
        DGV.DataSource = DT
        DGV.Columns(2).Visible = False
        DGV.Refresh()

        Dim x As String() = New String(DT.Rows.Count - 1) {}
        Dim y As Integer() = New Integer(DT.Rows.Count - 1) {}
        For i As Integer = 0 To DT.Rows.Count - 1
            x(i) = tostr(DT.Rows(i)(0)) & " (" & FormatNumber(toval(DT.Rows(i)(1)) / toval(DT.Rows(i)(2)) * 100, 2) & "%)"
            y(i) = toval(DT.Rows(i)(1))
        Next
        Chart1.Series(0).Points.DataBindXY(x, y)
        Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        Chart1.Legends(0).Enabled = True

        If DT.Rows.Count = 0 Then
            MsgBox("Data tidak ada")
            Exit Sub
        End If
    End Sub
End Class
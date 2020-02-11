Imports System.Globalization
Imports System.Threading

Public Class FindFrm

    Public SQL As String = ""
    Dim Row_Index As Integer
    Public ObjFrm As String = ""

    Sub DisplayDefault(ByVal SQL As String)
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        Load_Grid(SQL)
    End Sub

    Private Sub Load_Grid(ByVal SQL As String)
        Dim DT As New DataTable

        GetDataTable(SQL, DT, ErrMsg)
        DataGridView1.DataSource = DT
        DataGridView1.Refresh()
    End Sub

    Private Sub FindFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DisplayDefault(SQL)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        If ObjFrm = "OrdersOutFrm" Then
            OrdersOutFrm.txtidpembeli.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("ID").Value)
            OrdersOutFrm.TxtNamaPembeli.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Nama").Value)
            OrdersOutFrm.TxtHarga.Text = tostr(DataGridView1.Rows(e.RowIndex).Cells("Harga").Value)
        End If
        Row_Index = e.RowIndex
        GC.Collect()
        SQL = ""
        Me.Hide()
    End Sub
End Class
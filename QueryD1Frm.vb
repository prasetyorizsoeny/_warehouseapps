Imports System.Globalization
Imports System.Threading

Public Class QueryD1Frm
    Public d1SQL As String

    Private Sub QueryD1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ID")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

        Dim DT As New DataTable

        GetDataTable(d1SQL, DT, ErrMsg)
        GridView.DataSource = DT
        GridView.Refresh()
    End Sub
End Class
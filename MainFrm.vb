Imports System.Configuration

Public Class MainFrm

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        UserFrm.Show()
    End Sub

    Private Sub ProdukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdukToolStripMenuItem.Click
        produkFrm.Show()
    End Sub

    Private Sub PembeliToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembeliToolStripMenuItem1.Click
        profilFrm.Show()
    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderInMenu.Click
        OrdersInFrm.Show()
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderOutMenu.Click
        OrdersOutFrm.Show()
    End Sub

    Private Sub ReturToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturMenu.Click
        ReturFrm.Show()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChangePass.ShowDialog()
    End Sub

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GC.Collect()
        End
    End Sub

    Private Sub ListTempoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstTempoMenu.Click
        ListTempoFrm.Show()
    End Sub

    Private Sub QueryMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryMenu.Click
        QueryHFrm.Show()
    End Sub

    Private Sub MainFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT As New DataTable
        Dim AppSource As String = ConfigurationManager.AppSettings("AppSource")
        Dim Versi As String = ConfigurationManager.AppSettings("Versi")

        SQL = "Select Tipe from Users where id ='" & UserId & "'"
        GetDataTable(SQL, DT, ErrMsg)
        If UCase(DT.Rows(0)("Tipe")) <> "SPV" Then
            UserToolStripMenuItem.Visible = False
            ProdukToolStripMenuItem.Visible = False
        End If

        If UCase(AppSource) = "AGEN" Then UploadMenu.Visible = False

        Me.Text = "Menu Utama - " & UCase(AppSource) & " - " & UCase(Versi)
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        ChangePass.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim result As DialogResult

        result = MsgBox("Anda yakin mau keluar dari aplikasi ?", vbYesNo)
        If result = DialogResult.Yes Then
            GC.Collect()
            End
        End If
    End Sub

    Private Sub KategoriBiayaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KategoriBiayaToolStripMenuItem.Click
        Kategori.Show()
    End Sub

    Private Sub ListTerjualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListTerjualToolStripMenuItem.Click
        ListTerjual.Show()
    End Sub

    Private Sub ExpenseMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpenseMenu.Click
        ExpenseFrm.Show()
    End Sub

    Private Sub UploadMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadMenu.Click
        UploadFrm.Show()
    End Sub
End Class
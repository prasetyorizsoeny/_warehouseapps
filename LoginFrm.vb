Imports System.Configuration

Public Class LoginFrm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DT As New DataTable
        Dim AppSource As String = ConfigurationManager.AppSettings("AppSource")

        If UCase(AppSource) <> "AGEN" And UCase(AppSource) <> "GUDANG" Then
            MsgBox("Aplikasi belum disetting, hubungi admin untuk melakukan settingan aplikasi", vbOKOnly, "Information")
            Exit Sub
        End If
        If TxtUser.Text = "" Then
            MsgBox("ID atau password tidak sesuai", vbOKOnly, "Information")
            TxtUser.Focus()
        Else
            SQL = "SELECT * FROM users WHERE id = '" & TxtUser.Text & "'"
            GetDataTable(SQL, DT, ErrMsg)

            If DT.Rows.Count = 0 Then
                MsgBox("ID atau password tidak sesuai", vbOKOnly, "Information")
                TxtUser.Focus()
            Else
                If TxtPassword.Text = decrypt(tostr(DT.Rows(0)("Pass"))) Then
                    UserId = TxtUser.Text

                    MainFrm.Show()
                    Me.Hide()
                Else
                    MsgBox("ID atau password tidak sesuai", vbOKOnly, "Information")
                End If
            End If
        End If
    End Sub

    Private Sub TxtUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUser.KeyDown
        Dim DT As New DataTable

        If e.KeyCode = 13 Then
            If TxtUser.Text = "" Then
                MsgBox("ID atau password tidak sesuai", vbOKOnly, "Information")
                TxtUser.Focus()
            Else
                SQL = "SELECT * FROM users WHERE id = '" & TxtUser.Text & "'"
                GetDataTable(SQL, DT, ErrMsg)

                If DT.Rows.Count = 0 Then
                    MsgBox("ID atau password tidak sesuai", vbOKOnly, "Information")
                    TxtUser.Focus()
                Else
                    If TxtPassword.Text = decrypt(tostr(DT.Rows(0)("Pass"))) Then
                        UserId = TxtUser.Text
                        MainFrm.Show()
                        Me.Hide()
                    Else
                        MsgBox("ID atau password tidak sesuai", vbOKOnly, "Information")
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub TxtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPassword.KeyDown
        Dim DT As New DataTable

        If e.KeyCode = 13 Then
            If TxtUser.Text = "" Then
                MsgBox("ID atau password tidak sesuai", vbOKOnly, "Information")
                TxtUser.Focus()
            Else
                SQL = "SELECT * FROM users WHERE id = '" & TxtUser.Text & "'"
                GetDataTable(SQL, DT, ErrMsg)

                If DT.Rows.Count = 0 Then
                    MsgBox("ID atau password tidak sesuai", vbOKOnly, "Information")
                    TxtUser.Focus()
                Else
                    If TxtPassword.Text = decrypt(tostr(DT.Rows(0)("Pass"))) Then
                        UserId = TxtUser.Text
                        MainFrm.Show()
                        Me.Hide()
                    Else
                        MsgBox("ID atau password tidak sesuai", vbOKOnly, "Information")
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub LoginFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Cabang As String = ConfigurationManager.AppSettings("Cabang")

        LblCabang.Text = Cabang
    End Sub
End Class

Public Class ChangePass

    Private Sub BtnUbahPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbahPass.Click
        Dim DT As New DataTable

        If TxtPass.Text = "" Then
            MsgBox("Input password yang baru")
        ElseIf TxtPass1.Text = "" Then
            MsgBox("Input konfirmasi password yang baru")
        ElseIf TxtPass.Text <> TxtPass1.Text Then
            MsgBox("password dan konfirmasi password tidak sama")
        Else
            SQL = "SELECT pass FROM users where id = '" & UserId & "'"
            GetDataTable(SQL, DT, ErrMsg)
            If DT.Rows.Count <> 0 Then
                If decrypt(DT.Rows(0)("pass")) <> TxtPassSekarang.Text Then
                    MsgBox("Password sekarang salah")
                    Exit Sub
                End If
            End If

            SQL = "UPDATE users SET pass = '" & encrypt(TxtPass.Text) & "' where ID = '" & UserId & "'"
            If Not ExecuteSQL(SQL, ErrMsg) Then
                MsgBox(ErrMsg)
                Exit Sub
            Else
                MsgBox("Password berhasil diubah")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TxtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPass.KeyDown
        If e.KeyCode = 13 Then BtnUbahPass_Click(Me, e)
    End Sub

    Private Sub TxtPassSekarang_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPassSekarang.KeyDown
        If e.KeyCode = 13 Then BtnUbahPass_Click(Me, e)
    End Sub

    Private Sub TxtPass1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPass1.KeyDown
        If e.KeyCode = 13 Then BtnUbahPass_Click(Me, e)
    End Sub
End Class
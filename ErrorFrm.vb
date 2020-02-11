Public Class ErrorFrm

    Public ErrorString As String = ""

    Private Sub ErrorFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TxtFailed.Text = ErrorString
    End Sub
End Class
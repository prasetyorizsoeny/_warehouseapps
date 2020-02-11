<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorFrm))
        Me.TxtFailed = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'TxtFailed
        '
        Me.TxtFailed.Enabled = False
        Me.TxtFailed.Location = New System.Drawing.Point(12, 12)
        Me.TxtFailed.Name = "TxtFailed"
        Me.TxtFailed.Size = New System.Drawing.Size(601, 140)
        Me.TxtFailed.TabIndex = 0
        Me.TxtFailed.Text = ""
        '
        'ErrorFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(625, 164)
        Me.Controls.Add(Me.TxtFailed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ErrorFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ErrorFrm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtFailed As System.Windows.Forms.RichTextBox
End Class

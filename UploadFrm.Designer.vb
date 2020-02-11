<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UploadFrm))
        Me.CmdVerify = New System.Windows.Forms.Button
        Me.CmdProcess = New System.Windows.Forms.Button
        Me.GridView = New System.Windows.Forms.DataGridView
        Me.LinkFile = New System.Windows.Forms.LinkLabel
        Me.TxtFile = New System.Windows.Forms.TextBox
        Me.CmdOK = New System.Windows.Forms.Button
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdVerify
        '
        Me.CmdVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdVerify.Location = New System.Drawing.Point(707, 320)
        Me.CmdVerify.Name = "CmdVerify"
        Me.CmdVerify.Size = New System.Drawing.Size(75, 23)
        Me.CmdVerify.TabIndex = 0
        Me.CmdVerify.Text = "Verifikasi"
        Me.CmdVerify.UseVisualStyleBackColor = True
        '
        'CmdProcess
        '
        Me.CmdProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdProcess.Location = New System.Drawing.Point(788, 320)
        Me.CmdProcess.Name = "CmdProcess"
        Me.CmdProcess.Size = New System.Drawing.Size(75, 23)
        Me.CmdProcess.TabIndex = 1
        Me.CmdProcess.Text = "Proses"
        Me.CmdProcess.UseVisualStyleBackColor = True
        '
        'GridView
        '
        Me.GridView.AllowUserToAddRows = False
        Me.GridView.AllowUserToDeleteRows = False
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Location = New System.Drawing.Point(12, 40)
        Me.GridView.MultiSelect = False
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.ShowEditingIcon = False
        Me.GridView.Size = New System.Drawing.Size(851, 274)
        Me.GridView.TabIndex = 55
        '
        'LinkFile
        '
        Me.LinkFile.AutoSize = True
        Me.LinkFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkFile.Location = New System.Drawing.Point(12, 9)
        Me.LinkFile.Name = "LinkFile"
        Me.LinkFile.Size = New System.Drawing.Size(61, 15)
        Me.LinkFile.TabIndex = 56
        Me.LinkFile.TabStop = True
        Me.LinkFile.Text = "Cari File : "
        '
        'TxtFile
        '
        Me.TxtFile.Enabled = False
        Me.TxtFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFile.Location = New System.Drawing.Point(71, 6)
        Me.TxtFile.Name = "TxtFile"
        Me.TxtFile.Size = New System.Drawing.Size(402, 21)
        Me.TxtFile.TabIndex = 57
        '
        'CmdOK
        '
        Me.CmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOK.Location = New System.Drawing.Point(479, 4)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(33, 23)
        Me.CmdOK.TabIndex = 58
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'UploadFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 353)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.TxtFile)
        Me.Controls.Add(Me.LinkFile)
        Me.Controls.Add(Me.GridView)
        Me.Controls.Add(Me.CmdProcess)
        Me.Controls.Add(Me.CmdVerify)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UploadFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UploadFrm"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdVerify As System.Windows.Forms.Button
    Friend WithEvents CmdProcess As System.Windows.Forms.Button
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents LinkFile As System.Windows.Forms.LinkLabel
    Friend WithEvents TxtFile As System.Windows.Forms.TextBox
    Friend WithEvents CmdOK As System.Windows.Forms.Button
End Class

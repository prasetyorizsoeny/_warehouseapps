<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePass))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnUbahPass = New System.Windows.Forms.Button
        Me.TxtPass = New System.Windows.Forms.TextBox
        Me.TxtPass1 = New System.Windows.Forms.TextBox
        Me.TxtPassSekarang = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password Baru"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Konfirmasi password baru"
        '
        'BtnUbahPass
        '
        Me.BtnUbahPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbahPass.Location = New System.Drawing.Point(35, 192)
        Me.BtnUbahPass.Name = "BtnUbahPass"
        Me.BtnUbahPass.Size = New System.Drawing.Size(130, 26)
        Me.BtnUbahPass.TabIndex = 4
        Me.BtnUbahPass.Text = "Ubah Password"
        Me.BtnUbahPass.UseVisualStyleBackColor = True
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(15, 80)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(171, 21)
        Me.TxtPass.TabIndex = 2
        '
        'TxtPass1
        '
        Me.TxtPass1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass1.Location = New System.Drawing.Point(15, 134)
        Me.TxtPass1.Name = "TxtPass1"
        Me.TxtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass1.Size = New System.Drawing.Size(171, 21)
        Me.TxtPass1.TabIndex = 3
        '
        'TxtPassSekarang
        '
        Me.TxtPassSekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassSekarang.Location = New System.Drawing.Point(15, 31)
        Me.TxtPassSekarang.Name = "TxtPassSekarang"
        Me.TxtPassSekarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassSekarang.Size = New System.Drawing.Size(171, 21)
        Me.TxtPassSekarang.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password Sekarang"
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(202, 230)
        Me.Controls.Add(Me.TxtPassSekarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPass1)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.BtnUbahPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubah Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnUbahPass As System.Windows.Forms.Button
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents TxtPass1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassSekarang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

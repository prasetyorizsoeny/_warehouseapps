<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListTempoFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListTempoFrm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BtnExcel = New System.Windows.Forms.Button
        Me.BtnTampil = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(639, 299)
        Me.DataGridView1.TabIndex = 31
        '
        'BtnExcel
        '
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.Location = New System.Drawing.Point(528, 12)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(123, 25)
        Me.BtnExcel.TabIndex = 37
        Me.BtnExcel.Text = "Simpan ke Excel"
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'BtnTampil
        '
        Me.BtnTampil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTampil.Location = New System.Drawing.Point(399, 11)
        Me.BtnTampil.Name = "BtnTampil"
        Me.BtnTampil.Size = New System.Drawing.Size(123, 25)
        Me.BtnTampil.TabIndex = 38
        Me.BtnTampil.Text = "Tampilkan"
        Me.BtnTampil.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 15)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Jatuh tempo sampai tanggal"
        '
        'DTP1
        '
        Me.DTP1.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.DTP1.CustomFormat = "dd-MM-yyyy"
        Me.DTP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(181, 15)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(87, 21)
        Me.DTP1.TabIndex = 62
        Me.DTP1.Value = New Date(2016, 5, 3, 0, 0, 0, 0)
        '
        'ListTempoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(658, 356)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnTampil)
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListTempoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Tempo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnExcel As System.Windows.Forms.Button
    Friend WithEvents BtnTampil As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
End Class

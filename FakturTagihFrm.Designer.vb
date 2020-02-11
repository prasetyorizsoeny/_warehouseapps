<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FakturTagihFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FakturTagihFrm))
        Me.GridView = New System.Windows.Forms.DataGridView
        Me.TxtUser = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DTT = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtTagihan = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtNoNota = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txttlptoko = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Txtalmttoko = New System.Windows.Forms.TextBox
        Me.TxtNmToko = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LBuatTagihan = New System.Windows.Forms.LinkLabel
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.LTutup = New System.Windows.Forms.LinkLabel
        Me.LPrint = New System.Windows.Forms.LinkLabel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LUpdate = New System.Windows.Forms.LinkLabel
        Me.TxtJmlTerjual = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GridView2 = New System.Windows.Forms.DataGridView
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView
        '
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Location = New System.Drawing.Point(8, 134)
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.Size = New System.Drawing.Size(495, 458)
        Me.GridView.TabIndex = 11
        '
        'TxtUser
        '
        Me.TxtUser.Enabled = False
        Me.TxtUser.Location = New System.Drawing.Point(122, 100)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(104, 20)
        Me.TxtUser.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "User"
        '
        'DTT
        '
        Me.DTT.CustomFormat = "dd-MM-yyyy"
        Me.DTT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTT.Location = New System.Drawing.Point(122, 72)
        Me.DTT.Name = "DTT"
        Me.DTT.Size = New System.Drawing.Size(104, 21)
        Me.DTT.TabIndex = 6
        Me.DTT.Value = New Date(2016, 10, 21, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = ":"
        '
        'TxtTagihan
        '
        Me.TxtTagihan.Enabled = False
        Me.TxtTagihan.Location = New System.Drawing.Point(122, 44)
        Me.TxtTagihan.Name = "TxtTagihan"
        Me.TxtTagihan.Size = New System.Drawing.Size(74, 20)
        Me.TxtTagihan.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Tagihan"
        '
        'TxtNoNota
        '
        Me.TxtNoNota.Enabled = False
        Me.TxtNoNota.Location = New System.Drawing.Point(122, 18)
        Me.TxtNoNota.Name = "TxtNoNota"
        Me.TxtNoNota.Size = New System.Drawing.Size(199, 20)
        Me.TxtNoNota.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Nota"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttlptoko)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Txtalmttoko)
        Me.GroupBox1.Controls.Add(Me.TxtNmToko)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(572, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 109)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info Toko"
        '
        'txttlptoko
        '
        Me.txttlptoko.Enabled = False
        Me.txttlptoko.Location = New System.Drawing.Point(422, 18)
        Me.txttlptoko.Name = "txttlptoko"
        Me.txttlptoko.Size = New System.Drawing.Size(151, 20)
        Me.txttlptoko.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(411, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(352, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Tlp. Toko"
        '
        'Txtalmttoko
        '
        Me.Txtalmttoko.Enabled = False
        Me.Txtalmttoko.Location = New System.Drawing.Point(103, 45)
        Me.Txtalmttoko.Multiline = True
        Me.Txtalmttoko.Name = "Txtalmttoko"
        Me.Txtalmttoko.Size = New System.Drawing.Size(243, 54)
        Me.Txtalmttoko.TabIndex = 6
        '
        'TxtNmToko
        '
        Me.TxtNmToko.Enabled = False
        Me.TxtNmToko.Location = New System.Drawing.Point(103, 18)
        Me.TxtNmToko.Name = "TxtNmToko"
        Me.TxtNmToko.Size = New System.Drawing.Size(243, 20)
        Me.TxtNmToko.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(87, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Alamat Toko"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(87, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nama Toko"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBuatTagihan)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.LTutup)
        Me.GroupBox2.Controls.Add(Me.LPrint)
        Me.GroupBox2.Controls.Add(Me.GridView)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtTagihan)
        Me.GroupBox2.Controls.Add(Me.DTT)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtUser)
        Me.GroupBox2.Controls.Add(Me.TxtNoNota)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 607)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info Tagihan"
        '
        'LBuatTagihan
        '
        Me.LBuatTagihan.AutoSize = True
        Me.LBuatTagihan.Location = New System.Drawing.Point(300, 118)
        Me.LBuatTagihan.Name = "LBuatTagihan"
        Me.LBuatTagihan.Size = New System.Drawing.Size(71, 13)
        Me.LBuatTagihan.TabIndex = 17
        Me.LBuatTagihan.TabStop = True
        Me.LBuatTagihan.Text = "Buat Tagihan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(106, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Tagihan"
        '
        'LTutup
        '
        Me.LTutup.AutoSize = True
        Me.LTutup.Location = New System.Drawing.Point(377, 118)
        Me.LTutup.Name = "LTutup"
        Me.LTutup.Size = New System.Drawing.Size(126, 13)
        Me.LTutup.TabIndex = 14
        Me.LTutup.TabStop = True
        Me.LTutup.Text = "Tutup Transaksi Tagihan"
        '
        'LPrint
        '
        Me.LPrint.AutoSize = True
        Me.LPrint.Location = New System.Drawing.Point(515, 134)
        Me.LPrint.Name = "LPrint"
        Me.LPrint.Size = New System.Drawing.Size(35, 13)
        Me.LPrint.TabIndex = 13
        Me.LPrint.TabStop = True
        Me.LPrint.Text = "Cetak"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LUpdate)
        Me.GroupBox3.Controls.Add(Me.TxtJmlTerjual)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.GridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(572, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(579, 492)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Info Barang"
        '
        'LUpdate
        '
        Me.LUpdate.AutoSize = True
        Me.LUpdate.Location = New System.Drawing.Point(515, 58)
        Me.LUpdate.Name = "LUpdate"
        Me.LUpdate.Size = New System.Drawing.Size(42, 13)
        Me.LUpdate.TabIndex = 14
        Me.LUpdate.TabStop = True
        Me.LUpdate.Text = "Update"
        '
        'TxtJmlTerjual
        '
        Me.TxtJmlTerjual.Enabled = False
        Me.TxtJmlTerjual.Location = New System.Drawing.Point(495, 35)
        Me.TxtJmlTerjual.Name = "TxtJmlTerjual"
        Me.TxtJmlTerjual.Size = New System.Drawing.Size(78, 20)
        Me.TxtJmlTerjual.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(495, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Item Terjual"
        '
        'GridView2
        '
        Me.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView2.Location = New System.Drawing.Point(10, 19)
        Me.GridView2.Name = "GridView2"
        Me.GridView2.ReadOnly = True
        Me.GridView2.Size = New System.Drawing.Size(481, 458)
        Me.GridView2.TabIndex = 13
        '
        'FakturTagihFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1158, 616)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FakturTagihFrm"
        Me.Text = "FakturTagih"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNoNota As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTagihan As System.Windows.Forms.TextBox
    Friend WithEvents DTT As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txtalmttoko As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmToko As System.Windows.Forms.TextBox
    Friend WithEvents txttlptoko As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtJmlTerjual As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LPrint As System.Windows.Forms.LinkLabel
    Friend WithEvents LUpdate As System.Windows.Forms.LinkLabel
    Friend WithEvents LTutup As System.Windows.Forms.LinkLabel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LBuatTagihan As System.Windows.Forms.LinkLabel
End Class

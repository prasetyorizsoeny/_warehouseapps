<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExpenseFrm))
        Me.DTP = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TP = New System.Windows.Forms.TabPage
        Me.CmdSimpan = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtNominal = New System.Windows.Forms.TextBox
        Me.CmdHTambah = New System.Windows.Forms.Button
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.CbxKategori = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmdHapus = New System.Windows.Forms.Button
        Me.CmdTambah = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtNama = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GridView = New System.Windows.Forms.DataGridView
        Me.Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kategori = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nominal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TP1 = New System.Windows.Forms.TabPage
        Me.CmdTampil = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CmdCetak = New System.Windows.Forms.Button
        Me.EDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SDate = New System.Windows.Forms.DateTimePicker
        Me.TabControl1.SuspendLayout()
        Me.TP.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTP
        '
        Me.DTP.CustomFormat = "dd-MM-yyyy"
        Me.DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP.Location = New System.Drawing.Point(139, 10)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(87, 20)
        Me.DTP.TabIndex = 0
        Me.DTP.Value = New Date(2016, 5, 3, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Tanggal Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = ":"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TP)
        Me.TabControl1.Controls.Add(Me.TP1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(749, 359)
        Me.TabControl1.TabIndex = 53
        '
        'TP
        '
        Me.TP.Controls.Add(Me.CmdSimpan)
        Me.TP.Controls.Add(Me.Label5)
        Me.TP.Controls.Add(Me.TxtNominal)
        Me.TP.Controls.Add(Me.CmdHTambah)
        Me.TP.Controls.Add(Me.TxtTotal)
        Me.TP.Controls.Add(Me.CbxKategori)
        Me.TP.Controls.Add(Me.Label8)
        Me.TP.Controls.Add(Me.CmdHapus)
        Me.TP.Controls.Add(Me.CmdTambah)
        Me.TP.Controls.Add(Me.Label6)
        Me.TP.Controls.Add(Me.TxtNama)
        Me.TP.Controls.Add(Me.Label4)
        Me.TP.Controls.Add(Me.GridView)
        Me.TP.Controls.Add(Me.Label1)
        Me.TP.Controls.Add(Me.DTP)
        Me.TP.Controls.Add(Me.Label2)
        Me.TP.Location = New System.Drawing.Point(4, 22)
        Me.TP.Name = "TP"
        Me.TP.Padding = New System.Windows.Forms.Padding(3)
        Me.TP.Size = New System.Drawing.Size(741, 333)
        Me.TP.TabIndex = 1
        Me.TP.Text = "Pengeluaran"
        Me.TP.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Location = New System.Drawing.Point(270, 303)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(55, 21)
        Me.CmdSimpan.TabIndex = 77
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(539, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Total"
        '
        'TxtNominal
        '
        Me.TxtNominal.BackColor = System.Drawing.Color.LightYellow
        Me.TxtNominal.Location = New System.Drawing.Point(9, 211)
        Me.TxtNominal.Name = "TxtNominal"
        Me.TxtNominal.Size = New System.Drawing.Size(145, 20)
        Me.TxtNominal.TabIndex = 4
        '
        'CmdHTambah
        '
        Me.CmdHTambah.Location = New System.Drawing.Point(232, 10)
        Me.CmdHTambah.Name = "CmdHTambah"
        Me.CmdHTambah.Size = New System.Drawing.Size(87, 21)
        Me.CmdHTambah.TabIndex = 1
        Me.CmdHTambah.Text = "Buat Transaksi"
        Me.CmdHTambah.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.LightYellow
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(576, 303)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(145, 20)
        Me.TxtTotal.TabIndex = 72
        '
        'CbxKategori
        '
        Me.CbxKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbxKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxKategori.BackColor = System.Drawing.Color.LightYellow
        Me.CbxKategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxKategori.FormattingEnabled = True
        Me.CbxKategori.Location = New System.Drawing.Point(9, 171)
        Me.CbxKategori.Name = "CbxKategori"
        Me.CbxKategori.Size = New System.Drawing.Size(145, 21)
        Me.CbxKategori.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Kategori"
        '
        'CmdHapus
        '
        Me.CmdHapus.Location = New System.Drawing.Point(71, 237)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(55, 21)
        Me.CmdHapus.TabIndex = 6
        Me.CmdHapus.Text = "Hapus"
        Me.CmdHapus.UseVisualStyleBackColor = True
        '
        'CmdTambah
        '
        Me.CmdTambah.Location = New System.Drawing.Point(10, 237)
        Me.CmdTambah.Name = "CmdTambah"
        Me.CmdTambah.Size = New System.Drawing.Size(55, 21)
        Me.CmdTambah.TabIndex = 5
        Me.CmdTambah.Text = "Tambah"
        Me.CmdTambah.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Nominal"
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.Color.LightYellow
        Me.TxtNama.Location = New System.Drawing.Point(9, 53)
        Me.TxtNama.Multiline = True
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(250, 99)
        Me.TxtNama.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Nama Transaksi"
        '
        'GridView
        '
        Me.GridView.AllowUserToAddRows = False
        Me.GridView.AllowUserToDeleteRows = False
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tanggal, Me.Keterangan, Me.Kategori, Me.Nominal})
        Me.GridView.Location = New System.Drawing.Point(270, 37)
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.ShowEditingIcon = False
        Me.GridView.Size = New System.Drawing.Size(460, 260)
        Me.GridView.TabIndex = 55
        '
        'Tanggal
        '
        Me.Tanggal.HeaderText = "Tanggal Transaksi"
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.ReadOnly = True
        '
        'Keterangan
        '
        Me.Keterangan.HeaderText = "Nama Transaksi"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        '
        'Kategori
        '
        Me.Kategori.HeaderText = "Kategori"
        Me.Kategori.Name = "Kategori"
        Me.Kategori.ReadOnly = True
        '
        'Nominal
        '
        Me.Nominal.HeaderText = "Nominal"
        Me.Nominal.Name = "Nominal"
        Me.Nominal.ReadOnly = True
        Me.Nominal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TP1
        '
        Me.TP1.Controls.Add(Me.CmdTampil)
        Me.TP1.Controls.Add(Me.DataGridView1)
        Me.TP1.Controls.Add(Me.CmdCetak)
        Me.TP1.Controls.Add(Me.EDate)
        Me.TP1.Controls.Add(Me.Label7)
        Me.TP1.Controls.Add(Me.Label3)
        Me.TP1.Controls.Add(Me.SDate)
        Me.TP1.Location = New System.Drawing.Point(4, 22)
        Me.TP1.Name = "TP1"
        Me.TP1.Size = New System.Drawing.Size(741, 333)
        Me.TP1.TabIndex = 2
        Me.TP1.Text = "Laporan Pengeluaran"
        Me.TP1.UseVisualStyleBackColor = True
        '
        'CmdTampil
        '
        Me.CmdTampil.Location = New System.Drawing.Point(318, 12)
        Me.CmdTampil.Name = "CmdTampil"
        Me.CmdTampil.Size = New System.Drawing.Size(95, 21)
        Me.CmdTampil.TabIndex = 80
        Me.CmdTampil.Text = "Tampilkan Data"
        Me.CmdTampil.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(500, 279)
        Me.DataGridView1.TabIndex = 79
        '
        'CmdCetak
        '
        Me.CmdCetak.Location = New System.Drawing.Point(419, 12)
        Me.CmdCetak.Name = "CmdCetak"
        Me.CmdCetak.Size = New System.Drawing.Size(99, 21)
        Me.CmdCetak.TabIndex = 78
        Me.CmdCetak.Text = "Simpan Ke Excel"
        Me.CmdCetak.UseVisualStyleBackColor = True
        '
        'EDate
        '
        Me.EDate.CustomFormat = "dd-MM-yyyy"
        Me.EDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EDate.Location = New System.Drawing.Point(225, 13)
        Me.EDate.Name = "EDate"
        Me.EDate.Size = New System.Drawing.Size(87, 20)
        Me.EDate.TabIndex = 55
        Me.EDate.Value = New Date(2016, 5, 3, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(209, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Tanggal Transaksi"
        '
        'SDate
        '
        Me.SDate.CustomFormat = "dd-MM-yyyy"
        Me.SDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SDate.Location = New System.Drawing.Point(116, 13)
        Me.SDate.Name = "SDate"
        Me.SDate.Size = New System.Drawing.Size(87, 20)
        Me.SDate.TabIndex = 52
        Me.SDate.Value = New Date(2016, 5, 3, 0, 0, 0, 0)
        '
        'ExpenseFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(772, 381)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExpenseFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FinanceFrm"
        Me.TabControl1.ResumeLayout(False)
        Me.TP.ResumeLayout(False)
        Me.TP.PerformLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP1.ResumeLayout(False)
        Me.TP1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TP As System.Windows.Forms.TabPage
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmdHapus As System.Windows.Forms.Button
    Friend WithEvents CmdTambah As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CbxKategori As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents CmdHTambah As System.Windows.Forms.Button
    Friend WithEvents TxtNominal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents Tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kategori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nominal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TP1 As System.Windows.Forms.TabPage
    Friend WithEvents EDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdCetak As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CmdTampil As System.Windows.Forms.Button
End Class

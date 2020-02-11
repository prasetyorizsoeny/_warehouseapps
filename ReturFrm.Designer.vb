<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturFrm))
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnTambah = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtJumlah = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.CbxKondisi = New System.Windows.Forms.ComboBox
        Me.TxtUkuran = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DGVRetur = New System.Windows.Forms.DataGridView
        Me.Warna = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ukuran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Catatan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DGVItem = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtKeterangan = New System.Windows.Forms.TextBox
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtWarna = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTP = New System.Windows.Forms.DateTimePicker
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnTampil = New System.Windows.Forms.Button
        Me.CbxJenis = New System.Windows.Forms.ComboBox
        Me.CbxSuratJalan = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtNota = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVRetur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(1005, 201)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(62, 24)
        Me.BtnHapus.TabIndex = 45
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(345, 48)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(62, 56)
        Me.BtnTambah.TabIndex = 44
        Me.BtnTambah.Text = "Tambah ke List Retur"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Tanggal"
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJumlah.Location = New System.Drawing.Point(896, 83)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(51, 21)
        Me.TxtJumlah.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(839, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Jumlah"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CbxKondisi)
        Me.Panel1.Controls.Add(Me.TxtUkuran)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtKeterangan)
        Me.Panel1.Controls.Add(Me.BtnUpdate)
        Me.Panel1.Controls.Add(Me.BtnHapus)
        Me.Panel1.Controls.Add(Me.BtnTambah)
        Me.Panel1.Controls.Add(Me.TxtJumlah)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtWarna)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(14, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1094, 306)
        Me.Panel1.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(838, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Kondisi"
        '
        'CbxKondisi
        '
        Me.CbxKondisi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbxKondisi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxKondisi.BackColor = System.Drawing.Color.LightYellow
        Me.CbxKondisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxKondisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxKondisi.FormattingEnabled = True
        Me.CbxKondisi.Items.AddRange(New Object() {"Barang tidak laku", "Barang rusak"})
        Me.CbxKondisi.Location = New System.Drawing.Point(895, 108)
        Me.CbxKondisi.Name = "CbxKondisi"
        Me.CbxKondisi.Size = New System.Drawing.Size(122, 23)
        Me.CbxKondisi.TabIndex = 62
        '
        'TxtUkuran
        '
        Me.TxtUkuran.Enabled = False
        Me.TxtUkuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUkuran.Location = New System.Drawing.Point(896, 56)
        Me.TxtUkuran.Name = "TxtUkuran"
        Me.TxtUkuran.ReadOnly = True
        Me.TxtUkuran.Size = New System.Drawing.Size(51, 21)
        Me.TxtUkuran.TabIndex = 55
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGVRetur)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(414, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(419, 293)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Retur"
        '
        'DGVRetur
        '
        Me.DGVRetur.AllowUserToAddRows = False
        Me.DGVRetur.AllowUserToDeleteRows = False
        Me.DGVRetur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRetur.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Warna, Me.Ukuran, Me.Jumlah, Me.Kondisi, Me.Catatan, Me.OrderNo})
        Me.DGVRetur.Location = New System.Drawing.Point(6, 20)
        Me.DGVRetur.Name = "DGVRetur"
        Me.DGVRetur.ReadOnly = True
        Me.DGVRetur.ShowEditingIcon = False
        Me.DGVRetur.Size = New System.Drawing.Size(407, 259)
        Me.DGVRetur.TabIndex = 54
        '
        'Warna
        '
        Me.Warna.HeaderText = "Warna"
        Me.Warna.Name = "Warna"
        Me.Warna.ReadOnly = True
        Me.Warna.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Ukuran
        '
        Me.Ukuran.HeaderText = "Ukuran"
        Me.Ukuran.Name = "Ukuran"
        Me.Ukuran.ReadOnly = True
        Me.Ukuran.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Ukuran.Width = 50
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        Me.Jumlah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Jumlah.Width = 45
        '
        'Kondisi
        '
        Me.Kondisi.HeaderText = "Kondisi"
        Me.Kondisi.Name = "Kondisi"
        Me.Kondisi.ReadOnly = True
        '
        'Catatan
        '
        Me.Catatan.HeaderText = "Catatan"
        Me.Catatan.Name = "Catatan"
        Me.Catatan.ReadOnly = True
        '
        'OrderNo
        '
        Me.OrderNo.HeaderText = "OrderNo"
        Me.OrderNo.Name = "OrderNo"
        Me.OrderNo.ReadOnly = True
        Me.OrderNo.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVItem)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 293)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List PO"
        '
        'DGVItem
        '
        Me.DGVItem.AllowUserToAddRows = False
        Me.DGVItem.AllowUserToDeleteRows = False
        Me.DGVItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVItem.Location = New System.Drawing.Point(5, 20)
        Me.DGVItem.MultiSelect = False
        Me.DGVItem.Name = "DGVItem"
        Me.DGVItem.ReadOnly = True
        Me.DGVItem.ShowEditingIcon = False
        Me.DGVItem.Size = New System.Drawing.Size(326, 259)
        Me.DGVItem.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(838, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Catatan"
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeterangan.Location = New System.Drawing.Point(896, 136)
        Me.TxtKeterangan.Multiline = True
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(171, 59)
        Me.TxtKeterangan.TabIndex = 57
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(895, 201)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(62, 24)
        Me.BtnUpdate.TabIndex = 51
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(839, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Ukuran"
        '
        'TxtWarna
        '
        Me.TxtWarna.Enabled = False
        Me.TxtWarna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWarna.Location = New System.Drawing.Point(895, 31)
        Me.TxtWarna.Name = "TxtWarna"
        Me.TxtWarna.ReadOnly = True
        Me.TxtWarna.Size = New System.Drawing.Size(172, 21)
        Me.TxtWarna.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(839, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Warna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Jenis Retur"
        '
        'DTP
        '
        Me.DTP.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.DTP.CustomFormat = "dd-MM-yyyy"
        Me.DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP.Location = New System.Drawing.Point(70, 13)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(87, 21)
        Me.DTP.TabIndex = 48
        Me.DTP.Value = New Date(2016, 5, 3, 0, 0, 0, 0)
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(972, 11)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(135, 24)
        Me.BtnSimpan.TabIndex = 56
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Nota Retur"
        '
        'BtnTampil
        '
        Me.BtnTampil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTampil.Location = New System.Drawing.Point(576, 11)
        Me.BtnTampil.Name = "BtnTampil"
        Me.BtnTampil.Size = New System.Drawing.Size(127, 24)
        Me.BtnTampil.TabIndex = 59
        Me.BtnTampil.Text = "Tampilkan Item"
        Me.BtnTampil.UseVisualStyleBackColor = True
        '
        'CbxJenis
        '
        Me.CbxJenis.BackColor = System.Drawing.Color.LightYellow
        Me.CbxJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxJenis.FormattingEnabled = True
        Me.CbxJenis.Items.AddRange(New Object() {"Barang Masuk", "Barang Keluar"})
        Me.CbxJenis.Location = New System.Drawing.Point(239, 11)
        Me.CbxJenis.Name = "CbxJenis"
        Me.CbxJenis.Size = New System.Drawing.Size(114, 23)
        Me.CbxJenis.TabIndex = 60
        '
        'CbxSuratJalan
        '
        Me.CbxSuratJalan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbxSuratJalan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxSuratJalan.BackColor = System.Drawing.Color.LightYellow
        Me.CbxSuratJalan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSuratJalan.FormattingEnabled = True
        Me.CbxSuratJalan.Location = New System.Drawing.Point(437, 11)
        Me.CbxSuratJalan.Name = "CbxSuratJalan"
        Me.CbxSuratJalan.Size = New System.Drawing.Size(122, 23)
        Me.CbxSuratJalan.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(733, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Nota Baru "
        '
        'TxtNota
        '
        Me.TxtNota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtNota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtNota.BackColor = System.Drawing.Color.LightYellow
        Me.TxtNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.TxtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota.FormattingEnabled = True
        Me.TxtNota.Location = New System.Drawing.Point(795, 11)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(122, 23)
        Me.TxtNota.TabIndex = 63
        '
        'ReturFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1120, 365)
        Me.Controls.Add(Me.TxtNota)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CbxSuratJalan)
        Me.Controls.Add(Me.CbxJenis)
        Me.Controls.Add(Me.BtnTampil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReturFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retur"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGVRetur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnTampil As System.Windows.Forms.Button
    Friend WithEvents CbxJenis As System.Windows.Forms.ComboBox
    Friend WithEvents DGVRetur As System.Windows.Forms.DataGridView
    Friend WithEvents DGVItem As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtWarna As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents CbxSuratJalan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtUkuran As System.Windows.Forms.TextBox
    Friend WithEvents CbxKondisi As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNota As System.Windows.Forms.ComboBox
    Friend WithEvents Warna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ukuran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kondisi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Catatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

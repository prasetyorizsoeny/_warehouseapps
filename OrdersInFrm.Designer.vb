<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersInFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersInFrm))
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtKeterangan = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.LstTipe = New System.Windows.Forms.ComboBox
        Me.LstJenis = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GridView = New System.Windows.Forms.DataGridView
        Me.Warna = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ukuran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jenis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Catatan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnDTambah = New System.Windows.Forms.Button
        Me.txtjml = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTPO = New System.Windows.Forms.DateTimePicker
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.BtnHTambah = New System.Windows.Forms.Button
        Me.BtnBatal = New System.Windows.Forms.Button
        Me.txtsumqty = New System.Windows.Forms.TextBox
        Me.TxtSJ = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtDocNo = New System.Windows.Forms.ComboBox
        Me.TxtDO = New System.Windows.Forms.ComboBox
        Me.TxtPO = New System.Windows.Forms.ComboBox
        Me.TxtAlmtCbg = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtNmSpr = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtGM = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtmkt = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtStpm = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtAlmt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtPlatNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtNmPgr = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtWarna = New System.Windows.Forms.ComboBox
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Tanggal"
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeterangan.Location = New System.Drawing.Point(461, 45)
        Me.TxtKeterangan.Multiline = True
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(239, 21)
        Me.TxtKeterangan.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(458, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Catatan"
        '
        'LstTipe
        '
        Me.LstTipe.BackColor = System.Drawing.Color.LightYellow
        Me.LstTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LstTipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LstTipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstTipe.FormattingEnabled = True
        Me.LstTipe.Location = New System.Drawing.Point(153, 47)
        Me.LstTipe.Name = "LstTipe"
        Me.LstTipe.Size = New System.Drawing.Size(52, 23)
        Me.LstTipe.TabIndex = 15
        '
        'LstJenis
        '
        Me.LstJenis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LstJenis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LstJenis.BackColor = System.Drawing.Color.LightYellow
        Me.LstJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LstJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LstJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstJenis.FormattingEnabled = True
        Me.LstJenis.Location = New System.Drawing.Point(211, 46)
        Me.LstJenis.Name = "LstJenis"
        Me.LstJenis.Size = New System.Drawing.Size(187, 23)
        Me.LstJenis.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(208, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Jenis"
        '
        'GridView
        '
        Me.GridView.AllowUserToAddRows = False
        Me.GridView.AllowUserToDeleteRows = False
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Warna, Me.Ukuran, Me.Jenis, Me.Jumlah, Me.Catatan})
        Me.GridView.Location = New System.Drawing.Point(14, 74)
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.ShowEditingIcon = False
        Me.GridView.Size = New System.Drawing.Size(822, 154)
        Me.GridView.TabIndex = 55
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
        'Jenis
        '
        Me.Jenis.HeaderText = "Jenis"
        Me.Jenis.Name = "Jenis"
        Me.Jenis.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        Me.Jumlah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Jumlah.Width = 45
        '
        'Catatan
        '
        Me.Catatan.HeaderText = "Catatan"
        Me.Catatan.Name = "Catatan"
        Me.Catatan.ReadOnly = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(774, 42)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(62, 24)
        Me.BtnHapus.TabIndex = 20
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnDTambah
        '
        Me.BtnDTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDTambah.Location = New System.Drawing.Point(706, 43)
        Me.BtnDTambah.Name = "BtnDTambah"
        Me.BtnDTambah.Size = New System.Drawing.Size(62, 24)
        Me.BtnDTambah.TabIndex = 19
        Me.BtnDTambah.Text = "Tambah"
        Me.BtnDTambah.UseVisualStyleBackColor = True
        '
        'txtjml
        '
        Me.txtjml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjml.Location = New System.Drawing.Point(404, 46)
        Me.txtjml.Name = "txtjml"
        Me.txtjml.Size = New System.Drawing.Size(51, 21)
        Me.txtjml.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(401, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(150, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Ukuran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Warna"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 514)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 15)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Jumlah Barang Masuk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "No. PO"
        '
        'DTPO
        '
        Me.DTPO.CustomFormat = "dd-MM-yyyy"
        Me.DTPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPO.Location = New System.Drawing.Point(112, 21)
        Me.DTPO.Name = "DTPO"
        Me.DTPO.Size = New System.Drawing.Size(85, 21)
        Me.DTPO.TabIndex = 1
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(671, 514)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(62, 24)
        Me.BtnSimpan.TabIndex = 21
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 15)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "No. DO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 15)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "No. Dokumen"
        '
        'BtnHTambah
        '
        Me.BtnHTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHTambah.Location = New System.Drawing.Point(203, 19)
        Me.BtnHTambah.Name = "BtnHTambah"
        Me.BtnHTambah.Size = New System.Drawing.Size(79, 24)
        Me.BtnHTambah.TabIndex = 0
        Me.BtnHTambah.Text = "Buat Baru"
        Me.BtnHTambah.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Location = New System.Drawing.Point(742, 514)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(62, 24)
        Me.BtnBatal.TabIndex = 22
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'txtsumqty
        '
        Me.txtsumqty.Enabled = False
        Me.txtsumqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsumqty.Location = New System.Drawing.Point(151, 513)
        Me.txtsumqty.Name = "txtsumqty"
        Me.txtsumqty.Size = New System.Drawing.Size(133, 21)
        Me.txtsumqty.TabIndex = 78
        '
        'TxtSJ
        '
        Me.TxtSJ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtSJ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtSJ.BackColor = System.Drawing.Color.LightYellow
        Me.TxtSJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSJ.FormattingEnabled = True
        Me.TxtSJ.Location = New System.Drawing.Point(112, 124)
        Me.TxtSJ.Name = "TxtSJ"
        Me.TxtSJ.Size = New System.Drawing.Size(260, 23)
        Me.TxtSJ.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 124)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 15)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = "Surat Jalan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDocNo)
        Me.GroupBox1.Controls.Add(Me.TxtDO)
        Me.GroupBox1.Controls.Add(Me.TxtPO)
        Me.GroupBox1.Controls.Add(Me.TxtAlmtCbg)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.TxtNmSpr)
        Me.GroupBox1.Controls.Add(Me.BtnHTambah)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TxtGM)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtmkt)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxtStpm)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TxtAlmt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtPlatNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNmPgr)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TxtSJ)
        Me.GroupBox1.Controls.Add(Me.DTPO)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(854, 252)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Input Barang Masuk "
        '
        'TxtDocNo
        '
        Me.TxtDocNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtDocNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtDocNo.BackColor = System.Drawing.Color.LightYellow
        Me.TxtDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocNo.FormattingEnabled = True
        Me.TxtDocNo.Location = New System.Drawing.Point(112, 97)
        Me.TxtDocNo.Name = "TxtDocNo"
        Me.TxtDocNo.Size = New System.Drawing.Size(260, 23)
        Me.TxtDocNo.TabIndex = 4
        '
        'TxtDO
        '
        Me.TxtDO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtDO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtDO.BackColor = System.Drawing.Color.LightYellow
        Me.TxtDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDO.FormattingEnabled = True
        Me.TxtDO.Location = New System.Drawing.Point(112, 71)
        Me.TxtDO.Name = "TxtDO"
        Me.TxtDO.Size = New System.Drawing.Size(260, 23)
        Me.TxtDO.TabIndex = 3
        '
        'TxtPO
        '
        Me.TxtPO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtPO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtPO.BackColor = System.Drawing.Color.LightYellow
        Me.TxtPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPO.FormattingEnabled = True
        Me.TxtPO.Location = New System.Drawing.Point(112, 46)
        Me.TxtPO.Name = "TxtPO"
        Me.TxtPO.Size = New System.Drawing.Size(260, 23)
        Me.TxtPO.TabIndex = 2
        '
        'TxtAlmtCbg
        '
        Me.TxtAlmtCbg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlmtCbg.Location = New System.Drawing.Point(475, 152)
        Me.TxtAlmtCbg.Multiline = True
        Me.TxtAlmtCbg.Name = "TxtAlmtCbg"
        Me.TxtAlmtCbg.Size = New System.Drawing.Size(249, 60)
        Me.TxtAlmtCbg.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(378, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 15)
        Me.Label19.TabIndex = 111
        Me.Label19.Text = "Alamat Cabang"
        '
        'TxtNmSpr
        '
        Me.TxtNmSpr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNmSpr.Location = New System.Drawing.Point(475, 44)
        Me.TxtNmSpr.Name = "TxtNmSpr"
        Me.TxtNmSpr.Size = New System.Drawing.Size(249, 21)
        Me.TxtNmSpr.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(379, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 15)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Nama Supir"
        '
        'TxtGM
        '
        Me.TxtGM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGM.Location = New System.Drawing.Point(475, 219)
        Me.TxtGM.Name = "TxtGM"
        Me.TxtGM.Size = New System.Drawing.Size(249, 21)
        Me.TxtGM.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(379, 219)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 15)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "Nama GM"
        '
        'txtmkt
        '
        Me.txtmkt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmkt.Location = New System.Drawing.Point(112, 218)
        Me.txtmkt.Name = "txtmkt"
        Me.txtmkt.Size = New System.Drawing.Size(260, 21)
        Me.txtmkt.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 218)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 15)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "Nama Marketing"
        '
        'TxtStpm
        '
        Me.TxtStpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStpm.Location = New System.Drawing.Point(475, 125)
        Me.TxtStpm.Name = "TxtStpm"
        Me.TxtStpm.Size = New System.Drawing.Size(249, 21)
        Me.TxtStpm.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(378, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 15)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "Nama Satpam"
        '
        'TxtAlmt
        '
        Me.TxtAlmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAlmt.Location = New System.Drawing.Point(112, 151)
        Me.TxtAlmt.Multiline = True
        Me.TxtAlmt.Name = "TxtAlmt"
        Me.TxtAlmt.Size = New System.Drawing.Size(260, 61)
        Me.TxtAlmt.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Alamat Pengirim"
        '
        'TxtPlatNo
        '
        Me.TxtPlatNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlatNo.Location = New System.Drawing.Point(475, 98)
        Me.TxtPlatNo.Name = "TxtPlatNo"
        Me.TxtPlatNo.Size = New System.Drawing.Size(249, 21)
        Me.TxtPlatNo.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(379, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "No. Plat Mobil"
        '
        'TxtNmPgr
        '
        Me.TxtNmPgr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNmPgr.Location = New System.Drawing.Point(475, 72)
        Me.TxtNmPgr.Name = "TxtNmPgr"
        Me.TxtNmPgr.Size = New System.Drawing.Size(249, 21)
        Me.TxtNmPgr.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(378, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Nama Pengirim"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtWarna)
        Me.GroupBox2.Controls.Add(Me.GridView)
        Me.GroupBox2.Controls.Add(Me.LstTipe)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LstJenis)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtKeterangan)
        Me.GroupBox2.Controls.Add(Me.txtjml)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.BtnDTambah)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(854, 245)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Input Detail Barang Masuk "
        '
        'TxtWarna
        '
        Me.TxtWarna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtWarna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtWarna.BackColor = System.Drawing.Color.LightYellow
        Me.TxtWarna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtWarna.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TxtWarna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWarna.FormattingEnabled = True
        Me.TxtWarna.Location = New System.Drawing.Point(13, 47)
        Me.TxtWarna.Name = "TxtWarna"
        Me.TxtWarna.Size = New System.Drawing.Size(134, 23)
        Me.TxtWarna.TabIndex = 14
        '
        'OrdersInFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(878, 545)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtsumqty)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnSimpan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OrdersInFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang Masuk"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnDTambah As System.Windows.Forms.Button
    Friend WithEvents txtjml As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPO As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnHTambah As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents txtsumqty As System.Windows.Forms.TextBox
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSJ As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LstJenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Warna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ukuran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Catatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LstTipe As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAlmtCbg As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtNmSpr As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtGM As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtmkt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtStpm As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtAlmt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPlatNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNmPgr As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtWarna As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDocNo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDO As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPO As System.Windows.Forms.ComboBox
End Class

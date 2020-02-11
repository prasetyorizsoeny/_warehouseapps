<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersOutFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersOutFrm))
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPenerima = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtHarga = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtKeterangan = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnDTambah = New System.Windows.Forms.Button
        Me.TxtByr = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtJml = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnHTambah = New System.Windows.Forms.Button
        Me.TxtTempo = New System.Windows.Forms.TextBox
        Me.TxtTempoDate = New System.Windows.Forms.TextBox
        Me.TxtNamaPembeli = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtSJ = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnKonsinyasi = New System.Windows.Forms.Button
        Me.LstRefNota = New System.Windows.Forms.ComboBox
        Me.txtidpembeli = New System.Windows.Forms.TextBox
        Me.LinkPembeli = New System.Windows.Forms.LinkLabel
        Me.TxtBiayaKirim = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.LstJenisHarga = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.LstPembayaran = New System.Windows.Forms.ComboBox
        Me.DTP = New System.Windows.Forms.DateTimePicker
        Me.BtnBatal = New System.Windows.Forms.Button
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.txtsumqty = New System.Windows.Forms.TextBox
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.TxtSisa = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtWarna = New System.Windows.Forms.ComboBox
        Me.LstTipe = New System.Windows.Forms.ComboBox
        Me.LstJenis = New System.Windows.Forms.ComboBox
        Me.GridView = New System.Windows.Forms.DataGridView
        Me.Warna = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ukuran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jenis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Bayar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Catatan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KonsinyasiF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tanggal"
        '
        'TxtPenerima
        '
        Me.TxtPenerima.BackColor = System.Drawing.Color.White
        Me.TxtPenerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPenerima.Location = New System.Drawing.Point(496, 27)
        Me.TxtPenerima.Name = "TxtPenerima"
        Me.TxtPenerima.Size = New System.Drawing.Size(261, 21)
        Me.TxtPenerima.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Penerima"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Pembayaran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Tipe Harga"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(211, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Jenis"
        '
        'TxtHarga
        '
        Me.TxtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHarga.Location = New System.Drawing.Point(470, 50)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(92, 21)
        Me.TxtHarga.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(467, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Harga"
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeterangan.Location = New System.Drawing.Point(666, 50)
        Me.TxtKeterangan.Multiline = True
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(160, 20)
        Me.TxtKeterangan.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(663, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 15)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Catatan"
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(832, 77)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(69, 27)
        Me.BtnHapus.TabIndex = 18
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnDTambah
        '
        Me.BtnDTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDTambah.Location = New System.Drawing.Point(832, 44)
        Me.BtnDTambah.Name = "BtnDTambah"
        Me.BtnDTambah.Size = New System.Drawing.Size(69, 27)
        Me.BtnDTambah.TabIndex = 17
        Me.BtnDTambah.Text = "Tambah"
        Me.BtnDTambah.UseVisualStyleBackColor = True
        '
        'TxtByr
        '
        Me.TxtByr.Enabled = False
        Me.TxtByr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtByr.Location = New System.Drawing.Point(568, 50)
        Me.TxtByr.Name = "TxtByr"
        Me.TxtByr.Size = New System.Drawing.Size(92, 21)
        Me.TxtByr.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(565, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 15)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Bayar"
        '
        'TxtJml
        '
        Me.TxtJml.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJml.Location = New System.Drawing.Point(413, 50)
        Me.TxtJml.Name = "TxtJml"
        Me.TxtJml.Size = New System.Drawing.Size(51, 21)
        Me.TxtJml.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(410, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(152, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Ukuran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Warna"
        '
        'BtnHTambah
        '
        Me.BtnHTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHTambah.Location = New System.Drawing.Point(179, 28)
        Me.BtnHTambah.Name = "BtnHTambah"
        Me.BtnHTambah.Size = New System.Drawing.Size(69, 24)
        Me.BtnHTambah.TabIndex = 0
        Me.BtnHTambah.Text = "Buat Baru"
        Me.BtnHTambah.UseVisualStyleBackColor = True
        '
        'TxtTempo
        '
        Me.TxtTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTempo.Location = New System.Drawing.Point(496, 84)
        Me.TxtTempo.Name = "TxtTempo"
        Me.TxtTempo.Size = New System.Drawing.Size(49, 21)
        Me.TxtTempo.TabIndex = 6
        '
        'TxtTempoDate
        '
        Me.TxtTempoDate.Enabled = False
        Me.TxtTempoDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTempoDate.Location = New System.Drawing.Point(551, 84)
        Me.TxtTempoDate.Name = "TxtTempoDate"
        Me.TxtTempoDate.Size = New System.Drawing.Size(118, 21)
        Me.TxtTempoDate.TabIndex = 84
        '
        'TxtNamaPembeli
        '
        Me.TxtNamaPembeli.Enabled = False
        Me.TxtNamaPembeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaPembeli.Location = New System.Drawing.Point(173, 113)
        Me.TxtNamaPembeli.Name = "TxtNamaPembeli"
        Me.TxtNamaPembeli.Size = New System.Drawing.Size(204, 21)
        Me.TxtNamaPembeli.TabIndex = 87
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 15)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Nota"
        '
        'TxtSJ
        '
        Me.TxtSJ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtSJ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtSJ.BackColor = System.Drawing.Color.LightYellow
        Me.TxtSJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.TxtSJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSJ.FormattingEnabled = True
        Me.TxtSJ.Location = New System.Drawing.Point(86, 57)
        Me.TxtSJ.Name = "TxtSJ"
        Me.TxtSJ.Size = New System.Drawing.Size(162, 23)
        Me.TxtSJ.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnKonsinyasi)
        Me.GroupBox1.Controls.Add(Me.LstRefNota)
        Me.GroupBox1.Controls.Add(Me.txtidpembeli)
        Me.GroupBox1.Controls.Add(Me.LinkPembeli)
        Me.GroupBox1.Controls.Add(Me.TxtBiayaKirim)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.LstJenisHarga)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.LstPembayaran)
        Me.GroupBox1.Controls.Add(Me.DTP)
        Me.GroupBox1.Controls.Add(Me.TxtTempoDate)
        Me.GroupBox1.Controls.Add(Me.TxtSJ)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNamaPembeli)
        Me.GroupBox1.Controls.Add(Me.TxtPenerima)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtTempo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnHTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(916, 143)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Barang Keluar"
        '
        'BtnKonsinyasi
        '
        Me.BtnKonsinyasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKonsinyasi.Location = New System.Drawing.Point(763, 51)
        Me.BtnKonsinyasi.Name = "BtnKonsinyasi"
        Me.BtnKonsinyasi.Size = New System.Drawing.Size(113, 27)
        Me.BtnKonsinyasi.TabIndex = 102
        Me.BtnKonsinyasi.Text = "Tampilkan Item"
        Me.BtnKonsinyasi.UseVisualStyleBackColor = True
        '
        'LstRefNota
        '
        Me.LstRefNota.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LstRefNota.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LstRefNota.BackColor = System.Drawing.Color.LightYellow
        Me.LstRefNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstRefNota.FormattingEnabled = True
        Me.LstRefNota.Location = New System.Drawing.Point(595, 54)
        Me.LstRefNota.Name = "LstRefNota"
        Me.LstRefNota.Size = New System.Drawing.Size(162, 23)
        Me.LstRefNota.TabIndex = 25
        '
        'txtidpembeli
        '
        Me.txtidpembeli.Enabled = False
        Me.txtidpembeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidpembeli.Location = New System.Drawing.Point(86, 113)
        Me.txtidpembeli.Name = "txtidpembeli"
        Me.txtidpembeli.Size = New System.Drawing.Size(81, 21)
        Me.txtidpembeli.TabIndex = 100
        '
        'LinkPembeli
        '
        Me.LinkPembeli.AutoSize = True
        Me.LinkPembeli.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkPembeli.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkPembeli.Location = New System.Drawing.Point(12, 117)
        Me.LinkPembeli.Name = "LinkPembeli"
        Me.LinkPembeli.Size = New System.Drawing.Size(44, 13)
        Me.LinkPembeli.TabIndex = 4
        Me.LinkPembeli.TabStop = True
        Me.LinkPembeli.Text = "Pembeli"
        '
        'TxtBiayaKirim
        '
        Me.TxtBiayaKirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBiayaKirim.Location = New System.Drawing.Point(496, 110)
        Me.TxtBiayaKirim.Name = "TxtBiayaKirim"
        Me.TxtBiayaKirim.Size = New System.Drawing.Size(92, 21)
        Me.TxtBiayaKirim.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(414, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 15)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "Biaya Kirim"
        '
        'LstJenisHarga
        '
        Me.LstJenisHarga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LstJenisHarga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LstJenisHarga.BackColor = System.Drawing.Color.White
        Me.LstJenisHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstJenisHarga.FormattingEnabled = True
        Me.LstJenisHarga.Items.AddRange(New Object() {"Reseller", "Toko", "EndUser"})
        Me.LstJenisHarga.Location = New System.Drawing.Point(86, 86)
        Me.LstJenisHarga.Name = "LstJenisHarga"
        Me.LstJenisHarga.Size = New System.Drawing.Size(162, 23)
        Me.LstJenisHarga.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(414, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 15)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "Hari"
        '
        'LstPembayaran
        '
        Me.LstPembayaran.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LstPembayaran.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LstPembayaran.BackColor = System.Drawing.Color.White
        Me.LstPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstPembayaran.FormattingEnabled = True
        Me.LstPembayaran.Items.AddRange(New Object() {"Tunai", "Tempo", "Konsinyasi"})
        Me.LstPembayaran.Location = New System.Drawing.Point(496, 54)
        Me.LstPembayaran.Name = "LstPembayaran"
        Me.LstPembayaran.Size = New System.Drawing.Size(93, 23)
        Me.LstPembayaran.TabIndex = 5
        '
        'DTP
        '
        Me.DTP.CustomFormat = "dd-MM-yyyy"
        Me.DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP.Location = New System.Drawing.Point(86, 30)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(85, 21)
        Me.DTP.TabIndex = 1
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Location = New System.Drawing.Point(844, 468)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(69, 25)
        Me.BtnBatal.TabIndex = 20
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(414, 468)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(133, 21)
        Me.txttotal.TabIndex = 100
        '
        'txtsumqty
        '
        Me.txtsumqty.Enabled = False
        Me.txtsumqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsumqty.Location = New System.Drawing.Point(134, 468)
        Me.txtsumqty.Name = "txtsumqty"
        Me.txtsumqty.Size = New System.Drawing.Size(133, 21)
        Me.txtsumqty.TabIndex = 99
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(768, 469)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(69, 25)
        Me.BtnSimpan.TabIndex = 19
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 15)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Total Barang Keluar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 469)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 15)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Jumlah Barang Keluar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnUpdate)
        Me.GroupBox2.Controls.Add(Me.TxtSisa)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TxtWarna)
        Me.GroupBox2.Controls.Add(Me.LstTipe)
        Me.GroupBox2.Controls.Add(Me.LstJenis)
        Me.GroupBox2.Controls.Add(Me.GridView)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnDTambah)
        Me.GroupBox2.Controls.Add(Me.TxtHarga)
        Me.GroupBox2.Controls.Add(Me.TxtKeterangan)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtByr)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtJml)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(916, 305)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Detail Barang Keluar"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(832, 110)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(69, 27)
        Me.BtnUpdate.TabIndex = 101
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'TxtSisa
        '
        Me.TxtSisa.Enabled = False
        Me.TxtSisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSisa.Location = New System.Drawing.Point(362, 50)
        Me.TxtSisa.Name = "TxtSisa"
        Me.TxtSisa.Size = New System.Drawing.Size(45, 21)
        Me.TxtSisa.TabIndex = 100
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(359, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 15)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "Sisa"
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
        Me.TxtWarna.Location = New System.Drawing.Point(15, 49)
        Me.TxtWarna.Name = "TxtWarna"
        Me.TxtWarna.Size = New System.Drawing.Size(134, 23)
        Me.TxtWarna.TabIndex = 9
        '
        'LstTipe
        '
        Me.LstTipe.BackColor = System.Drawing.Color.LightYellow
        Me.LstTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LstTipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LstTipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstTipe.FormattingEnabled = True
        Me.LstTipe.Location = New System.Drawing.Point(155, 49)
        Me.LstTipe.Name = "LstTipe"
        Me.LstTipe.Size = New System.Drawing.Size(52, 23)
        Me.LstTipe.TabIndex = 10
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
        Me.LstJenis.Location = New System.Drawing.Point(213, 49)
        Me.LstJenis.Name = "LstJenis"
        Me.LstJenis.Size = New System.Drawing.Size(143, 23)
        Me.LstJenis.TabIndex = 11
        '
        'GridView
        '
        Me.GridView.AllowUserToAddRows = False
        Me.GridView.AllowUserToDeleteRows = False
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Warna, Me.Ukuran, Me.Jenis, Me.Jumlah, Me.Harga, Me.Bayar, Me.Catatan, Me.KonsinyasiF, Me.ID})
        Me.GridView.Location = New System.Drawing.Point(12, 76)
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.ShowEditingIcon = False
        Me.GridView.Size = New System.Drawing.Size(814, 212)
        Me.GridView.TabIndex = 98
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
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        Me.Harga.ReadOnly = True
        '
        'Bayar
        '
        Me.Bayar.HeaderText = "Bayar"
        Me.Bayar.Name = "Bayar"
        Me.Bayar.ReadOnly = True
        '
        'Catatan
        '
        Me.Catatan.HeaderText = "Catatan"
        Me.Catatan.Name = "Catatan"
        Me.Catatan.ReadOnly = True
        '
        'KonsinyasiF
        '
        Me.KonsinyasiF.HeaderText = "Konsinyasi"
        Me.KonsinyasiF.Name = "KonsinyasiF"
        Me.KonsinyasiF.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'OrdersOutFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(939, 500)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtsumqty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OrdersOutFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang Keluar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPenerima As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtJml As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtByr As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnDTambah As System.Windows.Forms.Button
    Friend WithEvents BtnHTambah As System.Windows.Forms.Button
    Friend WithEvents TxtTempo As System.Windows.Forms.TextBox
    Friend WithEvents TxtTempoDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtNamaPembeli As System.Windows.Forms.TextBox
    Friend WithEvents TxtHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtSJ As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents LstPembayaran As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LstJenisHarga As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBiayaKirim As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtsumqty As System.Windows.Forms.TextBox
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents TxtWarna As System.Windows.Forms.ComboBox
    Friend WithEvents LstTipe As System.Windows.Forms.ComboBox
    Friend WithEvents LstJenis As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSisa As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LinkPembeli As System.Windows.Forms.LinkLabel
    Friend WithEvents txtidpembeli As System.Windows.Forms.TextBox
    Friend WithEvents LstRefNota As System.Windows.Forms.ComboBox
    Friend WithEvents BtnKonsinyasi As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents Warna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ukuran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bayar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Catatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KonsinyasiF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

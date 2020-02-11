<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryHFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QueryHFrm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtPO = New System.Windows.Forms.TextBox
        Me.TxtDO = New System.Windows.Forms.TextBox
        Me.TxtDok = New System.Windows.Forms.TextBox
        Me.TxtMkt = New System.Windows.Forms.TextBox
        Me.TxtGM = New System.Windows.Forms.TextBox
        Me.TC = New System.Windows.Forms.TabControl
        Me.TP1 = New System.Windows.Forms.TabPage
        Me.Label30 = New System.Windows.Forms.Label
        Me.TxtSrtJln = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.EDate = New System.Windows.Forms.DateTimePicker
        Me.SDate = New System.Windows.Forms.DateTimePicker
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TP2 = New System.Windows.Forms.TabPage
        Me.LstJenisHarga = New System.Windows.Forms.ComboBox
        Me.LstPembayaran = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.EDate1 = New System.Windows.Forms.DateTimePicker
        Me.SDate1 = New System.Windows.Forms.DateTimePicker
        Me.CmdGudang = New System.Windows.Forms.Button
        Me.TxtSJ = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtToko = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TP3 = New System.Windows.Forms.TabPage
        Me.Label25 = New System.Windows.Forms.Label
        Me.EDate2 = New System.Windows.Forms.DateTimePicker
        Me.SDate2 = New System.Windows.Forms.DateTimePicker
        Me.TxtSJ1 = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.BtnRetrieve = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.CmdExcel = New System.Windows.Forms.Button
        Me.TC.SuspendLayout()
        Me.TP1.SuspendLayout()
        Me.TP2.SuspendLayout()
        Me.TP3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No PO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No DO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Dokumen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Marketing"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama GM"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(121, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(120, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(120, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(120, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = ":"
        '
        'TxtPO
        '
        Me.TxtPO.Location = New System.Drawing.Point(137, 9)
        Me.TxtPO.Name = "TxtPO"
        Me.TxtPO.Size = New System.Drawing.Size(218, 20)
        Me.TxtPO.TabIndex = 0
        '
        'TxtDO
        '
        Me.TxtDO.Location = New System.Drawing.Point(137, 35)
        Me.TxtDO.Name = "TxtDO"
        Me.TxtDO.Size = New System.Drawing.Size(218, 20)
        Me.TxtDO.TabIndex = 1
        '
        'TxtDok
        '
        Me.TxtDok.Location = New System.Drawing.Point(136, 88)
        Me.TxtDok.Name = "TxtDok"
        Me.TxtDok.Size = New System.Drawing.Size(218, 20)
        Me.TxtDok.TabIndex = 3
        '
        'TxtMkt
        '
        Me.TxtMkt.Location = New System.Drawing.Point(136, 113)
        Me.TxtMkt.Name = "TxtMkt"
        Me.TxtMkt.Size = New System.Drawing.Size(218, 20)
        Me.TxtMkt.TabIndex = 4
        '
        'TxtGM
        '
        Me.TxtGM.Location = New System.Drawing.Point(136, 139)
        Me.TxtGM.Name = "TxtGM"
        Me.TxtGM.Size = New System.Drawing.Size(218, 20)
        Me.TxtGM.TabIndex = 5
        '
        'TC
        '
        Me.TC.Controls.Add(Me.TP1)
        Me.TC.Controls.Add(Me.TP2)
        Me.TC.Controls.Add(Me.TP3)
        Me.TC.Location = New System.Drawing.Point(12, 12)
        Me.TC.Name = "TC"
        Me.TC.SelectedIndex = 0
        Me.TC.Size = New System.Drawing.Size(574, 218)
        Me.TC.TabIndex = 15
        '
        'TP1
        '
        Me.TP1.Controls.Add(Me.Label30)
        Me.TP1.Controls.Add(Me.TxtSrtJln)
        Me.TP1.Controls.Add(Me.Label31)
        Me.TP1.Controls.Add(Me.EDate)
        Me.TP1.Controls.Add(Me.SDate)
        Me.TP1.Controls.Add(Me.Label21)
        Me.TP1.Controls.Add(Me.Label12)
        Me.TP1.Controls.Add(Me.Label11)
        Me.TP1.Controls.Add(Me.TxtGM)
        Me.TP1.Controls.Add(Me.Label1)
        Me.TP1.Controls.Add(Me.TxtMkt)
        Me.TP1.Controls.Add(Me.Label2)
        Me.TP1.Controls.Add(Me.TxtDok)
        Me.TP1.Controls.Add(Me.Label3)
        Me.TP1.Controls.Add(Me.TxtDO)
        Me.TP1.Controls.Add(Me.Label4)
        Me.TP1.Controls.Add(Me.TxtPO)
        Me.TP1.Controls.Add(Me.Label5)
        Me.TP1.Controls.Add(Me.Label10)
        Me.TP1.Controls.Add(Me.Label6)
        Me.TP1.Controls.Add(Me.Label9)
        Me.TP1.Controls.Add(Me.Label7)
        Me.TP1.Controls.Add(Me.Label8)
        Me.TP1.Location = New System.Drawing.Point(4, 22)
        Me.TP1.Name = "TP1"
        Me.TP1.Padding = New System.Windows.Forms.Padding(3)
        Me.TP1.Size = New System.Drawing.Size(566, 192)
        Me.TP1.TabIndex = 0
        Me.TP1.Text = "Barang Masuk"
        Me.TP1.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 62)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 13)
        Me.Label30.TabIndex = 21
        Me.Label30.Text = "Surat Jalan"
        '
        'TxtSrtJln
        '
        Me.TxtSrtJln.Location = New System.Drawing.Point(136, 61)
        Me.TxtSrtJln.Name = "TxtSrtJln"
        Me.TxtSrtJln.Size = New System.Drawing.Size(218, 20)
        Me.TxtSrtJln.TabIndex = 2
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(121, 62)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(10, 13)
        Me.Label31.TabIndex = 22
        Me.Label31.Text = ":"
        '
        'EDate
        '
        Me.EDate.CustomFormat = "dd-MM-yyyy"
        Me.EDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EDate.Location = New System.Drawing.Point(243, 165)
        Me.EDate.Name = "EDate"
        Me.EDate.Size = New System.Drawing.Size(85, 21)
        Me.EDate.TabIndex = 7
        '
        'SDate
        '
        Me.SDate.CustomFormat = "dd-MM-yyyy"
        Me.SDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SDate.Location = New System.Drawing.Point(136, 165)
        Me.SDate.Name = "SDate"
        Me.SDate.Size = New System.Drawing.Size(85, 21)
        Me.SDate.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(227, 166)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(10, 13)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(120, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Tanggal Transaksi"
        '
        'TP2
        '
        Me.TP2.Controls.Add(Me.LstJenisHarga)
        Me.TP2.Controls.Add(Me.LstPembayaran)
        Me.TP2.Controls.Add(Me.Label22)
        Me.TP2.Controls.Add(Me.EDate1)
        Me.TP2.Controls.Add(Me.SDate1)
        Me.TP2.Controls.Add(Me.CmdGudang)
        Me.TP2.Controls.Add(Me.TxtSJ)
        Me.TP2.Controls.Add(Me.Label29)
        Me.TP2.Controls.Add(Me.Label28)
        Me.TP2.Controls.Add(Me.Label19)
        Me.TP2.Controls.Add(Me.Label20)
        Me.TP2.Controls.Add(Me.Label18)
        Me.TP2.Controls.Add(Me.Label17)
        Me.TP2.Controls.Add(Me.Label16)
        Me.TP2.Controls.Add(Me.Label15)
        Me.TP2.Controls.Add(Me.Label13)
        Me.TP2.Controls.Add(Me.TxtToko)
        Me.TP2.Controls.Add(Me.Label14)
        Me.TP2.Location = New System.Drawing.Point(4, 22)
        Me.TP2.Name = "TP2"
        Me.TP2.Padding = New System.Windows.Forms.Padding(3)
        Me.TP2.Size = New System.Drawing.Size(566, 192)
        Me.TP2.TabIndex = 1
        Me.TP2.Text = "Barang Keluar"
        Me.TP2.UseVisualStyleBackColor = True
        '
        'LstJenisHarga
        '
        Me.LstJenisHarga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LstJenisHarga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LstJenisHarga.BackColor = System.Drawing.Color.White
        Me.LstJenisHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstJenisHarga.FormattingEnabled = True
        Me.LstJenisHarga.Items.AddRange(New Object() {"Reseller", "Toko", "EndUser"})
        Me.LstJenisHarga.Location = New System.Drawing.Point(135, 91)
        Me.LstJenisHarga.Name = "LstJenisHarga"
        Me.LstJenisHarga.Size = New System.Drawing.Size(133, 23)
        Me.LstJenisHarga.TabIndex = 4
        '
        'LstPembayaran
        '
        Me.LstPembayaran.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LstPembayaran.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LstPembayaran.BackColor = System.Drawing.Color.White
        Me.LstPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstPembayaran.FormattingEnabled = True
        Me.LstPembayaran.Items.AddRange(New Object() {"Tunai", "Tempo", "Konsinyasi"})
        Me.LstPembayaran.Location = New System.Drawing.Point(135, 64)
        Me.LstPembayaran.Name = "LstPembayaran"
        Me.LstPembayaran.Size = New System.Drawing.Size(133, 23)
        Me.LstPembayaran.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(226, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(10, 13)
        Me.Label22.TabIndex = 99
        Me.Label22.Text = "-"
        '
        'EDate1
        '
        Me.EDate1.CustomFormat = "dd-MM-yyyy"
        Me.EDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EDate1.Location = New System.Drawing.Point(242, 117)
        Me.EDate1.Name = "EDate1"
        Me.EDate1.Size = New System.Drawing.Size(85, 21)
        Me.EDate1.TabIndex = 6
        '
        'SDate1
        '
        Me.SDate1.CustomFormat = "dd-MM-yyyy"
        Me.SDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SDate1.Location = New System.Drawing.Point(135, 117)
        Me.SDate1.Name = "SDate1"
        Me.SDate1.Size = New System.Drawing.Size(85, 21)
        Me.SDate1.TabIndex = 5
        '
        'CmdGudang
        '
        Me.CmdGudang.Location = New System.Drawing.Point(279, 9)
        Me.CmdGudang.Name = "CmdGudang"
        Me.CmdGudang.Size = New System.Drawing.Size(99, 23)
        Me.CmdGudang.TabIndex = 1
        Me.CmdGudang.Text = "Lapor Ke Gudang"
        Me.CmdGudang.UseVisualStyleBackColor = True
        '
        'TxtSJ
        '
        Me.TxtSJ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtSJ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtSJ.BackColor = System.Drawing.Color.LightYellow
        Me.TxtSJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSJ.FormattingEnabled = True
        Me.TxtSJ.Location = New System.Drawing.Point(135, 11)
        Me.TxtSJ.Name = "TxtSJ"
        Me.TxtSJ.Size = New System.Drawing.Size(133, 21)
        Me.TxtSJ.TabIndex = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(119, 14)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(10, 13)
        Me.Label29.TabIndex = 52
        Me.Label29.Text = ":"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(14, 14)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 13)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "Nota"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(119, 117)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 13)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = ":"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 117)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Tanggal Transaksi"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(119, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(10, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(119, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(10, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Jenis Harga"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Jenis Pembayaran"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Nama Toko/Pembeli"
        '
        'TxtToko
        '
        Me.TxtToko.Location = New System.Drawing.Point(135, 38)
        Me.TxtToko.Name = "TxtToko"
        Me.TxtToko.Size = New System.Drawing.Size(207, 20)
        Me.TxtToko.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(119, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = ":"
        '
        'TP3
        '
        Me.TP3.Controls.Add(Me.Label25)
        Me.TP3.Controls.Add(Me.EDate2)
        Me.TP3.Controls.Add(Me.SDate2)
        Me.TP3.Controls.Add(Me.TxtSJ1)
        Me.TP3.Controls.Add(Me.Label23)
        Me.TP3.Controls.Add(Me.Label24)
        Me.TP3.Controls.Add(Me.Label26)
        Me.TP3.Controls.Add(Me.Label27)
        Me.TP3.Location = New System.Drawing.Point(4, 22)
        Me.TP3.Name = "TP3"
        Me.TP3.Size = New System.Drawing.Size(566, 192)
        Me.TP3.TabIndex = 2
        Me.TP3.Text = "Retur"
        Me.TP3.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(231, 44)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(10, 13)
        Me.Label25.TabIndex = 102
        Me.Label25.Text = "-"
        '
        'EDate2
        '
        Me.EDate2.CustomFormat = "dd-MM-yyyy"
        Me.EDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EDate2.Location = New System.Drawing.Point(247, 41)
        Me.EDate2.Name = "EDate2"
        Me.EDate2.Size = New System.Drawing.Size(85, 21)
        Me.EDate2.TabIndex = 2
        '
        'SDate2
        '
        Me.SDate2.CustomFormat = "dd-MM-yyyy"
        Me.SDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SDate2.Location = New System.Drawing.Point(140, 41)
        Me.SDate2.Name = "SDate2"
        Me.SDate2.Size = New System.Drawing.Size(85, 21)
        Me.SDate2.TabIndex = 1
        '
        'TxtSJ1
        '
        Me.TxtSJ1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtSJ1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtSJ1.BackColor = System.Drawing.Color.LightYellow
        Me.TxtSJ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSJ1.FormattingEnabled = True
        Me.TxtSJ1.Location = New System.Drawing.Point(141, 13)
        Me.TxtSJ1.Name = "TxtSJ1"
        Me.TxtSJ1.Size = New System.Drawing.Size(219, 21)
        Me.TxtSJ1.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(125, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 13)
        Me.Label23.TabIndex = 97
        Me.Label23.Text = ":"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(20, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 13)
        Me.Label24.TabIndex = 96
        Me.Label24.Text = "Surat Jalan"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(126, 41)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(10, 13)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(21, 41)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 13)
        Me.Label27.TabIndex = 21
        Me.Label27.Text = "Tanggal Transaksi"
        '
        'BtnRetrieve
        '
        Me.BtnRetrieve.Location = New System.Drawing.Point(426, 236)
        Me.BtnRetrieve.Name = "BtnRetrieve"
        Me.BtnRetrieve.Size = New System.Drawing.Size(75, 23)
        Me.BtnRetrieve.TabIndex = 9
        Me.BtnRetrieve.Text = "Tampilkan"
        Me.BtnRetrieve.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(507, 236)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 23)
        Me.BtnNew.TabIndex = 10
        Me.BtnNew.Text = "Hapus"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'CmdExcel
        '
        Me.CmdExcel.Location = New System.Drawing.Point(310, 236)
        Me.CmdExcel.Name = "CmdExcel"
        Me.CmdExcel.Size = New System.Drawing.Size(113, 23)
        Me.CmdExcel.TabIndex = 8
        Me.CmdExcel.Text = "Tampilkan Ke Excel"
        Me.CmdExcel.UseVisualStyleBackColor = True
        Me.CmdExcel.Visible = False
        '
        'QueryHFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(601, 271)
        Me.Controls.Add(Me.CmdExcel)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnRetrieve)
        Me.Controls.Add(Me.TC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QueryHFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QueryFrm"
        Me.TC.ResumeLayout(False)
        Me.TP1.ResumeLayout(False)
        Me.TP1.PerformLayout()
        Me.TP2.ResumeLayout(False)
        Me.TP2.PerformLayout()
        Me.TP3.ResumeLayout(False)
        Me.TP3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtPO As System.Windows.Forms.TextBox
    Friend WithEvents TxtDok As System.Windows.Forms.TextBox
    Friend WithEvents TxtMkt As System.Windows.Forms.TextBox
    Friend WithEvents TxtGM As System.Windows.Forms.TextBox
    Friend WithEvents TC As System.Windows.Forms.TabControl
    Friend WithEvents TP1 As System.Windows.Forms.TabPage
    Friend WithEvents TP2 As System.Windows.Forms.TabPage
    Friend WithEvents BtnRetrieve As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtDO As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtToko As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TP3 As System.Windows.Forms.TabPage
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents CmdExcel As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtSJ As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSJ1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CmdGudang As System.Windows.Forms.Button
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtSrtJln As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents EDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents SDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents EDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents EDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LstJenisHarga As System.Windows.Forms.ComboBox
    Friend WithEvents LstPembayaran As System.Windows.Forms.ComboBox
End Class

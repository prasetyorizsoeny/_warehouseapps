<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class produkFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(produkFrm))
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtWarna = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtJumlah = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.LblInfo = New System.Windows.Forms.Label
        Me.CbxUkuran = New System.Windows.Forms.ComboBox
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnBatal = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.BtnTambah = New System.Windows.Forms.Button
        Me.CbxCariUkuran = New System.Windows.Forms.ComboBox
        Me.BtnExcel = New System.Windows.Forms.Button
        Me.BtnTampil = New System.Windows.Forms.Button
        Me.TxtCariWarna = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CbxJenis = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Ukuran"
        '
        'TxtWarna
        '
        Me.TxtWarna.BackColor = System.Drawing.Color.LightYellow
        Me.TxtWarna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWarna.Location = New System.Drawing.Point(71, 20)
        Me.TxtWarna.Name = "TxtWarna"
        Me.TxtWarna.Size = New System.Drawing.Size(170, 21)
        Me.TxtWarna.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Warna"
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJumlah.Location = New System.Drawing.Point(71, 99)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(52, 21)
        Me.TxtJumlah.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Jumlah"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(626, 299)
        Me.DataGridView1.TabIndex = 20
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.Location = New System.Drawing.Point(10, 132)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(22, 15)
        Me.LblInfo.TabIndex = 31
        Me.LblInfo.Text = "....."
        '
        'CbxUkuran
        '
        Me.CbxUkuran.BackColor = System.Drawing.Color.LightYellow
        Me.CbxUkuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxUkuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxUkuran.FormattingEnabled = True
        Me.CbxUkuran.Items.AddRange(New Object() {"S", "MD", "LG", "XL", "XXL"})
        Me.CbxUkuran.Location = New System.Drawing.Point(71, 46)
        Me.CbxUkuran.Name = "CbxUkuran"
        Me.CbxUkuran.Size = New System.Drawing.Size(52, 23)
        Me.CbxUkuran.TabIndex = 6
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(106, 12)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(83, 25)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Location = New System.Drawing.Point(284, 12)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(83, 25)
        Me.BtnBatal.TabIndex = 4
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(195, 12)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(83, 25)
        Me.BtnSimpan.TabIndex = 3
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(16, 12)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(83, 25)
        Me.BtnTambah.TabIndex = 1
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'CbxCariUkuran
        '
        Me.CbxCariUkuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCariUkuran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCariUkuran.FormattingEnabled = True
        Me.CbxCariUkuran.Items.AddRange(New Object() {"", "S", "MD", "LG", "XL", "XXL"})
        Me.CbxCariUkuran.Location = New System.Drawing.Point(248, 21)
        Me.CbxCariUkuran.Name = "CbxCariUkuran"
        Me.CbxCariUkuran.Size = New System.Drawing.Size(52, 23)
        Me.CbxCariUkuran.TabIndex = 9
        '
        'BtnExcel
        '
        Me.BtnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcel.Location = New System.Drawing.Point(524, 20)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(113, 23)
        Me.BtnExcel.TabIndex = 11
        Me.BtnExcel.Text = "Simpan ke Excel"
        Me.BtnExcel.UseVisualStyleBackColor = True
        '
        'BtnTampil
        '
        Me.BtnTampil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTampil.Location = New System.Drawing.Point(440, 20)
        Me.BtnTampil.Name = "BtnTampil"
        Me.BtnTampil.Size = New System.Drawing.Size(80, 23)
        Me.BtnTampil.TabIndex = 10
        Me.BtnTampil.Text = "Tampilkan"
        Me.BtnTampil.UseVisualStyleBackColor = True
        '
        'TxtCariWarna
        '
        Me.TxtCariWarna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCariWarna.Location = New System.Drawing.Point(55, 22)
        Me.TxtCariWarna.Name = "TxtCariWarna"
        Me.TxtCariWarna.Size = New System.Drawing.Size(133, 21)
        Me.TxtCariWarna.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(197, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Ukuran"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Warna"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Jenis"
        '
        'CbxJenis
        '
        Me.CbxJenis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbxJenis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxJenis.BackColor = System.Drawing.Color.LightYellow
        Me.CbxJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxJenis.FormattingEnabled = True
        Me.CbxJenis.Items.AddRange(New Object() {"Half Face"})
        Me.CbxJenis.Location = New System.Drawing.Point(71, 72)
        Me.CbxJenis.Name = "CbxJenis"
        Me.CbxJenis.Size = New System.Drawing.Size(115, 23)
        Me.CbxJenis.TabIndex = 57
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbxCariUkuran)
        Me.GroupBox1.Controls.Add(Me.BtnExcel)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.BtnTampil)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtCariWarna)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(270, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(648, 358)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtWarna)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CbxJenis)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtJumlah)
        Me.GroupBox2.Controls.Add(Me.LblInfo)
        Me.GroupBox2.Controls.Add(Me.CbxUkuran)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 164)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'produkFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(931, 408)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnTambah)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "produkFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Produk"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtWarna As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LblInfo As System.Windows.Forms.Label
    Friend WithEvents CbxUkuran As System.Windows.Forms.ComboBox
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents CbxCariUkuran As System.Windows.Forms.ComboBox
    Friend WithEvents BtnExcel As System.Windows.Forms.Button
    Friend WithEvents BtnTampil As System.Windows.Forms.Button
    Friend WithEvents TxtCariWarna As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbxJenis As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class

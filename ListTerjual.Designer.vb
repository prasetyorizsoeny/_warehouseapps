<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListTerjual
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListTerjual))
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.DTP2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.CbxJenis = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnTampil = New System.Windows.Forms.Button
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CbxKelompok = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal keluar"
        '
        'DTP1
        '
        Me.DTP1.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.DTP1.CustomFormat = "dd-MM-yyyy"
        Me.DTP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(113, 7)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(87, 21)
        Me.DTP1.TabIndex = 1
        Me.DTP1.Value = New Date(2016, 5, 3, 0, 0, 0, 0)
        '
        'DTP2
        '
        Me.DTP2.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.DTP2.CustomFormat = "dd-MM-yyyy"
        Me.DTP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP2.Location = New System.Drawing.Point(215, 7)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.Size = New System.Drawing.Size(87, 21)
        Me.DTP2.TabIndex = 2
        Me.DTP2.Value = New Date(2016, 5, 3, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "-"
        '
        'CbxJenis
        '
        Me.CbxJenis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbxJenis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxJenis.BackColor = System.Drawing.Color.LightYellow
        Me.CbxJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxJenis.FormattingEnabled = True
        Me.CbxJenis.Location = New System.Drawing.Point(544, 7)
        Me.CbxJenis.Name = "CbxJenis"
        Me.CbxJenis.Size = New System.Drawing.Size(122, 23)
        Me.CbxJenis.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(498, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Jenis"
        '
        'BtnTampil
        '
        Me.BtnTampil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTampil.Location = New System.Drawing.Point(676, 6)
        Me.BtnTampil.Name = "BtnTampil"
        Me.BtnTampil.Size = New System.Drawing.Size(88, 24)
        Me.BtnTampil.TabIndex = 4
        Me.BtnTampil.Text = "Tampilkan"
        Me.BtnTampil.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Location = New System.Drawing.Point(13, 50)
        Me.DGV.MultiSelect = False
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.ShowEditingIcon = False
        Me.DGV.Size = New System.Drawing.Size(250, 349)
        Me.DGV.TabIndex = 66
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CbxKelompok)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DTP2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnTampil)
        Me.Panel1.Controls.Add(Me.DTP1)
        Me.Panel1.Controls.Add(Me.CbxJenis)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 40)
        Me.Panel1.TabIndex = 67
        '
        'CbxKelompok
        '
        Me.CbxKelompok.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CbxKelompok.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxKelompok.BackColor = System.Drawing.Color.LightYellow
        Me.CbxKelompok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxKelompok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxKelompok.FormattingEnabled = True
        Me.CbxKelompok.Items.AddRange(New Object() {"Warna", "Pembeli"})
        Me.CbxKelompok.Location = New System.Drawing.Point(428, 7)
        Me.CbxKelompok.Name = "CbxKelompok"
        Me.CbxKelompok.Size = New System.Drawing.Size(68, 23)
        Me.CbxKelompok.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Pengelompokkan"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.White
        Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(269, 50)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(514, 349)
        Me.Chart1.TabIndex = 68
        Me.Chart1.Text = "Chart1"
        '
        'ListTerjual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(795, 424)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGV)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListTerjual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Terjual"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxJenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnTampil As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CbxKelompok As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class

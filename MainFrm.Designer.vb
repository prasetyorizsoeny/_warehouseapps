<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PembeliToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.KategoriBiayaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderInMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderOutMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ReturMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ExpenseMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.LstTempoMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ListTerjualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QueryMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.UploadMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem3, Me.GantiPasswordToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(17, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.ProdukToolStripMenuItem, Me.PembeliToolStripMenuItem1, Me.KategoriBiayaToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 19)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Image = CType(resources.GetObject("UserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'ProdukToolStripMenuItem
        '
        Me.ProdukToolStripMenuItem.Image = CType(resources.GetObject("ProdukToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdukToolStripMenuItem.Name = "ProdukToolStripMenuItem"
        Me.ProdukToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ProdukToolStripMenuItem.Text = "Produk"
        '
        'PembeliToolStripMenuItem1
        '
        Me.PembeliToolStripMenuItem1.Image = CType(resources.GetObject("PembeliToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PembeliToolStripMenuItem1.Name = "PembeliToolStripMenuItem1"
        Me.PembeliToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.PembeliToolStripMenuItem1.Text = "Pembeli"
        '
        'KategoriBiayaToolStripMenuItem
        '
        Me.KategoriBiayaToolStripMenuItem.Image = CType(resources.GetObject("KategoriBiayaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KategoriBiayaToolStripMenuItem.Name = "KategoriBiayaToolStripMenuItem"
        Me.KategoriBiayaToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.KategoriBiayaToolStripMenuItem.Text = "Kategori_Biaya"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderInMenu, Me.OrderOutMenu, Me.ReturMenu, Me.ExpenseMenu})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(67, 19)
        Me.ToolStripMenuItem1.Text = "Transaksi"
        '
        'OrderInMenu
        '
        Me.OrderInMenu.Image = CType(resources.GetObject("OrderInMenu.Image"), System.Drawing.Image)
        Me.OrderInMenu.Name = "OrderInMenu"
        Me.OrderInMenu.Size = New System.Drawing.Size(171, 22)
        Me.OrderInMenu.Text = "Barang Masuk"
        '
        'OrderOutMenu
        '
        Me.OrderOutMenu.Image = CType(resources.GetObject("OrderOutMenu.Image"), System.Drawing.Image)
        Me.OrderOutMenu.Name = "OrderOutMenu"
        Me.OrderOutMenu.Size = New System.Drawing.Size(171, 22)
        Me.OrderOutMenu.Text = "Barang Keluar"
        '
        'ReturMenu
        '
        Me.ReturMenu.Image = CType(resources.GetObject("ReturMenu.Image"), System.Drawing.Image)
        Me.ReturMenu.Name = "ReturMenu"
        Me.ReturMenu.Size = New System.Drawing.Size(171, 22)
        Me.ReturMenu.Text = "Retur"
        '
        'ExpenseMenu
        '
        Me.ExpenseMenu.Image = CType(resources.GetObject("ExpenseMenu.Image"), System.Drawing.Image)
        Me.ExpenseMenu.Name = "ExpenseMenu"
        Me.ExpenseMenu.Size = New System.Drawing.Size(171, 22)
        Me.ExpenseMenu.Text = "Biaya Pengeluaran"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LstTempoMenu, Me.ListTerjualToolStripMenuItem, Me.QueryMenu, Me.UploadMenu})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(56, 19)
        Me.ToolStripMenuItem3.Text = "Inquiry"
        '
        'LstTempoMenu
        '
        Me.LstTempoMenu.Image = CType(resources.GetObject("LstTempoMenu.Image"), System.Drawing.Image)
        Me.LstTempoMenu.Name = "LstTempoMenu"
        Me.LstTempoMenu.Size = New System.Drawing.Size(139, 22)
        Me.LstTempoMenu.Text = "List Tempo"
        '
        'ListTerjualToolStripMenuItem
        '
        Me.ListTerjualToolStripMenuItem.Image = CType(resources.GetObject("ListTerjualToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListTerjualToolStripMenuItem.Name = "ListTerjualToolStripMenuItem"
        Me.ListTerjualToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ListTerjualToolStripMenuItem.Text = "List Terjual"
        '
        'QueryMenu
        '
        Me.QueryMenu.Image = CType(resources.GetObject("QueryMenu.Image"), System.Drawing.Image)
        Me.QueryMenu.Name = "QueryMenu"
        Me.QueryMenu.Size = New System.Drawing.Size(139, 22)
        Me.QueryMenu.Text = "Query"
        '
        'UploadMenu
        '
        Me.UploadMenu.Image = CType(resources.GetObject("UploadMenu.Image"), System.Drawing.Image)
        Me.UploadMenu.Name = "UploadMenu"
        Me.UploadMenu.Size = New System.Drawing.Size(139, 22)
        Me.UploadMenu.Text = "Upload Data"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(100, 19)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 19)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1362, 622)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.Name = "MainFrm"
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembeliToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderInMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderOutMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LstTempoMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QueryMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KategoriBiayaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListTerjualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpenseMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadMenu As System.Windows.Forms.ToolStripMenuItem
End Class

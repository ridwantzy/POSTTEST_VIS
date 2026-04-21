<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        MenuStrip1 = New MenuStrip()
        DataGridView1 = New DataGridView()
        txtCari = New TextBox()
        Label2 = New Label()
        btnTambah = New Guna.UI2.WinForms.Guna2Button()
        btnEdit = New Guna.UI2.WinForms.Guna2Button()
        btnHapus = New Guna.UI2.WinForms.Guna2Button()
        btnKeluar = New Guna.UI2.WinForms.Guna2Button()
        btnCari = New Guna.UI2.WinForms.Guna2Button()
        cbFilterJenis = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(33, 151)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(728, 222)
        DataGridView1.TabIndex = 1
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(154, 98)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(172, 27)
        txtCari.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(71, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 23)
        Label2.TabIndex = 4
        Label2.Text = "Search"
        ' 
        ' btnTambah
        ' 
        btnTambah.AutoRoundedCorners = True
        btnTambah.BackColor = Color.Transparent
        btnTambah.CustomizableEdges = CustomizableEdges1
        btnTambah.DisabledState.BorderColor = Color.DarkGray
        btnTambah.DisabledState.CustomBorderColor = Color.DarkGray
        btnTambah.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnTambah.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnTambah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(33, 397)
        btnTambah.Name = "btnTambah"
        btnTambah.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnTambah.Size = New Size(159, 37)
        btnTambah.TabIndex = 12
        btnTambah.Text = "Tambah"
        ' 
        ' btnEdit
        ' 
        btnEdit.AutoRoundedCorners = True
        btnEdit.BackColor = Color.Transparent
        btnEdit.CustomizableEdges = CustomizableEdges3
        btnEdit.DisabledState.BorderColor = Color.DarkGray
        btnEdit.DisabledState.CustomBorderColor = Color.DarkGray
        btnEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEdit.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(214, 397)
        btnEdit.Name = "btnEdit"
        btnEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnEdit.Size = New Size(165, 37)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Edit"
        ' 
        ' btnHapus
        ' 
        btnHapus.AutoRoundedCorners = True
        btnHapus.BackColor = Color.Transparent
        btnHapus.CustomizableEdges = CustomizableEdges5
        btnHapus.DisabledState.BorderColor = Color.DarkGray
        btnHapus.DisabledState.CustomBorderColor = Color.DarkGray
        btnHapus.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnHapus.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(399, 397)
        btnHapus.Name = "btnHapus"
        btnHapus.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnHapus.Size = New Size(174, 37)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        ' 
        ' btnKeluar
        ' 
        btnKeluar.AutoRoundedCorners = True
        btnKeluar.BackColor = Color.Transparent
        btnKeluar.CustomizableEdges = CustomizableEdges7
        btnKeluar.DisabledState.BorderColor = Color.DarkGray
        btnKeluar.DisabledState.CustomBorderColor = Color.DarkGray
        btnKeluar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnKeluar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnKeluar.FillColor = Color.Red
        btnKeluar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = Color.White
        btnKeluar.Location = New Point(593, 397)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnKeluar.Size = New Size(168, 37)
        btnKeluar.TabIndex = 15
        btnKeluar.Text = "Keluar"
        ' 
        ' btnCari
        ' 
        btnCari.AutoRoundedCorners = True
        btnCari.BackColor = Color.Transparent
        btnCari.CustomizableEdges = CustomizableEdges9
        btnCari.DisabledState.BorderColor = Color.DarkGray
        btnCari.DisabledState.CustomBorderColor = Color.DarkGray
        btnCari.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCari.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCari.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCari.ForeColor = Color.White
        btnCari.Location = New Point(354, 99)
        btnCari.Name = "btnCari"
        btnCari.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnCari.Size = New Size(123, 26)
        btnCari.TabIndex = 16
        btnCari.Text = "Cari"
        ' 
        ' cbFilterJenis
        ' 
        cbFilterJenis.BackColor = Color.Transparent
        cbFilterJenis.CustomizableEdges = CustomizableEdges11
        cbFilterJenis.DrawMode = DrawMode.OwnerDrawFixed
        cbFilterJenis.DropDownStyle = ComboBoxStyle.DropDownList
        cbFilterJenis.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbFilterJenis.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbFilterJenis.Font = New Font("Segoe UI", 10.0F)
        cbFilterJenis.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbFilterJenis.ItemHeight = 30
        cbFilterJenis.Location = New Point(581, 92)
        cbFilterJenis.Name = "cbFilterJenis"
        cbFilterJenis.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        cbFilterJenis.Size = New Size(180, 36)
        cbFilterJenis.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.latarLaundry
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(cbFilterJenis)
        Controls.Add(btnCari)
        Controls.Add(btnKeluar)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnTambah)
        Controls.Add(Label2)
        Controls.Add(txtCari)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Input Data Layanan Laundy"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnKeluar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCari As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbFilterJenis As Guna.UI2.WinForms.Guna2ComboBox

End Class

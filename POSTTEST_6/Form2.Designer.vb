<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNama = New TextBox()
        txtHarga = New TextBox()
        txtEstimasi = New TextBox()
        btnSimpan = New Guna.UI2.WinForms.Guna2Button()
        btnBatal = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtDeskripsi = New TextBox()
        cbStatus = New ComboBox()
        cbSatuan = New ComboBox()
        cbJenis = New ComboBox()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(31, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Layanan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(32, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 1
        Label2.Text = "Harga Per Kg"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(31, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 20)
        Label3.TabIndex = 2
        Label3.Text = "Estimasi (Hari)"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(192, 18)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(228, 27)
        txtNama.TabIndex = 3
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(192, 56)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(228, 27)
        txtHarga.TabIndex = 4
        ' 
        ' txtEstimasi
        ' 
        txtEstimasi.Location = New Point(192, 101)
        txtEstimasi.Name = "txtEstimasi"
        txtEstimasi.Size = New Size(228, 27)
        txtEstimasi.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.AutoRoundedCorners = True
        btnSimpan.CustomizableEdges = CustomizableEdges7
        btnSimpan.DisabledState.BorderColor = Color.DarkGray
        btnSimpan.DisabledState.CustomBorderColor = Color.DarkGray
        btnSimpan.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSimpan.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(85, 273)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnSimpan.Size = New Size(272, 37)
        btnSimpan.TabIndex = 15
        btnSimpan.Text = "Simpan"
        ' 
        ' btnBatal
        ' 
        btnBatal.AutoRoundedCorners = True
        btnBatal.BackColor = Color.Transparent
        btnBatal.CustomizableEdges = CustomizableEdges9
        btnBatal.DisabledState.BorderColor = Color.DarkGray
        btnBatal.DisabledState.CustomBorderColor = Color.DarkGray
        btnBatal.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBatal.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBatal.FillColor = Color.Red
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(427, 273)
        btnBatal.Name = "btnBatal"
        btnBatal.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnBatal.Size = New Size(259, 37)
        btnBatal.TabIndex = 16
        btnBatal.Text = "Batal"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.AllowDrop = True
        Guna2Panel1.BackColor = SystemColors.GradientActiveCaption
        Guna2Panel1.BorderRadius = 167
        Guna2Panel1.Controls.Add(Label7)
        Guna2Panel1.Controls.Add(Label6)
        Guna2Panel1.Controls.Add(Label5)
        Guna2Panel1.Controls.Add(Label4)
        Guna2Panel1.Controls.Add(txtDeskripsi)
        Guna2Panel1.Controls.Add(cbStatus)
        Guna2Panel1.Controls.Add(cbSatuan)
        Guna2Panel1.Controls.Add(cbJenis)
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.Controls.Add(btnBatal)
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.Controls.Add(txtEstimasi)
        Guna2Panel1.Controls.Add(btnSimpan)
        Guna2Panel1.Controls.Add(txtHarga)
        Guna2Panel1.Controls.Add(Label3)
        Guna2Panel1.Controls.Add(txtNama)
        Guna2Panel1.CustomizableEdges = CustomizableEdges11
        Guna2Panel1.Location = New Point(12, 101)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel1.Size = New Size(776, 337)
        Guna2Panel1.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(566, 18)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 20)
        Label7.TabIndex = 24
        Label7.Text = "Deskripsi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(32, 234)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 23
        Label6.Text = "Status"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(31, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 22
        Label5.Text = "Satuan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(32, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 20)
        Label4.TabIndex = 21
        Label4.Text = "Jenis Layanan"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(454, 44)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(299, 210)
        txtDeskripsi.TabIndex = 20
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Dalam Proses", "Selesai"})
        cbStatus.Location = New Point(192, 226)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(228, 28)
        cbStatus.TabIndex = 19
        ' 
        ' cbSatuan
        ' 
        cbSatuan.FormattingEnabled = True
        cbSatuan.Items.AddRange(New Object() {"Kg", "Pcs"})
        cbSatuan.Location = New Point(192, 186)
        cbSatuan.Name = "cbSatuan"
        cbSatuan.Size = New Size(228, 28)
        cbSatuan.TabIndex = 18
        ' 
        ' cbJenis
        ' 
        cbJenis.FormattingEnabled = True
        cbJenis.Location = New Point(192, 143)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(228, 28)
        cbJenis.TabIndex = 17
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Laundry_service_data_interface
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Guna2Panel1)
        Name = "Form2"
        Text = "Input Data Layanan Laundry"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtEstimasi As TextBox
    Friend WithEvents btnSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbSatuan As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class

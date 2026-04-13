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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNama = New TextBox()
        txtHarga = New TextBox()
        txtEstimasi = New TextBox()
        btnSimpan = New Guna.UI2.WinForms.Guna2Button()
        btnBatal = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(43, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Layanan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(43, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 1
        Label2.Text = "Harga Per Kg"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(43, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 20)
        Label3.TabIndex = 2
        Label3.Text = "Estimasi (Hari)"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(192, 56)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(188, 27)
        txtNama.TabIndex = 3
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(192, 100)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(188, 27)
        txtHarga.TabIndex = 4
        ' 
        ' txtEstimasi
        ' 
        txtEstimasi.Location = New Point(192, 144)
        txtEstimasi.Name = "txtEstimasi"
        txtEstimasi.Size = New Size(188, 27)
        txtEstimasi.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.AutoRoundedCorners = True
        btnSimpan.CustomizableEdges = CustomizableEdges1
        btnSimpan.DisabledState.BorderColor = Color.DarkGray
        btnSimpan.DisabledState.CustomBorderColor = Color.DarkGray
        btnSimpan.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSimpan.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(43, 217)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnSimpan.Size = New Size(123, 37)
        btnSimpan.TabIndex = 15
        btnSimpan.Text = "Simpan"
        ' 
        ' btnBatal
        ' 
        btnBatal.AutoRoundedCorners = True
        btnBatal.BackColor = Color.Transparent
        btnBatal.CustomizableEdges = CustomizableEdges3
        btnBatal.DisabledState.BorderColor = Color.DarkGray
        btnBatal.DisabledState.CustomBorderColor = Color.DarkGray
        btnBatal.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBatal.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBatal.FillColor = Color.Red
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(245, 217)
        btnBatal.Name = "btnBatal"
        btnBatal.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnBatal.Size = New Size(123, 37)
        btnBatal.TabIndex = 16
        btnBatal.Text = "Batal"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.AllowDrop = True
        Guna2Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2Panel1.AutoRoundedCorners = True
        Guna2Panel1.BackColor = SystemColors.GradientActiveCaption
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.Controls.Add(btnBatal)
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.Controls.Add(txtEstimasi)
        Guna2Panel1.Controls.Add(btnSimpan)
        Guna2Panel1.Controls.Add(txtHarga)
        Guna2Panel1.Controls.Add(Label3)
        Guna2Panel1.Controls.Add(txtNama)
        Guna2Panel1.CustomizableEdges = CustomizableEdges5
        Guna2Panel1.Location = New Point(197, 101)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel1.Size = New Size(412, 285)
        Guna2Panel1.TabIndex = 17
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
End Class

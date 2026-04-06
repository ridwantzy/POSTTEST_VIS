<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        pbFotoKartu = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblKomunitas = New Label()
        lblTelepon = New Label()
        lblAktivitas = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoKartu
        ' 
        pbFotoKartu.Location = New Point(32, 142)
        pbFotoKartu.Name = "pbFotoKartu"
        pbFotoKartu.Size = New Size(153, 181)
        pbFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoKartu.TabIndex = 0
        pbFotoKartu.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Georgia", 9F, FontStyle.Bold)
        lblNama.Location = New Point(384, 145)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 18)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.Font = New Font("Georgia", 9F, FontStyle.Bold)
        lblID.Location = New Point(384, 185)
        lblID.Name = "lblID"
        lblID.Size = New Size(60, 18)
        lblID.TabIndex = 2
        lblID.Text = "Label2"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.BackColor = Color.Transparent
        lblKomunitas.Font = New Font("Georgia", 9F, FontStyle.Bold)
        lblKomunitas.Location = New Point(384, 225)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(60, 18)
        lblKomunitas.TabIndex = 3
        lblKomunitas.Text = "Label3"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.BackColor = Color.Transparent
        lblTelepon.Font = New Font("Georgia", 9F, FontStyle.Bold)
        lblTelepon.Location = New Point(384, 265)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(60, 18)
        lblTelepon.TabIndex = 4
        lblTelepon.Text = "Label4"
        ' 
        ' lblAktivitas
        ' 
        lblAktivitas.BackColor = Color.Transparent
        lblAktivitas.Font = New Font("Georgia", 9F, FontStyle.Bold)
        lblAktivitas.Location = New Point(384, 305)
        lblAktivitas.Name = "lblAktivitas"
        lblAktivitas.Size = New Size(365, 65)
        lblAktivitas.TabIndex = 5
        lblAktivitas.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Georgia", 9F, FontStyle.Bold)
        Label6.Location = New Point(250, 145)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 18)
        Label6.TabIndex = 6
        Label6.Text = "Nama"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Georgia", 9F, FontStyle.Bold)
        Label7.Location = New Point(250, 185)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 18)
        Label7.TabIndex = 7
        Label7.Text = "ID"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Georgia", 9F, FontStyle.Bold)
        Label8.Location = New Point(250, 225)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 18)
        Label8.TabIndex = 8
        Label8.Text = "Jenis Komunitas"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Georgia", 9F, FontStyle.Bold)
        Label9.Location = New Point(250, 265)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 18)
        Label9.TabIndex = 9
        Label9.Text = "Kontak"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Georgia", 9F, FontStyle.Bold)
        Label10.Location = New Point(250, 305)
        Label10.Name = "Label10"
        Label10.Size = New Size(75, 18)
        Label10.TabIndex = 10
        Label10.Text = "Aktivitas"
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = My.Resources.Resources.EXPLORER_MEMBER_CARD___10_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(lblAktivitas)
        Controls.Add(lblTelepon)
        Controls.Add(lblKomunitas)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(pbFotoKartu)
        Name = "FormKartu"
        Text = "FormKartu"
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoKartu As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAktivitas As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class

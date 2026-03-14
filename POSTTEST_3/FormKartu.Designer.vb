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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblName = New Label()
        lblAge = New Label()
        lblPhone = New Label()
        lblGender = New Label()
        lblBirth = New Label()
        lblAddress = New Label()
        lblHobby = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(36, 147)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(143, 198)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(256, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 20)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(256, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 20)
        Label2.TabIndex = 2
        Label2.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(256, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 3
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(256, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 20)
        Label4.TabIndex = 4
        Label4.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(256, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 20)
        Label5.TabIndex = 5
        Label5.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(256, 316)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 20)
        Label6.TabIndex = 6
        Label6.Text = "Hobby"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(256, 240)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 20)
        Label7.TabIndex = 7
        Label7.Text = "Date of Birth"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblName.Location = New Point(413, 120)
        lblName.Name = "lblName"
        lblName.Size = New Size(55, 20)
        lblName.TabIndex = 8
        lblName.Text = "Label8"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.BackColor = Color.Transparent
        lblAge.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAge.Location = New Point(413, 150)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(55, 20)
        lblAge.TabIndex = 9
        lblAge.Text = "Label9"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.BackColor = Color.Transparent
        lblPhone.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPhone.Location = New Point(413, 180)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(64, 20)
        lblPhone.TabIndex = 10
        lblPhone.Text = "Label10"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = Color.Transparent
        lblGender.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblGender.Location = New Point(413, 210)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(64, 20)
        lblGender.TabIndex = 11
        lblGender.Text = "Label11"
        ' 
        ' lblBirth
        ' 
        lblBirth.AutoSize = True
        lblBirth.BackColor = Color.Transparent
        lblBirth.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblBirth.Location = New Point(413, 240)
        lblBirth.Name = "lblBirth"
        lblBirth.Size = New Size(64, 20)
        lblBirth.TabIndex = 12
        lblBirth.Text = "Label12"
        ' 
        ' lblAddress
        ' 
        lblAddress.BackColor = Color.Transparent
        lblAddress.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAddress.Location = New Point(413, 271)
        lblAddress.MaximumSize = New Size(350, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(350, 45)
        lblAddress.TabIndex = 13
        lblAddress.Text = "Label13"
        ' 
        ' lblHobby
        ' 
        lblHobby.BackColor = Color.Transparent
        lblHobby.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblHobby.Location = New Point(413, 316)
        lblHobby.MaximumSize = New Size(350, 0)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(350, 65)
        lblHobby.TabIndex = 14
        lblHobby.Text = "Label14"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(388, 120)
        Label8.Name = "Label8"
        Label8.Size = New Size(13, 20)
        Label8.TabIndex = 15
        Label8.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.Location = New Point(388, 150)
        Label9.Name = "Label9"
        Label9.Size = New Size(13, 20)
        Label9.TabIndex = 16
        Label9.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label10.Location = New Point(388, 180)
        Label10.Name = "Label10"
        Label10.Size = New Size(13, 20)
        Label10.TabIndex = 17
        Label10.Text = ":"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label11.Location = New Point(388, 210)
        Label11.Name = "Label11"
        Label11.Size = New Size(13, 20)
        Label11.TabIndex = 18
        Label11.Text = ":"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label12.Location = New Point(388, 240)
        Label12.Name = "Label12"
        Label12.Size = New Size(13, 20)
        Label12.TabIndex = 19
        Label12.Text = ":"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label13.Location = New Point(388, 270)
        Label13.Name = "Label13"
        Label13.Size = New Size(13, 20)
        Label13.TabIndex = 20
        Label13.Text = ":"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label14.Location = New Point(388, 316)
        Label14.Name = "Label14"
        Label14.Size = New Size(13, 20)
        Label14.TabIndex = 21
        Label14.Text = ":"
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.EXPLORER_MEMBER_CARD___7_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(lblHobby)
        Controls.Add(lblAddress)
        Controls.Add(lblBirth)
        Controls.Add(lblGender)
        Controls.Add(lblPhone)
        Controls.Add(lblAge)
        Controls.Add(lblName)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "FormKartu"
        Text = "FormKartu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblBirth As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class

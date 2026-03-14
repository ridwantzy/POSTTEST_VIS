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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picProfile = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        grpGender = New GroupBox()
        rbFemale = New RadioButton()
        rbMale = New RadioButton()
        grpHobby = New GroupBox()
        cbBirdWatching = New CheckBox()
        cbNatureWalk = New CheckBox()
        cbRunning = New CheckBox()
        cbCycling = New CheckBox()
        cbFishing = New CheckBox()
        cbClimbing = New CheckBox()
        cbPhotography = New CheckBox()
        cbTraveling = New CheckBox()
        cbCamping = New CheckBox()
        cbHiking = New CheckBox()
        txtName = New TextBox()
        txtAge = New TextBox()
        txtPhone = New TextBox()
        txtAddress = New TextBox()
        dtpBirth = New DateTimePicker()
        btnPrint = New Button()
        btnBrowse = New Button()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        grpGender.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfile
        ' 
        picProfile.BackColor = Color.Transparent
        picProfile.BorderStyle = BorderStyle.FixedSingle
        picProfile.Image = CType(resources.GetObject("picProfile.Image"), Image)
        picProfile.Location = New Point(12, 22)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(254, 372)
        picProfile.SizeMode = PictureBoxSizeMode.Zoom
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(290, 22)
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
        Label2.Location = New Point(290, 60)
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
        Label3.Location = New Point(290, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 20)
        Label3.TabIndex = 3
        Label3.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(290, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 4
        Label4.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(290, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 20)
        Label5.TabIndex = 5
        Label5.Text = "Date of Birth"
        ' 
        ' grpGender
        ' 
        grpGender.BackColor = Color.Transparent
        grpGender.Controls.Add(rbFemale)
        grpGender.Controls.Add(rbMale)
        grpGender.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpGender.Location = New Point(283, 211)
        grpGender.Name = "grpGender"
        grpGender.Size = New Size(172, 183)
        grpGender.TabIndex = 6
        grpGender.TabStop = False
        grpGender.Text = "Gender"
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(10, 73)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(80, 24)
        rbFemale.TabIndex = 1
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(11, 33)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(64, 24)
        rbMale.TabIndex = 0
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.BackColor = Color.Transparent
        grpHobby.Controls.Add(cbBirdWatching)
        grpHobby.Controls.Add(cbNatureWalk)
        grpHobby.Controls.Add(cbRunning)
        grpHobby.Controls.Add(cbCycling)
        grpHobby.Controls.Add(cbFishing)
        grpHobby.Controls.Add(cbClimbing)
        grpHobby.Controls.Add(cbPhotography)
        grpHobby.Controls.Add(cbTraveling)
        grpHobby.Controls.Add(cbCamping)
        grpHobby.Controls.Add(cbHiking)
        grpHobby.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpHobby.Location = New Point(474, 211)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(323, 183)
        grpHobby.TabIndex = 7
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' cbBirdWatching
        ' 
        cbBirdWatching.AutoSize = True
        cbBirdWatching.Location = New Point(153, 144)
        cbBirdWatching.Name = "cbBirdWatching"
        cbBirdWatching.Size = New Size(130, 24)
        cbBirdWatching.TabIndex = 9
        cbBirdWatching.Text = "Bird Watching"
        cbBirdWatching.UseVisualStyleBackColor = True
        ' 
        ' cbNatureWalk
        ' 
        cbNatureWalk.AutoSize = True
        cbNatureWalk.Location = New Point(153, 114)
        cbNatureWalk.Name = "cbNatureWalk"
        cbNatureWalk.Size = New Size(118, 24)
        cbNatureWalk.TabIndex = 8
        cbNatureWalk.Text = "Nature Walk"
        cbNatureWalk.UseVisualStyleBackColor = True
        ' 
        ' cbRunning
        ' 
        cbRunning.AutoSize = True
        cbRunning.Location = New Point(153, 84)
        cbRunning.Name = "cbRunning"
        cbRunning.Size = New Size(90, 24)
        cbRunning.TabIndex = 7
        cbRunning.Text = "Running"
        cbRunning.UseVisualStyleBackColor = True
        ' 
        ' cbCycling
        ' 
        cbCycling.AutoSize = True
        cbCycling.Location = New Point(153, 54)
        cbCycling.Name = "cbCycling"
        cbCycling.Size = New Size(81, 24)
        cbCycling.TabIndex = 6
        cbCycling.Text = "Cycling"
        cbCycling.UseVisualStyleBackColor = True
        ' 
        ' cbFishing
        ' 
        cbFishing.AutoSize = True
        cbFishing.Location = New Point(153, 26)
        cbFishing.Name = "cbFishing"
        cbFishing.Size = New Size(81, 24)
        cbFishing.TabIndex = 5
        cbFishing.Text = "Fhising"
        cbFishing.UseVisualStyleBackColor = True
        ' 
        ' cbClimbing
        ' 
        cbClimbing.AutoSize = True
        cbClimbing.Location = New Point(10, 144)
        cbClimbing.Name = "cbClimbing"
        cbClimbing.Size = New Size(93, 24)
        cbClimbing.TabIndex = 4
        cbClimbing.Text = "Climbing"
        cbClimbing.UseVisualStyleBackColor = True
        ' 
        ' cbPhotography
        ' 
        cbPhotography.AutoSize = True
        cbPhotography.Location = New Point(10, 114)
        cbPhotography.Name = "cbPhotography"
        cbPhotography.Size = New Size(122, 24)
        cbPhotography.TabIndex = 3
        cbPhotography.Text = "Photography"
        cbPhotography.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Location = New Point(10, 84)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(95, 24)
        cbTraveling.TabIndex = 2
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbCamping
        ' 
        cbCamping.AutoSize = True
        cbCamping.Location = New Point(10, 54)
        cbCamping.Name = "cbCamping"
        cbCamping.Size = New Size(93, 24)
        cbCamping.TabIndex = 1
        cbCamping.Text = "Camping"
        cbCamping.UseVisualStyleBackColor = True
        ' 
        ' cbHiking
        ' 
        cbHiking.AutoSize = True
        cbHiking.Location = New Point(10, 25)
        cbHiking.Name = "cbHiking"
        cbHiking.Size = New Size(76, 24)
        cbHiking.TabIndex = 0
        cbHiking.Text = "Hiking"
        cbHiking.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(414, 15)
        txtName.Name = "txtName"
        txtName.Size = New Size(234, 27)
        txtName.TabIndex = 8
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(414, 54)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(234, 27)
        txtAge.TabIndex = 9
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(414, 93)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(234, 27)
        txtPhone.TabIndex = 10
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(414, 132)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(234, 27)
        txtAddress.TabIndex = 11
        ' 
        ' dtpBirth
        ' 
        dtpBirth.CustomFormat = "dd/mm/yyyy"
        dtpBirth.Format = DateTimePickerFormat.Short
        dtpBirth.Location = New Point(414, 171)
        dtpBirth.Name = "dtpBirth"
        dtpBirth.Size = New Size(234, 27)
        dtpBirth.TabIndex = 12
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.ForestGreen
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(283, 403)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(514, 40)
        btnPrint.TabIndex = 13
        btnPrint.Text = "Print Member Card"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(70, 409)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(133, 29)
        btnBrowse.TabIndex = 14
        btnBrowse.Text = "Browse Photo"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnBrowse)
        Controls.Add(btnPrint)
        Controls.Add(dtpBirth)
        Controls.Add(txtAddress)
        Controls.Add(txtPhone)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(grpHobby)
        Controls.Add(grpGender)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picProfile)
        Name = "Form1"
        Text = "Form1"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        grpGender.ResumeLayout(False)
        grpGender.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents cbHiking As CheckBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents dtpBirth As DateTimePicker
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents cbBirdWatching As CheckBox
    Friend WithEvents cbNatureWalk As CheckBox
    Friend WithEvents cbRunning As CheckBox
    Friend WithEvents cbCycling As CheckBox
    Friend WithEvents cbFishing As CheckBox
    Friend WithEvents cbClimbing As CheckBox
    Friend WithEvents cbPhotography As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbCamping As CheckBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnBrowse As Button

End Class

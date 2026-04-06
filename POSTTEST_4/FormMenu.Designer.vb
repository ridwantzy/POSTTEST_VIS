<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        menuInput = New ToolStripMenuItem()
        menuSimpan = New ToolStripMenuItem()
        menuBuka = New ToolStripMenuItem()
        menuLihat = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        tab = New TabControl()
        tabData = New TabPage()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        cmbKomunitas = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        txtID = New TextBox()
        txtNama = New TextBox()
        tabKontak = New TabPage()
        txtAlmdy = New Label()
        Label8 = New Label()
        Label7 = New Label()
        mtbTelepon = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        tabProfil = New TabPage()
        btnSimpan = New Button()
        gbAktivitas = New GroupBox()
        cbExploring = New CheckBox()
        cbRafting = New CheckBox()
        cbPhotography = New CheckBox()
        cbTracking = New CheckBox()
        cbSurvival = New CheckBox()
        cbClimbing = New CheckBox()
        cbCamping = New CheckBox()
        cbHiking = New CheckBox()
        GroupBox1 = New GroupBox()
        rbMember = New RadioButton()
        rbSurvival = New RadioButton()
        rbNavigator = New RadioButton()
        rbLeader = New RadioButton()
        btnBrowse = New Button()
        pbFoto = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        tab.SuspendLayout()
        tabData.SuspendLayout()
        tabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        gbAktivitas.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(632, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(168, 113)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuInput, menuSimpan, menuBuka, menuLihat, menuKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' menuInput
        ' 
        menuInput.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuInput.Name = "menuInput"
        menuInput.Size = New Size(98, 24)
        menuInput.Text = "Input Data"
        ' 
        ' menuSimpan
        ' 
        menuSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuSimpan.Name = "menuSimpan"
        menuSimpan.Size = New Size(112, 24)
        menuSimpan.Text = "Simpan Data"
        ' 
        ' menuBuka
        ' 
        menuBuka.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuBuka.Name = "menuBuka"
        menuBuka.Size = New Size(95, 24)
        menuBuka.Text = "Buka Data"
        ' 
        ' menuLihat
        ' 
        menuLihat.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuLihat.Name = "menuLihat"
        menuLihat.Size = New Size(101, 24)
        menuLihat.Text = "Lihat Kartu"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.BackColor = Color.OrangeRed
        menuKeluar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        menuKeluar.ForeColor = Color.Black
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(68, 24)
        menuKeluar.Text = "Keluar"
        ' 
        ' tab
        ' 
        tab.Controls.Add(tabData)
        tab.Controls.Add(tabKontak)
        tab.Controls.Add(tabProfil)
        tab.Location = New Point(24, 130)
        tab.Name = "tab"
        tab.SelectedIndex = 0
        tab.Size = New Size(757, 308)
        tab.TabIndex = 3
        tab.Tag = ""
        ' 
        ' tabData
        ' 
        tabData.BackgroundImage = CType(resources.GetObject("tabData.BackgroundImage"), Image)
        tabData.BackgroundImageLayout = ImageLayout.Stretch
        tabData.Controls.Add(Label6)
        tabData.Controls.Add(Label5)
        tabData.Controls.Add(Label4)
        tabData.Controls.Add(cmbKomunitas)
        tabData.Controls.Add(rbPerempuan)
        tabData.Controls.Add(rbLaki)
        tabData.Controls.Add(dtpTanggalLahir)
        tabData.Controls.Add(Label3)
        tabData.Controls.Add(Label2)
        tabData.Controls.Add(txtID)
        tabData.Controls.Add(txtNama)
        tabData.Location = New Point(4, 29)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(749, 275)
        tabData.TabIndex = 0
        tabData.Text = "Data Utama"
        tabData.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label6.Location = New Point(45, 205)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 20)
        Label6.TabIndex = 10
        Label6.Text = "Jenis Komunitas"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label5.Location = New Point(45, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 20)
        Label5.TabIndex = 9
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label4.Location = New Point(45, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 20)
        Label4.TabIndex = 8
        Label4.Text = "Tanggal Lahir"
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Mountain Explorer", "Jungle Explorer", "Marine Explorer", "Survival Team", "Adventure Squad", "Wildlife Observer", "Nature Research", "Extreme Expedition"})
        cmbKomunitas.Location = New Point(184, 202)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(309, 28)
        cmbKomunitas.TabIndex = 7
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(324, 158)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 6
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(184, 158)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(85, 24)
        rbLaki.TabIndex = 5
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Format = DateTimePickerFormat.Short
        dtpTanggalLahir.Location = New Point(184, 110)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(309, 27)
        dtpTanggalLahir.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label3.Location = New Point(45, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 3
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label2.Location = New Point(45, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nama"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(184, 67)
        txtID.Name = "txtID"
        txtID.Size = New Size(309, 27)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(184, 22)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(309, 27)
        txtNama.TabIndex = 0
        ' 
        ' tabKontak
        ' 
        tabKontak.BackgroundImage = My.Resources.Resources.Exploring_the_jungle_waterfall
        tabKontak.BackgroundImageLayout = ImageLayout.Stretch
        tabKontak.Controls.Add(txtAlmdy)
        tabKontak.Controls.Add(Label8)
        tabKontak.Controls.Add(Label7)
        tabKontak.Controls.Add(mtbTelepon)
        tabKontak.Controls.Add(txtAlamat)
        tabKontak.Controls.Add(txtEmail)
        tabKontak.Location = New Point(4, 29)
        tabKontak.Name = "tabKontak"
        tabKontak.Padding = New Padding(3)
        tabKontak.Size = New Size(749, 275)
        tabKontak.TabIndex = 1
        tabKontak.Text = "Kontak & Info"
        tabKontak.UseVisualStyleBackColor = True
        ' 
        ' txtAlmdy
        ' 
        txtAlmdy.AutoSize = True
        txtAlmdy.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        txtAlmdy.Location = New Point(114, 171)
        txtAlmdy.Name = "txtAlmdy"
        txtAlmdy.Size = New Size(60, 20)
        txtAlmdy.TabIndex = 6
        txtAlmdy.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label8.Location = New Point(114, 107)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 20)
        Label8.TabIndex = 5
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label7.Location = New Point(114, 43)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 20)
        Label7.TabIndex = 4
        Label7.Text = "Nomer Telpon "
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(275, 40)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(234, 27)
        mtbTelepon.TabIndex = 3
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(275, 168)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(234, 27)
        txtAlamat.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(275, 104)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(234, 27)
        txtEmail.TabIndex = 0
        ' 
        ' tabProfil
        ' 
        tabProfil.BackgroundImage = My.Resources.Resources.Coastal_adventure_at_sunset
        tabProfil.BackgroundImageLayout = ImageLayout.Stretch
        tabProfil.Controls.Add(btnSimpan)
        tabProfil.Controls.Add(gbAktivitas)
        tabProfil.Controls.Add(GroupBox1)
        tabProfil.Controls.Add(btnBrowse)
        tabProfil.Controls.Add(pbFoto)
        tabProfil.Location = New Point(4, 29)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(749, 275)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil & Aktivitas"
        tabProfil.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = SystemColors.MenuHighlight
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(291, 236)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(194, 29)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan Dan Cetak"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' gbAktivitas
        ' 
        gbAktivitas.Controls.Add(cbExploring)
        gbAktivitas.Controls.Add(cbRafting)
        gbAktivitas.Controls.Add(cbPhotography)
        gbAktivitas.Controls.Add(cbTracking)
        gbAktivitas.Controls.Add(cbSurvival)
        gbAktivitas.Controls.Add(cbClimbing)
        gbAktivitas.Controls.Add(cbCamping)
        gbAktivitas.Controls.Add(cbHiking)
        gbAktivitas.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        gbAktivitas.Location = New Point(211, 16)
        gbAktivitas.Name = "gbAktivitas"
        gbAktivitas.Size = New Size(539, 106)
        gbAktivitas.TabIndex = 3
        gbAktivitas.TabStop = False
        gbAktivitas.Text = "Aktivitas"
        ' 
        ' cbExploring
        ' 
        cbExploring.AutoSize = True
        cbExploring.Font = New Font("Segoe UI", 9.0F)
        cbExploring.Location = New Point(371, 51)
        cbExploring.Name = "cbExploring"
        cbExploring.Size = New Size(94, 24)
        cbExploring.TabIndex = 7
        cbExploring.Text = "Exploring"
        cbExploring.UseVisualStyleBackColor = True
        ' 
        ' cbRafting
        ' 
        cbRafting.AutoSize = True
        cbRafting.Font = New Font("Segoe UI", 9.0F)
        cbRafting.Location = New Point(371, 25)
        cbRafting.Name = "cbRafting"
        cbRafting.Size = New Size(79, 24)
        cbRafting.TabIndex = 6
        cbRafting.Text = "Rafting"
        cbRafting.UseVisualStyleBackColor = True
        ' 
        ' cbPhotography
        ' 
        cbPhotography.AutoSize = True
        cbPhotography.Font = New Font("Segoe UI", 9.0F)
        cbPhotography.Location = New Point(173, 77)
        cbPhotography.Name = "cbPhotography"
        cbPhotography.Size = New Size(165, 24)
        cbPhotography.TabIndex = 5
        cbPhotography.Text = "Nature Photography"
        cbPhotography.UseVisualStyleBackColor = True
        ' 
        ' cbTracking
        ' 
        cbTracking.AutoSize = True
        cbTracking.Font = New Font("Segoe UI", 9.0F)
        cbTracking.Location = New Point(173, 51)
        cbTracking.Name = "cbTracking"
        cbTracking.Size = New Size(132, 24)
        cbTracking.TabIndex = 4
        cbTracking.Text = "Jungle Tracking"
        cbTracking.UseVisualStyleBackColor = True
        ' 
        ' cbSurvival
        ' 
        cbSurvival.AutoSize = True
        cbSurvival.Font = New Font("Segoe UI", 9.0F)
        cbSurvival.Location = New Point(173, 25)
        cbSurvival.Name = "cbSurvival"
        cbSurvival.Size = New Size(82, 24)
        cbSurvival.TabIndex = 3
        cbSurvival.Text = "Survival"
        cbSurvival.UseVisualStyleBackColor = True
        ' 
        ' cbClimbing
        ' 
        cbClimbing.AutoSize = True
        cbClimbing.Font = New Font("Segoe UI", 9.0F)
        cbClimbing.Location = New Point(15, 77)
        cbClimbing.Name = "cbClimbing"
        cbClimbing.Size = New Size(91, 24)
        cbClimbing.TabIndex = 2
        cbClimbing.Text = "Climbing"
        cbClimbing.UseVisualStyleBackColor = True
        ' 
        ' cbCamping
        ' 
        cbCamping.AutoSize = True
        cbCamping.Font = New Font("Segoe UI", 9.0F)
        cbCamping.Location = New Point(15, 51)
        cbCamping.Name = "cbCamping"
        cbCamping.Size = New Size(91, 24)
        cbCamping.TabIndex = 1
        cbCamping.Text = "Camping"
        cbCamping.UseVisualStyleBackColor = True
        ' 
        ' cbHiking
        ' 
        cbHiking.AutoSize = True
        cbHiking.Font = New Font("Segoe UI", 9.0F)
        cbHiking.Location = New Point(15, 25)
        cbHiking.Name = "cbHiking"
        cbHiking.Size = New Size(74, 24)
        cbHiking.TabIndex = 0
        cbHiking.Text = "Hiking"
        cbHiking.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbMember)
        GroupBox1.Controls.Add(rbSurvival)
        GroupBox1.Controls.Add(rbNavigator)
        GroupBox1.Controls.Add(rbLeader)
        GroupBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(211, 128)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(337, 100)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' rbMember
        ' 
        rbMember.AutoSize = True
        rbMember.Font = New Font("Segoe UI", 9.0F)
        rbMember.Location = New Point(188, 56)
        rbMember.Name = "rbMember"
        rbMember.Size = New Size(86, 24)
        rbMember.TabIndex = 3
        rbMember.TabStop = True
        rbMember.Text = "Member"
        rbMember.UseVisualStyleBackColor = True
        ' 
        ' rbSurvival
        ' 
        rbSurvival.AutoSize = True
        rbSurvival.Font = New Font("Segoe UI", 9.0F)
        rbSurvival.Location = New Point(188, 31)
        rbSurvival.Name = "rbSurvival"
        rbSurvival.Size = New Size(127, 24)
        rbSurvival.TabIndex = 2
        rbSurvival.TabStop = True
        rbSurvival.Text = "Survival Expert"
        rbSurvival.UseVisualStyleBackColor = True
        ' 
        ' rbNavigator
        ' 
        rbNavigator.AutoSize = True
        rbNavigator.Font = New Font("Segoe UI", 9.0F)
        rbNavigator.Location = New Point(16, 56)
        rbNavigator.Name = "rbNavigator"
        rbNavigator.Size = New Size(96, 24)
        rbNavigator.TabIndex = 1
        rbNavigator.TabStop = True
        rbNavigator.Text = "Navigator"
        rbNavigator.UseVisualStyleBackColor = True
        ' 
        ' rbLeader
        ' 
        rbLeader.AutoSize = True
        rbLeader.Font = New Font("Segoe UI", 9.0F)
        rbLeader.Location = New Point(16, 26)
        rbLeader.Name = "rbLeader"
        rbLeader.Size = New Size(75, 24)
        rbLeader.TabIndex = 0
        rbLeader.TabStop = True
        rbLeader.Text = "Leader"
        rbLeader.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(56, 235)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' pbFoto
        ' 
        pbFoto.BackColor = Color.White
        pbFoto.BackgroundImage = CType(resources.GetObject("pbFoto.BackgroundImage"), Image)
        pbFoto.BackgroundImageLayout = ImageLayout.Stretch
        pbFoto.Location = New Point(17, 16)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(173, 212)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormMenu
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.EXPLORER_MEMBER_CARD___9_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(tab)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormMenu"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        tab.ResumeLayout(False)
        tabData.ResumeLayout(False)
        tabData.PerformLayout()
        tabKontak.ResumeLayout(False)
        tabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        gbAktivitas.ResumeLayout(False)
        gbAktivitas.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuInput As ToolStripMenuItem
    Friend WithEvents menuSimpan As ToolStripMenuItem
    Friend WithEvents menuBuka As ToolStripMenuItem
    Friend WithEvents menuLihat As ToolStripMenuItem
    Friend WithEvents menuKeluar As ToolStripMenuItem
    Friend WithEvents tab As TabControl
    Friend WithEvents tabData As TabPage
    Friend WithEvents tabKontak As TabPage
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents txtAlmdy As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents rbNavigator As RadioButton
    Friend WithEvents rbLeader As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rbMember As RadioButton
    Friend WithEvents rbSurvival As RadioButton
    Friend WithEvents gbAktivitas As GroupBox
    Friend WithEvents cbExploring As CheckBox
    Friend WithEvents cbRafting As CheckBox
    Friend WithEvents cbPhotography As CheckBox
    Friend WithEvents cbTracking As CheckBox
    Friend WithEvents cbSurvival As CheckBox
    Friend WithEvents cbClimbing As CheckBox
    Friend WithEvents cbCamping As CheckBox
    Friend WithEvents cbHiking As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class

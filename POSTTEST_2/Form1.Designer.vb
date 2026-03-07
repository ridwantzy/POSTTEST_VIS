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
        grpTambah = New GroupBox()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        btnTambah = New Button()
        lblGenre = New Label()
        lblJudul = New Label()
        grpHapus = New GroupBox()
        txtHapus = New TextBox()
        btnHapus = New Button()
        lblHapus = New Label()
        listBuku = New ListBox()
        Label1 = New Label()
        panelHeader = New Panel()
        Label2 = New Label()
        Panel1 = New Panel()
        grpTambah.SuspendLayout()
        grpHapus.SuspendLayout()
        panelHeader.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpTambah
        ' 
        grpTambah.BackColor = Color.White
        grpTambah.Controls.Add(txtGenre)
        grpTambah.Controls.Add(txtJudul)
        grpTambah.Controls.Add(btnTambah)
        grpTambah.Controls.Add(lblGenre)
        grpTambah.Controls.Add(lblJudul)
        grpTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpTambah.Location = New Point(12, 60)
        grpTambah.Name = "grpTambah"
        grpTambah.Size = New Size(377, 150)
        grpTambah.TabIndex = 0
        grpTambah.TabStop = False
        grpTambah.Text = "Tambah Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(119, 70)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(186, 27)
        txtGenre.TabIndex = 4
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(119, 32)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(186, 27)
        txtJudul.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.LightGreen
        btnTambah.Location = New Point(200, 108)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(27, 77)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(51, 20)
        lblGenre.TabIndex = 1
        lblGenre.Text = "Genre"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(21, 35)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(87, 20)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Judul Buku"
        ' 
        ' grpHapus
        ' 
        grpHapus.BackColor = Color.White
        grpHapus.Controls.Add(txtHapus)
        grpHapus.Controls.Add(btnHapus)
        grpHapus.Controls.Add(lblHapus)
        grpHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpHapus.Location = New Point(395, 60)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(368, 150)
        grpHapus.TabIndex = 1
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(131, 35)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(200, 27)
        txtHapus.TabIndex = 2
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.LightCoral
        btnHapus.Location = New Point(215, 108)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 1
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' lblHapus
        ' 
        lblHapus.AutoSize = True
        lblHapus.Location = New Point(12, 39)
        lblHapus.Name = "lblHapus"
        lblHapus.Size = New Size(87, 20)
        lblHapus.TabIndex = 0
        lblHapus.Text = "Judul Buku"
        ' 
        ' listBuku
        ' 
        listBuku.Font = New Font("Segoe UI", 10F)
        listBuku.FormattingEnabled = True
        listBuku.ItemHeight = 23
        listBuku.Location = New Point(13, 264)
        listBuku.Name = "listBuku"
        listBuku.Size = New Size(750, 188)
        listBuku.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label1.Location = New Point(265, 223)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 25)
        Label1.TabIndex = 3
        Label1.Text = "Daftar Buku Perpustakaan"
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.SteelBlue
        panelHeader.Controls.Add(Label2)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(782, 54)
        panelHeader.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(224, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(341, 38)
        Label2.TabIndex = 0
        Label2.Text = "SISTEM PERPUSTAKAAN"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(listBuku)
        Panel1.Controls.Add(grpTambah)
        Panel1.Controls.Add(grpHapus)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(782, 453)
        Panel1.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(782, 453)
        Controls.Add(panelHeader)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Daftar Buku Perpustakaan"
        grpTambah.ResumeLayout(False)
        grpTambah.PerformLayout()
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grpTambah As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents lblHapus As Label
    Friend WithEvents listBuku As ListBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panelHeader As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel

End Class

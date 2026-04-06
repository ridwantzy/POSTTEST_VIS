Public Class FormMenu

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)

        If e.Handled Then
            MsgBox("Nama hanya boleh huruf")
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        HanyaAngka(e)

        If e.Handled Then
            MsgBox("ID hanya boleh angka")
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Function AmbilAktivitas() As String
        Dim aktivitas As String = ""

        For Each ctrl As Control In gbAktivitas.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    aktivitas &= cb.Text & ", "
                End If
            End If
        Next

        Return aktivitas.TrimEnd(", ")
    End Function

    Private Function ValidasiInput() As Boolean

        If Not TidakBolehKosong(txtNama.Text) Then
            MsgBox("Nama tidak boleh kosong")
            Return False
        End If

        If Not TidakBolehKosong(txtID.Text) Then
            MsgBox("ID tidak boleh kosong")
            Return False
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MsgBox("Pilih jenis kelamin")
            Return False
        End If

        If cmbKomunitas.SelectedIndex = -1 Then
            MsgBox("Pilih jenis komunitas")
            Return False
        End If

        If Not MaskHarusLengkap(mtbTelepon) Then
            MsgBox("Nomor telepon belum lengkap")
            Return False
        End If

        If Not TidakBolehKosong(txtEmail.Text) Then
            MsgBox("Email tidak boleh kosong")
            Return False
        End If

        If Not EmailValid(txtEmail.Text) Then
            MsgBox("Format email tidak valid")
            Return False
        End If

        If Not TidakBolehKosong(txtAlamat.Text) Then
            MsgBox("Alamat tidak boleh kosong")
            Return False
        End If

        If pbFoto.Image Is Nothing Then
            MsgBox("Foto profil harus diisi")
            Return False
        End If

        If Not rbLeader.Checked And Not rbNavigator.Checked And Not rbSurvival.Checked And Not rbMember.Checked Then
            MsgBox("Pilih peran terlebih dahulu")
            Return False
        End If

        If Not MinimalSatuCheckbox(gbAktivitas.Controls) Then
            MsgBox("Pilih minimal 1 aktivitas")
            Return False
        End If

        Return True
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not ValidasiInput() Then Exit Sub

        Dim tanya As DialogResult
        tanya = MessageBox.Show("Tampilkan kartu sekarang?", "Konfirmasi Cetak", MessageBoxButtons.YesNo)

        If tanya = DialogResult.No Then Exit Sub

        Dim aktivitas As String = AmbilAktivitas()

        Dim frm As New FormKartu

        frm.nama = txtNama.Text
        frm.idAnggota = txtID.Text
        frm.komunitas = cmbKomunitas.Text
        frm.telepon = mtbTelepon.Text
        frm.aktivitas = aktivitas
        frm.foto = pbFoto.Image

        frm.Show()
    End Sub

    Private Sub menuSimpan_Click(sender As Object, e As EventArgs) Handles menuSimpan.Click

        Dim tanya As DialogResult
        tanya = MessageBox.Show("Yakin ingin menyimpan data?", "Konfirmasi Simpan", MessageBoxButtons.YesNo)

        If tanya = DialogResult.No Then Exit Sub

        Dim aktivitas As String = AmbilAktivitas()

        Dim jenisKelamin As String = ""
        If rbLaki.Checked Then jenisKelamin = "Laki-laki"
        If rbPerempuan.Checked Then jenisKelamin = "Perempuan"

        Dim peran As String = ""
        If rbLeader.Checked Then peran = "Leader"
        If rbNavigator.Checked Then peran = "Navigator"
        If rbSurvival.Checked Then peran = "Survival"
        If rbMember.Checked Then peran = "Member"

        Dim isi As String = BuatIsiFile(
        txtNama.Text,
        txtID.Text,
        cmbKomunitas.Text,
        mtbTelepon.Text,
        txtEmail.Text,
        txtAlamat.Text,
        jenisKelamin,
        peran,
        aktivitas
    )

        If SimpanData(SaveFileDialog1, isi) Then
            MsgBox("Data berhasil disimpan")
        End If

    End Sub

    Private Sub menuBuka_Click(sender As Object, e As EventArgs) Handles menuBuka.Click

        Dim data = BukaData(OpenFileDialog1)

        If data IsNot Nothing Then

            txtNama.Text = AmbilNilai(data, "Nama")
            txtID.Text = AmbilNilai(data, "ID")
            cmbKomunitas.Text = AmbilNilai(data, "Komunitas")
            mtbTelepon.Text = AmbilNilai(data, "Telepon")
            txtEmail.Text = AmbilNilai(data, "Email")
            txtAlamat.Text = AmbilNilai(data, "Alamat")

            Dim jk As String = AmbilNilai(data, "JenisKelamin")
            If jk = "Laki-laki" Then rbLaki.Checked = True
            If jk = "Perempuan" Then rbPerempuan.Checked = True

            Dim pr As String = AmbilNilai(data, "Peran")
            If pr = "Leader" Then rbLeader.Checked = True
            If pr = "Navigator" Then rbNavigator.Checked = True
            If pr = "Survival" Then rbSurvival.Checked = True
            If pr = "Member" Then rbMember.Checked = True

            Dim aktivitas As String = AmbilNilai(data, "Aktivitas")

            For Each ctrl As Control In gbAktivitas.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim cb As CheckBox = CType(ctrl, CheckBox)
                    cb.Checked = aktivitas.Contains(cb.Text)
                End If
            Next

        End If

    End Sub

    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihat.Click

        Dim frm As New FormKartu

        frm.nama = txtNama.Text
        frm.idAnggota = txtID.Text
        frm.komunitas = cmbKomunitas.Text
        frm.telepon = mtbTelepon.Text
        frm.aktivitas = AmbilAktivitas()
        frm.foto = pbFoto.Image

        frm.Show()
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click

        Dim tanya As DialogResult

        tanya = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)

        If tanya = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
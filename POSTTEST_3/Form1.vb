Imports System.IO

Public Class Form1

    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton


    Private Function CekData() As Boolean

        grupHobi = {cbHiking, cbCamping, cbTraveling, cbPhotography, cbClimbing,
                    cbFishing, cbCycling, cbRunning, cbNatureWalk, cbBirdWatching}

        grupJK = {rbMale, rbFemale}

        If Not ValidasiTextBox(txtName, "Name tidak boleh kosong") Then Return False
        If Not ValidasiTextBox(txtAge, "Age tidak boleh kosong") Then Return False
        If Not ValidasiTextBox(txtPhone, "Phone number tidak boleh kosong") Then Return False
        If txtPhone.Text.Length < 10 Then
            MessageBox.Show("Nomor telepon minimal 10 digit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return False
        End If
        If Not ValidasiTextBox(txtAddress, "Address tidak boleh kosong") Then Return False

        If Not ValidasiRadioButton(grupJK, "Pilih Gender") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Pilih minimal 1 Hobby") Then Return False
        If Not ValidasiPictureBox(picProfile, "Foto tidak boleh kosong") Then Return False

        Return True

    End Function


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If CekData() Then

            grupHobi = {cbHiking, cbCamping, cbTraveling, cbPhotography, cbClimbing,
                        cbFishing, cbCycling, cbRunning, cbNatureWalk, cbBirdWatching}

            grupJK = {rbMale, rbFemale}

            Dim hobbySelected As String = GetSelectedCheckBox(grupHobi)
            Dim jkSelected As String = GetSelectedRadioButton(grupJK)

            DataModule.Nama = txtName.Text
            DataModule.Umur = txtAge.Text
            DataModule.Telepon = txtPhone.Text
            DataModule.Alamat = txtAddress.Text
            DataModule.TglLahir = dtpBirth.Value.ToShortDateString()
            DataModule.JK = jkSelected
            DataModule.Hobi = hobbySelected

            FormKartu.Show()

        End If

    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        If ValidasiTextBox(txtName, "Name tidak boleh kosong") Then

            Dim namaFile As String = txtName.Text.Trim()

            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"

            If openFileDialog.ShowDialog() = DialogResult.OK Then

                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = namaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)

                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                File.Copy(openFileDialog.FileName, destinationPath, True)

                DataModule.Foto = destinationPath
                picProfile.Image = Image.FromFile(destinationPath)

                MessageBox.Show("Foto berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If

    End Sub


    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub


    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub


    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        ValidationModule.HanyaHuruf(sender, e)
    End Sub

End Class
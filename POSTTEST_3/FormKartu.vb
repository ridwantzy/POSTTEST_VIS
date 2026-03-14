Public Class FormKartu

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblName.Text = DataModule.Nama
        lblAge.Text = DataModule.Umur
        lblPhone.Text = DataModule.Telepon
        lblAddress.Text = DataModule.Alamat
        lblGender.Text = DataModule.JK
        lblHobby.Text = DataModule.Hobi
        lblBirth.Text = DataModule.TglLahir

        If Not String.IsNullOrEmpty(DataModule.Foto) Then
            PictureBox1.Image = Image.FromFile(DataModule.Foto)
        Else
            MessageBox.Show("Foto tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End If

    End Sub

End Class
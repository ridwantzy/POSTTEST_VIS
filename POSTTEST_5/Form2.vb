Imports MySqlConnector


Public Class Form2

    Public id_layanan As String
    Public modeEdit As Boolean = False

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not TidakBolehKosong(txtNama, "Nama layanan tidak boleh kosong!") Then
            Exit Sub
        End If
        If Not TidakBolehKosong(txtHarga, "Harga tidak boleh kosong!") Then
            Exit Sub
        End If
        If Not TidakBolehKosong(txtEstimasi, "Estimasi tidak boleh kosong!") Then
            Exit Sub
        End If
        If Not HarusAngka(txtHarga, "Harga harus berupa angka!") Then
            Exit Sub
        End If
        If Not HarusAngka(txtEstimasi, "Estimasi harus berupa angka!") Then
            Exit Sub
        End If

        Try
            Koneksi()

            If modeEdit = False Then
                Dim query As String = "INSERT INTO layanan_laundry (nama_layanan, harga_per_kg, estimasi_hari) VALUES (@nama, @harga, @estimasi)"
                cmd = New MySqlCommand(query, conn)

            Else
                Dim query As String = "UPDATE layanan_laundry SET nama_layanan=@nama, harga_per_kg=@harga, estimasi_hari=@estimasi WHERE id_layanan=@id"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id_layanan)

            End If

            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            cmd.Parameters.AddWithValue("@estimasi", txtEstimasi.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan!")
            'Biar pas nambah atau edit, Data langsung ke refresh tanpa harus klik load lagi
            If Application.OpenForms().OfType(Of Form1).Any Then
                Application.OpenForms().OfType(Of Form1).First().TampilData()
            End If
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim konfirmasi As DialogResult
        konfirmasi = MessageBox.Show("Yakin batal?", "Konfirmasi", MessageBoxButtons.YesNo)

        If konfirmasi = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
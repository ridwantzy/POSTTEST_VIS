Imports MySqlConnector

Public Class Form1
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Form2.modeEdit = False
        Form2.txtNama.Clear()
        Form2.txtHarga.Clear()
        Form2.txtEstimasi.Clear()

        Form2.ShowDialog()
    End Sub
    Private Sub btnLoad_Click_1(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            Koneksi()

            da = New MySqlDataAdapter("SELECT * FROM layanan_laundry", conn)
            ds = New DataSet
            da.Fill(ds, "layanan_laundry")

            DataGridView1.DataSource = ds.Tables("layanan_laundry")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data terlebih dahulu!")
            Exit Sub
        End If

        Form2.txtNama.Text = DataGridView1.CurrentRow.Cells("nama_layanan").Value
        Form2.txtHarga.Text = DataGridView1.CurrentRow.Cells("harga_per_kg").Value
        Form2.txtEstimasi.Text = DataGridView1.CurrentRow.Cells("estimasi_hari").Value

        Form2.id_layanan = DataGridView1.CurrentRow.Cells("id_layanan").Value
        Form2.modeEdit = True

        Form2.ShowDialog()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data yang ingin dihapus!")
            Exit Sub
        End If

        Dim id As String = DataGridView1.CurrentRow.Cells("id_layanan").Value

        Dim konfirmasi As DialogResult
        konfirmasi = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo)

        If konfirmasi = DialogResult.Yes Then
            Try
                Koneksi()

                Dim query As String = "DELETE FROM layanan_laundry WHERE id_layanan=@id"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Data berhasil dihapus!")

                btnLoad.PerformClick()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            Koneksi()

            Dim keyword As String = txtCari.Text

            Dim query As String = "SELECT * FROM layanan_laundry WHERE nama_layanan LIKE '%" & keyword & "%'"
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet
            da.Fill(ds, "layanan_laundry")

            DataGridView1.DataSource = ds.Tables("layanan_laundry")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub TampilData()
        Try
            Koneksi()

            da = New MySqlDataAdapter("SELECT * FROM layanan_laundry", conn)
            ds = New DataSet
            da.Fill(ds, "layanan_laundry")

            DataGridView1.DataSource = ds.Tables("layanan_laundry")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TampilData()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim konfirmasi As DialogResult
        konfirmasi = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class

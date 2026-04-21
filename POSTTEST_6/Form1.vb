Imports MySqlConnector

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFilterJenis()
        FilterData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Form2.modeEdit = False
        Form2.ResetForm()
        Form2.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data terlebih dahulu!")
            Exit Sub
        End If

        Form2.modeEdit = True
        Form2.id_layanan = DataGridView1.CurrentRow.Cells("id_layanan").Value

        Form2.Show()

        Form2.SetDataEdit(
            DataGridView1.CurrentRow.Cells("nama_layanan").Value,
            DataGridView1.CurrentRow.Cells("harga_per_kg").Value,
            DataGridView1.CurrentRow.Cells("estimasi_hari").Value,
            DataGridView1.CurrentRow.Cells("id_jenis").Value,
            DataGridView1.CurrentRow.Cells("satuan").Value,
            DataGridView1.CurrentRow.Cells("status").Value,
            DataGridView1.CurrentRow.Cells("deskripsi").Value
        )
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

                FilterData()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        FilterData()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        FilterData()
    End Sub

    Private Sub cbFilterJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilterJenis.SelectedIndexChanged
        If TypeOf cbFilterJenis.SelectedValue Is DataRowView Then Exit Sub
        FilterData()
    End Sub

    Public Sub LoadFilterJenis()
        Try
            Koneksi()

            Dim daJenis As New MySqlDataAdapter("SELECT id_jenis, nama_jenis FROM jenis_layanan", conn)
            Dim dt As New DataTable
            daJenis.Fill(dt)

            Dim row As DataRow = dt.NewRow()
            row("id_jenis") = 0
            row("nama_jenis") = "-- Semua Jenis --"
            dt.Rows.InsertAt(row, 0)

            cbFilterJenis.DataSource = dt
            cbFilterJenis.DisplayMember = "nama_jenis"
            cbFilterJenis.ValueMember = "id_jenis"
            cbFilterJenis.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub FilterData()
        Try
            Koneksi()

            If TypeOf cbFilterJenis.SelectedValue Is DataRowView Then Exit Sub

            Dim idJenis As Integer = CInt(cbFilterJenis.SelectedValue)
            Dim keyword As String = txtCari.Text

            Dim query As String = "
            SELECT 
                layanan_laundry.id_layanan,
                layanan_laundry.nama_layanan,
                layanan_laundry.harga_per_kg,
                layanan_laundry.estimasi_hari,
                layanan_laundry.id_jenis,
                jenis_layanan.nama_jenis,
                layanan_laundry.satuan,
                layanan_laundry.status,
                layanan_laundry.deskripsi
            FROM layanan_laundry
            INNER JOIN jenis_layanan 
            ON layanan_laundry.id_jenis = jenis_layanan.id_jenis
            WHERE 1=1
            "

            If keyword <> "" Then
                query &= " AND layanan_laundry.nama_layanan LIKE '%" & keyword & "%'"
            End If

            If idJenis <> 0 Then
                query &= " AND layanan_laundry.id_jenis = " & idJenis
            End If

            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet
            da.Fill(ds, "layanan_laundry")

            DataGridView1.DataSource = ds.Tables("layanan_laundry")
            DataGridView1.Columns("id_jenis").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim konfirmasi As DialogResult
        konfirmasi = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
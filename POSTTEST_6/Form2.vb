Imports MySqlConnector

Public Class Form2

    Public id_layanan As String
    Public modeEdit As Boolean = False

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Koneksi()

            Dim daJenis As New MySqlDataAdapter("SELECT id_jenis, nama_jenis FROM jenis_layanan", conn)
            Dim dtJenis As New DataTable
            daJenis.Fill(dtJenis)

            Dim row As DataRow = dtJenis.NewRow()
            row("id_jenis") = 0
            row("nama_jenis") = "-- Pilih Jenis --"
            dtJenis.Rows.InsertAt(row, 0)

            cbJenis.DataSource = Nothing
            cbJenis.Items.Clear()

            cbJenis.DataSource = dtJenis
            cbJenis.DisplayMember = "nama_jenis"
            cbJenis.ValueMember = "id_jenis"

            cbJenis.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If modeEdit = False Then
            ResetForm()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not TidakBolehKosong(txtNama, "Nama layanan tidak boleh kosong!") Then Exit Sub
        If Not TidakBolehKosong(txtHarga, "Harga tidak boleh kosong!") Then Exit Sub
        If Not TidakBolehKosong(txtEstimasi, "Estimasi tidak boleh kosong!") Then Exit Sub
        If Not HarusAngka(txtHarga, "Harga harus berupa angka!") Then Exit Sub
        If Not HarusAngka(txtEstimasi, "Estimasi harus berupa angka!") Then Exit Sub

        If cbJenis.SelectedValue = 0 Then
            MessageBox.Show("Silakan pilih jenis layanan!")
            cbJenis.Focus()
            Exit Sub
        End If

        If cbSatuan.SelectedIndex = -1 Or cbSatuan.Text = "" Then
            MessageBox.Show("Satuan tidak boleh kosong!")
            cbSatuan.Focus()
            Exit Sub
        End If

        If cbStatus.SelectedIndex = -1 Or cbStatus.Text = "" Then
            MessageBox.Show("Status tidak boleh kosong!")
            cbStatus.Focus()
            Exit Sub
        End If

        Try
            Koneksi()

            Dim idJenis As Integer = 0

            If cbJenis.SelectedValue IsNot Nothing AndAlso IsNumeric(cbJenis.SelectedValue) Then
                idJenis = CInt(cbJenis.SelectedValue)
            End If
            Dim deskripsi As String = txtDeskripsi.Text
            Dim satuan As String = cbSatuan.Text
            Dim status As String = cbStatus.Text

            If modeEdit = False Then

                Dim query As String = "INSERT INTO layanan_laundry 
                (nama_layanan, harga_per_kg, estimasi_hari, id_jenis, deskripsi, satuan, status) 
                VALUES (@nama, @harga, @estimasi, @jenis, @deskripsi, @satuan, @status)"

                cmd = New MySqlCommand(query, conn)

            Else

                Dim query As String = "UPDATE layanan_laundry SET 
                    nama_layanan=@nama,
                    harga_per_kg=@harga,
                    estimasi_hari=@estimasi,
                    id_jenis=@jenis,
                    deskripsi=@deskripsi,
                    satuan=@satuan,
                    status=@status
                    WHERE id_layanan=@id"

                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id_layanan)

            End If

            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            cmd.Parameters.AddWithValue("@estimasi", txtEstimasi.Text)
            cmd.Parameters.AddWithValue("@jenis", idJenis)
            cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
            cmd.Parameters.AddWithValue("@satuan", satuan)
            cmd.Parameters.AddWithValue("@status", status)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan!")

            If Application.OpenForms().OfType(Of Form1).Any Then
                Application.OpenForms().OfType(Of Form1).First().FilterData()
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

    Public Sub SetDataEdit(nama As String, harga As String, estimasi As String, idJenis As Integer, satuan As String, status As String, deskripsi As String)
        txtNama.Text = nama
        txtHarga.Text = harga
        txtEstimasi.Text = estimasi
        txtDeskripsi.Text = deskripsi

        cbJenis.SelectedValue = idJenis
        cbSatuan.Text = satuan
        cbStatus.Text = status
    End Sub

    Public Sub ResetForm()
        txtNama.Clear()
        txtHarga.Clear()
        txtEstimasi.Clear()
        txtDeskripsi.Clear()

        If cbJenis.Items.Count > 0 Then
            cbJenis.SelectedIndex = 0
        End If

        cbSatuan.SelectedIndex = -1
        cbStatus.SelectedIndex = -1
    End Sub
End Class
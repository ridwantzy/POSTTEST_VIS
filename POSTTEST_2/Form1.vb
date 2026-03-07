Public Class Form1
    Private Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        judulBuku(jumlahBuku) = judul
        genreBuku(jumlahBuku) = genre

        jumlahBuku += 1

    End Sub

    Private Function CariBuku(judul As String) As Integer

        Dim i As Integer

        For i = 0 To jumlahBuku - 1
            If judulBuku(i) = judul Then
                Return i
            End If

        Next

        Return -1

    End Function

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtJudul.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("Data belum lengkap")
            Exit Sub
        End If

        If CariBuku(txtJudul.Text) <> -1 Then
            MessageBox.Show("Buku sudah ada")
            Exit Sub
        End If

        TambahBuku(txtJudul.Text, txtGenre.Text)

        listBuku.Items.Add(txtJudul.Text & " - " & txtGenre.Text)

        MessageBox.Show("Buku berhasil ditambahkan")

        txtJudul.Text = ""
        txtGenre.Text = ""

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim index As Integer

        index = CariBuku(txtHapus.Text)

        If index = -1 Then

            MessageBox.Show("Buku tidak ditemukan")

        Else

            judulBuku(index) = ""
            genreBuku(index) = ""

            MessageBox.Show("Buku berhasil dihapus")

            txtHapus.Text = ""

            listBuku.Items.Clear()

            Dim i As Integer

            For i = 0 To jumlahBuku - 1

                If judulBuku(i) <> "" Then
                    listBuku.Items.Add(judulBuku(i) & " - " & genreBuku(i))
                End If

            Next

        End If

    End Sub

End Class

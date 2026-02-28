Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ips As Double

        If txtIPS.Text = "" Then
            MessageBox.Show("IPS tidak boleh kosong!")
        Else

            If Double.TryParse(txtIPS.Text, ips) Then

                If ips >= 0 And ips <= 4 Then

                    totalIP = totalIP + ips
                    jumlahSemester = jumlahSemester + 1

                    Dim ipk As Double
                    ipk = totalIP / jumlahSemester

                    txtIPK.Text = ipk.ToString("0.00")

                    If ipk >= 2 And ipk <= 2.75 Then
                        predikat.Text = "Cukup"
                    ElseIf ipk >= 2.76 And ipk <= 3 Then
                        predikat.Text = "Memuaskan"
                    ElseIf ipk > 3 Then
                        predikat.Text = "Sangat Memuaskan"
                    Else
                        predikat.Text = "-"
                    End If

                    txtIPS.Text = ""

                Else
                    MessageBox.Show("IPS harus antara 0 sampai 4!")
                End If

            Else
                MessageBox.Show("IPS harus berupa angka!")
            End If

        End If

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPS.Text = ""
        txtIPK.Text = ""
        predikat.Text = "-"

    End Sub

End Class
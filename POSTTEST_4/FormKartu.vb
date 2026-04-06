Public Class FormKartu

    Public nama As String
    Public idAnggota As String
    Public komunitas As String
    Public telepon As String
    Public aktivitas As String
    Public foto As Image
    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = ":  " & nama
        lblID.Text = ":  " & idAnggota
        lblKomunitas.Text = ":  " & komunitas
        lblTelepon.Text = ":  " & telepon
        lblAktivitas.Text = ":  " & aktivitas

        pbFotoKartu.Image = foto
    End Sub
End Class
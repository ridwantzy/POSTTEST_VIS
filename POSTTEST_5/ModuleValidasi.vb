Module ModuleValidasi

    Public Function TidakBolehKosong(txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim = "" Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If
        Return True
    End Function

    Public Function HarusAngka(txt As TextBox, pesan As String) As Boolean
        If Not IsNumeric(txt.Text) Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If
        Return True
    End Function

    Public Function TidakBolehAngka(txt As TextBox, pesan As String) As Boolean
        If IsNumeric(txt.Text) Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If
        Return True
    End Function

End Module
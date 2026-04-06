Imports System.Text.RegularExpressions

Module ModuleValidasi

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
       Char.IsWhiteSpace(e.KeyChar) OrElse
       Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function TidakBolehKosong(teks As String) As Boolean
        Return teks.Trim() <> ""
    End Function

    Public Function MaskHarusLengkap(mtb As MaskedTextBox) As Boolean
        Return mtb.MaskFull
    End Function
    Public Function EmailValid(email As String) As Boolean
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email, pattern)
    End Function

    Public Function MinimalSatuCheckbox(ctrls As Control.ControlCollection) As Boolean

        For Each ctrl As Control In ctrls

            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    Return True
                End If
            End If

            If ctrl.HasChildren Then
                If MinimalSatuCheckbox(ctrl.Controls) Then
                    Return True
                End If
            End If

        Next

        Return False
    End Function

End Module
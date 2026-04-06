Imports System.IO

Module DataModule

    Public Function BuatIsiFile(
        nama As String,
        id As String,
        komunitas As String,
        telepon As String,
        email As String,
        alamat As String,
        jenisKelamin As String,
        peran As String,
        aktivitas As String
    ) As String

        Return "Nama=" & nama & vbCrLf &
               "ID=" & id & vbCrLf &
               "Komunitas=" & komunitas & vbCrLf &
               "Telepon=" & telepon & vbCrLf &
               "Email=" & email & vbCrLf &
               "Alamat=" & alamat & vbCrLf &
               "JenisKelamin=" & jenisKelamin & vbCrLf &
               "Peran=" & peran & vbCrLf &
               "Aktivitas=" & aktivitas

    End Function

    Public Function SimpanData(sfd As SaveFileDialog, isi As String) As Boolean

        sfd.Filter = "Text File|*.txt"
        sfd.Title = "Simpan Data"
        sfd.FileName = "data.txt"

        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi)
            Return True
        End If

        Return False
    End Function

    Public Function BukaData(ofd As OpenFileDialog) As Dictionary(Of String, String)

        ofd.Filter = "Text File|*.txt"

        If ofd.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        End If

        Dim hasil As New Dictionary(Of String, String)

        Dim lines() As String = File.ReadAllLines(ofd.FileName)

        For Each line In lines

            If String.IsNullOrWhiteSpace(line) Then Continue For

            Dim parts() As String = line.Split("="c)

            If parts.Length = 2 Then
                hasil(parts(0).Trim()) = parts(1).Trim()
            End If

        Next

        Return hasil
    End Function

    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String

        If data IsNot Nothing AndAlso data.ContainsKey(key) Then
            Return data(key)
        End If

        Return ""

    End Function

End Module
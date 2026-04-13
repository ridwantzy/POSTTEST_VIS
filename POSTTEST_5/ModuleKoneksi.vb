Imports MySqlConnector

Module ModuleKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public ds As DataSet

    Public Sub Koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_laundry")

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
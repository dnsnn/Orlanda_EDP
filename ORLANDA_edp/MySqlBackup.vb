Imports MySql.Data.MySqlClient

Friend Class MySqlBackup
    Private cmd As MySqlCommand

    Public Sub New(cmd As MySqlCommand)
        Me.cmd = cmd
    End Sub

    Friend Sub ExportToFile(fileName As String)
        Throw New NotImplementedException()
    End Sub
End Class

Imports MySql.Data.MySqlClient
Public Class Form1
    Private conn As MySqlConnection

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim username As String = UsernameTxt.Text
        Dim password As String = PasswordTxt.Text

        Dim myConnectionString As String = "server=localhost;user id=root;password=februaryFOURTEEN2001;database=point-of-sale system"
        Dim conn As New MySqlConnection(myConnectionString)

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()


            Dim query As String = "SELECT * FROM loginform;"


            Dim cmd As New MySqlCommand(query, conn)


            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login successful!")
                Me.Hide()
                Dim form2 As New Form2()
                form2.Show()
            Else
                MessageBox.Show("Invalid username or password!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class

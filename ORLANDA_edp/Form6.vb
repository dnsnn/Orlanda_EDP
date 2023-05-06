Imports MySql.Data.MySqlClient
Public Class Form6
    Dim myConnectionString As String = "server=localhost;user id=root;password=februaryFOURTEEN2001;database=point-of-sale system"
    Dim conn As New MySqlConnection(myConnectionString)
    Dim selectedprodno As Integer = 0
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO category(categoryname, description) VALUES(@categoryname, @description);"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@categoryname", categoryname.Text)
            cmd.Parameters.AddWithValue("@description", description.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Category was successfully added!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim form5 As New Form5()
        form5.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            conn.Open()
            Dim query As String = "DELETE FROM category WHERE categoryname=@categoryname;"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@catefgoryname", categoryname.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Category was successfully deleted!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
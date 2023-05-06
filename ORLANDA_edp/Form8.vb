Imports DocumentFormat.OpenXml.InkML
Imports MySql.Data.MySqlClient

Public Class Form8
    Dim myConnectionString As String = "server=localhost;user id=root;password=februaryFOURTEEN2001;database=point-of-sale system"
    Dim conn As New MySqlConnection(myConnectionString)
    Dim selectedprodno As Integer = 0
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO sales(sales, date) VALUES(@sales, @date);"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@sales", sales.Text)
            cmd.Parameters.AddWithValue("@date", date_time.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sales was successfully added!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            conn.Open()
            Dim query As String = "DELETE FROM sales WHERE sales=@sales;"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@sales", sales.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sales was successfully deleted!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim form7 As New Form7()
        form7.Show()
        Me.Hide()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class Form4
    Dim myConnectionString As String = "server=localhost;user id=root;password=februaryFOURTEEN2001;database=point-of-sale system"
    Dim conn As New MySqlConnection(myConnectionString)
    Dim selectedprodno As Integer = 0

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim form3 As New Form3()
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO product(prodname, category, quantity_stock, price) VALUES(@prodname, @category, @quantity_stock, @price);"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@prodname", productname.Text)
            cmd.Parameters.AddWithValue("@category", category.Text)
            cmd.Parameters.AddWithValue("@quantity_stock", stock.Text)
            cmd.Parameters.AddWithValue("@price", price.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Product was successfully added!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            conn.Open()
            Dim query As String = "DELETE FROM product WHERE prodname=@prodname;"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@prodname", productname.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Product was successfully deleted!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
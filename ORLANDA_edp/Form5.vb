Imports MySql.Data.MySqlClient
Public Class Form5
    Private conn As MySqlConnection
    Public Sub New()
        InitializeComponent()

        ' Initialize the connection object with connection string
        conn = New MySqlConnection("Server=localhost;Database=point-of-sale system;Uid=root;Pwd=februaryFOURTEEN2001;")
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Open the database connection
            conn.Open()

            ' Create MySqlCommand and MySqlDataReader objects
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            ' Query to fetch data from equipments table
            Dim strSQL As String = "SELECT * FROM category;"
            mycmd.CommandText = strSQL
            mycmd.Connection = conn

            ' Execute the query and fetch the data
            myreader = mycmd.ExecuteReader()

            ' Load data into a DataTable
            Dim dt As New DataTable
            dt.Load(myreader)

            ' Bind the DataTable to the DataGridView
            DataGridView1.DataSource = dt

            ' Close the database connection and reader
            myreader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim form6 As New Form6()
        form6.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim form6 As New Form6()
        form6.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Library_saniDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.Library_saniDataSet.books)

    End Sub

    Private Sub Add_Btn_Click(sender As Object, e As EventArgs) Handles Add_Btn.Click
        Dim Query As String
        'step 1: connect with the database
        Dim Con As MySqlConnection = New MySqlConnection("DataSource=localhost;Database=library_sani;User Id=root;Password=;")
        Con.Open()
        'step 2: Create query string
        Query = " insert into books (Name, Author, Year) values ('" + Name_txbx.Text + "','" + author_txbx.Text + "'," + year_txbx.Text + ");"

        'step 3: run the query
        Dim c As MySqlCommand = New MySqlCommand(Query, Con)
        Dim i As Integer = c.ExecuteNonQuery()

        ' step 4: check the result
        If (i = 0) Then
            MsgBox("fail")
        Else
            MsgBox("sucess")
            Me.BooksTableAdapter.Fill(Me.Library_saniDataSet.books)
        End If
        'step 5: close connection
        Con.Close()
    End Sub


    Private Sub del_Btn_Click(sender As Object, e As EventArgs) Handles del_Btn.Click
        Dim Query As String
        'step 1: connect with the database
        Dim Con As MySqlConnection = New MySqlConnection("DataSource=localhost;Database=library_sani;User Id=root;Password=;")
        Con.Open()
        'step 2: Create query string
        Query = " DELETE from books where BookID = " + Delete_txbx.Text + ";"

        'step 3: run the query
        Dim c As MySqlCommand = New MySqlCommand(Query, Con)
        Dim i As Integer = c.ExecuteNonQuery()

        ' step 4: check the result
        If (i = 0) Then
            MsgBox("fail")
        Else
            MsgBox("sucess")
            Me.BooksTableAdapter.Fill(Me.Library_saniDataSet.books)
        End If
        'step 5: close connection
        Con.Close()
    End Sub
End Class

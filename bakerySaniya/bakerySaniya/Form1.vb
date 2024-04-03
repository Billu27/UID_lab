Imports MySql.Data.MySqlClient
Public Class Form1
    Public Sub UpdateQuantity(itemId As Integer, newQuantity As Integer)
        Dim connectionString As String = "server=localhost;database=bakerysani;user id=root;password=student;"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim query As String = "UPDATE Bakery_items SET Quantity = @newQuantity WHERE item_id = @itemId"


        Using command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@newQuantity", newQuantity)
            command.Parameters.AddWithValue("@itemId", itemId)

            Try

                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Console.WriteLine("Rows affected: " & rowsAffected.ToString())
                Me.Bakery_itemsTableAdapter.Fill(Me.BakerysaniDataSet.bakery_items)
            Catch ex As Exception
                Console.WriteLine("An error occurred: " & ex.Message)
                connection.Close()
            End Try
        End Using

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BakerysaniDataSet.bakery_items' table. You can move, or remove it, as needed.
        Me.Bakery_itemsTableAdapter.Fill(Me.BakerysaniDataSet.bakery_items)

    End Sub

    Private Sub upd_btn_Click(sender As Object, e As EventArgs) Handles upd_btn.Click
        UpdateQuantity(Val(itemID_txbx.Text), Val(qty_txbx.Text))
    End Sub

End Class

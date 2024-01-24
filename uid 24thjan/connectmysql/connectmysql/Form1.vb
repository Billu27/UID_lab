Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_22135_saniyaDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me._22135_saniyaDataSet.student)

    End Sub

    Private Sub refBTN_Click(sender As Object, e As EventArgs) Handles refBTN.Click
        Me.StudentTableAdapter.Fill(Me._22135_saniyaDataSet.student)
    End Sub
End Class

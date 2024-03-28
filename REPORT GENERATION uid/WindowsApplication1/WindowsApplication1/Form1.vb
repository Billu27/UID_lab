Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'college_22135DataSet.student' table. You can move, or remove it, as needed.
        Me.studentTableAdapter.Fill(Me.college_22135DataSet.student)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class

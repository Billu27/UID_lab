Public Class Form1

    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        Dim n1, n2, answer As Integer
        Try
            n1 = Val(numTxBx1.Text)
            n2 = Val(numTxbx2.Text)

            If (n1.Equals(0) Or n2.Equals(0)) Then
                Throw New ApplicationException("zero exception")
            ElseIf (n1 > 10) Then
                Throw New ApplicationException("num")
            Else
                answer = n1 \ n2
            End If
        Catch ex As DivideByZeroException
            MsgBox(ex.ToString)

        Catch ex As InvalidCastException
            MsgBox("empty string")
        Catch ex As ApplicationException
            MsgBox(" change the number to anythg other than zero")
        Catch ex As ApplicationException
            MsgBox("nuum should be less than 10")
        Finally
            MsgBox(answer)
        End Try

    End Sub
End Class

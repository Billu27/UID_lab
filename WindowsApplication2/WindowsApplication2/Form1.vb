Public Class Form1

    Private Sub termsconds_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles termsconds.LinkClicked
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If checkbx.Checked = True Then
            Me.Hide()
            Form3.Show()
        Else
            MessageBox.Show("please check the terms and conditions", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

   
    Private Sub resetbtn_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to reset the values?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            fnametxt.Clear()
            lnametxt.Clear()
            gunameTxt.Clear()
            addrTxt.Clear()
            DateTimePicker1.ResetText()
            MaleRbtn.Checked = False
            FmlRbtn.Checked = False
            otherRbtn.Checked = False
            classCombobx.ResetText()
            checkbx.Checked = False
        End If
    End Sub
End Class

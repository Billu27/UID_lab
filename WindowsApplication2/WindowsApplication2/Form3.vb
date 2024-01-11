Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fnTxbx.Text = Form1.fnametxt.Text
        lnTxbx.Text = Form1.lnametxt.Text
        guardTxbx.Text = Form1.gunameTxt.Text
        addTxbx.Text = Form1.addrTxt.Text
        'Dim datestr As String
        Datepick = Form1.DateTimePicker1

        If Form1.MaleRbtn.Checked Then
            gendTxbx.Text = "Male"
        ElseIf Form1.FmlRbtn.Checked Then
            gendTxbx.Text = "Female"
        Else
            gendTxbx.Text = "Others"
        End If

        clasTxbx.Text = Form1.classCombobx.Text
    End Sub

    Private Sub confBtn_Click(sender As Object, e As EventArgs) Handles confBtn.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub modfbtn_Click(sender As Object, e As EventArgs) Handles modfbtn.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
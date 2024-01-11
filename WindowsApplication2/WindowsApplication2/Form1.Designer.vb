<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.fnametxt = New System.Windows.Forms.TextBox()
        Me.lnametxt = New System.Windows.Forms.TextBox()
        Me.gunameTxt = New System.Windows.Forms.TextBox()
        Me.addrTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.classCombobx = New System.Windows.Forms.ComboBox()
        Me.MaleRbtn = New System.Windows.Forms.RadioButton()
        Me.FmlRbtn = New System.Windows.Forms.RadioButton()
        Me.otherRbtn = New System.Windows.Forms.RadioButton()
        Me.checkbx = New System.Windows.Forms.CheckBox()
        Me.termsconds = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'fnametxt
        '
        Me.fnametxt.Location = New System.Drawing.Point(175, 71)
        Me.fnametxt.Name = "fnametxt"
        Me.fnametxt.Size = New System.Drawing.Size(207, 20)
        Me.fnametxt.TabIndex = 0
        '
        'lnametxt
        '
        Me.lnametxt.Location = New System.Drawing.Point(175, 109)
        Me.lnametxt.Name = "lnametxt"
        Me.lnametxt.Size = New System.Drawing.Size(207, 20)
        Me.lnametxt.TabIndex = 1
        '
        'gunameTxt
        '
        Me.gunameTxt.Location = New System.Drawing.Point(176, 146)
        Me.gunameTxt.Name = "gunameTxt"
        Me.gunameTxt.Size = New System.Drawing.Size(207, 20)
        Me.gunameTxt.TabIndex = 2
        '
        'addrTxt
        '
        Me.addrTxt.Location = New System.Drawing.Point(176, 180)
        Me.addrTxt.Multiline = True
        Me.addrTxt.Name = "addrTxt"
        Me.addrTxt.Size = New System.Drawing.Size(207, 55)
        Me.addrTxt.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(176, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'resetbtn
        '
        Me.resetbtn.Location = New System.Drawing.Point(306, 393)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(75, 23)
        Me.resetbtn.TabIndex = 7
        Me.resetbtn.Text = "RESET"
        Me.resetbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "FIRST NAME : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "LAST NAME : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "GUARDIAN NAME : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ADDRESS : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "DATE OF BIRTH : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "GENDER : "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(176, 253)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(207, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'classCombobx
        '
        Me.classCombobx.FormattingEnabled = True
        Me.classCombobx.Items.AddRange(New Object() {"FY", "SY", "TY"})
        Me.classCombobx.Location = New System.Drawing.Point(175, 317)
        Me.classCombobx.Name = "classCombobx"
        Me.classCombobx.Size = New System.Drawing.Size(206, 21)
        Me.classCombobx.TabIndex = 15
        '
        'MaleRbtn
        '
        Me.MaleRbtn.AutoSize = True
        Me.MaleRbtn.Location = New System.Drawing.Point(175, 284)
        Me.MaleRbtn.Name = "MaleRbtn"
        Me.MaleRbtn.Size = New System.Drawing.Size(54, 17)
        Me.MaleRbtn.TabIndex = 16
        Me.MaleRbtn.TabStop = True
        Me.MaleRbtn.Text = "MALE"
        Me.MaleRbtn.UseVisualStyleBackColor = True
        '
        'FmlRbtn
        '
        Me.FmlRbtn.AutoSize = True
        Me.FmlRbtn.Location = New System.Drawing.Point(245, 284)
        Me.FmlRbtn.Name = "FmlRbtn"
        Me.FmlRbtn.Size = New System.Drawing.Size(67, 17)
        Me.FmlRbtn.TabIndex = 17
        Me.FmlRbtn.TabStop = True
        Me.FmlRbtn.Text = "FEMALE"
        Me.FmlRbtn.UseVisualStyleBackColor = True
        '
        'otherRbtn
        '
        Me.otherRbtn.AutoSize = True
        Me.otherRbtn.Location = New System.Drawing.Point(318, 284)
        Me.otherRbtn.Name = "otherRbtn"
        Me.otherRbtn.Size = New System.Drawing.Size(70, 17)
        Me.otherRbtn.TabIndex = 18
        Me.otherRbtn.TabStop = True
        Me.otherRbtn.Text = "OTHERS"
        Me.otherRbtn.UseVisualStyleBackColor = True
        '
        'checkbx
        '
        Me.checkbx.AutoSize = True
        Me.checkbx.Location = New System.Drawing.Point(174, 353)
        Me.checkbx.Name = "checkbx"
        Me.checkbx.Size = New System.Drawing.Size(65, 17)
        Me.checkbx.TabIndex = 19
        Me.checkbx.Text = "I accept"
        Me.checkbx.UseVisualStyleBackColor = True
        '
        'termsconds
        '
        Me.termsconds.AutoSize = True
        Me.termsconds.Location = New System.Drawing.Point(260, 354)
        Me.termsconds.Name = "termsconds"
        Me.termsconds.Size = New System.Drawing.Size(104, 13)
        Me.termsconds.TabIndex = 20
        Me.termsconds.TabStop = True
        Me.termsconds.Text = "terms and conditions"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(324, 31)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "REGISTRATION FORM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "CLASS : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 432)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.termsconds)
        Me.Controls.Add(Me.checkbx)
        Me.Controls.Add(Me.otherRbtn)
        Me.Controls.Add(Me.FmlRbtn)
        Me.Controls.Add(Me.MaleRbtn)
        Me.Controls.Add(Me.classCombobx)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resetbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.addrTxt)
        Me.Controls.Add(Me.gunameTxt)
        Me.Controls.Add(Me.lnametxt)
        Me.Controls.Add(Me.fnametxt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fnametxt As System.Windows.Forms.TextBox
    Friend WithEvents lnametxt As System.Windows.Forms.TextBox
    Friend WithEvents gunameTxt As System.Windows.Forms.TextBox
    Friend WithEvents addrTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents resetbtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents classCombobx As System.Windows.Forms.ComboBox
    Friend WithEvents MaleRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents FmlRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents otherRbtn As System.Windows.Forms.RadioButton
    Friend WithEvents checkbx As System.Windows.Forms.CheckBox
    Friend WithEvents termsconds As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.numTxBx1 = New System.Windows.Forms.TextBox()
        Me.numTxbx2 = New System.Windows.Forms.TextBox()
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(31, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(31, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(85, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "EXCEPTION HANDLING"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Peru
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 46)
        Me.Panel1.TabIndex = 3
        '
        'numTxBx1
        '
        Me.numTxBx1.BackColor = System.Drawing.Color.Goldenrod
        Me.numTxBx1.Location = New System.Drawing.Point(121, 90)
        Me.numTxBx1.Name = "numTxBx1"
        Me.numTxBx1.Size = New System.Drawing.Size(211, 20)
        Me.numTxBx1.TabIndex = 4
        '
        'numTxbx2
        '
        Me.numTxbx2.BackColor = System.Drawing.Color.Goldenrod
        Me.numTxbx2.Location = New System.Drawing.Point(121, 129)
        Me.numTxbx2.Name = "numTxbx2"
        Me.numTxbx2.Size = New System.Drawing.Size(211, 20)
        Me.numTxbx2.TabIndex = 5
        '
        'calcBtn
        '
        Me.calcBtn.Location = New System.Drawing.Point(134, 170)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(156, 22)
        Me.calcBtn.TabIndex = 6
        Me.calcBtn.Text = "CALCULATE"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 204)
        Me.Controls.Add(Me.calcBtn)
        Me.Controls.Add(Me.numTxbx2)
        Me.Controls.Add(Me.numTxBx1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents numTxBx1 As System.Windows.Forms.TextBox
    Friend WithEvents numTxbx2 As System.Windows.Forms.TextBox
    Friend WithEvents calcBtn As System.Windows.Forms.Button

End Class

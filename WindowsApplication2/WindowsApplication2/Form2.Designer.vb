<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.terms = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.termsokbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'terms
        '
        Me.terms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terms.Location = New System.Drawing.Point(36, 63)
        Me.terms.Multiline = True
        Me.terms.Name = "terms"
        Me.terms.ReadOnly = True
        Me.terms.Size = New System.Drawing.Size(434, 335)
        Me.terms.TabIndex = 0
        Me.terms.Text = resources.GetString("terms.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TERMS AND CONDITIONS"
        '
        'termsokbtn
        '
        Me.termsokbtn.Location = New System.Drawing.Point(193, 415)
        Me.termsokbtn.Name = "termsokbtn"
        Me.termsokbtn.Size = New System.Drawing.Size(75, 23)
        Me.termsokbtn.TabIndex = 2
        Me.termsokbtn.Text = "ok"
        Me.termsokbtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 460)
        Me.Controls.Add(Me.termsokbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.terms)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents terms As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents termsokbtn As System.Windows.Forms.Button
End Class

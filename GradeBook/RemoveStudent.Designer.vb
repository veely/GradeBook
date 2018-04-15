<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveStudent
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
        Me.txtStID = New System.Windows.Forms.TextBox()
        Me.lblStID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtStID
        '
        Me.txtStID.Location = New System.Drawing.Point(107, 128)
        Me.txtStID.MaxLength = 9
        Me.txtStID.Name = "txtStID"
        Me.txtStID.Size = New System.Drawing.Size(117, 20)
        Me.txtStID.TabIndex = 0
        '
        'lblStID
        '
        Me.lblStID.AutoSize = True
        Me.lblStID.Location = New System.Drawing.Point(40, 131)
        Me.lblStID.Name = "lblStID"
        Me.lblStID.Size = New System.Drawing.Size(61, 13)
        Me.lblStID.TabIndex = 1
        Me.lblStID.Text = "Student ID:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(139, 194)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 3
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'txtInstructions
        '
        Me.txtInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.txtInstructions.Location = New System.Drawing.Point(29, 12)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.ReadOnly = True
        Me.txtInstructions.Size = New System.Drawing.Size(225, 80)
        Me.txtInstructions.TabIndex = 4
        Me.txtInstructions.Text = "Enter the Student ID of the student you want to remove from the grade book, then " & _
    "click 'Remove'.  Click 'Done' when finished."
        '
        'RemoveStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtInstructions)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblStID)
        Me.Controls.Add(Me.txtStID)
        Me.Name = "RemoveStudent"
        Me.Text = "Remove Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStID As System.Windows.Forms.TextBox
    Friend WithEvents lblStID As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents txtInstructions As System.Windows.Forms.TextBox
End Class

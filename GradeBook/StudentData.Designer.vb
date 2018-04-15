<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentData
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtGr1 = New System.Windows.Forms.TextBox()
        Me.txtGr2 = New System.Windows.Forms.TextBox()
        Me.txtGr3 = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGr1 = New System.Windows.Forms.Label()
        Me.lblGr2 = New System.Windows.Forms.Label()
        Me.lblGr3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(88, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(156, 20)
        Me.txtName.TabIndex = 0
        '
        'txtGr1
        '
        Me.txtGr1.Location = New System.Drawing.Point(88, 70)
        Me.txtGr1.MaxLength = 3
        Me.txtGr1.Name = "txtGr1"
        Me.txtGr1.Size = New System.Drawing.Size(56, 20)
        Me.txtGr1.TabIndex = 1
        '
        'txtGr2
        '
        Me.txtGr2.Location = New System.Drawing.Point(88, 101)
        Me.txtGr2.MaxLength = 3
        Me.txtGr2.Name = "txtGr2"
        Me.txtGr2.Size = New System.Drawing.Size(56, 20)
        Me.txtGr2.TabIndex = 2
        '
        'txtGr3
        '
        Me.txtGr3.Location = New System.Drawing.Point(88, 132)
        Me.txtGr3.MaxLength = 3
        Me.txtGr3.Name = "txtGr3"
        Me.txtGr3.Size = New System.Drawing.Size(56, 20)
        Me.txtGr3.TabIndex = 3
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(59, 192)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(10, 42)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(78, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Student Name:"
        '
        'lblGr1
        '
        Me.lblGr1.AutoSize = True
        Me.lblGr1.Location = New System.Drawing.Point(43, 73)
        Me.lblGr1.Name = "lblGr1"
        Me.lblGr1.Size = New System.Drawing.Size(45, 13)
        Me.lblGr1.TabIndex = 6
        Me.lblGr1.Text = "Exam 1:"
        '
        'lblGr2
        '
        Me.lblGr2.AutoSize = True
        Me.lblGr2.Location = New System.Drawing.Point(43, 104)
        Me.lblGr2.Name = "lblGr2"
        Me.lblGr2.Size = New System.Drawing.Size(45, 13)
        Me.lblGr2.TabIndex = 7
        Me.lblGr2.Text = "Exam 2:"
        '
        'lblGr3
        '
        Me.lblGr3.AutoSize = True
        Me.lblGr3.Location = New System.Drawing.Point(27, 135)
        Me.lblGr3.Name = "lblGr3"
        Me.lblGr3.Size = New System.Drawing.Size(61, 13)
        Me.lblGr3.TabIndex = 8
        Me.lblGr3.Text = "Final Exam:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(150, 192)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'StudentData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblGr3)
        Me.Controls.Add(Me.lblGr2)
        Me.Controls.Add(Me.lblGr1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtGr3)
        Me.Controls.Add(Me.txtGr2)
        Me.Controls.Add(Me.txtGr1)
        Me.Controls.Add(Me.txtName)
        Me.Name = "StudentData"
        Me.Text = "StudentData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtGr1 As System.Windows.Forms.TextBox
    Friend WithEvents txtGr2 As System.Windows.Forms.TextBox
    Friend WithEvents txtGr3 As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblGr1 As System.Windows.Forms.Label
    Friend WithEvents lblGr2 As System.Windows.Forms.Label
    Friend WithEvents lblGr3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class

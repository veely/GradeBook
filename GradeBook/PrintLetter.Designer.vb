<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintLetter
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
        Me.listLetter = New System.Windows.Forms.ListBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblStID = New System.Windows.Forms.Label()
        Me.txtStID = New System.Windows.Forms.TextBox()
        Me.txtProf = New System.Windows.Forms.TextBox()
        Me.lblProf = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'listLetter
        '
        Me.listLetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.listLetter.FormattingEnabled = True
        Me.listLetter.ItemHeight = 17
        Me.listLetter.Location = New System.Drawing.Point(20, 194)
        Me.listLetter.Name = "listLetter"
        Me.listLetter.Size = New System.Drawing.Size(496, 378)
        Me.listLetter.TabIndex = 5
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(124, 118)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse.TabIndex = 2
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnPrint.Location = New System.Drawing.Point(253, 92)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(227, 73)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(47, 121)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(71, 13)
        Me.lblCourse.TabIndex = 7
        Me.lblCourse.Text = "Course Code:"
        '
        'lblStID
        '
        Me.lblStID.AutoSize = True
        Me.lblStID.Location = New System.Drawing.Point(57, 97)
        Me.lblStID.Name = "lblStID"
        Me.lblStID.Size = New System.Drawing.Size(61, 13)
        Me.lblStID.TabIndex = 6
        Me.lblStID.Text = "Student ID:"
        '
        'txtStID
        '
        Me.txtStID.Location = New System.Drawing.Point(124, 92)
        Me.txtStID.MaxLength = 9
        Me.txtStID.Name = "txtStID"
        Me.txtStID.Size = New System.Drawing.Size(100, 20)
        Me.txtStID.TabIndex = 0
        '
        'txtProf
        '
        Me.txtProf.Location = New System.Drawing.Point(124, 144)
        Me.txtProf.Name = "txtProf"
        Me.txtProf.Size = New System.Drawing.Size(100, 20)
        Me.txtProf.TabIndex = 3
        '
        'lblProf
        '
        Me.lblProf.AutoSize = True
        Me.lblProf.Location = New System.Drawing.Point(64, 147)
        Me.lblProf.Name = "lblProf"
        Me.lblProf.Size = New System.Drawing.Size(54, 13)
        Me.lblProf.TabIndex = 8
        Me.lblProf.Text = "Professor:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(441, 587)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtInstructions
        '
        Me.txtInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtInstructions.Location = New System.Drawing.Point(20, 13)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.ReadOnly = True
        Me.txtInstructions.Size = New System.Drawing.Size(496, 50)
        Me.txtInstructions.TabIndex = 10
        Me.txtInstructions.Text = "Enter the Student ID for the student you wish to print a letter to.   The letter " & _
    "will contain their final exam grade and semester grade."
        '
        'PrintLetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 621)
        Me.Controls.Add(Me.txtInstructions)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblProf)
        Me.Controls.Add(Me.txtProf)
        Me.Controls.Add(Me.lblStID)
        Me.Controls.Add(Me.txtStID)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.listLetter)
        Me.Name = "PrintLetter"
        Me.Text = "Print Letter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listLetter As System.Windows.Forms.ListBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lblStID As System.Windows.Forms.Label
    Friend WithEvents txtStID As System.Windows.Forms.TextBox
    Friend WithEvents txtProf As System.Windows.Forms.TextBox
    Friend WithEvents lblProf As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtInstructions As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintGrades
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
        Me.listGrades = New System.Windows.Forms.ListBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listGrades
        '
        Me.listGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.listGrades.FormattingEnabled = True
        Me.listGrades.ItemHeight = 18
        Me.listGrades.Location = New System.Drawing.Point(33, 197)
        Me.listGrades.Name = "listGrades"
        Me.listGrades.Size = New System.Drawing.Size(478, 418)
        Me.listGrades.TabIndex = 5
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnPrint.Location = New System.Drawing.Point(254, 73)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(227, 73)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(110, 99)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 1
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(50, 76)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(54, 13)
        Me.lblSemester.TabIndex = 6
        Me.lblSemester.Text = "Semester:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(72, 102)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 7
        Me.lblYear.Text = "Year:"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(33, 129)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(71, 13)
        Me.lblCourse.TabIndex = 8
        Me.lblCourse.Text = "Course Code:"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(110, 126)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse.TabIndex = 2
        '
        'cmbSemester
        '
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Items.AddRange(New Object() {"Fall", "Winter", "Spring", "Summer"})
        Me.cmbSemester.Location = New System.Drawing.Point(110, 72)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(100, 21)
        Me.cmbSemester.TabIndex = 0
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(110, 153)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(100, 20)
        Me.txtSection.TabIndex = 3
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Location = New System.Drawing.Point(58, 156)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(46, 13)
        Me.lblSection.TabIndex = 9
        Me.lblSection.Text = "Section:"
        '
        'txtInstructions
        '
        Me.txtInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtInstructions.Location = New System.Drawing.Point(24, 12)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.ReadOnly = True
        Me.txtInstructions.Size = New System.Drawing.Size(496, 50)
        Me.txtInstructions.TabIndex = 11
        Me.txtInstructions.Text = "Print a list of all the students' grades."
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(461, 642)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PrintGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 677)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtInstructions)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.cmbSemester)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.listGrades)
        Me.Name = "PrintGrades"
        Me.Text = "Print Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listGrades As System.Windows.Forms.ListBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents cmbSemester As System.Windows.Forms.ComboBox
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents txtInstructions As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class

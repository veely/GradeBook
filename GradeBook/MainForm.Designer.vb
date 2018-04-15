<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.listStudents = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAvg = New System.Windows.Forms.Button()
        Me.lblStdID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnPrintGrades = New System.Windows.Forms.Button()
        Me.btnPrintLetter = New System.Windows.Forms.Button()
        Me.btnEditGrades = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listStudents
        '
        Me.listStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.listStudents.FormattingEnabled = True
        Me.listStudents.ItemHeight = 15
        Me.listStudents.Location = New System.Drawing.Point(30, 81)
        Me.listStudents.Name = "listStudents"
        Me.listStudents.Size = New System.Drawing.Size(267, 154)
        Me.listStudents.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(561, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.AddStudentsToolStripMenuItem, Me.RemoveStudentsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'AddStudentsToolStripMenuItem
        '
        Me.AddStudentsToolStripMenuItem.Enabled = False
        Me.AddStudentsToolStripMenuItem.Name = "AddStudentsToolStripMenuItem"
        Me.AddStudentsToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.AddStudentsToolStripMenuItem.Text = "Add Students"
        '
        'RemoveStudentsToolStripMenuItem
        '
        Me.RemoveStudentsToolStripMenuItem.Enabled = False
        Me.RemoveStudentsToolStripMenuItem.Name = "RemoveStudentsToolStripMenuItem"
        Me.RemoveStudentsToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.RemoveStudentsToolStripMenuItem.Text = "Remove Students"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnAvg
        '
        Me.btnAvg.Enabled = False
        Me.btnAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnAvg.Location = New System.Drawing.Point(340, 81)
        Me.btnAvg.Name = "btnAvg"
        Me.btnAvg.Size = New System.Drawing.Size(185, 32)
        Me.btnAvg.TabIndex = 3
        Me.btnAvg.Text = "Display Semester Averages"
        Me.btnAvg.UseVisualStyleBackColor = True
        '
        'lblStdID
        '
        Me.lblStdID.AutoSize = True
        Me.lblStdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lblStdID.Location = New System.Drawing.Point(30, 62)
        Me.lblStdID.Name = "lblStdID"
        Me.lblStdID.Size = New System.Drawing.Size(69, 16)
        Me.lblStdID.TabIndex = 4
        Me.lblStdID.Text = "Student ID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.lblName.Location = New System.Drawing.Point(141, 62)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(93, 16)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Student Name"
        '
        'btnPrintGrades
        '
        Me.btnPrintGrades.Enabled = False
        Me.btnPrintGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnPrintGrades.Location = New System.Drawing.Point(340, 129)
        Me.btnPrintGrades.Name = "btnPrintGrades"
        Me.btnPrintGrades.Size = New System.Drawing.Size(185, 31)
        Me.btnPrintGrades.TabIndex = 10
        Me.btnPrintGrades.Text = "Print Semester Grades"
        Me.btnPrintGrades.UseVisualStyleBackColor = True
        '
        'btnPrintLetter
        '
        Me.btnPrintLetter.Enabled = False
        Me.btnPrintLetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnPrintLetter.Location = New System.Drawing.Point(340, 176)
        Me.btnPrintLetter.Name = "btnPrintLetter"
        Me.btnPrintLetter.Size = New System.Drawing.Size(185, 32)
        Me.btnPrintLetter.TabIndex = 11
        Me.btnPrintLetter.Text = "Print Letter"
        Me.btnPrintLetter.UseVisualStyleBackColor = True
        '
        'btnEditGrades
        '
        Me.btnEditGrades.Enabled = False
        Me.btnEditGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnEditGrades.Location = New System.Drawing.Point(30, 246)
        Me.btnEditGrades.Name = "btnEditGrades"
        Me.btnEditGrades.Size = New System.Drawing.Size(267, 23)
        Me.btnEditGrades.TabIndex = 12
        Me.btnEditGrades.Text = "Add/Edit Selected Student's Grades"
        Me.btnEditGrades.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 319)
        Me.Controls.Add(Me.btnEditGrades)
        Me.Controls.Add(Me.btnPrintLetter)
        Me.Controls.Add(Me.btnPrintGrades)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblStdID)
        Me.Controls.Add(Me.btnAvg)
        Me.Controls.Add(Me.listStudents)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Grade Book"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listStudents As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAvg As System.Windows.Forms.Button
    Friend WithEvents lblStdID As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnPrintGrades As System.Windows.Forms.Button
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrintLetter As System.Windows.Forms.Button
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEditGrades As System.Windows.Forms.Button

End Class

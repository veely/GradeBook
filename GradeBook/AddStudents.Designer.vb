<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudents
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtCityState = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCityState = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtStID = New System.Windows.Forms.TextBox()
        Me.lblStID = New System.Windows.Forms.Label()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lblError1 = New System.Windows.Forms.Label()
        Me.lblError2 = New System.Windows.Forms.Label()
        Me.lblError3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(48, 215)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(48, 132)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(102, 20)
        Me.txtLast.TabIndex = 0
        '
        'txtCityState
        '
        Me.txtCityState.Location = New System.Drawing.Point(208, 178)
        Me.txtCityState.Name = "txtCityState"
        Me.txtCityState.Size = New System.Drawing.Size(154, 20)
        Me.txtCityState.TabIndex = 4
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(156, 132)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(102, 20)
        Me.txtFirst.TabIndex = 1
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(45, 116)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 4
        Me.lblLast.Text = "Last Name"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(153, 116)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(57, 13)
        Me.lblFirst.TabIndex = 5
        Me.lblFirst.Text = "First Name"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(48, 178)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(154, 20)
        Me.txtAddress.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(45, 162)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 7
        Me.lblAddress.Text = "Address"
        '
        'lblCityState
        '
        Me.lblCityState.AutoSize = True
        Me.lblCityState.Location = New System.Drawing.Point(205, 162)
        Me.lblCityState.Name = "lblCityState"
        Me.lblCityState.Size = New System.Drawing.Size(73, 13)
        Me.lblCityState.TabIndex = 8
        Me.lblCityState.Text = "City and State"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(368, 178)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(75, 20)
        Me.txtZip.TabIndex = 5
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(365, 162)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(94, 13)
        Me.lblZip.TabIndex = 10
        Me.lblZip.Text = "ZIP Code (5-digits)"
        '
        'txtStID
        '
        Me.txtStID.Location = New System.Drawing.Point(264, 132)
        Me.txtStID.MaxLength = 9
        Me.txtStID.Name = "txtStID"
        Me.txtStID.Size = New System.Drawing.Size(102, 20)
        Me.txtStID.TabIndex = 2
        '
        'lblStID
        '
        Me.lblStID.AutoSize = True
        Me.lblStID.Location = New System.Drawing.Point(261, 116)
        Me.lblStID.Name = "lblStID"
        Me.lblStID.Size = New System.Drawing.Size(100, 13)
        Me.lblStID.TabIndex = 12
        Me.lblStID.Text = "Student ID (9-digits)"
        '
        'txtInstructions
        '
        Me.txtInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtInstructions.Location = New System.Drawing.Point(48, 13)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.ReadOnly = True
        Me.txtInstructions.Size = New System.Drawing.Size(470, 76)
        Me.txtInstructions.TabIndex = 8
        Me.txtInstructions.Text = "For each student in the class, enter their information below and click 'Add'.  A " & _
    "new entry will be made each time 'Add' is clicked.  When finished, click 'Done'." & _
    ""
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(477, 277)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lblError1
        '
        Me.lblError1.AutoSize = True
        Me.lblError1.Location = New System.Drawing.Point(45, 252)
        Me.lblError1.Name = "lblError1"
        Me.lblError1.Size = New System.Drawing.Size(0, 13)
        Me.lblError1.TabIndex = 13
        '
        'lblError2
        '
        Me.lblError2.AutoSize = True
        Me.lblError2.Location = New System.Drawing.Point(45, 269)
        Me.lblError2.Name = "lblError2"
        Me.lblError2.Size = New System.Drawing.Size(0, 13)
        Me.lblError2.TabIndex = 14
        '
        'lblError3
        '
        Me.lblError3.AutoSize = True
        Me.lblError3.Location = New System.Drawing.Point(45, 286)
        Me.lblError3.Name = "lblError3"
        Me.lblError3.Size = New System.Drawing.Size(0, 13)
        Me.lblError3.TabIndex = 15
        '
        'AddStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 330)
        Me.Controls.Add(Me.lblError3)
        Me.Controls.Add(Me.lblError2)
        Me.Controls.Add(Me.lblError1)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.txtInstructions)
        Me.Controls.Add(Me.lblStID)
        Me.Controls.Add(Me.txtStID)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.lblCityState)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.txtCityState)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "AddStudents"
        Me.Text = "Add New Students"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents txtCityState As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCityState As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents txtStID As System.Windows.Forms.TextBox
    Friend WithEvents lblStID As System.Windows.Forms.Label
    Friend WithEvents txtInstructions As System.Windows.Forms.TextBox
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents lblError1 As System.Windows.Forms.Label
    Friend WithEvents lblError2 As System.Windows.Forms.Label
    Friend WithEvents lblError3 As System.Windows.Forms.Label
End Class

Imports System.Data.OleDb
Public Class MainForm
    Public bs As New BindingSource()
    Public strFileName As String = Nothing
    Public newFileName As String = Nothing
    Public selection As String
    Private Sub FirstForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Filldatatable()

        Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & strFileName
        Dim sqlstr As String = "SELECT * FROM students ORDER BY LastName"
        Dim dt As New DataTable()
        Dim da As New OleDbDataAdapter(sqlstr, constr)
        AddStudentsToolStripMenuItem.Enabled = True
        dt.Reset()
        listStudents.Items.Clear()
        da.Fill(dt)
        da.Dispose()
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                listStudents.Items.Add(CStr(dt.Rows(i)(0)) & vbTab & CStr(dt.Rows(i)(1)) & ", " & CStr(dt.Rows(i)(2)))
            Next
            btnEditGrades.Enabled = True
            btnAvg.Enabled = True
            btnPrintGrades.Enabled = True
            btnPrintLetter.Enabled = True
            RemoveStudentsToolStripMenuItem.Enabled = True
        Else
            listStudents.Items.Add("No items to show.")
            listStudents.Items.Add("Please add students to the record.")
            listStudents.Items.Add("(File -> Add Students)")
            btnEditGrades.Enabled = False
            btnAvg.Enabled = False
            btnPrintGrades.Enabled = False
            btnPrintLetter.Enabled = False
            RemoveStudentsToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openfile As OpenFileDialog = New OpenFileDialog()
        openfile.Title = "Open File"
        openfile.Filter = "Microsoft Access Database (*.accdb)|*.accdb"
        openfile.ValidateNames = True
        openfile.RestoreDirectory = True
        If openfile.ShowDialog() = DialogResult.OK Then
            strFileName = openfile.FileName
        End If
        If strFileName <> Nothing Then
            Filldatatable()
        End If
    End Sub

    Private Sub AddStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentsToolStripMenuItem.Click
        Dim AddData As New AddStudents
        AddData.Show()
    End Sub


    Private Sub btnAvg_Click(sender As Object, e As EventArgs) Handles btnAvg.Click
        Dim Avg As New Navigator
        Avg.ShowDialog()
    End Sub

    Private Sub btnPrintGrades_Click(sender As Object, e As EventArgs) Handles btnPrintGrades.Click
        Dim printgrades As New PrintGrades
        printgrades.Show()
    End Sub

    Private Sub RemoveStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveStudentsToolStripMenuItem.Click
        Dim remove As New RemoveStudent
        remove.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim newfile As SaveFileDialog = New SaveFileDialog()
        Dim extcheck As Boolean
        newfile.Title = "Create New Grade Book File"
        newfile.Filter = "Microsoft Access Database (*.accdb)|*.accdb"
        newfile.ValidateNames = True
        newfile.RestoreDirectory = True
        If newfile.ShowDialog() = DialogResult.OK Then
            newFileName = newfile.FileName
        End If
        If newFileName <> Nothing Then
            extcheck = newFileName Like "*.accdb"
            If extcheck = True Then
                My.Computer.FileSystem.CopyFile("template.dat", "" & newFileName & "", FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                strFileName = newFileName
            Else
                My.Computer.FileSystem.CopyFile("template.dat", "" & newFileName & ".accdb", FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                strFileName = newFileName & ".accdb"
            End If
            Filldatatable()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnPrintLetter_Click(sender As Object, e As EventArgs) Handles btnPrintLetter.Click
        Dim printletter As New PrintLetter
        printletter.Show()
    End Sub

    Private Sub btnEditGrades_Click(sender As Object, e As EventArgs) Handles btnEditGrades.Click
        If CStr(listStudents.SelectedItem) <> Nothing Then
            Dim temp As String = CStr(listStudents.SelectedItem)
            selection = Mid(temp, 1, 9)
            Dim sdata As New StudentData
            sdata.ShowDialog()
            Filldatatable()
        Else
            MsgBox("Please select a student on from the list to add/edit grades.", , "Add/Edit Grades")
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Grade Book" & vbNewLine & "Written by Vincent Ly", , "About Grade Book")
    End Sub
End Class

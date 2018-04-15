Imports System.Data.OleDb
Public Class PrintGrades
    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & MainForm.strFileName
    Dim dt As New DataTable()

    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        If ((e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> ControlChars.Back) Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim FirstExam, SecondExam, FinalExam As Integer
        Dim avg As Double
        Dim grade As String
        Dim sqlstr As String = "SELECT * FROM students INNER JOIN grades ON students.StID=grades.StID ORDER BY ((FirstExam + SecondExam + 2 * FinalExam)/4) DESC"
        Dim da As New OleDbDataAdapter(sqlstr, constr)
        da.Fill(dt)
        da.Dispose()
        dt.Columns.Add("SemesterGrade")
        For i As Integer = 0 To dt.Rows.Count - 1
            FirstExam = CInt(dt.Rows(i)(7))
            SecondExam = CInt(dt.Rows(i)(8))
            FinalExam = CInt(dt.Rows(i)(9))
            avg = (FirstExam + SecondExam + 2 * FinalExam) / 4
            Select Case avg
                Case 90 To 100
                    grade = "A"
                Case 80 To 89
                    grade = "B"
                Case 70 To 79
                    grade = "C"
                Case 60 To 69
                    grade = "D"
                Case Else
                    grade = "F"
            End Select
            dt.Rows(i)(10) = grade
        Next
        listGrades.Items.Clear()
        listGrades.Items.Add(txtCourse.Text.ToUpper() & txtSection.Text.ToUpper() & " " & cmbSemester.Text.ToUpper() & " SEMESTER " & txtYear.Text & " - STUDENT GRADES")
        listGrades.Items.Add("")
        listGrades.Items.Add("Last 4 digits of Student ID" & vbTab & "Final Grade")
        For i As Integer = 0 To dt.Rows.Count - 1
            listGrades.Items.Add("--------------------------------------------------------------")
            listGrades.Items.Add(Mid(CStr(dt.Rows(i)(0)), 6, 4) & vbTab & vbTab & vbTab & CStr(dt.Rows(i)(10)))
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
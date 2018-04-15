Imports System.Data.OleDb
Public Class PrintLetter
    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & MainForm.strFileName
    Dim dt As New DataTable()

    Private Sub txtStID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStID.KeyPress
        If ((e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> ControlChars.Back) Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim stid As String = txtStID.Text
        Dim coursecode As String = txtCourse.Text.ToUpper
        Dim prof As String = txtProf.Text
        Dim FirstExam, SecondExam, FinalExam As Integer
        Dim avg As Double
        Dim grade As String
        Dim sqlstr As String = "SELECT * FROM students INNER JOIN grades ON students.StID=grades.StID ORDER BY ((FirstExam + SecondExam + 2 * FinalExam)/4) DESC"
        Dim da As New OleDbDataAdapter(sqlstr, constr)
        dt.Reset()
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
        listLetter.Items.Clear()
        For i As Integer = 0 To dt.Rows.Count - 1
            If CStr(dt.Rows(i)(0)) = stid Then
                listLetter.Items.Add(CStr(dt.Rows(i)(2)) & " " & CStr(dt.Rows(i)(1)))
                listLetter.Items.Add(CStr(dt.Rows(i)(3)))
                listLetter.Items.Add(CStr(dt.Rows(i)(4)) & " " & CStr(dt.Rows(i)(5)))
                listLetter.Items.Add("")
                listLetter.Items.Add("Dear " & CStr(dt.Rows(i)(2)) & ",")
                listLetter.Items.Add("")
                listLetter.Items.Add("Your grades for " & coursecode & " are as follows:")
                listLetter.Items.Add("Final Exam: " & CStr(dt.Rows(i)(9)))
                listLetter.Items.Add("Semester Grade: " & CStr(dt.Rows(i)(10)))
                listLetter.Items.Add("")
                listLetter.Items.Add("Best Wishes for a good summer,")
                listLetter.Items.Add("Professor " & prof)
            End If
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
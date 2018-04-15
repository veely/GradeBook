Imports System.Data.OleDb
Public Class Navigator
    Private Sub Navigator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FirstExam, SecondExam, FinalExam As Integer
        Dim bs As New BindingSource()
        Dim dt As New DataTable()
        Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & MainForm.strFileName
        Dim sqlstr As String = "SELECT FirstName, LastName, FirstExam, SecondExam, FinalExam FROM students INNER JOIN grades ON students.StID=grades.StID ORDER BY LastName ASC"
        Dim da As New OleDbDataAdapter(sqlstr, constr)
        da.Fill(dt)
        da.Dispose()
        dt.Columns.Add("SemesterAverage")
        For i As Integer = 0 To dt.Rows.Count - 1
            FirstExam = CInt(dt.Rows(i)(2))
            SecondExam = CInt(dt.Rows(i)(3))
            FinalExam = CInt(dt.Rows(i)(4))
            dt.Rows(i)(5) = (FirstExam + SecondExam + 2 * FinalExam) / 4
        Next
        bs.DataSource = dt
        BindingNavigator1.BindingSource = bs
        If (dt.Rows.Count > 0) Then
            txtFirst.DataBindings.Add(New Binding("text", bs, "FirstName"))
            txtLast.DataBindings.Add(New Binding("text", bs, "LastName"))
            txtAvg.DataBindings.Add(New Binding("text", bs, "SemesterAverage"))
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
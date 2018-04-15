Imports System.Data.OleDb
Public Class StudentData
    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & MainForm.strFileName

    Private Sub txtGr1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGr1.KeyPress
        If ((e.KeyChar < "0" OrElse e.KeyChar > "9") And e.KeyChar <> ControlChars.Back) Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub txtGr2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGr2.KeyPress
        If ((e.KeyChar < "0" OrElse e.KeyChar > "9") And e.KeyChar <> ControlChars.Back) Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub txtGr3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGr3.KeyPress
        If ((e.KeyChar < "0" OrElse e.KeyChar > "9") And e.KeyChar <> ControlChars.Back) Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub StudentData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlstr As String = "SELECT * FROM students INNER JOIN grades ON students.StID=grades.StID"
        Dim dt As New DataTable()
        Dim da As New OleDbDataAdapter(sqlstr, constr)
        da.Fill(dt)
        da.Dispose()
        For i As Integer = 0 To dt.Rows.Count - 1
            If MainForm.selection = CStr(dt.Rows(i)(0)) Then
                txtName.Text = CStr(dt.Rows(i)(2)) & " " & CStr(dt.Rows(i)(1))
                txtGr1.Text = CStr(dt.Rows(i)(7))
                txtGr2.Text = CStr(dt.Rows(i)(8))
                txtGr3.Text = CStr(dt.Rows(i)(9))
            End If
        Next
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtGr1.Text <> "" And txtGr2.Text <> "" And txtGr3.Text <> "" Then
            Dim gr1, gr2, gr3 As Integer
            gr1 = CInt(txtGr1.Text)
            gr2 = CInt(txtGr2.Text)
            gr3 = CInt(txtGr3.Text)
            Dim sqlupdate As String = "UPDATE grades SET FirstExam='" & gr1 & "', SecondExam='" & gr2 & "', FinalExam='" & gr3 & "' WHERE StID='" & MainForm.selection & "'"
            Dim conobj As New OleDbConnection(constr)
            Dim da As New OleDbDataAdapter()
            conobj.Open()
            da.UpdateCommand = New OleDbCommand(sqlupdate, conobj)
            da.UpdateCommand.ExecuteNonQuery()
            conobj.Close()
            Me.Close()
        Else
            Beep()
            MsgBox("Please enter numeric values from 0 - 100.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
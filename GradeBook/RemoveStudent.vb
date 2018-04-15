Imports System.Data.OleDb
Public Class RemoveStudent
    Private Sub txtStID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStID.KeyPress
        If ((e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> ControlChars.Back) Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & MainForm.strFileName
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stid As String = txtStID.Text
        Dim da As New OleDbDataAdapter()
        Dim conobj As New OleDbConnection(constr)
        Dim delStudent As String = "DELETE * FROM students WHERE StID='" & stid & "'"
        Dim delGrades As String = "DELETE * FROM grades WHERE StID='" & stid & "'"
        conobj.Open()
        da.DeleteCommand = New OleDbCommand(delStudent, conobj)
        da.DeleteCommand.ExecuteNonQuery()
        da.DeleteCommand = New OleDbCommand(delGrades, conobj)
        conobj.Close()
        MainForm.Filldatatable()
        txtStID.Text = ""
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub
End Class
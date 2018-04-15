Imports System.Data.OleDb
Public Class AddStudents
    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & MainForm.strFileName

    Private Sub txtZip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZip.KeyPress
        If ((e.KeyChar < "0" OrElse e.KeyChar > "9") And e.KeyChar <> ControlChars.Back) Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub txtStID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStID.KeyPress
        If ((e.KeyChar < "0" OrElse e.KeyChar > "9") And e.KeyChar <> ControlChars.Back) Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtFirst.Text = Nothing Or txtLast.Text = Nothing Or txtStID.Text = Nothing Or txtAddress.Text = Nothing Or txtCityState.Text = Nothing Or txtZip.Text = Nothing Then
            lblError1.Text = "Please fill in all required fields marked with a *."
        Else
            lblError1.Text = ""
        End If
        If txtStID.Text.Length < 9 Then
            lblError2.Text = "Student ID must be 9 digits long."
        Else
            lblError2.Text = ""
        End If
        If txtZip.Text.Length < 5 Then
            lblError3.Text = "ZIP code must be 5 digits long."
        Else
            lblError3.Text = ""
        End If
        If txtFirst.Text <> Nothing And txtLast.Text <> Nothing And txtStID.Text <> Nothing And txtStID.Text.Length = 9 And txtAddress.Text <> Nothing And txtCityState.Text <> Nothing And txtZip.Text <> Nothing And txtZip.Text.Length = 5 Then
            Dim first, last, stid, address, citystate, zip As String
            first = txtFirst.Text
            last = txtLast.Text
            stid = txtStID.Text
            address = txtAddress.Text
            citystate = txtCityState.Text
            zip = txtZip.Text
            Dim sqlstudents As String = "INSERT INTO students(StID, LastName, FirstName, StreetAddress, cityAndState, zipCode) VALUES ('" & stid & "', '" & last & "', '" & first & "', '" & address & "', '" & citystate & "', '" & zip & "')"
            Dim sqlgrades As String = "INSERT INTO grades(StID) VALUES ('" & stid & "')"
            Dim conobj As New OleDbConnection(constr)
            Dim da As New OleDbDataAdapter()
            conobj.Open()
            da.InsertCommand = New OleDbCommand(sqlstudents, conobj)
            da.InsertCommand.ExecuteNonQuery()
            da.InsertCommand = New OleDbCommand(sqlgrades, conobj)
            da.InsertCommand.ExecuteNonQuery()
            conobj.Close()
            MainForm.Filldatatable()
            txtFirst.Text = ""
            txtLast.Text = ""
            txtStID.Text = ""
            txtAddress.Text = ""
            txtCityState.Text = ""
            txtZip.Text = ""
        End If
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub
End Class
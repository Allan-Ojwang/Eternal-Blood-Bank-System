Public Class ManageStaff
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim sql As String
    Dim que As String

    Private Sub loadData()
        Try
            con.Open()
            sql = "Select * from Staff"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            StaffDataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub StaffDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = StaffDataGridView.Rows(index)
        StaffIDTb.Text = selectedrow.Cells(0).Value.ToString()
        FullNameTb.Text = selectedrow.Cells(1).Value.ToString()
        NumberTb.Text = selectedrow.Cells(2).Value.ToString()
        GenderCb.Text = selectedrow.Cells(3).Value.ToString()
        UsernameTb.Text = selectedrow.Cells(4).Value.ToString()
        PasswordTb.Text = selectedrow.Cells(5).Value.ToString()
    End Sub

    Private Sub ManageStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        AdminScreen.Show()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim save_check As Integer

        que = MsgBox("Are you sure you want to add this staff's record?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Insert into Staff (Staff_ID,Name,Phone_Number,Gender,Username,Pass) values('" & StaffIDTb.Text & "','" & FullNameTb.Text & "','" & Val(NumberTb.Text) & "','" & GenderCb.Text & "','" & UsernameTb.Text & "','" & PasswordTb.Text & "')"
                cmd.Connection = con
                cmd.CommandText = sql

                save_check = cmd.ExecuteNonQuery

                If save_check > 0 Then
                    MsgBox("You have successfully saved the information.")
                Else
                    MsgBox("Information has not been saved.")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                StaffDataGridView.DataSource.Clear()
                loadData()
                StaffIDTb.Text = ""
                FullNameTb.Text = ""
                UsernameTb.Text = ""
                NumberTb.Text = ""
                GenderCb.Text = ""
                PasswordTb.Text = ""
            End Try
        End If
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim save_check2 As Integer

        que = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Update Staff set Name = '" & FullNameTb.Text & "',Phone_Number = '" & Val(NumberTb.Text) & "', Gender = '" & GenderCb.Text & "',Username = '" & UsernameTb.Text & "',Pass = '" & PasswordTb.Text & "'  where Staff_ID = '" & StaffIDTb.Text & "'"
                cmd.Connection = con
                cmd.CommandText = sql

                save_check2 = cmd.ExecuteNonQuery

                If save_check2 > 0 Then
                    MsgBox("You have successfully updated the information.")
                Else
                    MsgBox("Information has not been updated.")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                StaffDataGridView.DataSource.Clear()
                loadData()
                StaffIDTb.Text = ""
                FullNameTb.Text = ""
                UsernameTb.Text = ""
                NumberTb.Text = ""
                GenderCb.Text = ""
                PasswordTb.Text = ""
            End Try
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim save_check3 As Integer

        que = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Delete from Staff where Staff_ID = '" & StaffIDTb.Text & "'"
                cmd.Connection = con
                cmd.CommandText = sql

                save_check3 = cmd.ExecuteNonQuery

                If save_check3 > 0 Then
                    MsgBox("You have successfully deleted the information.")
                Else
                    MsgBox("Information has not been deleted.")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                StaffDataGridView.DataSource.Clear()
                loadData()
                StaffIDTb.Text = ""
                FullNameTb.Text = ""
                UsernameTb.Text = ""
                NumberTb.Text = ""
                GenderCb.Text = ""
                PasswordTb.Text = ""
            End Try
        End If
    End Sub
End Class
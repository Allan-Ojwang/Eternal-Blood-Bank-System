Imports System.Security.Cryptography

Public Class ManageUser
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim sql As String
    Dim que As String

    Private Sub UserDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = UserDataGridView.Rows(index)
        IDTb.Text = selectedrow.Cells(0).Value.ToString()
        FirstNameTb.Text = selectedrow.Cells(1).Value.ToString()
        LastNameTb.Text = selectedrow.Cells(2).Value.ToString()
        EmailTb.Text = selectedrow.Cells(3).Value.ToString()
        NumberTb.Text = selectedrow.Cells(4).Value.ToString()
        DOB.Text = selectedrow.Cells(5).Value.ToString()
        GenderCb.Text = selectedrow.Cells(6).Value.ToString()
        UsernameTb.Text = selectedrow.Cells(7).Value.ToString()
        PaswordTb.Text = selectedrow.Cells(8).Value.ToString()
    End Sub
    Private Sub loadData()
        Try
            con.Open()
            sql = "Select * from Users"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            UserDataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        AdminScreen.Show()
    End Sub



    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim save_check3 As Integer

        que = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Delete from Users where ID = '" & IDTb.Text & "'"
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
                UserDataGridView.DataSource.Clear()
                loadData()
                IDTb.Text = ""
                FirstNameTb.Text = ""
                LastNameTb.Text = ""
                EmailTb.Text = ""
                DOB.Text = ""
                UsernameTb.Text = ""
                NumberTb.Text = ""
                GenderCb.Text = ""
                PaswordTb.Text = ""
            End Try
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim save_check2 As Integer

        que = MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Update Users set First_Name = '" & FirstNameTb.Text & "',Last_Name = '" & LastNameTb.Text & "',Email = '" & EmailTb.Text & "',Phone_Number = '" & Val(NumberTb.Text) & "', Date_Of_Birth = '" & DOB.Value & "' ,Gender = '" & GenderCb.Text & "',Username = '" & UsernameTb.Text & "',Pass = '" & PaswordTb.Text & "'  where ID = '" & IDTb.Text & "'"
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
                UserDataGridView.DataSource.Clear()
                loadData()
                IDTb.Text = ""
                FirstNameTb.Text = ""
                LastNameTb.Text = ""
                EmailTb.Text = ""
                DOB.Text = ""
                UsernameTb.Text = ""
                NumberTb.Text = ""
                GenderCb.Text = ""
                PaswordTb.Text = ""
            End Try
        End If
    End Sub



End Class
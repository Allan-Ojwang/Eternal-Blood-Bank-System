Imports System.Security.Cryptography

Public Class EventSetterScreen
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String

    Public AppID As Integer = 0
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim save_check As Integer
        If AppID = 0 Then
            If LocationTb.Text = "" Or ActivityTb.Text = "" Then
                MessageBox.Show("Please enter all the fields provided")
            Else
                Try
                    con.Open()
                    sql = "Insert into Schedule (Location,Reserved_Date,Activity) values('" & LocationTb.Text & "','" & DR.Value & "','" & ActivityTb.Text & "')"
                    cmd.Connection = con
                    cmd.CommandText = sql
                    save_check = cmd.ExecuteNonQuery

                    If save_check > 0 Then
                        MsgBox("Event was added successfully.")

                    Else
                        MsgBox("Event was not added.")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            End If
        Else
            Try
                con.Open()
                Dim sql2 As String = $"Update Schedule set Reserved_Date = '{DR.Value.ToShortDateString()}', Location = '{LocationTb.Text}',Activity='{ActivityTb.Text}' Where ID = {AppID}"
                Dim cmd2 As New OleDb.OleDbCommand
                cmd2.Connection = con
                cmd2.CommandText = sql2
                Dim save_check2 As Integer

                If save_check2 > 0 Then
                    MsgBox("Event was updated successfully.")

                Else
                    MsgBox("Event was not updated.")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try

        End If


    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        SaveButton.Visible = True
        LocationTb.Enabled = True
        ActivityTb.Enabled = True
    End Sub

End Class
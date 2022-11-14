Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SignUpScreen

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim id As String

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Application.Exit()
    End Sub

    Private Sub SigninBtn_Click(sender As Object, e As EventArgs) Handles SigninBtn.Click
        Me.Hide()
        LogInScreen.Show()
    End Sub
    Private Sub AutoID()
        con.Open()
        Dim cmd3 As OleDbCommand = New OleDbCommand("Select count(ID) from Users", con)
        Dim i As Integer
        i = Convert.ToInt32(cmd3.ExecuteScalar())
        con.Close()
        i += 1
        id = "USER-" + i.ToString()
    End Sub
    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        Dim save_check As Integer
        AutoID()
        If FirstNameTb.Text = "" Or LastNameTb.Text = " " Or EmailTb.Text = "" Or NumberTb.Text = "" Or GenderCb.Text = "" Or UsernameTb.Text = "" Or PasswordTb.Text = "" Then
            MessageBox.Show("Please enter all the fields provided")
        Else
            con.Open()
            Dim cmd2 As OleDbCommand = New OleDbCommand("Select * From Users Where Username='" & UsernameTb.Text & "' ", con)
            Dim dr As OleDbDataReader = cmd2.ExecuteReader
            If dr.Read = True Then
                MessageBox.Show("Username all ready exists please enter a new username")
            Else
                Try

                    sql = "Insert into Users (ID,First_Name,Last_Name,Email,Phone_Number,Date_Of_Birth,Gender,Username,Pass) values('" & id & "','" & FirstNameTb.Text & "','" & LastNameTb.Text & "','" & EmailTb.Text & "'," & Val(NumberTb.Text) & ",'" & DOB.Value & "','" & GenderCb.Text & "','" & UsernameTb.Text & "','" & PasswordTb.Text & "')"
                    cmd.Connection = con
                    cmd.CommandText = sql

                    save_check = cmd.ExecuteNonQuery

                    If save_check > 0 Then
                        MsgBox("Your have created an account successfully.")
                        Me.Hide()
                        LogInScreen.Show()
                    Else
                        MsgBox("Your request has not been submitted.")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            End If
            con.Close()
        End If
        FirstNameTb.Text = ""
        LastNameTb.Text = ""
        EmailTb.Text = ""
        NumberTb.Text = ""
        GenderCb.Text = ""
        UsernameTb.Text = ""
        PasswordTb.Text = ""
    End Sub
End Class
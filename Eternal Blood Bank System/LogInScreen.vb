Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Eternal_Blood_Bank_System.AdminScreen
Public Class LogInScreen
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim user As String = ""
    Dim pass As String = ""
    Dim user2 As String = ""
    Dim pass2 As String = ""
    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        Me.Hide()
        SignUpScreen.Show()
    End Sub

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click

        Try
            con.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("Select * From Staff Where Username='" & UsernameTb.Text & "' and Pass ='" & PasswordTb.Text & "'", con)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            Dim cmd2 As OleDbCommand = New OleDbCommand("Select * From Users Where Username='" & UsernameTb.Text & "' and Pass ='" & PasswordTb.Text & "'", con)
            Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

            If UsernameTb.Text = "" Or PasswordTb.Text = "" Then
                If UsernameTb.Text = "" And PasswordTb.Text = "" Then
                    MessageBox.Show("Please enter the username and password")
                ElseIf UsernameTb.Text = "" Then
                    MessageBox.Show("Please enter a username")
                ElseIf PasswordTb.Text = "" Then
                    MessageBox.Show("Please enter a password")
                End If

            Else
                If UsernameTb.Text = "admin" And PasswordTb.Text = "001admin" Then
                    'Admin
                    Me.Hide()
                    AdminScreen.Show()
                    AdminScreen.AddToolStripSplitButton.Visible = False
                ElseIf dr.Read = True Then
                    'staff user
                    user = dr("Username")
                    pass = dr("Pass")
                    MessageBox.Show("Login Successfully as a staff")
                    Me.Hide()
                    AdminScreen.Show()
                    AdminScreen.ReportsToolStripSplitButton.Visible = False
                    AdminScreen.ManageToolStripSplitButton.Visible = False


                ElseIf dr2.Read = True Then
                    'normal user
                    user2 = dr2("Username")
                    pass2 = dr2("Pass")
                    MessageBox.Show("Login Successfully as normal user")
                    Me.Hide()
                    UserScreen.Show()
                Else
                    'wrong username or password
                    MessageBox.Show("Invalid username or password")
                End If
                UsernameTb.Text = ""
                PasswordTb.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Application.Exit()
    End Sub

End Class
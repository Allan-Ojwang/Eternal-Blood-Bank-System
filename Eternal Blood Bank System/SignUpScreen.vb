Public Class SignUpScreen
    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        Me.Hide()
        LogInScreen.Show()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Application.Exit()
    End Sub

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click

    End Sub
End Class
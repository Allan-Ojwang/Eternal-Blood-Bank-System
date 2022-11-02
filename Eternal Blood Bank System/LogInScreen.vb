Public Class LogInScreen

    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        Me.Hide()
        SignUpScreen.Show()
    End Sub

    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Application.Exit()
    End Sub
End Class
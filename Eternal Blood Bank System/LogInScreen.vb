Public Class LogInScreen

    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        Me.Hide()
        SignUpScreen.Show()
    End Sub
End Class
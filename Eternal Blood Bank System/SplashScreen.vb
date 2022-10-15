Public Class SplashScreen
    Dim valueP As Integer = 0
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        SplashScreenBar.Value = valueP
        If (SplashScreenBar.Value = 100) Then
            Timer1.Stop()
            LogInScreen.Show()

        Else
            valueP += 1
            SplashScreenBar.Value = valueP
        End If
        If (SplashScreenBar.Value = 0) Then
            LoadTxt.Text = "Please Wait ."
        ElseIf (SplashScreenBar.Value = 10) Then
            LoadTxt.Text = "Please Wait .."
        ElseIf (SplashScreenBar.Value = 20) Then
            LoadTxt.Text = "Please Wait ..."
        ElseIf (SplashScreenBar.Value = 30) Then
            LoadTxt.Text = "Loading ."
        ElseIf (SplashScreenBar.Value = 40) Then
            LoadTxt.Text = "Loading .."
        ElseIf (SplashScreenBar.Value = 50) Then
            LoadTxt.Text = "Loading ..."
        ElseIf (SplashScreenBar.Value = 60) Then
            LoadTxt.Text = "Almost There ."
        ElseIf (SplashScreenBar.Value = 70) Then
            LoadTxt.Text = "Almost There .."
        ElseIf (SplashScreenBar.Value = 80) Then
            LoadTxt.Text = "Almost There ..."
        ElseIf (SplashScreenBar.Value >= 90) Then
            LoadTxt.Text = "Welcome"
        End If
    End Sub

End Class

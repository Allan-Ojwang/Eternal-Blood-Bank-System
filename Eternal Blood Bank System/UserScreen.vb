Public Class UserScreen
    Private Sub closeToolStripButton_Click(sender As Object, e As EventArgs) Handles closeToolStripButton.Click
        Application.Exit()
    End Sub

    Private Sub donateToolStripButton_Click(sender As Object, e As EventArgs) Handles donateToolStripButton.Click
        Me.Hide()
        BookDonationScreen.Show()
    End Sub

    Private Sub requestToolStripButton_Click(sender As Object, e As EventArgs) Handles requestToolStripButton.Click
        Me.Hide()
        RequestForBloodScreen.Show()
    End Sub

    Private Sub scheduleToolStripButton_Click(sender As Object, e As EventArgs) Handles scheduleToolStripButton.Click
        Me.Hide()
        DonationScheduleScreen.Show()
    End Sub
End Class
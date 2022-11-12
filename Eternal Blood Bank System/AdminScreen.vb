Public Class AdminScreen

    Private Sub CloseAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAppToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BloodDonationAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BloodDonationAppointmentToolStripMenuItem.Click
        Me.Hide()
        DonationAppointmentApprovalScreen.Show()
    End Sub

    Private Sub BloodRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BloodRequestToolStripMenuItem.Click
        Me.Hide()
        BloodRequestApprovalScreen.Show()
    End Sub

    Private Sub ScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleToolStripMenuItem.Click
        Me.Hide()
        ScheduleSetterScreen.Show()
    End Sub
End Class
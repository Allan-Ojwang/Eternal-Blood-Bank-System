Public Class AdminScreen

    Private Sub CloseAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAppToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BloodDonationAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BloodDonationAppointmentToolStripMenuItem.Click
        Me.Hide()
        DonationAppointmentApprovalScreen.Show()
    End Sub
End Class
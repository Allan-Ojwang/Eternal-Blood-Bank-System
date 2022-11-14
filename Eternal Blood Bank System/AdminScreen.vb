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

    Private Sub AllReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllReportsToolStripMenuItem.Click
        Me.Hide()
        Reports.Show()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        Me.Hide()
        ManageUser.Show()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffToolStripMenuItem.Click
        Me.Hide()
        ManageStaff.Show()
    End Sub

    Private Sub ReportsToolStripSplitButton_DropDownOpened(sender As Object, e As EventArgs) Handles ReportsToolStripSplitButton.DropDownOpened
        ReportsToolStripSplitButton.ForeColor = Color.Black
        ReportsToolStripSplitButton.Image = My.Resources.records_dark
    End Sub

    Private Sub ReportsToolStripSplitButton_DropDownClosed(sender As Object, e As EventArgs) Handles ReportsToolStripSplitButton.DropDownClosed
        ReportsToolStripSplitButton.ForeColor = Color.White
        ReportsToolStripSplitButton.Image = My.Resources.records
    End Sub

    Private Sub AcceptToolStripSplitButton_DropDownOpened(sender As Object, e As EventArgs) Handles AcceptToolStripSplitButton.DropDownOpened
        AcceptToolStripSplitButton.ForeColor = Color.Black
        AcceptToolStripSplitButton.Image = My.Resources.accept_dark
    End Sub

    Private Sub AcceptToolStripSplitButton_DropDownClosed(sender As Object, e As EventArgs) Handles AcceptToolStripSplitButton.DropDownClosed
        AcceptToolStripSplitButton.ForeColor = Color.White
        AcceptToolStripSplitButton.Image = My.Resources.accept
    End Sub

    Private Sub ManageToolStripSplitButton_DropDownOpened(sender As Object, e As EventArgs) Handles ManageToolStripSplitButton.DropDownOpened
        ManageToolStripSplitButton.ForeColor = Color.Black
        ManageToolStripSplitButton.Image = My.Resources.manage_dark
    End Sub

    Private Sub ManageToolStripSplitButton_DropDownClosed(sender As Object, e As EventArgs) Handles ManageToolStripSplitButton.DropDownClosed
        ManageToolStripSplitButton.ForeColor = Color.White
        ManageToolStripSplitButton.Image = My.Resources.manage
    End Sub
    Private Sub SetToolStripSplitButton_DropDownOpened(sender As Object, e As EventArgs) Handles SetToolStripSplitButton.DropDownOpened
        SetToolStripSplitButton.ForeColor = Color.Black
        SetToolStripSplitButton.Image = My.Resources.set_dark
    End Sub

    Private Sub SetToolStripSplitButton_DropDownClosed(sender As Object, e As EventArgs) Handles SetToolStripSplitButton.DropDownClosed
        SetToolStripSplitButton.ForeColor = Color.White
        SetToolStripSplitButton.Image = My.Resources._Set
    End Sub
    Private Sub ExitToolStripSplitButton_DropDownOpened(sender As Object, e As EventArgs) Handles ExitToolStripSplitButton.DropDownOpened
        ExitToolStripSplitButton.ForeColor = Color.Black
        ExitToolStripSplitButton.Image = My.Resources.exit_dark
    End Sub

    Private Sub ExitToolStripSplitButton_DropDownClosed(sender As Object, e As EventArgs) Handles ExitToolStripSplitButton.DropDownClosed
        ExitToolStripSplitButton.ForeColor = Color.White
        ExitToolStripSplitButton.Image = My.Resources._exit
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        LogInScreen.Show()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Me.Hide()
        DonationScreen.Show()
    End Sub

    Private Sub AddToolStripSplitButton_DropDownOpened(sender As Object, e As EventArgs) Handles AddToolStripSplitButton.DropDownOpened
        AddToolStripSplitButton.ForeColor = Color.Black
        AddToolStripSplitButton.Image = My.Resources.add_dark
    End Sub

    Private Sub AddToolStripSplitButton_DropDownClosed(sender As Object, e As EventArgs) Handles AddToolStripSplitButton.DropDownClosed
        AddToolStripSplitButton.ForeColor = Color.White
        AddToolStripSplitButton.Image = My.Resources.add
    End Sub
End Class
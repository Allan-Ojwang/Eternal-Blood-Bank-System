Public Class DonationAppointmentApprovalScreen
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd, cmd2 As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim sql, sql2, ID As String
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        AdminScreen.Show()
    End Sub
    Private Sub loadData()
        Try
            con.Open()
            sql = "Select * from Appointment"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DonationDataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub DonationAppointmentApprovalScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub ApproveButton_Click(sender As Object, e As EventArgs) Handles ApproveButton.Click
        Dim save_check As Integer
        Dim que As String
        que = MsgBox("Are you sure you want to approve this appointment?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Update Appointment set Approval = 'Approved' Where ID= '" & ID & "' "
                cmd.Connection = con
                cmd.CommandText = sql

                save_check = cmd.ExecuteNonQuery

                If save_check > 0 Then
                    MsgBox("You have successfully approved the appointment.")
                Else
                    MsgBox("Information has not been saved.")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                DonationDataGridView.DataSource.Clear()
                DonationDataGridView.ClearSelection()
                loadData()
                ApproveButton.Enabled = False
                DisapproveButton.Enabled = False
            End Try
        End If
    End Sub

    Private Sub DisapproveButton_Click(sender As Object, e As EventArgs) Handles DisapproveButton.Click
        Dim save_check As Integer
        Dim que As String
        que = MsgBox("Are you sure you want to disapprove this request?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Update Appointment set Approval = 'Disapproved' Where ID= '" & ID & "' "
                cmd.Connection = con
                cmd.CommandText = sql

                save_check = cmd.ExecuteNonQuery

                If save_check > 0 Then
                    MsgBox("You have successfully disapproved the request.")
                Else
                    MsgBox("Information has not been saved.")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                DonationDataGridView.DataSource.Clear()
                DonationDataGridView.ClearSelection()
                loadData()
                ApproveButton.Enabled = False
                DisapproveButton.Enabled = False
            End Try
        End If
    End Sub

    Private Sub DonationDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DonationDataGridView.CellClick
        ApproveButton.Enabled = True
        DisapproveButton.Enabled = True
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DonationDataGridView.Rows(index)
        ID = selectedrow.Cells(0).Value.ToString()
    End Sub
End Class
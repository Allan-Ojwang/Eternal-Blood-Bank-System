Public Class DonationAppointmentApprovalScreen
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim sql As String
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
End Class
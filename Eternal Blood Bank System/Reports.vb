Public Class Reports
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim da, da2, da3 As New OleDb.OleDbDataAdapter
    Dim dt, dt2, dt3 As New DataTable
    Dim sql As String

    Private Sub AppointmentReport_Enter(sender As Object, e As EventArgs) Handles AppointmentReport.Enter
        Try
            con.Open()
            sql = "Select * from Appointment"
            cmd.Connection = con
            cmd.CommandText = sql
            da3.SelectCommand = cmd
            da3.Fill(dt3)
            AppointmentReportDataGridView.DataSource = dt3
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BloodRequest_Enter(sender As Object, e As EventArgs) Handles BloodRequest.Enter
        Try
            con.Open()
            sql = "Select * from Request"
            cmd.Connection = con
            cmd.CommandText = sql
            da2.SelectCommand = cmd
            da2.Fill(dt2)
            RequestReportDataGridView.DataSource = dt2
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.Open()
            sql = "Select * from Donation"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DonationReportDataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub RequestPrintButton_Click(sender As Object, e As EventArgs) Handles RequestPrintButton.Click
        RequestDoc.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = RequestDoc
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub AppointmentPrintButton_Click(sender As Object, e As EventArgs) Handles AppointmentPrintButton.Click
        AppointmentDoc.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = AppointmentDoc
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        AdminScreen.Show()
    End Sub

    Private Sub DonationPrintButton_Click(sender As Object, e As EventArgs) Handles DonationPrintButton.Click
        DonationDoc.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = DonationDoc
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub DonationDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles DonationDoc.PrintPage
        Dim bm As New Bitmap(Me.DonationReportDataGridView.Width, Me.DonationReportDataGridView.Height)
        DonationReportDataGridView.DrawToBitmap(bm, New Rectangle(0, 0, Me.DonationReportDataGridView.Width, Me.DonationReportDataGridView.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub RequestDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles RequestDoc.PrintPage
        Dim bm As New Bitmap(Me.RequestReportDataGridView.Width, Me.RequestReportDataGridView.Height)
        RequestReportDataGridView.DrawToBitmap(bm, New Rectangle(20, 20, Me.RequestReportDataGridView.Width, Me.RequestReportDataGridView.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub AppointmentDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles AppointmentDoc.PrintPage
        Dim bm As New Bitmap(Me.AppointmentReportDataGridView.Width, Me.AppointmentReportDataGridView.Height)
        AppointmentReportDataGridView.DrawToBitmap(bm, New Rectangle(20, 20, Me.AppointmentReportDataGridView.Width, Me.AppointmentReportDataGridView.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

End Class
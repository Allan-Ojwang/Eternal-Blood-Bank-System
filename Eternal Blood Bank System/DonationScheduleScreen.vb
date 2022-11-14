Imports System.Data.OleDb
Public Class DonationScheduleScreen
    Private listF1Day As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Private Sub DonationScheduleScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDayPanel(37)
        DisplayCurrentDate()
    End Sub
    Private Sub ShowAppointmentDetails(sender As Object, e As EventArgs)
        Dim appId As Integer = CType(sender, LinkLabel).Tag
        Dim sql As String = $"Select * From Schedule Where ID = {appId}"
        Dim dt As DataTable = QueryForCal(sql)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            With EventSetterScreen
                .SaveButton.Visible = False
                .LocationTb.Enabled = False
                .ActivityTb.Enabled = False
                .AppID = appId
                .LocationTb.Text = row("Location")
                .DR.Value = row("Reserved_Date")
                .ActivityTb.Text = row("Activity")
                .ShowDialog()
            End With
            DisplayCurrentDate()

        End If
    End Sub
    Private Sub AddApointmentToF1Day(ByVal startDayAtF1Number As Integer)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)

        Dim sql As String = $"Select * From Schedule Where Reserved_Date between #{startDate.ToShortDateString()}# and #{endDate.ToShortDateString()}#"
        Dim dt As DataTable = QueryForCal(sql)

        For Each row As DataRow In dt.Rows
            Dim appDay As DateTime = Date.Parse(row("Reserved_Date"))
            Dim link As New LinkLabel
            link.Tag = row("ID")
            link.Name = $"link{row("ID")}"
            link.AutoSize = False
            link.Size = New Size(144, 23)
            link.Text = row("Activity")
            AddHandler link.Click, AddressOf ShowAppointmentDetails
            listF1Day((appDay.Day - 1) + (startDayAtF1Number - 1)).Controls.Add(link)

        Next
    End Sub

    Public Function QueryForCal(ByVal sql As String) As DataTable
        Dim da As New OleDbDataAdapter(sql, con)
        Dim ds As New DataSet
        da.Fill(ds, "result")
        Return ds.Tables("result")
    End Function
    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAndYear.Text = currentDate.ToString("MMMM,yyyy")
        Dim firstDayAtF1Number As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToF1Day(firstDayAtF1Number, totalDay)
        AddApointmentToF1Day(firstDayAtF1Number)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub
    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        f1Days.Controls.Clear()
        listF1Day.Clear()
        For i As Integer = 1 To totalDays
            Dim f1 As New FlowLayoutPanel
            f1.Name = $"f1Day{i}"
            f1.Size = New Size(151, 120)
            f1.BackColor = Color.White
            f1.BorderStyle = BorderStyle.FixedSingle
            f1Days.Controls.Add(f1)
            listF1Day.Add(f1)
        Next
    End Sub

    Private Sub AddLabelDayToF1Day(ByVal startDayAtF1Number As Integer, ByVal totalDaysInMonth As Integer)

        For Each f1 As FlowLayoutPanel In listF1Day
            f1.Controls.Clear()
        Next
        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Font = New Font("Microsoft Sans Serif", 12)
            lbl.Size = New Size(144, 23)
            lbl.Text = i
            listF1Day((i - 1) + (startDayAtF1Number) - 1).Controls.Add(lbl)
        Next
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        UserScreen.Show()
    End Sub

    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        PrevMonth()
    End Sub

    Private Sub TodayButton_Click(sender As Object, e As EventArgs) Handles TodayButton.Click
        Today()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        NextMonth()
    End Sub
End Class
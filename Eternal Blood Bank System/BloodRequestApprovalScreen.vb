Imports System.Data.OleDb


Public Class BloodRequestApprovalScreen

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim sql As String
    Dim ID As String

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        AdminScreen.Show()
    End Sub
    Private Sub loadData()
        Try
            con.Open()
            sql = "Select * from Request"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            RequestDataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub BloodRequestApprovalScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Private Sub RequestDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RequestDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = RequestDataGridView.Rows(index)
        ID = selectedrow.Cells(0).Value.ToString()
    End Sub

    Private Sub ApproveButton_Click(sender As Object, e As EventArgs) Handles ApproveButton.Click
        Dim save_check As Integer
        Dim que As String
        que = MsgBox("Are you sure you want to approve this request?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Update Request set Approval = 'Approved' Where ID= '" & ID & "' "
                cmd.Connection = con
                cmd.CommandText = sql

                save_check = cmd.ExecuteNonQuery

                If save_check > 0 Then
                    MsgBox("You have successfully approved the request.")
                Else
                    MsgBox("Information has not been saved.")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                RequestDataGridView.DataSource.Clear()
                loadData()
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
                sql = "Update Request set Approval = 'Disapproved' Where ID= '" & ID & "' "
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
                RequestDataGridView.DataSource.Clear()
                loadData()
            End Try
        End If
    End Sub
End Class
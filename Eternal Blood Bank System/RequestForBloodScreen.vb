Imports System.Data.OleDb
Public Class RequestForBloodScreen

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim dr As OleDbDataReader
    Dim sql As String
    Dim que As String
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        UserScreen.Show()
    End Sub

    Private Sub RequestButton_Click(sender As Object, e As EventArgs) Handles RequestButton.Click
        Dim save_check As Integer

        que = MsgBox("Are you sure you want to request for blood?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Insert into Request (First_Name,Last_Name,Phone_Number,Gender,Blood_Type,Blood_Quantity) values('" & FirstNameTb.Text & "','" & LastNameTb.Text & "'," & Val(NumberTb.Text) & ",'" & GenderCB.Text & "','" & BloodTypeCB.Text & "'," & Val(BloodNeededTB.Text) & ")"
                cmd.Connection = con
                cmd.CommandText = sql

                save_check = cmd.ExecuteNonQuery

                If save_check > 0 Then
                    MsgBox("Your request has been submitted successfully. We will notify you when the request is accepted.")
                Else
                    MsgBox("Your request has not been submitted.")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
        FirstNameTb.Text = ""
        LastNameTb.Text = ""
        NumberTb.Text = ""
        GenderCB.Text = ""
        BloodTypeCB.Text = ""
        BloodNeededTB.Text = ""
    End Sub
End Class
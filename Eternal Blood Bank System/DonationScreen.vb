Imports System.Security.Cryptography

Public Class DonationScreen
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim que As String

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        AdminScreen.Show()
    End Sub

    Private Sub SaveButton_Click_1(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim save_check As Integer

        que = MsgBox("Are you sure you want to save this information?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Insert into Donation (First_Name,Last_Name,Phone_Number,Gender,Blood_Type,Amount_Donated) values('" & FirstNameTb.Text & "','" & LastNameTb.Text & "','" & Val(NumberTb.Text) & "','" & GenderCb.Text & "','" & BloodTypeCB.Text & "','" & Val(BloodDonatedTB.Text) & "')"
                cmd.Connection = con
                cmd.CommandText = sql

                save_check = cmd.ExecuteNonQuery

                If save_check > 0 Then
                    MsgBox("You have successfully saved the information.")
                Else
                    MsgBox("Information has not been saved.")
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
        GenderCb.Text = ""
        BloodTypeCB.Text = ""
        BloodDonatedTB.Text = ""
    End Sub
End Class
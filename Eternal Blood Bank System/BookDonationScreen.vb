﻿Imports System.Data.OleDb
Public Class BookDonationScreen

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ojwang\Desktop\Project\Eternal Blood Bank System\Eternal Blood Bank System\Eternal.mdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim que As String
    Dim id As String
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Hide()
        UserScreen.Show()
    End Sub

    Private Sub AutoID()
        con.Open()
        Dim cmd3 As OleDbCommand = New OleDbCommand("Select count(ID) from Appointment", con)
        Dim i As Integer
        i = Convert.ToInt32(cmd3.ExecuteScalar())
        con.Close()
        i += 1
        id = i.ToString()
    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        Dim save_check As Integer
        AutoID()
        que = MsgBox("Are you sure you want to request for blood?", vbYesNo + vbQuestion, "Attention!!!")
        If que = vbYes Then
            Try
                con.Open()
                sql = "Insert into Appointment (ID,First_Name,Last_Name,Phone_Number,Date_Of_Appointment) values('" & id & "','" & FirstNameTb.Text & "','" & LastNameTb.Text & "','" & Val(NumberTb.Text) & "','" & DOA.Value & "')"
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
    End Sub
End Class
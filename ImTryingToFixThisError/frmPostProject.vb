Imports System.Data.OleDb

Public Class frmPostProject
    Private Sub btnProjectFeed_Click(sender As Object, e As EventArgs) Handles btnProjectFeed.Click
        Dim postForm As New frmProjectFeed() ' Create new instance
        postForm.Show()                     ' Show as separate window
    End Sub

    Private Sub frmPostProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userEmail As String = SessionData.LoggedInEmail
        Dim userName As String = ""

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\source\repos\ImTryingToFixThisError\ImTryingToFixThisError\bin\Debug\InnoBridgeDatabase.accdb")

        Try
            con.Open()
            Dim query As String = "SELECT userFullName FROM SignupLoginPage WHERE userEmail = ?"
            Dim cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("?", userEmail)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                userName = reader("userFullName").ToString()
            End If
            reader.Close()

            lblWelcomeTitle.Text = "Hello " & userName & ", What are you up to?"

        Catch ex As Exception
            MessageBox.Show("Error loading user name: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnPostProject_Click(sender As Object, e As EventArgs) Handles btnPostProject.Click
        Dim postForm As New frmProjectFeed() ' Create new instance
        postForm.Show()                     ' Show as separate window
    End Sub
End Class
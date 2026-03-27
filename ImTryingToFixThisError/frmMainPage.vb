Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class frmMainPage

    Private Sub btnYourProject_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Your Project button clicked!")
    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click
        lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy")
    End Sub

    Private Sub lblWelcomeTitle_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub frmMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy")

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

            lblWelcome.Text = "Welcome To InnoBridge, " & userName & "!"

        Catch ex As Exception
            MessageBox.Show("Error loading user name: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnBrowseProblems_Click(sender As Object, e As EventArgs)
        'frmMainMenu.LoadFormIntoPanel(New frmBrowseProblems())
    End Sub

    Private Sub btnProjectFeed_Click(sender As Object, e As EventArgs)
        'page.Show() ' finally, show it inside
        Dim page As New frmProjectFeed() ' Create an instance 

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel
        Me.Hide()
        page.Show()
    End Sub
End Class
Imports System.Data.OleDb
Public Class frmProfilePage
    Private Sub frmProfilePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserProfile()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New frmLoginPage() ' Show the login form 

        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to logout?", "Input Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            frmMainMenu.Close() ' Close the main menu form
            Me.Close() ' Close the profile page form
            login.Show() ' Opens the login page 
        End If
    End Sub

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to edit your profile?", "Input Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim editForm As New frmProfileEditPage() ' Declaring variable and insert it into another form
            editForm.ShowDialog() ' This pauses until the edit form is closed
            LoadUserProfile() ' Reload updated info
        End If
    End Sub

    Public Sub LoadUserProfile()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\source\repos\ImTryingToFixThisError\ImTryingToFixThisError\bin\Debug\InnoBridgeDatabase.accdb")
        Dim cmd As New OleDbCommand("SELECT * FROM SignupLoginPage WHERE userEmail = ?", con)
        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = LoggedInEmail ' This variable should be globally stored at login

        con.Open()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            ' Username fallback logic
            Dim username = reader("Username").ToString().Trim()
            Dim fullName = reader("userFullName").ToString().Trim() ' Watch your spelling!

            lblUsername.Text = If(String.IsNullOrWhiteSpace(username), fullName, username)

            ' Update labels
            lblEmailDesc.Text = reader("userEmail").ToString()
            lblDescription.Text = reader("Description").ToString()

            ' Split the comma-separated string
            Dim skills() As String = reader("Skills").ToString().Split(","c)
            Dim interests() As String = reader("Interests").ToString().Split(","c)

            ' Safely assign skill values (with index checks)
            lblSkill1.Text = If(skills.Length > 0, skills(0).Trim(), "<>")
            lblSkill2.Text = If(skills.Length > 1, skills(1).Trim(), "<>")
            lblSkill3.Text = If(skills.Length > 2, skills(2).Trim(), "<>")

            ' Assign interest values
            lblInterest1.Text = If(interests.Length > 0, interests(0).Trim(), "<>")
            lblInterest2.Text = If(interests.Length > 1, interests(1).Trim(), "<>")
            lblInterest3.Text = If(interests.Length > 2, interests(2).Trim(), "<>")
        End If

        reader.Close()
        con.Close()
    End Sub

End Class
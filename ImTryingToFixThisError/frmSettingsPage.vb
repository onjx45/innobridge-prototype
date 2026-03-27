Public Class frmSettingsPage
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        btnExit.BackColor = Color.DarkRed
        btnExit.ForeColor = Color.White
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.IndianRed ' Or your original color
        btnExit.ForeColor = Color.White
    End Sub

    Private Sub frmSettingsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
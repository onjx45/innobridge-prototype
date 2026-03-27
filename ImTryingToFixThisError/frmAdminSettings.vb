Public Class frmAdminSettings
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim login As New frmLoginPage() ' Show the login form 

        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to logout?", "Input Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close() ' Close the profile page form
            frmAdminPanel.Close()
            login.Show() ' Opens the login page 
        End If
    End Sub
End Class
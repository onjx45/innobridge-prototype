Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.OleDb


Public Class frmLoginPage
    Private Sub frmLoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(picEmail, "Enter your registered Email")
        ToolTip2.SetToolTip(picPass, "Enter your registered password")
        txtPassword.Text = "Password" ' Set initial placeholder text
        txtPassword.ForeColor = Color.Gray  ' Make placeholder color gray
        txtPassword.Tag = "placeholder" ' Tag it so we know it's just a placeholder
        txtPassword.UseSystemPasswordChar = False ' Show plain text (not password dots)
        txtAdminPasskey.Visible = False

    End Sub

    Private Sub lblTOS_MouseEnter(sender As Object, e As EventArgs) Handles lblTOS.MouseEnter
        lblTOS.ForeColor = Color.Blue
    End Sub
    Private Sub lblTOS_MouseLeave(sender As Object, e As EventArgs) Handles lblTOS.MouseLeave
        lblTOS.ForeColor = Color.Black
    End Sub
    Private Sub lblPP_MouseEnter(sender As Object, e As EventArgs) Handles lblPP.MouseEnter
        lblPP.ForeColor = Color.Blue
    End Sub
    Private Sub lblPP_MouseLeave(sender As Object, e As EventArgs) Handles lblPP.MouseLeave
        lblPP.ForeColor = Color.Black
    End Sub


    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        If txtEmail.Text = "Email" Then
            txtEmail.Text = ""
            txtEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.Text.Trim() = "" Then 'Only resets if empty
            txtEmail.Text = "Email"
            txtEmail.ForeColor = Color.Gray
            lblPassword.Visible = False
        End If
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Tag.ToString() = "placeholder" Then ' Only clear if it's still placeholder
            txtPassword.Text = "" ' Clear the placeholder
            txtPassword.ForeColor = Color.Black ' Set normal input color
            txtPassword.UseSystemPasswordChar = True ' Show dots instead of characters
            txtPassword.Tag = "real" ' Mark it as real input
        End If
    End Sub
    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then ' If empty when losing focus
            txtPassword.Text = "Password *" ' Show placeholder again
            txtPassword.ForeColor = Color.Gray ' Set placeholder color
            txtPassword.Tag = "placeholder" ' Mark it as placeholder
            End If
    End Sub
    Private Sub txtPassword_MouseEnter(sender As Object, e As EventArgs) Handles txtPassword.MouseEnter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        End If
    End Sub
    Private Sub txtPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtPassword.MouseLeave
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Gray
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub


    Private Sub lblSignUpNow_MouseEnter(sender As Object, e As EventArgs) Handles lblSignUpNow.MouseEnter
        lblSignUpNow.Font = New Font(lblSignUpNow.Font, FontStyle.Bold Or FontStyle.Underline)
        lblSignUpNow.Cursor = Cursors.Hand ' Show hand cursor on hover
        lblSignUpNow.ForeColor = Color.Blue
    End Sub

    Private Sub lblSignUpNow_MouseLeave(sender As Object, e As EventArgs) Handles lblSignUpNow.MouseLeave
        lblSignUpNow.Font = New Font(lblSignUpNow.Font, FontStyle.Bold) ' Remove underline
        lblSignUpNow.ForeColor = Color.DarkSlateGray
    End Sub

    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.FromArgb(25, 118, 210) ' Hover color (darker blue)
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.FromArgb(33, 150, 243) ' Original blue
    End Sub

    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InnoBridgeDatabase.accdb")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both email and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If chkAdminLogin.Checked Then ' Check if Admin Login
            If txtAdminPasskey.Text = "innoAdmin2025" Then ' If passkey correct then logged in as user
                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                frmAdminPanel.Show()
            Else
                MessageBox.Show("Invalid admin passkey.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Exit Sub ' ❗ Important: Stop the rest of the code from running
        End If

        ' Regular user login 
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InnoBridgeDatabase.accdb")
        Dim cmd As New OleDbCommand("SELECT * FROM SignUpLoginPage WHERE userEmail = ? AND userPassword = ?", con)

        cmd.Parameters.AddWithValue("?", email)
        cmd.Parameters.AddWithValue("?", password)

        Try
            con.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                SessionData.LoggedInEmail = reader("userEmail").ToString()
                SessionData.LoggedInUserID = reader("ID").ToString()

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                frmMainMenu.Show()
            Else
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            ' Show the password (remove masking)
            txtPassword.UseSystemPasswordChar = False
        Else
            ' Mask the password again
            If txtPassword.Text <> "" AndAlso txtPassword.Text <> "Password" Then
                txtPassword.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    Private Sub lblSignUpNow_Click(sender As Object, e As EventArgs) Handles lblSignUpNow.Click
        frmSignUp.Show() ' Show the login form
        Me.Hide() ' hide the current form
    End Sub

    Private Sub lblTOS_Click(sender As Object, e As EventArgs) Handles lblTOS.Click
        Dim tos As New frmTOS ' declaring the variable to assign new forms
        tos.SetSourceForm(Me)
        tos.Show() 'Open the new form
        Me.Hide() ' hide the curretn for,
    End Sub

    Private Sub lblPP_Click(sender As Object, e As EventArgs) Handles lblPP.Click
        Dim pp As New frmPrivacyPolicy
        pp.SetSourceForm(Me)
        pp.Show()
        Me.Hide()
    End Sub

    Private Sub chkAdminLogin_CheckedChanged(sender As Object, e As EventArgs) Handles chkAdminLogin.CheckedChanged
        txtAdminPasskey.Visible = chkAdminLogin.Checked
    End Sub


End Class

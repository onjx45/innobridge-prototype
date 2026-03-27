Imports System.Data.OleDb
Public Class frmSignUp
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InnoBridgeDatabase.accdb")
    Private Sub btnLoginSignUp_Click(sender As Object, e As EventArgs) Handles btnLoginSignUp.Click
        frmLoginPage.Show()
        Me.Hide()
    End Sub
    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPasswordSignUp.UseSystemPasswordChar = False
        lblMMSignUp.Visible = True
        lblDDSignUp.Visible = True
        lblYYYYSignUp.Visible = True

        txtUsernameSignUp.Text = "Username (Optional)"
        txtUsernameSignUp.ForeColor = Color.Gray
        txtFullNameSignUp.Text = "Full Name *"
        txtFullNameSignUp.ForeColor = Color.Gray
        txtEmailSignUp.Text = "Email *"
        txtEmailSignUp.ForeColor = Color.Gray
        txtPasswordSignUp.Text = "Password *"
        txtPasswordSignUp.ForeColor = Color.Gray

        ' Months for combobox
        cmbMMSignUp.Items.AddRange({"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})

        ' Days 1–31 for combobox
        For i As Integer = 1 To 31
            cmbDDSignUp.Items.Add(i.ToString("D2")) ' D2 = two digits, like 01
        Next

        ' Populate Years 2007 or earlier only
        For year As Integer = 2007 To 1900 Step -1
            cmbYYYYSignUp.Items.Add(year.ToString())
        Next

        cmbMMSignUp.Text = "MM"
        cmbDDSignUp.Text = "DD"
        cmbYYYYSignUp.Text = "YYYY"

        cmbMMSignUp.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDDSignUp.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYYYYSignUp.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnLoginSignUp_MouseEnter(sender As Object, e As EventArgs) Handles btnLoginSignUp.MouseEnter
        btnLoginSignUp.BackColor = Color.FromArgb(25, 118, 210) ' Hover color (darker blue)
    End Sub

    Private Sub btnLoginSignUp_MouseLeave(sender As Object, e As EventArgs) Handles btnLoginSignUp.MouseLeave
        btnLoginSignUp.BackColor = Color.FromArgb(33, 150, 243) ' Original blue
    End Sub

    Private Sub txtUsernameSignUp_TextChanged(sender As Object, e As EventArgs) Handles txtUsernameSignUp.TextChanged
        Dim username As String = txtUsernameSignUp.Text.Trim() ' To assign username in the username text box to username variable

        If username.Length > 20 Then ' To check if the username is too long then it will show up a warning
            MessageBox.Show("Username must be less than 20 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

    End Sub

    Private Sub txtUsernameSignUp_MouseEnter(sender As Object, e As EventArgs) Handles txtUsernameSignUp.MouseEnter
        If txtUsernameSignUp.Text = "Username (Optional)" Then
            txtUsernameSignUp.Text = ""
            txtUsernameSignUp.ForeColor = Color.Black
            lblUsernameSignUp.Visible = False
        End If

    End Sub

    Private Sub txtUsernameSignUp_MouseLeave(sender As Object, e As EventArgs) Handles txtUsernameSignUp.MouseLeave
        If txtUsernameSignUp.Text.Trim() = "" Then 'Only resets if empty
            txtUsernameSignUp.Text = "Username (Optional)"
            txtUsernameSignUp.ForeColor = Color.Gray
            lblUsernameSignUp.Visible = False
        End If
    End Sub

    Private Sub txtFullNameSignUp_MouseEnter(sender As Object, e As EventArgs) Handles txtFullNameSignUp.MouseEnter
        If txtFullNameSignUp.Text = "Full Name *" Then
            txtFullNameSignUp.Text = ""
            txtFullNameSignUp.ForeColor = Color.Black
            lblFullNameSignUp.Visible = False
        End If
    End Sub

    Private Sub txtFullNameSignUp_MouseLeave(sender As Object, e As EventArgs) Handles txtFullNameSignUp.MouseLeave
        If txtFullNameSignUp.Text.Trim() = "" Then 'Only resets if empty
            txtFullNameSignUp.Text = "Full Name *"
            txtFullNameSignUp.ForeColor = Color.Gray
            lblFullNameSignUp.Visible = False
        End If
    End Sub
    Private Sub txtEmailSignUp_MouseEnter(sender As Object, e As EventArgs) Handles txtEmailSignUp.MouseEnter
        If txtEmailSignUp.Text = "Email *" Then
            txtEmailSignUp.Text = ""
            txtEmailSignUp.ForeColor = Color.Black
            lblEmailSignUp.Visible = False
        End If
    End Sub

    Private Sub txtEmailSignUp_MouseLeave(sender As Object, e As EventArgs) Handles txtEmailSignUp.MouseLeave
        If txtEmailSignUp.Text.Trim() = "" Then 'Only resets if empty
            txtEmailSignUp.Text = "Email *"
            txtEmailSignUp.ForeColor = Color.Gray
            lblEmailSignUp.Visible = False
        End If
    End Sub


    Private Sub txtPasswordSignUp_MouseEnter(sender As Object, e As EventArgs) Handles txtPasswordSignUp.MouseEnter
        If txtPasswordSignUp.Text = "Password *" Then
            txtPasswordSignUp.UseSystemPasswordChar = True
            txtPasswordSignUp.Text = ""
            txtPasswordSignUp.ForeColor = Color.Black
            lblPasswordSignUp.Visible = True
        End If
    End Sub

    Private Sub txtPasswordSignUp_MouseLeave(sender As Object, e As EventArgs) Handles txtPasswordSignUp.MouseLeave
        If txtPasswordSignUp.Text.Trim() = "" Then 'Only resets if empty
            txtPasswordSignUp.UseSystemPasswordChar = False ' When True, it shows the masking
            txtPasswordSignUp.Text = "Password *"
            txtPasswordSignUp.ForeColor = Color.Gray
            lblPasswordSignUp.Visible = False
        End If
    End Sub

    Private Sub chkShowPasswordSignUp_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPasswordSignUp.CheckedChanged

        If txtPasswordSignUp.Text = "Password *" OrElse String.IsNullOrWhiteSpace(txtPasswordSignUp.Text) Then
            txtPasswordSignUp.UseSystemPasswordChar = False
        Else
            txtPasswordSignUp.UseSystemPasswordChar = Not chkShowPasswordSignUp.Checked
        End If

    End Sub

    Private Sub ShowPasswordError(message As String)
        lblPasswordSignUp.Text = message
        lblPasswordSignUp.ForeColor = Color.Red
        lblPasswordSignUp.Visible = True
    End Sub

    Private Sub txtPasswordSignUp_TextChanged(sender As Object, e As EventArgs) Handles txtPasswordSignUp.TextChanged

    End Sub


    Private Sub chkOrganizationSignUp_CheckedChanged(sender As Object, e As EventArgs) Handles chkOrganizationSignUp.CheckedChanged
        If chkOrganizationSignUp.Checked Then
            ' Uncheck Student
            chkStudentSignUp.Checked = False

            ' Hide Date of Birth fields
            cmbMMSignUp.Visible = False
            cmbDDSignUp.Visible = False
            cmbYYYYSignUp.Visible = False
            lblDOBSignUp.Visible = False
            lblMMSignUp.Visible = False
            lblDDSignUp.Visible = False
            lblYYYYSignUp.Visible = False
            lblDaySignUp.Visible = False
            lblMonthSignUp.Visible = False
            lblYearSignUp.Visible = False

        Else
            ' If unchecked, show the DOB fields again
            cmbMMSignUp.Visible = True
            cmbDDSignUp.Visible = True
            cmbYYYYSignUp.Visible = True
            lblDOBSignUp.Visible = True
            lblMMSignUp.Visible = True
            lblDDSignUp.Visible = True
            lblYYYYSignUp.Visible = True
            lblDaySignUp.Visible = True
            lblMonthSignUp.Visible = True
            lblYearSignUp.Visible = True

        End If
    End Sub

    Private Sub chkStudentSignUp_CheckedChanged(sender As Object, e As EventArgs) Handles chkStudentSignUp.CheckedChanged
        If chkOrganizationSignUp.Checked Then
            chkStudentSignUp.Checked = False
        End If
    End Sub

    Private Sub cmbMMSignUp_MouseEnter(sender As Object, e As EventArgs) Handles cmbMMSignUp.MouseEnter
        lblMMSignUp.Visible = False
        lblMMSignUp.Enabled = False

    End Sub

    Private Sub cmbMMSignUp_TextChanged(sender As Object, e As EventArgs) Handles cmbMMSignUp.TextChanged
        If cmbMMSignUp.Text <> "" Then
            lblMMSignUp.Visible = False
        Else
            lblMMSignUp.Visible = True
        End If

        ' Handles if user type months that are more than 12
        If cmbMMSignUp.Text.Length > 2 Then
            MessageBox.Show("Months cannot be greater than 2 digits", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub cmbMMSignUp_MouseLeave(sender As Object, e As EventArgs) Handles cmbMMSignUp.MouseLeave
        ' Only show the label again if no item is selected
        If cmbMMSignUp.SelectedIndex = -1 Then
            lblMMSignUp.Visible = True
        End If

    End Sub

    Private Sub cmbDDSignUp_MouseEnter(sender As Object, e As EventArgs) Handles cmbDDSignUp.MouseEnter
        lblDDSignUp.Visible = False
        lblDDSignUp.Enabled = False
    End Sub
    Private Sub cmbDDSignUp_TextChanged(sender As Object, e As EventArgs) Handles cmbDDSignUp.TextChanged
        If cmbDDSignUp.Text <> "" Then
            lblDDSignUp.Visible = False
        Else
            lblDDSignUp.Visible = True
        End If

        If cmbDDSignUp.Text.Length > 2 Then
            MessageBox.Show("Day cannot be greater than 2 digits", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub cmbDDSignUp_MouseLeave(sender As Object, e As EventArgs) Handles cmbDDSignUp.MouseLeave
        ' Only show the label again if no item is selected
        If cmbDDSignUp.SelectedIndex = -1 Then
            lblDDSignUp.Visible = True
        End If
    End Sub

    Private Sub cmbYYYYSignUp_MouseEnter(sender As Object, e As EventArgs) Handles cmbYYYYSignUp.MouseEnter
        lblYYYYSignUp.Visible = False
        lblYYYYSignUp.Enabled = False
    End Sub

    Private Sub cmbYYYYSignUp_TextChanged(sender As Object, e As EventArgs) Handles cmbYYYYSignUp.TextChanged
        If cmbYYYYSignUp.Text <> "" Then
            lblYYYYSignUp.Visible = False
        Else
            lblYYYYSignUp.Visible = True
        End If

        If cmbYYYYSignUp.Text.Length > 4 Then
            MessageBox.Show("Year cannot be greater than 4 digits", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub cmbYYYYSignUp_MouseLeave(sender As Object, e As EventArgs) Handles cmbYYYYSignUp.MouseLeave
        ' Only show the label again if no item is selected
        If cmbYYYYSignUp.SelectedIndex = -1 Then
            lblYYYYSignUp.Visible = True
        End If
    End Sub

    Private Sub btnSignUp_MouseEnter(sender As Object, e As EventArgs) Handles btnSignUp.MouseEnter
        btnSignUp.BackColor = Color.FromArgb(25, 118, 210) ' Hover color (darker blue)
    End Sub

    Private Sub btnSignUp_MouseLeave(sender As Object, e As EventArgs) Handles btnSignUp.MouseLeave
        btnSignUp.BackColor = Color.FromArgb(33, 150, 243) ' Original blue
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'MessageBox.Show("Step 1: Button clicked!")

        ' Step 1: Validate password first
        Dim password As String = txtPasswordSignUp.Text.Trim()

        If password = "" Or password = "Password *" Then
            MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If password.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not password.Any(AddressOf Char.IsUpper) Then
            MessageBox.Show("Password must contain at least one uppercase letter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Passed all checks
        lblPasswordSignUp.Visible = False


        'MessageBox.Show("Step 2: Password passed.")


        ' Step 2: If not an organization, validate DOB
        Dim dob As String = ""
        If Not chkOrganizationSignUp.Checked Then
            If cmbMMSignUp.Text = "MM" Or cmbDDSignUp.Text = "DD" Or cmbYYYYSignUp.Text = "YYYY" Then
                MessageBox.Show("Please select your complete Date of Birth.", "Incomplete DOB", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Validate date exists
            Try
                Dim validDOB As Date = New Date(CInt(cmbYYYYSignUp.Text), CInt(cmbMMSignUp.Text), CInt(cmbDDSignUp.Text))
            Catch ex As Exception
                MessageBox.Show("Invalid date selected. Please check your DOB.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            ' Calculate age
            Dim selectedDay As Integer = CInt(cmbDDSignUp.Text)
            Dim selectedMonth As Integer = CInt(cmbMMSignUp.Text)
            Dim selectedYear As Integer = CInt(cmbYYYYSignUp.Text)

            Dim NewDateOfBirth As New Date(selectedYear, selectedMonth, selectedDay)
            Dim today As Date = Date.Today

            Dim age As Integer = today.Year - NewDateOfBirth.Year
            If NewDateOfBirth > today.AddYears(-age) Then age -= 1

            If age < 18 Then
                MessageBox.Show("You must be at least 18 years old to register.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            dob = cmbMMSignUp.Text & "/" & cmbDDSignUp.Text & "/" & cmbYYYYSignUp.Text
        Else
            dob = "" ' Allow empty DOB for organization
        End If

        'MessageBox.Show("Step 3: DOB passed.")


        ' Step 3: Proceed with DB insert
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\InnoBridgeDatabase.accdb")
        Dim cmd As New OleDbCommand(
            "INSERT INTO SignupLoginPage ([Username],[userFullName],[userEmail],[userPassword],[userIsStudent],[userIsOrganization],[userDOB]) " &
            "VALUES (?,?,?,?,?,?,?)", con)

        cmd.Parameters.Add("?", OleDbType.VarChar).Value = txtUsernameSignUp.Text
        cmd.Parameters.Add("?", OleDbType.VarChar).Value = txtFullNameSignUp.Text
        cmd.Parameters.Add("?", OleDbType.VarChar).Value = txtEmailSignUp.Text
        cmd.Parameters.Add("?", OleDbType.VarChar).Value = txtPasswordSignUp.Text
        cmd.Parameters.Add("?", OleDbType.Boolean).Value = chkStudentSignUp.Checked
        cmd.Parameters.Add("?", OleDbType.Boolean).Value = chkOrganizationSignUp.Checked

        If dob <> "" Then
            cmd.Parameters.Add("?", OleDbType.Date).Value = Convert.ToDateTime(dob)
        Else
            cmd.Parameters.Add("?", OleDbType.Date).Value = DBNull.Value
        End If

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sign-Up Successful!", "Success")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try

        'MessageBox.Show("Step 4: Ready to insert into DB.")


        ' Combine into one string
        Dim DateOfBirth As String = cmbMMSignUp.Text & "/" & cmbDDSignUp.Text & "/" & cmbYYYYSignUp.Text
    End Sub
    Private Sub lblTOSSignUp_MouseEnter(sender As Object, e As EventArgs) Handles lblTOSSignUp.MouseEnter
        lblTOSSignUp.ForeColor = Color.Blue
    End Sub
    Private Sub lblTOSSignUp_MouseLeave(sender As Object, e As EventArgs) Handles lblTOSSignUp.MouseLeave
        lblTOSSignUp.ForeColor = Color.Black
    End Sub
    Private Sub lblPPSignUp_MouseEnter(sender As Object, e As EventArgs) Handles lblPPSignUp.MouseEnter
        lblPPSignUp.ForeColor = Color.Blue
    End Sub
    Private Sub lblPPSignUp_MouseLeave(sender As Object, e As EventArgs) Handles lblPPSignUp.MouseLeave
        lblPPSignUp.ForeColor = Color.Black
    End Sub

    Private Sub lblTOSSignUp_MouseClick(sender As Object, e As MouseEventArgs) Handles lblTOSSignUp.MouseClick
        Dim tosSignUp As New frmTOS
        tosSignUp.SetSourceForm(Me)
        tosSignUp.Show()
        Me.Hide()
    End Sub
    Private Sub lblPPSignUp_MouseClick(sender As Object, e As MouseEventArgs) Handles lblPPSignUp.MouseClick
        Dim ppSignUp As New frmPrivacyPolicy
        ppSignUp.SetSourceForm(Me)
        ppSignUp.Show()
        Me.Hide()
    End Sub


End Class
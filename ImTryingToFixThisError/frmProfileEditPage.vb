Imports System.Data.OleDb
Public Class frmProfileEditPage
    Private originalCancelColor As Color = Color.White
    Private originalSaveColor As Color = Color.White

    Private Sub frmProfileEditPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial background
        btnCancel.BackColor = originalCancelColor
        btnSave.BackColor = originalSaveColor
        btnCancel.FlatStyle = FlatStyle.Flat
        btnSave.FlatStyle = FlatStyle.Flat
        btnCancel.FlatAppearance.BorderColor = Color.Gray
        btnSave.FlatAppearance.BorderColor = Color.Gray


        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\source\repos\ImTryingToFixThisError\ImTryingToFixThisError\bin\Debug\InnoBridgeDatabase.accdb") ' declaring the variable and assign as the location of the database file
        Dim cmd As New OleDbCommand("SELECT * FROM SignupLoginPage WHERE userEmail = @email", con) ' To get to specific table "SignupLoginPage" in MS Access 
        cmd.Parameters.AddWithValue("@email", LoggedInEmail) ' LoggedInEmail

        con.Open()
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            ' Username fallback to FullName
            txtUsername.Text = If(IsDBNull(reader("Username")) OrElse reader("Username").ToString().Trim() = "", reader("FullName").ToString(), reader("Username").ToString())

            txtEmail.Text = reader("userEmail").ToString()
            txtDescription.Text = reader("Description").ToString()

            ' Populate combo boxes
            ' Assume skills/interests are stored as comma-separated strings
            Dim skills = reader("Skills").ToString().Split(","c)
            Dim interests = reader("Interests").ToString().Split(","c)

            ' Set selected values (assuming dropdowns are named cbSkill1, cbSkill2, etc.)
            If skills.Length > 0 Then cmbSkill1.Text = skills(0)
            If skills.Length > 1 Then cmbSkill2.Text = skills(1)
            If skills.Length > 2 Then cmbSkill3.Text = skills(2)

            If interests.Length > 0 Then cmbInterest1.Text = interests(0)
            If interests.Length > 1 Then cmbInterest2.Text = interests(1)
            If interests.Length > 2 Then cmbInterest3.Text = interests(2)
        End If

        con.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' 🔗 Connection to Access
            Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\source\repos\ImTryingToFixThisError\ImTryingToFixThisError\bin\Debug\InnoBridgeDatabase.accdb")

                ' 🛠 SQL Command with actual field names
                Dim cmd As New OleDbCommand("UPDATE SignupLoginPage SET Username = ?, Skills = ?, Interests = ?, Description = ? WHERE userEmail = ?", con)

                ' Get selected values from Skills and Interests
                Dim skillList As New List(Of String) From {cmbSkill1.Text.Trim(), cmbSkill2.Text.Trim(), cmbSkill3.Text.Trim()}
                Dim interestList As New List(Of String) From {cmbInterest1.Text.Trim(), cmbInterest2.Text.Trim(), cmbInterest3.Text.Trim()}

                ' Remove empty selections for safe comparison
                skillList = skillList.Where(Function(x) Not String.IsNullOrWhiteSpace(x)).ToList()
                interestList = interestList.Where(Function(x) Not String.IsNullOrWhiteSpace(x)).ToList()

                ' Check for duplicate skills
                If skillList.Count <> skillList.Distinct().Count() Then
                    MessageBox.Show("Please ensure all selected skills are unique.", "Duplicate Skill Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Check for duplicate interests
                If interestList.Count <> interestList.Distinct().Count() Then
                    MessageBox.Show("Please ensure all selected interests are unique.", "Duplicate Interest Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If


                ' 📦 Collect and trim inputs
                Dim selectedSkills As String = cmbSkill1.Text.Trim() & "," & cmbSkill2.Text.Trim() & "," & cmbSkill3.Text.Trim()
                Dim selectedInterests As String = cmbInterest1.Text.Trim() & "," & cmbInterest2.Text.Trim() & "," & cmbInterest3.Text.Trim()

                ' 🧩 Add parameters in the exact order of the placeholders
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtUsername.Text.Trim()
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = selectedSkills
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = selectedInterests
                cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = txtDescription.Text.Trim()
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtEmail.Text.Trim()

                ' 🔄 Execute inside connection
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using

            MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As OleDbException
            MessageBox.Show("Database error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close() ' Close the edit form
    End Sub

    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackColor = Color.LightCoral
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackColor = originalCancelColor
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles btnSave.MouseEnter
        btnSave.BackColor = Color.LightGreen
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.BackColor = originalSaveColor
    End Sub

End Class
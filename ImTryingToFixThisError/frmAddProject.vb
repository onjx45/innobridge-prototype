Public Class frmAddProject
    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackColor = Color.Salmon
        btnCancel.ForeColor = Color.White
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.ForeColor = Color.Black
        btnCancel.BackColor = Color.White
    End Sub

    Private Sub btnSubmit_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter
        btnSubmit.BackColor = Color.White
        btnSubmit.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub btnSubmit_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave
        btnSubmit.ForeColor = Color.White
        btnSubmit.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim backForm As New frmProjectFeed()
        backForm.Show()
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtProjectTitle.Text = "" Or txtDescription.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        dtpProjectDate.MaxDate = Date.Today ' Ensure user cannot select a future date

        ' Prepare database connection and query
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InnoBridgeDatabase.accdb")
        Dim cmd As New OleDb.OleDbCommand("INSERT INTO tblUserProjects (UserID, ProjectTitle, ProjectDesc, ProjectDate) VALUES (?, ?, ?, ?)", con)

        cmd.Parameters.AddWithValue("?", SessionData.LoggedInUserID) ' Add parameters in correct order
        cmd.Parameters.AddWithValue("?", txtProjectTitle.Text)
        cmd.Parameters.AddWithValue("?", txtDescription.Text)
        cmd.Parameters.AddWithValue("?", dtpProjectDate.Value)

        If txtProjectTitle.Text = "" Or txtDescription.Text = "" Then 'Or picPreview.Image Is Nothing
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Execute the query safely
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Project Posted Successfully!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try

        txtProjectTitle.Clear()
        txtDescription.Clear()
        dtpProjectDate.Value = Date.Today
        'picPreview.Image = Nothing
    End Sub

    Private Sub frmAddProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
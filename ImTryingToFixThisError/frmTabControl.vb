Imports System.Data.OleDb

Public Class frmTabControl
    Private Sub frmTabControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
        LoadProjects()
    End Sub
    Private Sub LoadUsers()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InnoBridgeDatabase.accdb")
        Dim cmd As New OleDbCommand("SELECT ID, userName, userEmail FROM SignUpLoginPage", con)
        Dim dt As New DataTable()

        Try
            con.Open()
            dt.Load(cmd.ExecuteReader())
            dgvUsers.DataSource = dt
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefreshUsers.Click
        LoadUsers()
    End Sub

    Private Sub LoadProjects()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InnoBridgeDatabase.accdb")
        Dim cmd As New OleDbCommand("SELECT ProjectID, ProjectTitle, ProjectDesc, ProjectDate FROM tblUserProjects", con)
        Dim dt As New DataTable()

        Try
            con.Open()
            dt.Load(cmd.ExecuteReader())
            dgvProjects.DataSource = dt
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading projects: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUsers.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim userID As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("ID").Value)

            Dim confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = DialogResult.Yes Then
                Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InnoBridgeDatabase.accdb")
                Dim cmd As New OleDbCommand("DELETE FROM SignUpLoginPage WHERE ID = ?", con)
                cmd.Parameters.AddWithValue("?", userID)

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("User deleted successfully.")
                    LoadUsers()
                Catch ex As Exception
                    MessageBox.Show("Error deleting user: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Please select a user to delete.")
        End If
    End Sub

    Private Sub btnDeleteProject_Click_1(sender As Object, e As EventArgs) Handles btnDeleteProject.Click
        If dgvProjects.SelectedRows.Count > 0 Then
            Dim projectID As Integer = Convert.ToInt32(dgvProjects.SelectedRows(0).Cells("ProjectID").Value)

            Dim confirm = MessageBox.Show("Are you sure you want to delete this project?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = DialogResult.Yes Then
                Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InnoBridgeDatabase.accdb")
                Dim cmd As New OleDbCommand("DELETE FROM tblUserProjects WHERE ProjectID = ?", con)
                cmd.Parameters.AddWithValue("?", projectID)

                Try
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Project deleted successfully.")
                    LoadProjects()
                Catch ex As Exception
                    MessageBox.Show("Error deleting project: " & ex.Message)
                End Try
            End If
        Else
            MessageBox.Show("Please select a project to delete.")
        End If
    End Sub

    Private Sub btnRefreshProject_Click(sender As Object, e As EventArgs) Handles btnRefreshProject.Click
        LoadProjects()
    End Sub

    ' Mouse Enter Event
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) _
    Handles btnRefreshUsers.MouseEnter, btnDeleteUsers.MouseEnter, btnRefreshProject.MouseEnter, btnDeleteProject.MouseEnter

        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(52, 152, 219)
        btn.ForeColor = Color.White
    End Sub

    ' Mouse Leave Event
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) _
    Handles btnRefreshUsers.MouseLeave, btnDeleteUsers.MouseLeave, btnRefreshProject.MouseLeave, btnDeleteProject.MouseLeave

        Dim btn As Button = CType(sender, Button)
        btn.BackColor = SystemColors.Control
        btn.ForeColor = Color.Black
    End Sub

End Class
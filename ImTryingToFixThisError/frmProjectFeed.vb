Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmProjectFeed

    Dim allProjects As New List(Of ProjectModel)
    Dim currentPage As Integer = 1
    Dim projectsPerPage As Integer = 3
    Dim totalPages As Integer = 1

    Private Sub LoadAllProjects()
        allProjects.Clear()

        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\source\repos\ImTryingToFixThisError\ImTryingToFixThisError\bin\Debug\InnoBridgeDatabase.accdb")
            Dim cmd As New OleDbCommand("SELECT * FROM tblUserProjects ORDER BY ProjectDate DESC", con)
            con.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim project As New ProjectModel()
                project.Title = reader("ProjectTitle").ToString()
                project.Description = reader("ProjectDesc").ToString()
                project.DatePosted = Convert.ToDateTime(reader("ProjectDate"))
                project.ImageData = If(IsDBNull(reader("ProjectImage")), Nothing, CType(reader("ProjectImage"), Byte()))
                allProjects.Add(project)
            End While
        End Using

        DisplayProjects() ' show first 3

    End Sub

    Private Sub DisplayProjects()

        Dim pageSize As Integer = 3
        If currentPage < 1 Then currentPage = 1
        Dim startIndex As Integer = (currentPage - 1) * pageSize

        ' If no projects at all, exit
        If allProjects.Count = 0 Then
            ClearAllCards()
            lblPage.Text = "No projects found"
            Return
        End If

        ' If startIndex is beyond list, reset to page 1
        If startIndex >= allProjects.Count Then
            currentPage = 1
            startIndex = 0
        End If

        ' Clear previous values
        ClearAllCards()

        ' Card 1
        If startIndex < allProjects.Count Then
            Dim p = allProjects(startIndex)
            lblTitle1.Text = p.Title
            lblDesc1.Text = p.Description
            lblDate1.Text = p.DatePosted.ToShortDateString()
        End If

        ' Card 2
        If startIndex + 1 < allProjects.Count Then
            Dim p = allProjects(startIndex + 1)
            lblTitle2.Text = p.Title
            lblDesc2.Text = p.Description
            lblDate2.Text = p.DatePosted.ToShortDateString()
        End If

        ' Card 3
        If startIndex + 2 < allProjects.Count Then
            Dim p = allProjects(startIndex + 2)
            lblTitle3.Text = p.Title
            lblDesc3.Text = p.Description
            lblDate3.Text = p.DatePosted.ToShortDateString()
        End If

        ' Update pagination label
        Dim totalPages As Integer = Math.Ceiling(allProjects.Count / pageSize)
        totalPages = CInt(Math.Ceiling(allProjects.Count / pageSize * 1.0))
        lblPage.Text = $"Page {currentPage} of {totalPages}"

    End Sub

    Private Sub ClearAllCards()
        ' Card 1
        lblTitle1.Text = ""
        lblDesc1.Text = ""
        lblDate1.Text = ""

        ' Card 2
        lblTitle2.Text = ""
        lblDesc2.Text = ""
        lblDate2.Text = ""

        ' Card 3
        lblTitle3.Text = ""
        lblDesc3.Text = ""
        lblDate3.Text = ""
    End Sub

    Private Sub btnPostProject_Click(sender As Object, e As EventArgs) Handles btnPostProject.Click
        Dim addForm As New frmAddProject()
        addForm.ShowDialog()

        ' After closing, reload the feed and reset pagination
        currentPage = 1
        LoadAllProjects()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (currentPage + 1) * projectsPerPage < allProjects.Count Then
            currentPage += 1
            DisplayProjects()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentPage > 0 Then
            currentPage -= 1
            DisplayProjects()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMainMenu.Show()     ' Show the main menu form
        Me.Hide()              ' Hide the current form (frmProjectFeed)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAllProjects()
    End Sub

    Public Class ProjectModel
        Public Property Title As String
        Public Property Description As String
        Public Property DatePosted As DateTime
        Public Property ImageData As Byte()
    End Class

    Private Sub frmProjectFeed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllProjects()
    End Sub

    Private Sub btnCollaborate1_Click(sender As Object, e As EventArgs) Handles btnCollaborate1.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to request?", "Input Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Collaboration sent!", "Input Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCollaborate1.Enabled = False
        End If
    End Sub

    Private Sub btnCollaborate2_Click(sender As Object, e As EventArgs) Handles btnCollaborate2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to request?", "Input Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Collaboration sent!", "Input Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCollaborate2.Enabled = False
        End If
    End Sub

    Private Sub btnCollborate3_Click(sender As Object, e As EventArgs) Handles btnCollaborate3.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to request?", "Input Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            MessageBox.Show("Collaboration sent!", "Input Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnCollaborate3.Enabled = False
        End If
    End Sub
    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackColor = Color.DodgerBlue
        btnBack.ForeColor = Color.White
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackColor = Color.White
        btnBack.ForeColor = Color.Black
    End Sub

    Private Sub btnPostProject_MouseEnter(sender As Object, e As EventArgs) Handles btnPostProject.MouseEnter
        btnPostProject.BackColor = Color.DodgerBlue
        btnPostProject.ForeColor = Color.White
    End Sub
    Private Sub btnPostProject_MouseLeave(sender As Object, e As EventArgs) Handles btnPostProject.MouseLeave
        btnPostProject.BackColor = Color.White
        btnPostProject.ForeColor = Color.Black
    End Sub

    Private Sub btnRefresh_MouseEnter(sender As Object, e As EventArgs) Handles btnRefresh.MouseEnter
        btnRefresh.BackColor = Color.DodgerBlue
        btnRefresh.ForeColor = Color.White
    End Sub
    Private Sub btnRefresh_MouseLeave(sender As Object, e As EventArgs) Handles btnRefresh.MouseLeave
        btnRefresh.BackColor = Color.White
        btnRefresh.ForeColor = Color.Black
    End Sub

    Private Sub pnlPostProject_Paint(sender As Object, e As PaintEventArgs) Handles pnlPostProject.Paint

    End Sub
End Class
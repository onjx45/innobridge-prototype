Imports System.Data.OleDb

Public Class frmBrowseProblems
    Private totalProblems As DataTable
    Private currentPage As Integer = 1
    Private pageSize As Integer = 4

    Public Sub LoadAllProblems()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InnoBridgeDatabase.accdb")
        Dim cmd As New OleDbCommand("SELECT * FROM tblProblems", con)

        Dim da As New OleDbDataAdapter(cmd)
        totalProblems = New DataTable()
        da.Fill(totalProblems)
    End Sub

    Public Sub ShowProblemPage(page As Integer)
        Dim cards As Panel() = {pnlCard1, pnlCard2, pnlCard3, pnlCard4}
        Dim lblTitles As Label() = {lblName1, lblName2, lblName3, lblName4}
        Dim lblSDGs As Label() = {lblRole1, lblRole2, lblRole3, lblRole4}

        For i As Integer = 0 To 3
            Dim index As Integer = (page - 1) * pageSize + i
            If index < totalProblems.Rows.Count Then
                Dim row As DataRow = totalProblems.Rows(index)

                lblTitles(i).Text = row("Title").ToString()
                lblSDGs(i).Text = "SDG: " & row("SDG").ToString()

                ' Optional: Add click event to show detail
                AddHandler cards(i).Click, Sub()
                                               lblTitleCard.Text = row("Title").ToString()
                                               lblIndustryDetail.Text = row("Industry").ToString()
                                               lblSDGDetail.Text = row("SDG").ToString()
                                               txtDescDetail.Text = row("Description").ToString()
                                           End Sub

                cards(i).Visible = True ' show the card
            Else
                cards(i).Visible = False ' hide unused cards
            End If
        Next

        lblPageTracker.Text = $"Page {page} of {Math.Ceiling(totalProblems.Rows.Count / pageSize)}"
        currentPage = page
    End Sub

    Private Sub frmBrowseProblems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCollaborate.BackColor = Color.DodgerBlue
        btnCollaborate.ForeColor = Color.White
        btnCollaborate.FlatStyle = FlatStyle.Flat
        btnCollaborate.FlatAppearance.BorderSize = 0

        btnCollaborate.Cursor = Cursors.Hand

        LoadAllProblems()
        ShowProblemPage(1)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim totalPages = Math.Ceiling(totalProblems.Rows.Count / pageSize)
        If currentPage < totalPages Then
            currentPage += 1
            ShowProblemPage(currentPage)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            ShowProblemPage(currentPage)
        End If
    End Sub

    Private Sub btnCollaborate_MouseEnter(sender As Object, e As EventArgs) Handles btnCollaborate.MouseEnter
        btnCollaborate.BackColor = Color.DeepSkyBlue ' Slightly lighter on hover
    End Sub

    Private Sub btnCollaborate_MouseLeave(sender As Object, e As EventArgs) Handles btnCollaborate.MouseLeave
        btnCollaborate.BackColor = Color.DodgerBlue ' Back to default
    End Sub

    Private Sub btnCollaborate_Click(sender As Object, e As EventArgs) Handles btnCollaborate.Click
        MessageBox.Show("Your collaboration request has been sent successfully.", "Request Sent!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        btnCollaborate.Enabled = False
    End Sub
End Class
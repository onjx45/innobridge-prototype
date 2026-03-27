Public Class frmMainMenu
    Private Sub btnHome_MouseEnter(sender As Object, e As EventArgs) Handles btnHome.MouseEnter
        btnHome.BackColor = Color.RoyalBlue
    End Sub

    Private Sub btnHome_MouseLeave(sender As Object, e As EventArgs) Handles btnHome.MouseLeave
        btnHome.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pnlMainContent.Controls.Clear() ' Clear any existing controls

        Dim page As New frmMainPage() ' Create an instance 

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel

        pnlMainContent.Controls.Add(page) ' Add to the panel
        page.Show() ' finally, show it inside

    End Sub

    Private Sub btnPostProject_Click(sender As Object, e As EventArgs) Handles btnPostProject.Click
        pnlMainContent.Controls.Clear() ' Clear any existing controls

        Dim page As New frmPostProject() ' Create an instance 

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel

        pnlMainContent.Controls.Add(page) ' Add to the panel
        page.Show() ' finally, show it inside
    End Sub

    Private Sub btnPostProject_MouseEnter(sender As Object, e As EventArgs) Handles btnPostProject.MouseEnter
        btnPostProject.BackColor = Color.RoyalBlue
    End Sub

    Private Sub btnPostProject_MouseLeave(sender As Object, e As EventArgs) Handles btnPostProject.MouseLeave
        btnPostProject.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        pnlMainContent.Controls.Clear() ' Clear any existing controls

        Dim page As New frmConnectPage() ' Create an instance 

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel

        pnlMainContent.Controls.Add(page) ' Add to the panel
        page.Show() ' finally, show it inside
    End Sub

    Private Sub btnConnect_MouseEnter(sender As Object, e As EventArgs) Handles btnConnect.MouseEnter
        btnConnect.BackColor = Color.RoyalBlue
    End Sub

    Private Sub btnConnect_MouseLeave(sender As Object, e As EventArgs) Handles btnConnect.MouseLeave
        btnConnect.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnBrowseProblems_Click(sender As Object, e As EventArgs) Handles btnBrowseProblems.Click
        pnlMainContent.Controls.Clear() ' Clear any existing controls

        Dim page As New frmBrowseProblems() ' Create an instance 

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel

        pnlMainContent.Controls.Add(page) ' Add to the panel
        page.Show() ' finally, show it inside
    End Sub

    Private Sub btnBrowseProblems_MouseEnter(sender As Object, e As EventArgs) Handles btnBrowseProblems.MouseEnter
        btnBrowseProblems.BackColor = Color.RoyalBlue
    End Sub

    Private Sub btnBrowseProblems_MouseLeave(sender As Object, e As EventArgs) Handles btnBrowseProblems.MouseLeave
        btnBrowseProblems.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        pnlMainContent.Controls.Clear() ' Clear any existing controls

        Dim page As New frmProfilePage() ' Create an instance 

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel

        pnlMainContent.Controls.Add(page) ' Add to the panel
        page.Show() ' finally, show it inside
    End Sub

    Private Sub btnProfile_MouseEnter(sender As Object, e As EventArgs) Handles btnProfile.MouseEnter
        btnProfile.BackColor = Color.RoyalBlue
    End Sub

    Private Sub btnProfile_MouseLeave(sender As Object, e As EventArgs) Handles btnProfile.MouseLeave
        btnProfile.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        pnlMainContent.Controls.Clear() ' Clear any existing controls

        Dim page As New frmSettingsPage() ' Create an instance 

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel

        pnlMainContent.Controls.Add(page) ' Add to the panel
        page.Show() ' finally, show it inside
    End Sub

    Private Sub btnSettings_MouseEnter(sender As Object, e As EventArgs) Handles btnSettings.MouseEnter
        btnSettings.BackColor = Color.RoyalBlue
    End Sub

    Private Sub btnSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        btnSettings.BackColor = Color.DodgerBlue
    End Sub

    Private Sub btnPremium_Click(sender As Object, e As EventArgs) Handles btnPremium.Click
        pnlMainContent.Controls.Clear() ' Clear any existing controls

        Dim page As New frmPremiumPage() ' Create an instance 

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel

        pnlMainContent.Controls.Add(page) ' Add to the panel
        page.Show() ' finally, show it inside
    End Sub

    Private Sub btnPremium_MouseEnter(sender As Object, e As EventArgs) Handles btnPremium.MouseEnter
        btnPremium.BackColor = Color.RoyalBlue
    End Sub

    Private Sub btnPremium_MouseLeave(sender As Object, e As EventArgs) Handles btnPremium.MouseLeave
        btnPremium.BackColor = Color.DodgerBlue
    End Sub
    Private Sub LoadFormIntoPanel(childForm As Form)
        pnlMainContent.Controls.Clear()                         ' Clear existing controls
        childForm.TopLevel = False                            ' Set as non-top-level
        childForm.FormBorderStyle = FormBorderStyle.None      ' Remove border
        childForm.Dock = DockStyle.Fill                       ' Fill the panel
        pnlMainContent.Controls.Add(childForm)                  ' Add to panel
        childForm.Show()                                      ' Show the form
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormIntoPanel(New frmMainPage())  ' Load frmMainPage by default
    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        pnlMainContent.Controls.Clear() ' Clear any existing controls

        Dim page As New frmAboutPage() ' Create an instance 

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel

        pnlMainContent.Controls.Add(page) ' Add to the panel
        page.Show() ' finally, show it inside
    End Sub
End Class
Public Class frmAdminPanel
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        pnlAdminPage.Controls.Clear() ' Clear any existing controls

        Dim page As New frmAdminSettings() ' Create an instance of frmMainPage

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel

        pnlAdminPage.Controls.Add(page) ' Add to the panel
        page.Show() ' finally, show it inside
    End Sub

    Private Sub btnTabControl_Click(sender As Object, e As EventArgs) Handles btnTabControl.Click


        pnlAdminPage.Controls.Clear() ' Clear any existing controls

        Dim page As New frmTabControl() ' Create an instance of frmMainPage

        page.TopLevel = False ' Remove the border and set TopLevel to false
        page.FormBorderStyle = FormBorderStyle.None
        page.Dock = DockStyle.Fill ' Make it expand to fit the panel

        pnlAdminPage.Controls.Add(page) ' Add to the panel
        page.Show() ' finally, show it inside
    End Sub

End Class
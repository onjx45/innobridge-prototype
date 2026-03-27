Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#1f77f2")
        ' Set form style
        Me.FormBorderStyle = FormBorderStyle.None
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Set and start the timer
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() ' ✅ Stop only here, not restart
        Me.Hide()
        frmLoginPage.Show()
    End Sub
End Class


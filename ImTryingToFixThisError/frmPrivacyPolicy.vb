Public Class frmPrivacyPolicy
    Private sourceForm As Form
    Public Sub SetSourceForm(form As Form)
        sourceForm = form
    End Sub

    Private Sub btnPPok_Click(sender As Object, e As EventArgs) Handles btnPPok.Click
        If sourceForm IsNot Nothing AndAlso Not sourceForm.IsDisposed Then
            sourceForm.Show()
        End If
        Me.Close()
    End Sub
End Class
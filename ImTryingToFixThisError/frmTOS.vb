Public Class frmTOS
    Private sourceForm As Form

    ' Setter for source
    Public Sub SetSourceForm(form As Form)
        sourceForm = form
    End Sub

    Private Sub btnTOSok_Click(sender As Object, e As EventArgs) Handles btnTOSok.Click
        If Not sourceForm Is Nothing Then
            sourceForm.Show()
        End If
        Me.Close()
    End Sub
End Class
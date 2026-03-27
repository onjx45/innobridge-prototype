Public Class frmPremiumPage
    Private Sub btnRedeemNow_Click(sender As Object, e As EventArgs) Handles btnRedeemNow.Click
        Dim paymentForm As New frmPaymentPage()
        paymentForm.Show() ' Use Show() to open the form without hiding the current one
    End Sub
End Class
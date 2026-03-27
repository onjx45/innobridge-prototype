Imports System.Data.OleDb
Public Class frmPaymentPage

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ahmad\source\repos\ImTryingToFixThisError\ImTryingToFixThisError\bin\Debug\InnoBridgeDatabase.accdb") ' Connecting to the database

    Private Sub frmPaymentPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCardNumber.MaxLength = 19 ' Set the maximum length inside the Card Number text box
        txtCVV.MaxLength = 3 ' Set the maximum length inside the CVV textbox
    End Sub

    Private Sub btnPayNow_MouseEnter(sender As Object, e As EventArgs) Handles btnPayNow.MouseEnter
        btnPayNow.BackColor = Color.Snow ' Change the color font of the button oppositely
        btnPayNow.ForeColor = Color.DarkGoldenrod ' Change the Backcolor of the button oppositely
    End Sub

    Private Sub btnPayNow_MouseLeave(sender As Object, e As EventArgs) Handles btnPayNow.MouseLeave
        btnPayNow.BackColor = Color.DarkGoldenrod ' So that the button will return in default color
        btnPayNow.ForeColor = Color.Snow ' So that the button font will return in default color
    End Sub

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        Try
            ' Input validation
            If String.IsNullOrWhiteSpace(txtNameOnCard.Text) OrElse
                String.IsNullOrWhiteSpace(txtCardNumber.Text) Then
                MessageBox.Show("Please fill in all required fields before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Try
            End If

            con.Open()

            ' Get current date and last 4 digits of card number
            Dim currentUserID As String = txtNameOnCard.Text
            Dim purchaseDate As Date = Date.Now
            Dim price As Double = 9.99
            Dim plan As String = "Monthly (First Month 50% Off)" ' Indicate the plan that they user purchased
            Dim cardNumber As String = txtCardNumber.Text ' set that cardNumber as textBox
            Dim last4 As String = cardNumber.Substring(cardNumber.Length - 4) ' takes the number form 12 and above (the last 4 digits character)

            ' Storing to the database
            Dim cmd As New OleDbCommand("INSERT INTO tblPremiumPurchases ([UserID], [PurchaseDate], [Price], [Plan], [CardLast4]) VALUES (?, ?, ?, ?, ?)", con)

            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = currentUserID
            cmd.Parameters.Add("?", OleDbType.Date).Value = purchaseDate
            cmd.Parameters.Add("?", OleDbType.Currency).Value = price
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = plan
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = last4

            cmd.ExecuteNonQuery()
            MessageBox.Show("Purchase saved successfully!") ' Pop ups show up to notify the user the purchases
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to cancel the payment?", "Input Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub pnlPaymentDetails_Paint(sender As Object, e As PaintEventArgs) Handles pnlPaymentDetails.Paint
        txtCardNumber.Text = "123 4567 8901 2345"
        txtCardNumber.ForeColor = Color.Gray
        txtCVV.Text = "123"
        txtCVV.ForeColor = Color.Gray
        txtNameOnCard.Text = "Your Name"
        txtNameOnCard.ForeColor = Color.Gray
    End Sub

    Private Sub txtCardNumber_MouseEnter(sender As Object, e As EventArgs) Handles txtCardNumber.MouseEnter
        If txtCardNumber.Text = "123 4567 8901 2345" Then
            txtCardNumber.Text = ""
            txtCardNumber.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCardNumber_MouseLeave(sender As Object, e As EventArgs) Handles txtCardNumber.MouseLeave
        If txtCardNumber.Text.Trim() = "" Then 'Only resets if empty
            txtCardNumber.Text = "123 4567 8901 2345"
            txtCardNumber.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtCVV_MouseEnter(sender As Object, e As EventArgs) Handles txtCVV.MouseEnter
        If txtCVV.Text = "123" Then
            txtCVV.Text = ""
            txtCVV.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCVV_MouseLeave(sender As Object, e As EventArgs) Handles txtCVV.MouseLeave
        If txtCVV.Text.Trim() = "" Then 'Only resets if empty
            txtCVV.Text = "123"
            txtCVV.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtNameOnCard_MouseEnter(sender As Object, e As EventArgs) Handles txtNameOnCard.MouseEnter
        If txtNameOnCard.Text = "Your Name" Then
            txtNameOnCard.Text = ""
            txtNameOnCard.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtNameOnCard_MouseLeave(sender As Object, e As EventArgs) Handles txtNameOnCard.MouseLeave
        If txtNameOnCard.Text.Trim() = "" Then 'Only resets if empty
            txtNameOnCard.Text = "Your Name"
            txtNameOnCard.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtCardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then ' Only allow numbers and backspace
            e.Handled = True ' Block the key if it is not numbers
        End If
    End Sub

    Private Sub txtCVV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCVV.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then ' Only allow numbers and backspace
            e.Handled = True  ' Block the key if it is not numbers
        End If
    End Sub


End Class
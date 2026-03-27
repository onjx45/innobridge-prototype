<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlPurchaseTab = New System.Windows.Forms.Panel()
        Me.lblTotalText = New System.Windows.Forms.Label()
        Me.lblPriceText = New System.Windows.Forms.Label()
        Me.lblPlanText = New System.Windows.Forms.Label()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.lblPriceTitle = New System.Windows.Forms.Label()
        Me.lblPlanTitle = New System.Windows.Forms.Label()
        Me.lblPaymentDetails = New System.Windows.Forms.Label()
        Me.pnlPaymentDetails = New System.Windows.Forms.Panel()
        Me.lblTotalDesc = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPayNow = New System.Windows.Forms.Button()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.txtNameOnCard = New System.Windows.Forms.TextBox()
        Me.lblNameOnCard = New System.Windows.Forms.Label()
        Me.pnlPurchaseTab.SuspendLayout()
        Me.pnlPaymentDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(159, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(303, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Complete Your Premium Purchase"
        '
        'pnlPurchaseTab
        '
        Me.pnlPurchaseTab.BackColor = System.Drawing.Color.Snow
        Me.pnlPurchaseTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPurchaseTab.Controls.Add(Me.lblTotalText)
        Me.pnlPurchaseTab.Controls.Add(Me.lblPriceText)
        Me.pnlPurchaseTab.Controls.Add(Me.lblPlanText)
        Me.pnlPurchaseTab.Controls.Add(Me.lblTotalTitle)
        Me.pnlPurchaseTab.Controls.Add(Me.lblPriceTitle)
        Me.pnlPurchaseTab.Controls.Add(Me.lblPlanTitle)
        Me.pnlPurchaseTab.Location = New System.Drawing.Point(176, 63)
        Me.pnlPurchaseTab.Name = "pnlPurchaseTab"
        Me.pnlPurchaseTab.Size = New System.Drawing.Size(269, 100)
        Me.pnlPurchaseTab.TabIndex = 1
        '
        'lblTotalText
        '
        Me.lblTotalText.AutoSize = True
        Me.lblTotalText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalText.Location = New System.Drawing.Point(81, 66)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(128, 13)
        Me.lblTotalText.TabIndex = 5
        Me.lblTotalText.Text = "MYR 9.99 (First Month)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPriceText
        '
        Me.lblPriceText.AutoSize = True
        Me.lblPriceText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceText.Location = New System.Drawing.Point(81, 40)
        Me.lblPriceText.Name = "lblPriceText"
        Me.lblPriceText.Size = New System.Drawing.Size(129, 13)
        Me.lblPriceText.TabIndex = 4
        Me.lblPriceText.Text = "50% Off on First Month" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPlanText
        '
        Me.lblPlanText.AutoSize = True
        Me.lblPlanText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanText.Location = New System.Drawing.Point(81, 14)
        Me.lblPlanText.Name = "lblPlanText"
        Me.lblPlanText.Size = New System.Drawing.Size(102, 13)
        Me.lblPlanText.TabIndex = 3
        Me.lblPlanText.Text = "Premium Monthly"
        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.AutoSize = True
        Me.lblTotalTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTitle.Location = New System.Drawing.Point(28, 66)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(35, 13)
        Me.lblTotalTitle.TabIndex = 2
        Me.lblTotalTitle.Text = "Total:"
        '
        'lblPriceTitle
        '
        Me.lblPriceTitle.AutoSize = True
        Me.lblPriceTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceTitle.Location = New System.Drawing.Point(28, 40)
        Me.lblPriceTitle.Name = "lblPriceTitle"
        Me.lblPriceTitle.Size = New System.Drawing.Size(34, 13)
        Me.lblPriceTitle.TabIndex = 1
        Me.lblPriceTitle.Text = "Price:"
        '
        'lblPlanTitle
        '
        Me.lblPlanTitle.AutoSize = True
        Me.lblPlanTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanTitle.Location = New System.Drawing.Point(28, 14)
        Me.lblPlanTitle.Name = "lblPlanTitle"
        Me.lblPlanTitle.Size = New System.Drawing.Size(31, 13)
        Me.lblPlanTitle.TabIndex = 0
        Me.lblPlanTitle.Text = "Plan:"
        '
        'lblPaymentDetails
        '
        Me.lblPaymentDetails.AutoSize = True
        Me.lblPaymentDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentDetails.Location = New System.Drawing.Point(143, 185)
        Me.lblPaymentDetails.Name = "lblPaymentDetails"
        Me.lblPaymentDetails.Size = New System.Drawing.Size(109, 17)
        Me.lblPaymentDetails.TabIndex = 6
        Me.lblPaymentDetails.Text = "Payment Details"
        '
        'pnlPaymentDetails
        '
        Me.pnlPaymentDetails.BackColor = System.Drawing.Color.Snow
        Me.pnlPaymentDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPaymentDetails.Controls.Add(Me.lblTotalDesc)
        Me.pnlPaymentDetails.Controls.Add(Me.btnCancel)
        Me.pnlPaymentDetails.Controls.Add(Me.btnPayNow)
        Me.pnlPaymentDetails.Controls.Add(Me.txtCVV)
        Me.pnlPaymentDetails.Controls.Add(Me.lblCVV)
        Me.pnlPaymentDetails.Controls.Add(Me.txtCardNumber)
        Me.pnlPaymentDetails.Controls.Add(Me.lblCardNumber)
        Me.pnlPaymentDetails.Controls.Add(Me.txtNameOnCard)
        Me.pnlPaymentDetails.Controls.Add(Me.lblNameOnCard)
        Me.pnlPaymentDetails.Location = New System.Drawing.Point(146, 207)
        Me.pnlPaymentDetails.Name = "pnlPaymentDetails"
        Me.pnlPaymentDetails.Size = New System.Drawing.Size(339, 150)
        Me.pnlPaymentDetails.TabIndex = 7
        '
        'lblTotalDesc
        '
        Me.lblTotalDesc.AutoSize = True
        Me.lblTotalDesc.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDesc.Location = New System.Drawing.Point(183, 135)
        Me.lblTotalDesc.Name = "lblTotalDesc"
        Me.lblTotalDesc.Size = New System.Drawing.Size(131, 11)
        Me.lblTotalDesc.TabIndex = 6
        Me.lblTotalDesc.Text = "*then RM 19.99 after the First Month"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SeaShell
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCancel.Location = New System.Drawing.Point(17, 112)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(58, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPayNow
        '
        Me.btnPayNow.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnPayNow.FlatAppearance.BorderSize = 0
        Me.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayNow.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayNow.ForeColor = System.Drawing.Color.White
        Me.btnPayNow.Location = New System.Drawing.Point(177, 112)
        Me.btnPayNow.Name = "btnPayNow"
        Me.btnPayNow.Size = New System.Drawing.Size(145, 23)
        Me.btnPayNow.TabIndex = 12
        Me.btnPayNow.Text = "Pay Now - RM 9.99"
        Me.btnPayNow.UseVisualStyleBackColor = False
        '
        'txtCVV
        '
        Me.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCVV.Location = New System.Drawing.Point(226, 70)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(96, 20)
        Me.txtCVV.TabIndex = 11
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVV.Location = New System.Drawing.Point(225, 54)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(28, 13)
        Me.lblCVV.TabIndex = 10
        Me.lblCVV.Text = "CVV"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardNumber.Location = New System.Drawing.Point(17, 70)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(186, 20)
        Me.txtCardNumber.TabIndex = 9
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.Location = New System.Drawing.Point(16, 54)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(75, 13)
        Me.lblCardNumber.TabIndex = 8
        Me.lblCardNumber.Text = "Card Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNameOnCard
        '
        Me.txtNameOnCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNameOnCard.Location = New System.Drawing.Point(17, 26)
        Me.txtNameOnCard.Name = "txtNameOnCard"
        Me.txtNameOnCard.Size = New System.Drawing.Size(304, 20)
        Me.txtNameOnCard.TabIndex = 7
        '
        'lblNameOnCard
        '
        Me.lblNameOnCard.AutoSize = True
        Me.lblNameOnCard.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOnCard.Location = New System.Drawing.Point(16, 10)
        Me.lblNameOnCard.Name = "lblNameOnCard"
        Me.lblNameOnCard.Size = New System.Drawing.Size(80, 13)
        Me.lblNameOnCard.TabIndex = 6
        Me.lblNameOnCard.Text = "Name on Card"
        '
        'frmPaymentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(624, 381)
        Me.Controls.Add(Me.pnlPaymentDetails)
        Me.Controls.Add(Me.lblPaymentDetails)
        Me.Controls.Add(Me.pnlPurchaseTab)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmPaymentPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPaymentPage"
        Me.pnlPurchaseTab.ResumeLayout(False)
        Me.pnlPurchaseTab.PerformLayout()
        Me.pnlPaymentDetails.ResumeLayout(False)
        Me.pnlPaymentDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlPurchaseTab As Panel
    Friend WithEvents lblTotalText As Label
    Friend WithEvents lblPriceText As Label
    Friend WithEvents lblPlanText As Label
    Friend WithEvents lblTotalTitle As Label
    Friend WithEvents lblPriceTitle As Label
    Friend WithEvents lblPlanTitle As Label
    Friend WithEvents lblPaymentDetails As Label
    Friend WithEvents pnlPaymentDetails As Panel
    Friend WithEvents txtNameOnCard As TextBox
    Friend WithEvents lblNameOnCard As Label
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents lblCVV As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents btnPayNow As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTotalDesc As Label
End Class

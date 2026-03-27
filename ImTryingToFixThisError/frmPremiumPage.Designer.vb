<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPremiumPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPremiumPage))
        Me.pnlProfilePage = New System.Windows.Forms.Panel()
        Me.lblPremiumTitle = New System.Windows.Forms.Label()
        Me.pnlSidebarMark = New System.Windows.Forms.Panel()
        Me.pnlPremiumBenefits = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRedeemNow = New System.Windows.Forms.Button()
        Me.pnlProfilePage.SuspendLayout()
        Me.pnlPremiumBenefits.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlProfilePage
        '
        Me.pnlProfilePage.BackColor = System.Drawing.Color.White
        Me.pnlProfilePage.Controls.Add(Me.Label1)
        Me.pnlProfilePage.Controls.Add(Me.pnlPremiumBenefits)
        Me.pnlProfilePage.Controls.Add(Me.lblPremiumTitle)
        Me.pnlProfilePage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlProfilePage.Location = New System.Drawing.Point(103, -2)
        Me.pnlProfilePage.Name = "pnlProfilePage"
        Me.pnlProfilePage.Size = New System.Drawing.Size(616, 426)
        Me.pnlProfilePage.TabIndex = 22
        '
        'lblPremiumTitle
        '
        Me.lblPremiumTitle.BackColor = System.Drawing.Color.White
        Me.lblPremiumTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremiumTitle.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblPremiumTitle.Location = New System.Drawing.Point(247, 25)
        Me.lblPremiumTitle.Name = "lblPremiumTitle"
        Me.lblPremiumTitle.Size = New System.Drawing.Size(125, 32)
        Me.lblPremiumTitle.TabIndex = 3
        Me.lblPremiumTitle.Text = "Premium"
        '
        'pnlSidebarMark
        '
        Me.pnlSidebarMark.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSidebarMark.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebarMark.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebarMark.Name = "pnlSidebarMark"
        Me.pnlSidebarMark.Size = New System.Drawing.Size(109, 422)
        Me.pnlSidebarMark.TabIndex = 24
        '
        'pnlPremiumBenefits
        '
        Me.pnlPremiumBenefits.BackColor = System.Drawing.Color.FloralWhite
        Me.pnlPremiumBenefits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPremiumBenefits.Controls.Add(Me.btnRedeemNow)
        Me.pnlPremiumBenefits.Controls.Add(Me.Label2)
        Me.pnlPremiumBenefits.Location = New System.Drawing.Point(106, 92)
        Me.pnlPremiumBenefits.Name = "pnlPremiumBenefits"
        Me.pnlPremiumBenefits.Size = New System.Drawing.Size(415, 303)
        Me.pnlPremiumBenefits.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(106, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 32)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Get 50% Off Premium On Your First Purchase"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FloralWhite
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(17, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(385, 278)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'btnRedeemNow
        '
        Me.btnRedeemNow.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnRedeemNow.FlatAppearance.BorderSize = 0
        Me.btnRedeemNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRedeemNow.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedeemNow.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnRedeemNow.Location = New System.Drawing.Point(17, 267)
        Me.btnRedeemNow.Name = "btnRedeemNow"
        Me.btnRedeemNow.Size = New System.Drawing.Size(193, 27)
        Me.btnRedeemNow.TabIndex = 41
        Me.btnRedeemNow.Text = "Redeem Now - Only RM 9.99/mo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnRedeemNow.UseVisualStyleBackColor = False
        '
        'frmPremiumPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlSidebarMark)
        Me.Controls.Add(Me.pnlProfilePage)
        Me.Name = "frmPremiumPage"
        Me.Text = "frmPremiumPage"
        Me.pnlProfilePage.ResumeLayout(False)
        Me.pnlPremiumBenefits.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlProfilePage As Panel
    Friend WithEvents lblPremiumTitle As Label
    Friend WithEvents pnlSidebarMark As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlPremiumBenefits As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRedeemNow As Button
End Class

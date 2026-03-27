<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettingsPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlProfilePage = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblAccountSettings = New System.Windows.Forms.Label()
        Me.lblSettingsTitle = New System.Windows.Forms.Label()
        Me.pnlSidebarMark = New System.Windows.Forms.Panel()
        Me.pnlProfilePage.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlProfilePage
        '
        Me.pnlProfilePage.BackColor = System.Drawing.Color.White
        Me.pnlProfilePage.Controls.Add(Me.btnExit)
        Me.pnlProfilePage.Controls.Add(Me.btnLogout)
        Me.pnlProfilePage.Controls.Add(Me.lblAccountSettings)
        Me.pnlProfilePage.Controls.Add(Me.lblSettingsTitle)
        Me.pnlProfilePage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlProfilePage.ForeColor = System.Drawing.Color.Black
        Me.pnlProfilePage.Location = New System.Drawing.Point(104, -2)
        Me.pnlProfilePage.Name = "pnlProfilePage"
        Me.pnlProfilePage.Size = New System.Drawing.Size(616, 426)
        Me.pnlProfilePage.TabIndex = 22
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.IndianRed
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(242, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(153, 40)
        Me.btnExit.TabIndex = 38
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(48, 113)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(153, 40)
        Me.btnLogout.TabIndex = 37
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblAccountSettings
        '
        Me.lblAccountSettings.AutoSize = True
        Me.lblAccountSettings.BackColor = System.Drawing.Color.White
        Me.lblAccountSettings.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountSettings.ForeColor = System.Drawing.Color.Black
        Me.lblAccountSettings.Location = New System.Drawing.Point(44, 68)
        Me.lblAccountSettings.Name = "lblAccountSettings"
        Me.lblAccountSettings.Size = New System.Drawing.Size(128, 20)
        Me.lblAccountSettings.TabIndex = 20
        Me.lblAccountSettings.Text = "Account Settings"
        '
        'lblSettingsTitle
        '
        Me.lblSettingsTitle.BackColor = System.Drawing.Color.White
        Me.lblSettingsTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsTitle.ForeColor = System.Drawing.Color.Black
        Me.lblSettingsTitle.Location = New System.Drawing.Point(42, 32)
        Me.lblSettingsTitle.Name = "lblSettingsTitle"
        Me.lblSettingsTitle.Size = New System.Drawing.Size(112, 32)
        Me.lblSettingsTitle.TabIndex = 3
        Me.lblSettingsTitle.Text = "Settings"
        '
        'pnlSidebarMark
        '
        Me.pnlSidebarMark.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSidebarMark.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebarMark.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebarMark.Name = "pnlSidebarMark"
        Me.pnlSidebarMark.Size = New System.Drawing.Size(109, 422)
        Me.pnlSidebarMark.TabIndex = 23
        '
        'frmSettingsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlSidebarMark)
        Me.Controls.Add(Me.pnlProfilePage)
        Me.Name = "frmSettingsPage"
        Me.Text = "frmSettingsPage"
        Me.pnlProfilePage.ResumeLayout(False)
        Me.pnlProfilePage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlProfilePage As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblAccountSettings As Label
    Friend WithEvents lblSettingsTitle As Label
    Friend WithEvents pnlSidebarMark As Panel
    Friend WithEvents btnExit As Button
End Class

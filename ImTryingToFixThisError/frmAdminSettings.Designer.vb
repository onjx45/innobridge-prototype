<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminSettings
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
        Me.pnlAdminPanel = New System.Windows.Forms.Panel()
        Me.lblViewProfile = New System.Windows.Forms.Label()
        Me.lblVisibilitySettings = New System.Windows.Forms.Label()
        Me.lblProfilePreferences = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblAccountSettings = New System.Windows.Forms.Label()
        Me.lblSettingsTitle = New System.Windows.Forms.Label()
        Me.pnlSidebarMark = New System.Windows.Forms.Panel()
        Me.pnlAdminPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlAdminPanel
        '
        Me.pnlAdminPanel.BackColor = System.Drawing.Color.White
        Me.pnlAdminPanel.Controls.Add(Me.lblViewProfile)
        Me.pnlAdminPanel.Controls.Add(Me.lblVisibilitySettings)
        Me.pnlAdminPanel.Controls.Add(Me.lblProfilePreferences)
        Me.pnlAdminPanel.Controls.Add(Me.btnLogout)
        Me.pnlAdminPanel.Controls.Add(Me.lblAccountSettings)
        Me.pnlAdminPanel.Controls.Add(Me.lblSettingsTitle)
        Me.pnlAdminPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAdminPanel.ForeColor = System.Drawing.Color.Black
        Me.pnlAdminPanel.Location = New System.Drawing.Point(102, -2)
        Me.pnlAdminPanel.Name = "pnlAdminPanel"
        Me.pnlAdminPanel.Size = New System.Drawing.Size(616, 426)
        Me.pnlAdminPanel.TabIndex = 23
        '
        'lblViewProfile
        '
        Me.lblViewProfile.AutoSize = True
        Me.lblViewProfile.BackColor = System.Drawing.Color.White
        Me.lblViewProfile.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewProfile.ForeColor = System.Drawing.Color.Black
        Me.lblViewProfile.Location = New System.Drawing.Point(45, 216)
        Me.lblViewProfile.Name = "lblViewProfile"
        Me.lblViewProfile.Size = New System.Drawing.Size(151, 15)
        Me.lblViewProfile.TabIndex = 41
        Me.lblViewProfile.Text = "Who can view your profile?"
        '
        'lblVisibilitySettings
        '
        Me.lblVisibilitySettings.AutoSize = True
        Me.lblVisibilitySettings.BackColor = System.Drawing.Color.White
        Me.lblVisibilitySettings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisibilitySettings.ForeColor = System.Drawing.Color.Black
        Me.lblVisibilitySettings.Location = New System.Drawing.Point(45, 197)
        Me.lblVisibilitySettings.Name = "lblVisibilitySettings"
        Me.lblVisibilitySettings.Size = New System.Drawing.Size(102, 15)
        Me.lblVisibilitySettings.TabIndex = 40
        Me.lblVisibilitySettings.Text = "Visibility Settings"
        '
        'lblProfilePreferences
        '
        Me.lblProfilePreferences.AutoSize = True
        Me.lblProfilePreferences.BackColor = System.Drawing.Color.White
        Me.lblProfilePreferences.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfilePreferences.ForeColor = System.Drawing.Color.Black
        Me.lblProfilePreferences.Location = New System.Drawing.Point(44, 168)
        Me.lblProfilePreferences.Name = "lblProfilePreferences"
        Me.lblProfilePreferences.Size = New System.Drawing.Size(141, 20)
        Me.lblProfilePreferences.TabIndex = 39
        Me.lblProfilePreferences.Text = "Profile Preferences"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(48, 103)
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
        Me.pnlSidebarMark.TabIndex = 24
        '
        'frmAdminSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlSidebarMark)
        Me.Controls.Add(Me.pnlAdminPanel)
        Me.Name = "frmAdminSettings"
        Me.Text = "frmAdminSettings"
        Me.pnlAdminPanel.ResumeLayout(False)
        Me.pnlAdminPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAdminPanel As Panel
    Friend WithEvents lblViewProfile As Label
    Friend WithEvents lblVisibilitySettings As Label
    Friend WithEvents lblProfilePreferences As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblAccountSettings As Label
    Friend WithEvents lblSettingsTitle As Label
    Friend WithEvents pnlSidebarMark As Panel
End Class

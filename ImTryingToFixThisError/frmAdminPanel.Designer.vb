<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminPanel
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnTabControl = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.pnlAdminPage = New System.Windows.Forms.Panel()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSidebar.Controls.Add(Me.lblAdmin)
        Me.pnlSidebar.Controls.Add(Me.picLogo)
        Me.pnlSidebar.Controls.Add(Me.btnTabControl)
        Me.pnlSidebar.Controls.Add(Me.btnSettings)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(109, 422)
        Me.pnlSidebar.TabIndex = 1
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = Global.ImTryingToFixThisError.My.Resources.Resources.Logo_2_For_Code
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogo.Location = New System.Drawing.Point(17, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(79, 77)
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'btnTabControl
        '
        Me.btnTabControl.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTabControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTabControl.FlatAppearance.BorderSize = 0
        Me.btnTabControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTabControl.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTabControl.ForeColor = System.Drawing.Color.White
        Me.btnTabControl.Location = New System.Drawing.Point(1, 117)
        Me.btnTabControl.Name = "btnTabControl"
        Me.btnTabControl.Size = New System.Drawing.Size(108, 43)
        Me.btnTabControl.TabIndex = 0
        Me.btnTabControl.Text = "Tab Control"
        Me.btnTabControl.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(1, 354)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(108, 37)
        Me.btnSettings.TabIndex = 6
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'pnlAdminPage
        '
        Me.pnlAdminPage.Location = New System.Drawing.Point(105, -1)
        Me.pnlAdminPage.Name = "pnlAdminPage"
        Me.pnlAdminPage.Size = New System.Drawing.Size(616, 426)
        Me.pnlAdminPage.TabIndex = 2
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.Color.White
        Me.lblAdmin.Location = New System.Drawing.Point(33, 83)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(43, 15)
        Me.lblAdmin.TabIndex = 7
        Me.lblAdmin.Text = "Admin"
        '
        'frmAdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlAdminPage)
        Me.Name = "frmAdminPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdminPanel"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnTabControl As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents pnlAdminPage As Panel
    Friend WithEvents lblAdmin As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnPostProject = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnBrowseProblems = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnPremium = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(1, 95)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(108, 43)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnPostProject
        '
        Me.btnPostProject.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnPostProject.FlatAppearance.BorderSize = 0
        Me.btnPostProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPostProject.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostProject.ForeColor = System.Drawing.Color.White
        Me.btnPostProject.Location = New System.Drawing.Point(1, 144)
        Me.btnPostProject.Name = "btnPostProject"
        Me.btnPostProject.Size = New System.Drawing.Size(108, 43)
        Me.btnPostProject.TabIndex = 1
        Me.btnPostProject.Text = "Post Project"
        Me.btnPostProject.UseVisualStyleBackColor = False
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnConnect.FlatAppearance.BorderSize = 0
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnect.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.Color.White
        Me.btnConnect.Location = New System.Drawing.Point(1, 193)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(108, 43)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'btnBrowseProblems
        '
        Me.btnBrowseProblems.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBrowseProblems.FlatAppearance.BorderSize = 0
        Me.btnBrowseProblems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseProblems.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseProblems.ForeColor = System.Drawing.Color.White
        Me.btnBrowseProblems.Location = New System.Drawing.Point(1, 242)
        Me.btnBrowseProblems.Name = "btnBrowseProblems"
        Me.btnBrowseProblems.Size = New System.Drawing.Size(108, 43)
        Me.btnBrowseProblems.TabIndex = 3
        Me.btnBrowseProblems.Text = "  Browse " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Problems"
        Me.btnBrowseProblems.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Location = New System.Drawing.Point(1, 291)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(108, 43)
        Me.btnProfile.TabIndex = 4
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnPremium
        '
        Me.btnPremium.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnPremium.FlatAppearance.BorderSize = 0
        Me.btnPremium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPremium.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPremium.ForeColor = System.Drawing.Color.White
        Me.btnPremium.Location = New System.Drawing.Point(1, 340)
        Me.btnPremium.Name = "btnPremium"
        Me.btnPremium.Size = New System.Drawing.Size(108, 35)
        Me.btnPremium.TabIndex = 5
        Me.btnPremium.Text = "Premium"
        Me.btnPremium.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(1, 379)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(108, 37)
        Me.btnSettings.TabIndex = 6
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'pnlMainContent
        '
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(734, 422)
        Me.pnlMainContent.TabIndex = 7
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSidebar.Controls.Add(Me.picLogo)
        Me.pnlSidebar.Controls.Add(Me.btnHome)
        Me.pnlSidebar.Controls.Add(Me.btnSettings)
        Me.pnlSidebar.Controls.Add(Me.btnBrowseProblems)
        Me.pnlSidebar.Controls.Add(Me.btnPremium)
        Me.pnlSidebar.Controls.Add(Me.btnConnect)
        Me.pnlSidebar.Controls.Add(Me.btnPostProject)
        Me.pnlSidebar.Controls.Add(Me.btnProfile)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(109, 422)
        Me.pnlSidebar.TabIndex = 0
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
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ImTryingToFixThisError.My.Resources.Resources.Main_Menu__Home_Page___Copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 422)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlMainContent)
        Me.DoubleBuffered = True
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainMenu"
        Me.pnlSidebar.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents btnPostProject As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnBrowseProblems As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnPremium As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents picLogo As PictureBox
End Class

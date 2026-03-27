<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainPage
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblWelcomeDesc = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.pnlAnnouncement = New System.Windows.Forms.Panel()
        Me.ldadad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAnnouncement1 = New System.Windows.Forms.Label()
        Me.lblAnnouncement = New System.Windows.Forms.Label()
        Me.pnlLayerMP = New System.Windows.Forms.Panel()
        Me.picAnnouncementMP = New System.Windows.Forms.PictureBox()
        Me.pnlMainPageLayout = New System.Windows.Forms.Panel()
        Me.pnlSidebarMark = New System.Windows.Forms.Panel()
        Me.pnlAnnouncement.SuspendLayout()
        Me.pnlLayerMP.SuspendLayout()
        CType(Me.picAnnouncementMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMainPageLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.White
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblWelcome.Location = New System.Drawing.Point(48, 20)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(335, 73)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "Welcome To InnoBridge, User!"
        '
        'lblWelcomeDesc
        '
        Me.lblWelcomeDesc.AutoSize = True
        Me.lblWelcomeDesc.BackColor = System.Drawing.Color.White
        Me.lblWelcomeDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeDesc.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblWelcomeDesc.Location = New System.Drawing.Point(52, 93)
        Me.lblWelcomeDesc.Name = "lblWelcomeDesc"
        Me.lblWelcomeDesc.Size = New System.Drawing.Size(331, 45)
        Me.lblWelcomeDesc.TabIndex = 3
        Me.lblWelcomeDesc.Text = "Discover real-world projects, connect with industry partners, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and grow your ski" &
    "lls through innovation-driven challenges, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all in one place." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.White
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDate.Location = New System.Drawing.Point(450, 93)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(128, 25)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "23 June 2025"
        '
        'pnlAnnouncement
        '
        Me.pnlAnnouncement.BackColor = System.Drawing.Color.White
        Me.pnlAnnouncement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAnnouncement.Controls.Add(Me.ldadad)
        Me.pnlAnnouncement.Controls.Add(Me.Label1)
        Me.pnlAnnouncement.Controls.Add(Me.lblAnnouncement1)
        Me.pnlAnnouncement.Location = New System.Drawing.Point(515, 178)
        Me.pnlAnnouncement.Name = "pnlAnnouncement"
        Me.pnlAnnouncement.Size = New System.Drawing.Size(168, 219)
        Me.pnlAnnouncement.TabIndex = 13
        '
        'ldadad
        '
        Me.ldadad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ldadad.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ldadad.Location = New System.Drawing.Point(3, 114)
        Me.ldadad.Name = "ldadad"
        Me.ldadad.Size = New System.Drawing.Size(158, 35)
        Me.ldadad.TabIndex = 2
        Me.ldadad.Text = "• Check out our July " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   hackathon 🔥" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(3, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "• New partnership with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   TechX Co.!"
        '
        'lblAnnouncement1
        '
        Me.lblAnnouncement1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnouncement1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAnnouncement1.Location = New System.Drawing.Point(7, 13)
        Me.lblAnnouncement1.Name = "lblAnnouncement1"
        Me.lblAnnouncement1.Size = New System.Drawing.Size(158, 35)
        Me.lblAnnouncement1.TabIndex = 0
        Me.lblAnnouncement1.Text = "• Server maintenance on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   24 June, 12 AM - 3 AM"
        '
        'lblAnnouncement
        '
        Me.lblAnnouncement.AutoSize = True
        Me.lblAnnouncement.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnouncement.ForeColor = System.Drawing.Color.Navy
        Me.lblAnnouncement.Location = New System.Drawing.Point(38, 5)
        Me.lblAnnouncement.Name = "lblAnnouncement"
        Me.lblAnnouncement.Size = New System.Drawing.Size(93, 15)
        Me.lblAnnouncement.TabIndex = 0
        Me.lblAnnouncement.Text = "Announcement"
        '
        'pnlLayerMP
        '
        Me.pnlLayerMP.BackColor = System.Drawing.Color.White
        Me.pnlLayerMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLayerMP.Controls.Add(Me.picAnnouncementMP)
        Me.pnlLayerMP.Controls.Add(Me.lblAnnouncement)
        Me.pnlLayerMP.Location = New System.Drawing.Point(515, 153)
        Me.pnlLayerMP.Name = "pnlLayerMP"
        Me.pnlLayerMP.Size = New System.Drawing.Size(168, 26)
        Me.pnlLayerMP.TabIndex = 14
        '
        'picAnnouncementMP
        '
        Me.picAnnouncementMP.BackgroundImage = Global.ImTryingToFixThisError.My.Resources.Resources.rocket_icon
        Me.picAnnouncementMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAnnouncementMP.Location = New System.Drawing.Point(3, -1)
        Me.picAnnouncementMP.Name = "picAnnouncementMP"
        Me.picAnnouncementMP.Size = New System.Drawing.Size(36, 30)
        Me.picAnnouncementMP.TabIndex = 15
        Me.picAnnouncementMP.TabStop = False
        '
        'pnlMainPageLayout
        '
        Me.pnlMainPageLayout.BackColor = System.Drawing.Color.White
        Me.pnlMainPageLayout.Controls.Add(Me.lblDate)
        Me.pnlMainPageLayout.Controls.Add(Me.lblWelcome)
        Me.pnlMainPageLayout.Controls.Add(Me.lblWelcomeDesc)
        Me.pnlMainPageLayout.Location = New System.Drawing.Point(105, -1)
        Me.pnlMainPageLayout.Name = "pnlMainPageLayout"
        Me.pnlMainPageLayout.Size = New System.Drawing.Size(616, 426)
        Me.pnlMainPageLayout.TabIndex = 15
        '
        'pnlSidebarMark
        '
        Me.pnlSidebarMark.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSidebarMark.Location = New System.Drawing.Point(0, -1)
        Me.pnlSidebarMark.Name = "pnlSidebarMark"
        Me.pnlSidebarMark.Size = New System.Drawing.Size(109, 423)
        Me.pnlSidebarMark.TabIndex = 0
        '
        'frmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlSidebarMark)
        Me.Controls.Add(Me.pnlLayerMP)
        Me.Controls.Add(Me.pnlAnnouncement)
        Me.Controls.Add(Me.pnlMainPageLayout)
        Me.Name = "frmMainPage"
        Me.Text = "frmMainPage"
        Me.pnlAnnouncement.ResumeLayout(False)
        Me.pnlLayerMP.ResumeLayout(False)
        Me.pnlLayerMP.PerformLayout()
        CType(Me.picAnnouncementMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMainPageLayout.ResumeLayout(False)
        Me.pnlMainPageLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblWelcomeDesc As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents pnlAnnouncement As Panel
    Friend WithEvents lblAnnouncement As Label
    Friend WithEvents pnlLayerMP As Panel
    Friend WithEvents picAnnouncementMP As PictureBox
    Friend WithEvents pnlMainPageLayout As Panel
    Friend WithEvents pnlSidebarMark As Panel
    Friend WithEvents ldadad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAnnouncement1 As Label
End Class

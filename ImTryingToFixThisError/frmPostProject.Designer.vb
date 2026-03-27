<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostProject
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
        Me.pnlPostProject = New System.Windows.Forms.Panel()
        Me.btnProjectFeed = New System.Windows.Forms.Button()
        Me.pnlPostingTips = New System.Windows.Forms.Panel()
        Me.lblTipCategory = New System.Windows.Forms.Label()
        Me.lblTipNaming = New System.Windows.Forms.Label()
        Me.lblTipClearTitle = New System.Windows.Forms.Label()
        Me.lblTipsTitle = New System.Windows.Forms.Label()
        Me.btnPostProject = New System.Windows.Forms.Button()
        Me.lblWelcomeTitle = New System.Windows.Forms.Label()
        Me.pnlSidebarMark = New System.Windows.Forms.Panel()
        Me.picTipIcon = New System.Windows.Forms.PictureBox()
        Me.pnlPostProject.SuspendLayout()
        Me.pnlPostingTips.SuspendLayout()
        CType(Me.picTipIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPostProject
        '
        Me.pnlPostProject.BackColor = System.Drawing.Color.White
        Me.pnlPostProject.Controls.Add(Me.btnProjectFeed)
        Me.pnlPostProject.Controls.Add(Me.pnlPostingTips)
        Me.pnlPostProject.Controls.Add(Me.btnPostProject)
        Me.pnlPostProject.Controls.Add(Me.lblWelcomeTitle)
        Me.pnlPostProject.Location = New System.Drawing.Point(102, -1)
        Me.pnlPostProject.Name = "pnlPostProject"
        Me.pnlPostProject.Size = New System.Drawing.Size(616, 426)
        Me.pnlPostProject.TabIndex = 16
        '
        'btnProjectFeed
        '
        Me.btnProjectFeed.BackColor = System.Drawing.Color.AliceBlue
        Me.btnProjectFeed.FlatAppearance.BorderSize = 0
        Me.btnProjectFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProjectFeed.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjectFeed.ForeColor = System.Drawing.Color.Navy
        Me.btnProjectFeed.Location = New System.Drawing.Point(221, 101)
        Me.btnProjectFeed.Name = "btnProjectFeed"
        Me.btnProjectFeed.Size = New System.Drawing.Size(136, 62)
        Me.btnProjectFeed.TabIndex = 17
        Me.btnProjectFeed.Text = "Project Feed"
        Me.btnProjectFeed.UseVisualStyleBackColor = False
        '
        'pnlPostingTips
        '
        Me.pnlPostingTips.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlPostingTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPostingTips.Controls.Add(Me.picTipIcon)
        Me.pnlPostingTips.Controls.Add(Me.lblTipCategory)
        Me.pnlPostingTips.Controls.Add(Me.lblTipNaming)
        Me.pnlPostingTips.Controls.Add(Me.lblTipClearTitle)
        Me.pnlPostingTips.Controls.Add(Me.lblTipsTitle)
        Me.pnlPostingTips.Location = New System.Drawing.Point(51, 293)
        Me.pnlPostingTips.Name = "pnlPostingTips"
        Me.pnlPostingTips.Size = New System.Drawing.Size(350, 90)
        Me.pnlPostingTips.TabIndex = 12
        '
        'lblTipCategory
        '
        Me.lblTipCategory.AutoSize = True
        Me.lblTipCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipCategory.Location = New System.Drawing.Point(178, 36)
        Me.lblTipCategory.Name = "lblTipCategory"
        Me.lblTipCategory.Size = New System.Drawing.Size(143, 15)
        Me.lblTipCategory.TabIndex = 3
        Me.lblTipCategory.Text = "- Select the right category"
        '
        'lblTipNaming
        '
        Me.lblTipNaming.AutoSize = True
        Me.lblTipNaming.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipNaming.Location = New System.Drawing.Point(34, 58)
        Me.lblTipNaming.Name = "lblTipNaming"
        Me.lblTipNaming.Size = New System.Drawing.Size(138, 15)
        Me.lblTipNaming.TabIndex = 2
        Me.lblTipNaming.Text = "- Use appropiate naming"
        '
        'lblTipClearTitle
        '
        Me.lblTipClearTitle.AutoSize = True
        Me.lblTipClearTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipClearTitle.Location = New System.Drawing.Point(35, 36)
        Me.lblTipClearTitle.Name = "lblTipClearTitle"
        Me.lblTipClearTitle.Size = New System.Drawing.Size(90, 15)
        Me.lblTipClearTitle.TabIndex = 1
        Me.lblTipClearTitle.Text = "- Use clear titles"
        '
        'lblTipsTitle
        '
        Me.lblTipsTitle.AutoSize = True
        Me.lblTipsTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipsTitle.Location = New System.Drawing.Point(33, 5)
        Me.lblTipsTitle.Name = "lblTipsTitle"
        Me.lblTipsTitle.Size = New System.Drawing.Size(130, 21)
        Me.lblTipsTitle.TabIndex = 0
        Me.lblTipsTitle.Text = "Tips for posting:"
        '
        'btnPostProject
        '
        Me.btnPostProject.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPostProject.FlatAppearance.BorderSize = 0
        Me.btnPostProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPostProject.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostProject.ForeColor = System.Drawing.Color.Navy
        Me.btnPostProject.Location = New System.Drawing.Point(51, 101)
        Me.btnPostProject.Name = "btnPostProject"
        Me.btnPostProject.Size = New System.Drawing.Size(136, 62)
        Me.btnPostProject.TabIndex = 7
        Me.btnPostProject.Text = "Post a Project"
        Me.btnPostProject.UseVisualStyleBackColor = False
        '
        'lblWelcomeTitle
        '
        Me.lblWelcomeTitle.BackColor = System.Drawing.Color.White
        Me.lblWelcomeTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblWelcomeTitle.Location = New System.Drawing.Point(45, 10)
        Me.lblWelcomeTitle.Name = "lblWelcomeTitle"
        Me.lblWelcomeTitle.Size = New System.Drawing.Size(437, 68)
        Me.lblWelcomeTitle.TabIndex = 3
        Me.lblWelcomeTitle.Text = "Hello User, What are you up to?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pnlSidebarMark
        '
        Me.pnlSidebarMark.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSidebarMark.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebarMark.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebarMark.Name = "pnlSidebarMark"
        Me.pnlSidebarMark.Size = New System.Drawing.Size(109, 422)
        Me.pnlSidebarMark.TabIndex = 17
        '
        'picTipIcon
        '
        Me.picTipIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTipIcon.Image = Global.ImTryingToFixThisError.My.Resources.Resources.information_icon
        Me.picTipIcon.Location = New System.Drawing.Point(10, 8)
        Me.picTipIcon.Name = "picTipIcon"
        Me.picTipIcon.Size = New System.Drawing.Size(18, 18)
        Me.picTipIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTipIcon.TabIndex = 4
        Me.picTipIcon.TabStop = False
        '
        'frmPostProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlSidebarMark)
        Me.Controls.Add(Me.pnlPostProject)
        Me.Name = "frmPostProject"
        Me.Text = "frmPostProject"
        Me.pnlPostProject.ResumeLayout(False)
        Me.pnlPostingTips.ResumeLayout(False)
        Me.pnlPostingTips.PerformLayout()
        CType(Me.picTipIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPostProject As Panel
    Friend WithEvents pnlSidebarMark As Panel
    Friend WithEvents lblWelcomeTitle As Label
    Friend WithEvents btnPostProject As Button
    Friend WithEvents pnlPostingTips As Panel
    Friend WithEvents picTipIcon As PictureBox
    Friend WithEvents lblTipCategory As Label
    Friend WithEvents lblTipNaming As Label
    Friend WithEvents lblTipClearTitle As Label
    Friend WithEvents lblTipsTitle As Label
    Friend WithEvents btnProjectFeed As Button
End Class

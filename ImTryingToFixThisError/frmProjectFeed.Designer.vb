<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectFeed
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnPostProject = New System.Windows.Forms.Button()
        Me.pnlFeed = New System.Windows.Forms.Panel()
        Me.pnlCard3 = New System.Windows.Forms.Panel()
        Me.btnCollaborate3 = New System.Windows.Forms.Button()
        Me.lblDesc3 = New System.Windows.Forms.Label()
        Me.lblDate3 = New System.Windows.Forms.Label()
        Me.lblTitle3 = New System.Windows.Forms.Label()
        Me.pnlCard2 = New System.Windows.Forms.Panel()
        Me.btnCollaborate2 = New System.Windows.Forms.Button()
        Me.lblDesc2 = New System.Windows.Forms.Label()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.pnlCard1 = New System.Windows.Forms.Panel()
        Me.btnCollaborate1 = New System.Windows.Forms.Button()
        Me.lblDesc1 = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlSidebarMark = New System.Windows.Forms.Panel()
        Me.picCard3 = New System.Windows.Forms.PictureBox()
        Me.picCard2 = New System.Windows.Forms.PictureBox()
        Me.picCard1 = New System.Windows.Forms.PictureBox()
        Me.pnlPostProject.SuspendLayout()
        Me.pnlFeed.SuspendLayout()
        Me.pnlCard3.SuspendLayout()
        Me.pnlCard2.SuspendLayout()
        Me.pnlCard1.SuspendLayout()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPostProject
        '
        Me.pnlPostProject.BackColor = System.Drawing.Color.White
        Me.pnlPostProject.Controls.Add(Me.btnRefresh)
        Me.pnlPostProject.Controls.Add(Me.btnNext)
        Me.pnlPostProject.Controls.Add(Me.lblPage)
        Me.pnlPostProject.Controls.Add(Me.btnPrevious)
        Me.pnlPostProject.Controls.Add(Me.btnPostProject)
        Me.pnlPostProject.Controls.Add(Me.pnlFeed)
        Me.pnlPostProject.Controls.Add(Me.btnBack)
        Me.pnlPostProject.Location = New System.Drawing.Point(103, -2)
        Me.pnlPostProject.Name = "pnlPostProject"
        Me.pnlPostProject.Size = New System.Drawing.Size(616, 426)
        Me.pnlPostProject.TabIndex = 17
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(129, 32)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(89, 32)
        Me.btnRefresh.TabIndex = 32
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(282, 388)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(41, 20)
        Me.btnNext.TabIndex = 31
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblPage
        '
        Me.lblPage.AutoSize = True
        Me.lblPage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPage.Location = New System.Drawing.Point(212, 390)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(64, 13)
        Me.lblPage.TabIndex = 30
        Me.lblPage.Text = "Page 1 of 3"
        '
        'btnPrevious
        '
        Me.btnPrevious.AutoSize = True
        Me.btnPrevious.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(163, 388)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(43, 20)
        Me.btnPrevious.TabIndex = 29
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnPostProject
        '
        Me.btnPostProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPostProject.Location = New System.Drawing.Point(359, 32)
        Me.btnPostProject.Name = "btnPostProject"
        Me.btnPostProject.Size = New System.Drawing.Size(99, 32)
        Me.btnPostProject.TabIndex = 2
        Me.btnPostProject.Text = "Post a Project"
        Me.btnPostProject.UseVisualStyleBackColor = True
        '
        'pnlFeed
        '
        Me.pnlFeed.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFeed.Controls.Add(Me.pnlCard3)
        Me.pnlFeed.Controls.Add(Me.pnlCard2)
        Me.pnlFeed.Controls.Add(Me.pnlCard1)
        Me.pnlFeed.Location = New System.Drawing.Point(34, 70)
        Me.pnlFeed.Name = "pnlFeed"
        Me.pnlFeed.Size = New System.Drawing.Size(424, 305)
        Me.pnlFeed.TabIndex = 1
        '
        'pnlCard3
        '
        Me.pnlCard3.BackColor = System.Drawing.Color.White
        Me.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard3.Controls.Add(Me.btnCollaborate3)
        Me.pnlCard3.Controls.Add(Me.lblDesc3)
        Me.pnlCard3.Controls.Add(Me.lblDate3)
        Me.pnlCard3.Controls.Add(Me.lblTitle3)
        Me.pnlCard3.Controls.Add(Me.picCard3)
        Me.pnlCard3.Location = New System.Drawing.Point(17, 200)
        Me.pnlCard3.Name = "pnlCard3"
        Me.pnlCard3.Size = New System.Drawing.Size(387, 88)
        Me.pnlCard3.TabIndex = 4
        '
        'btnCollaborate3
        '
        Me.btnCollaborate3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCollaborate3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollaborate3.Location = New System.Drawing.Point(306, 57)
        Me.btnCollaborate3.Name = "btnCollaborate3"
        Me.btnCollaborate3.Size = New System.Drawing.Size(76, 26)
        Me.btnCollaborate3.TabIndex = 35
        Me.btnCollaborate3.Text = "Collaborate"
        Me.btnCollaborate3.UseVisualStyleBackColor = True
        '
        'lblDesc3
        '
        Me.lblDesc3.Location = New System.Drawing.Point(83, 49)
        Me.lblDesc3.Name = "lblDesc3"
        Me.lblDesc3.Size = New System.Drawing.Size(217, 34)
        Me.lblDesc3.TabIndex = 3
        Me.lblDesc3.Text = "Label3"
        '
        'lblDate3
        '
        Me.lblDate3.Location = New System.Drawing.Point(83, 28)
        Me.lblDate3.Name = "lblDate3"
        Me.lblDate3.Size = New System.Drawing.Size(140, 13)
        Me.lblDate3.TabIndex = 2
        Me.lblDate3.Text = "Label2"
        '
        'lblTitle3
        '
        Me.lblTitle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle3.Location = New System.Drawing.Point(84, 7)
        Me.lblTitle3.Name = "lblTitle3"
        Me.lblTitle3.Size = New System.Drawing.Size(285, 19)
        Me.lblTitle3.TabIndex = 1
        Me.lblTitle3.Text = "Label1"
        '
        'pnlCard2
        '
        Me.pnlCard2.BackColor = System.Drawing.Color.White
        Me.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard2.Controls.Add(Me.btnCollaborate2)
        Me.pnlCard2.Controls.Add(Me.lblDesc2)
        Me.pnlCard2.Controls.Add(Me.lblDate2)
        Me.pnlCard2.Controls.Add(Me.lblTitle2)
        Me.pnlCard2.Controls.Add(Me.picCard2)
        Me.pnlCard2.Location = New System.Drawing.Point(17, 106)
        Me.pnlCard2.Name = "pnlCard2"
        Me.pnlCard2.Size = New System.Drawing.Size(387, 88)
        Me.pnlCard2.TabIndex = 5
        '
        'btnCollaborate2
        '
        Me.btnCollaborate2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCollaborate2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollaborate2.Location = New System.Drawing.Point(306, 57)
        Me.btnCollaborate2.Name = "btnCollaborate2"
        Me.btnCollaborate2.Size = New System.Drawing.Size(76, 26)
        Me.btnCollaborate2.TabIndex = 34
        Me.btnCollaborate2.Text = "Collaborate"
        Me.btnCollaborate2.UseVisualStyleBackColor = True
        '
        'lblDesc2
        '
        Me.lblDesc2.Location = New System.Drawing.Point(83, 49)
        Me.lblDesc2.Name = "lblDesc2"
        Me.lblDesc2.Size = New System.Drawing.Size(217, 34)
        Me.lblDesc2.TabIndex = 3
        Me.lblDesc2.Text = "Label3"
        '
        'lblDate2
        '
        Me.lblDate2.Location = New System.Drawing.Point(83, 28)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(140, 13)
        Me.lblDate2.TabIndex = 2
        Me.lblDate2.Text = "Label5"
        '
        'lblTitle2
        '
        Me.lblTitle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Location = New System.Drawing.Point(84, 7)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(285, 19)
        Me.lblTitle2.TabIndex = 1
        Me.lblTitle2.Text = "Label1"
        '
        'pnlCard1
        '
        Me.pnlCard1.BackColor = System.Drawing.Color.White
        Me.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard1.Controls.Add(Me.btnCollaborate1)
        Me.pnlCard1.Controls.Add(Me.lblDesc1)
        Me.pnlCard1.Controls.Add(Me.lblDate1)
        Me.pnlCard1.Controls.Add(Me.lblTitle1)
        Me.pnlCard1.Controls.Add(Me.picCard1)
        Me.pnlCard1.Location = New System.Drawing.Point(17, 12)
        Me.pnlCard1.Name = "pnlCard1"
        Me.pnlCard1.Size = New System.Drawing.Size(387, 88)
        Me.pnlCard1.TabIndex = 0
        '
        'btnCollaborate1
        '
        Me.btnCollaborate1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCollaborate1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollaborate1.Location = New System.Drawing.Point(302, 57)
        Me.btnCollaborate1.Name = "btnCollaborate1"
        Me.btnCollaborate1.Size = New System.Drawing.Size(80, 26)
        Me.btnCollaborate1.TabIndex = 33
        Me.btnCollaborate1.Text = "Collaborate"
        Me.btnCollaborate1.UseVisualStyleBackColor = True
        '
        'lblDesc1
        '
        Me.lblDesc1.Location = New System.Drawing.Point(83, 49)
        Me.lblDesc1.Name = "lblDesc1"
        Me.lblDesc1.Size = New System.Drawing.Size(213, 34)
        Me.lblDesc1.TabIndex = 3
        Me.lblDesc1.Text = "Label3"
        '
        'lblDate1
        '
        Me.lblDate1.Location = New System.Drawing.Point(83, 28)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(140, 13)
        Me.lblDate1.TabIndex = 2
        Me.lblDate1.Text = "Label2"
        '
        'lblTitle1
        '
        Me.lblTitle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.Location = New System.Drawing.Point(84, 7)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(285, 19)
        Me.lblTitle1.TabIndex = 1
        Me.lblTitle1.Text = "Label1"
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(34, 32)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 32)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'pnlSidebarMark
        '
        Me.pnlSidebarMark.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSidebarMark.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebarMark.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebarMark.Name = "pnlSidebarMark"
        Me.pnlSidebarMark.Size = New System.Drawing.Size(109, 422)
        Me.pnlSidebarMark.TabIndex = 18
        '
        'picCard3
        '
        Me.picCard3.Location = New System.Drawing.Point(10, 6)
        Me.picCard3.Name = "picCard3"
        Me.picCard3.Size = New System.Drawing.Size(68, 71)
        Me.picCard3.TabIndex = 0
        Me.picCard3.TabStop = False
        '
        'picCard2
        '
        Me.picCard2.Location = New System.Drawing.Point(10, 6)
        Me.picCard2.Name = "picCard2"
        Me.picCard2.Size = New System.Drawing.Size(68, 71)
        Me.picCard2.TabIndex = 0
        Me.picCard2.TabStop = False
        '
        'picCard1
        '
        Me.picCard1.Location = New System.Drawing.Point(10, 6)
        Me.picCard1.Name = "picCard1"
        Me.picCard1.Size = New System.Drawing.Size(68, 71)
        Me.picCard1.TabIndex = 0
        Me.picCard1.TabStop = False
        '
        'frmProjectFeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlSidebarMark)
        Me.Controls.Add(Me.pnlPostProject)
        Me.Name = "frmProjectFeed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProjectFeed"
        Me.pnlPostProject.ResumeLayout(False)
        Me.pnlPostProject.PerformLayout()
        Me.pnlFeed.ResumeLayout(False)
        Me.pnlCard3.ResumeLayout(False)
        Me.pnlCard2.ResumeLayout(False)
        Me.pnlCard1.ResumeLayout(False)
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPostProject As Panel
    Friend WithEvents btnPostProject As Button
    Friend WithEvents pnlFeed As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlSidebarMark As Panel
    Friend WithEvents btnNext As Button
    Friend WithEvents lblPage As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pnlCard1 As Panel
    Friend WithEvents pnlCard3 As Panel
    Friend WithEvents lblDesc3 As Label
    Friend WithEvents lblDate3 As Label
    Friend WithEvents lblTitle3 As Label
    Friend WithEvents picCard3 As PictureBox
    Friend WithEvents pnlCard2 As Panel
    Friend WithEvents lblDesc2 As Label
    Friend WithEvents lblDate2 As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents picCard2 As PictureBox
    Friend WithEvents lblDesc1 As Label
    Friend WithEvents lblDate1 As Label
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents picCard1 As PictureBox
    Friend WithEvents btnCollaborate3 As Button
    Friend WithEvents btnCollaborate2 As Button
    Friend WithEvents btnCollaborate1 As Button
End Class

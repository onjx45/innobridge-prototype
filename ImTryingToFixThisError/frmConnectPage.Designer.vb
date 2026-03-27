<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectPage
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
        Me.pnlSidebarMark = New System.Windows.Forms.Panel()
        Me.lblConnectTitle = New System.Windows.Forms.Label()
        Me.lblSuggestion = New System.Windows.Forms.Label()
        Me.pnlUserCards = New System.Windows.Forms.Panel()
        Me.pnlCard4 = New System.Windows.Forms.Panel()
        Me.btnConnect4 = New System.Windows.Forms.Button()
        Me.lblRole4 = New System.Windows.Forms.Label()
        Me.lblName4 = New System.Windows.Forms.Label()
        Me.pnlCard3 = New System.Windows.Forms.Panel()
        Me.btnConnect3 = New System.Windows.Forms.Button()
        Me.lblRole3 = New System.Windows.Forms.Label()
        Me.lblName3 = New System.Windows.Forms.Label()
        Me.pnlCard2 = New System.Windows.Forms.Panel()
        Me.btnConnect2 = New System.Windows.Forms.Button()
        Me.lblRole2 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.pnlCard1 = New System.Windows.Forms.Panel()
        Me.btnConnect1 = New System.Windows.Forms.Button()
        Me.lblRole1 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblPageTracker = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pnlConnectMain = New System.Windows.Forms.Panel()
        Me.picUser4 = New System.Windows.Forms.PictureBox()
        Me.picUser3 = New System.Windows.Forms.PictureBox()
        Me.picUser2 = New System.Windows.Forms.PictureBox()
        Me.picUser1 = New System.Windows.Forms.PictureBox()
        Me.pnlUserCards.SuspendLayout()
        Me.pnlCard4.SuspendLayout()
        Me.pnlCard3.SuspendLayout()
        Me.pnlCard2.SuspendLayout()
        Me.pnlCard1.SuspendLayout()
        Me.pnlConnectMain.SuspendLayout()
        CType(Me.picUser4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lblConnectTitle
        '
        Me.lblConnectTitle.AutoSize = True
        Me.lblConnectTitle.BackColor = System.Drawing.Color.White
        Me.lblConnectTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectTitle.ForeColor = System.Drawing.Color.Black
        Me.lblConnectTitle.Location = New System.Drawing.Point(45, 18)
        Me.lblConnectTitle.Name = "lblConnectTitle"
        Me.lblConnectTitle.Size = New System.Drawing.Size(108, 32)
        Me.lblConnectTitle.TabIndex = 3
        Me.lblConnectTitle.Text = "Connect" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSuggestion
        '
        Me.lblSuggestion.AutoSize = True
        Me.lblSuggestion.BackColor = System.Drawing.Color.White
        Me.lblSuggestion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuggestion.ForeColor = System.Drawing.Color.Black
        Me.lblSuggestion.Location = New System.Drawing.Point(47, 62)
        Me.lblSuggestion.Name = "lblSuggestion"
        Me.lblSuggestion.Size = New System.Drawing.Size(177, 20)
        Me.lblSuggestion.TabIndex = 20
        Me.lblSuggestion.Text = "Connection Suggestions"
        '
        'pnlUserCards
        '
        Me.pnlUserCards.BackColor = System.Drawing.Color.White
        Me.pnlUserCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUserCards.Controls.Add(Me.pnlCard4)
        Me.pnlUserCards.Controls.Add(Me.pnlCard3)
        Me.pnlUserCards.Controls.Add(Me.pnlCard2)
        Me.pnlUserCards.Controls.Add(Me.pnlCard1)
        Me.pnlUserCards.Location = New System.Drawing.Point(53, 98)
        Me.pnlUserCards.Name = "pnlUserCards"
        Me.pnlUserCards.Size = New System.Drawing.Size(321, 209)
        Me.pnlUserCards.TabIndex = 21
        '
        'pnlCard4
        '
        Me.pnlCard4.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard4.Controls.Add(Me.btnConnect4)
        Me.pnlCard4.Controls.Add(Me.lblRole4)
        Me.pnlCard4.Controls.Add(Me.lblName4)
        Me.pnlCard4.Controls.Add(Me.picUser4)
        Me.pnlCard4.Location = New System.Drawing.Point(18, 155)
        Me.pnlCard4.Name = "pnlCard4"
        Me.pnlCard4.Size = New System.Drawing.Size(281, 38)
        Me.pnlCard4.TabIndex = 26
        '
        'btnConnect4
        '
        Me.btnConnect4.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnConnect4.FlatAppearance.BorderSize = 0
        Me.btnConnect4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect4.ForeColor = System.Drawing.Color.White
        Me.btnConnect4.Location = New System.Drawing.Point(209, 8)
        Me.btnConnect4.Name = "btnConnect4"
        Me.btnConnect4.Size = New System.Drawing.Size(64, 22)
        Me.btnConnect4.TabIndex = 22
        Me.btnConnect4.Text = "Connect"
        Me.btnConnect4.UseVisualStyleBackColor = False
        '
        'lblRole4
        '
        Me.lblRole4.AutoSize = True
        Me.lblRole4.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole4.Location = New System.Drawing.Point(44, 22)
        Me.lblRole4.Name = "lblRole4"
        Me.lblRole4.Size = New System.Drawing.Size(60, 12)
        Me.lblRole4.TabIndex = 24
        Me.lblRole4.Text = "Cybersecurity"
        '
        'lblName4
        '
        Me.lblName4.AutoSize = True
        Me.lblName4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName4.Location = New System.Drawing.Point(42, 5)
        Me.lblName4.Name = "lblName4"
        Me.lblName4.Size = New System.Drawing.Size(43, 17)
        Me.lblName4.TabIndex = 23
        Me.lblName4.Text = "Smith"
        '
        'pnlCard3
        '
        Me.pnlCard3.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard3.Controls.Add(Me.btnConnect3)
        Me.pnlCard3.Controls.Add(Me.lblRole3)
        Me.pnlCard3.Controls.Add(Me.lblName3)
        Me.pnlCard3.Controls.Add(Me.picUser3)
        Me.pnlCard3.Location = New System.Drawing.Point(18, 109)
        Me.pnlCard3.Name = "pnlCard3"
        Me.pnlCard3.Size = New System.Drawing.Size(281, 38)
        Me.pnlCard3.TabIndex = 25
        '
        'btnConnect3
        '
        Me.btnConnect3.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnConnect3.FlatAppearance.BorderSize = 0
        Me.btnConnect3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect3.ForeColor = System.Drawing.Color.White
        Me.btnConnect3.Location = New System.Drawing.Point(209, 8)
        Me.btnConnect3.Name = "btnConnect3"
        Me.btnConnect3.Size = New System.Drawing.Size(64, 22)
        Me.btnConnect3.TabIndex = 22
        Me.btnConnect3.Text = "Connect"
        Me.btnConnect3.UseVisualStyleBackColor = False
        '
        'lblRole3
        '
        Me.lblRole3.AutoSize = True
        Me.lblRole3.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole3.Location = New System.Drawing.Point(44, 22)
        Me.lblRole3.Name = "lblRole3"
        Me.lblRole3.Size = New System.Drawing.Size(56, 12)
        Me.lblRole3.TabIndex = 24
        Me.lblRole3.Text = "Data Analyst"
        '
        'lblName3
        '
        Me.lblName3.AutoSize = True
        Me.lblName3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName3.Location = New System.Drawing.Point(42, 5)
        Me.lblName3.Name = "lblName3"
        Me.lblName3.Size = New System.Drawing.Size(37, 17)
        Me.lblName3.TabIndex = 23
        Me.lblName3.Text = "John"
        '
        'pnlCard2
        '
        Me.pnlCard2.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard2.Controls.Add(Me.btnConnect2)
        Me.pnlCard2.Controls.Add(Me.lblRole2)
        Me.pnlCard2.Controls.Add(Me.lblName2)
        Me.pnlCard2.Controls.Add(Me.picUser2)
        Me.pnlCard2.Location = New System.Drawing.Point(18, 63)
        Me.pnlCard2.Name = "pnlCard2"
        Me.pnlCard2.Size = New System.Drawing.Size(281, 38)
        Me.pnlCard2.TabIndex = 25
        '
        'btnConnect2
        '
        Me.btnConnect2.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnConnect2.FlatAppearance.BorderSize = 0
        Me.btnConnect2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect2.ForeColor = System.Drawing.Color.White
        Me.btnConnect2.Location = New System.Drawing.Point(209, 8)
        Me.btnConnect2.Name = "btnConnect2"
        Me.btnConnect2.Size = New System.Drawing.Size(64, 22)
        Me.btnConnect2.TabIndex = 22
        Me.btnConnect2.Text = "Connect"
        Me.btnConnect2.UseVisualStyleBackColor = False
        '
        'lblRole2
        '
        Me.lblRole2.AutoSize = True
        Me.lblRole2.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole2.Location = New System.Drawing.Point(44, 22)
        Me.lblRole2.Name = "lblRole2"
        Me.lblRole2.Size = New System.Drawing.Size(41, 12)
        Me.lblRole2.TabIndex = 24
        Me.lblRole2.Text = "Manager"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName2.Location = New System.Drawing.Point(42, 5)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(44, 17)
        Me.lblName2.TabIndex = 23
        Me.lblName2.Text = "Imran"
        '
        'pnlCard1
        '
        Me.pnlCard1.BackColor = System.Drawing.Color.AliceBlue
        Me.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard1.Controls.Add(Me.btnConnect1)
        Me.pnlCard1.Controls.Add(Me.lblRole1)
        Me.pnlCard1.Controls.Add(Me.lblName1)
        Me.pnlCard1.Controls.Add(Me.picUser1)
        Me.pnlCard1.Location = New System.Drawing.Point(18, 17)
        Me.pnlCard1.Name = "pnlCard1"
        Me.pnlCard1.Size = New System.Drawing.Size(281, 38)
        Me.pnlCard1.TabIndex = 0
        '
        'btnConnect1
        '
        Me.btnConnect1.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnConnect1.FlatAppearance.BorderSize = 0
        Me.btnConnect1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect1.ForeColor = System.Drawing.Color.White
        Me.btnConnect1.Location = New System.Drawing.Point(209, 8)
        Me.btnConnect1.Name = "btnConnect1"
        Me.btnConnect1.Size = New System.Drawing.Size(64, 22)
        Me.btnConnect1.TabIndex = 22
        Me.btnConnect1.Text = "Connect"
        Me.btnConnect1.UseVisualStyleBackColor = False
        '
        'lblRole1
        '
        Me.lblRole1.AutoSize = True
        Me.lblRole1.Font = New System.Drawing.Font("Segoe UI Semibold", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole1.Location = New System.Drawing.Point(44, 22)
        Me.lblRole1.Name = "lblRole1"
        Me.lblRole1.Size = New System.Drawing.Size(59, 12)
        Me.lblRole1.TabIndex = 24
        Me.lblRole1.Text = "Data Scientist"
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName1.Location = New System.Drawing.Point(42, 5)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(42, 17)
        Me.lblName1.TabIndex = 23
        Me.lblName1.Text = "David"
        '
        'btnPrevious
        '
        Me.btnPrevious.AutoSize = True
        Me.btnPrevious.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(123, 313)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(43, 20)
        Me.btnPrevious.TabIndex = 25
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'lblPageTracker
        '
        Me.lblPageTracker.AutoSize = True
        Me.lblPageTracker.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageTracker.Location = New System.Drawing.Point(172, 315)
        Me.lblPageTracker.Name = "lblPageTracker"
        Me.lblPageTracker.Size = New System.Drawing.Size(64, 13)
        Me.lblPageTracker.TabIndex = 27
        Me.lblPageTracker.Text = "Page 1 of 3"
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(242, 313)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(41, 20)
        Me.btnNext.TabIndex = 28
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'pnlConnectMain
        '
        Me.pnlConnectMain.BackColor = System.Drawing.Color.White
        Me.pnlConnectMain.Controls.Add(Me.btnNext)
        Me.pnlConnectMain.Controls.Add(Me.lblPageTracker)
        Me.pnlConnectMain.Controls.Add(Me.btnPrevious)
        Me.pnlConnectMain.Controls.Add(Me.pnlUserCards)
        Me.pnlConnectMain.Controls.Add(Me.lblSuggestion)
        Me.pnlConnectMain.Controls.Add(Me.lblConnectTitle)
        Me.pnlConnectMain.Location = New System.Drawing.Point(102, -2)
        Me.pnlConnectMain.Name = "pnlConnectMain"
        Me.pnlConnectMain.Size = New System.Drawing.Size(616, 426)
        Me.pnlConnectMain.TabIndex = 17
        '
        'picUser4
        '
        Me.picUser4.BackColor = System.Drawing.Color.White
        Me.picUser4.BackgroundImage = Global.ImTryingToFixThisError.My.Resources.Resources._360_F_301200886_7y1204uG8OPvmUYzN4HueXPgLblqBce9
        Me.picUser4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUser4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUser4.Location = New System.Drawing.Point(6, 3)
        Me.picUser4.Name = "picUser4"
        Me.picUser4.Size = New System.Drawing.Size(32, 30)
        Me.picUser4.TabIndex = 22
        Me.picUser4.TabStop = False
        '
        'picUser3
        '
        Me.picUser3.BackColor = System.Drawing.Color.White
        Me.picUser3.BackgroundImage = Global.ImTryingToFixThisError.My.Resources.Resources._360_F_161209383_0z2ORLIdbxgcO4BiFUhGKdLYMJNDc1RS
        Me.picUser3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUser3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUser3.Location = New System.Drawing.Point(6, 3)
        Me.picUser3.Name = "picUser3"
        Me.picUser3.Size = New System.Drawing.Size(32, 30)
        Me.picUser3.TabIndex = 22
        Me.picUser3.TabStop = False
        '
        'picUser2
        '
        Me.picUser2.BackColor = System.Drawing.Color.White
        Me.picUser2.BackgroundImage = Global.ImTryingToFixThisError.My.Resources.Resources.how_to_stop_being_a_people_pleaser_1_1
        Me.picUser2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUser2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUser2.Location = New System.Drawing.Point(6, 3)
        Me.picUser2.Name = "picUser2"
        Me.picUser2.Size = New System.Drawing.Size(32, 30)
        Me.picUser2.TabIndex = 22
        Me.picUser2.TabStop = False
        '
        'picUser1
        '
        Me.picUser1.BackColor = System.Drawing.Color.White
        Me.picUser1.BackgroundImage = Global.ImTryingToFixThisError.My.Resources.Resources.people
        Me.picUser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUser1.Location = New System.Drawing.Point(6, 3)
        Me.picUser1.Name = "picUser1"
        Me.picUser1.Size = New System.Drawing.Size(32, 30)
        Me.picUser1.TabIndex = 22
        Me.picUser1.TabStop = False
        '
        'frmConnectPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlSidebarMark)
        Me.Controls.Add(Me.pnlConnectMain)
        Me.Name = "frmConnectPage"
        Me.Text = "ConnectPage"
        Me.pnlUserCards.ResumeLayout(False)
        Me.pnlCard4.ResumeLayout(False)
        Me.pnlCard4.PerformLayout()
        Me.pnlCard3.ResumeLayout(False)
        Me.pnlCard3.PerformLayout()
        Me.pnlCard2.ResumeLayout(False)
        Me.pnlCard2.PerformLayout()
        Me.pnlCard1.ResumeLayout(False)
        Me.pnlCard1.PerformLayout()
        Me.pnlConnectMain.ResumeLayout(False)
        Me.pnlConnectMain.PerformLayout()
        CType(Me.picUser4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSidebarMark As Panel
    Friend WithEvents lblConnectTitle As Label
    Friend WithEvents lblSuggestion As Label
    Friend WithEvents pnlUserCards As Panel
    Friend WithEvents pnlCard4 As Panel
    Friend WithEvents btnConnect4 As Button
    Friend WithEvents lblRole4 As Label
    Friend WithEvents lblName4 As Label
    Friend WithEvents picUser4 As PictureBox
    Friend WithEvents pnlCard3 As Panel
    Friend WithEvents btnConnect3 As Button
    Friend WithEvents lblRole3 As Label
    Friend WithEvents lblName3 As Label
    Friend WithEvents picUser3 As PictureBox
    Friend WithEvents pnlCard2 As Panel
    Friend WithEvents btnConnect2 As Button
    Friend WithEvents lblRole2 As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents picUser2 As PictureBox
    Friend WithEvents pnlCard1 As Panel
    Friend WithEvents btnConnect1 As Button
    Friend WithEvents lblRole1 As Label
    Friend WithEvents lblName1 As Label
    Friend WithEvents picUser1 As PictureBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblPageTracker As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents pnlConnectMain As Panel
End Class

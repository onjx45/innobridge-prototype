<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfileEditPage
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblSkills = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.cmbSkill1 = New System.Windows.Forms.ComboBox()
        Me.cmbInterest1 = New System.Windows.Forms.ComboBox()
        Me.cmbInterest2 = New System.Windows.Forms.ComboBox()
        Me.cmbSkill2 = New System.Windows.Forms.ComboBox()
        Me.cmbInterest3 = New System.Windows.Forms.ComboBox()
        Me.cmbSkill3 = New System.Windows.Forms.ComboBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblEditProfile = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(42, 50)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(114, 50)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(279, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(114, 87)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(279, 20)
        Me.txtEmail.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(42, 87)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email:"
        '
        'lblSkills
        '
        Me.lblSkills.AutoSize = True
        Me.lblSkills.Location = New System.Drawing.Point(42, 128)
        Me.lblSkills.Name = "lblSkills"
        Me.lblSkills.Size = New System.Drawing.Size(34, 13)
        Me.lblSkills.TabIndex = 4
        Me.lblSkills.Text = "Skills:"
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Location = New System.Drawing.Point(42, 165)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(45, 13)
        Me.lblInterest.TabIndex = 5
        Me.lblInterest.Text = "Interest:"
        '
        'cmbSkill1
        '
        Me.cmbSkill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSkill1.FormattingEnabled = True
        Me.cmbSkill1.Items.AddRange(New Object() {"Python", "UI/UX Design", "AI", "Data Analysis", "Project Management"})
        Me.cmbSkill1.Location = New System.Drawing.Point(114, 125)
        Me.cmbSkill1.Name = "cmbSkill1"
        Me.cmbSkill1.Size = New System.Drawing.Size(82, 21)
        Me.cmbSkill1.TabIndex = 6
        '
        'cmbInterest1
        '
        Me.cmbInterest1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInterest1.FormattingEnabled = True
        Me.cmbInterest1.Items.AddRange(New Object() {"AI Ethics", "Economics", "FinTech", "Tech Startups", "Sustainable Innovation"})
        Me.cmbInterest1.Location = New System.Drawing.Point(114, 162)
        Me.cmbInterest1.Name = "cmbInterest1"
        Me.cmbInterest1.Size = New System.Drawing.Size(82, 21)
        Me.cmbInterest1.TabIndex = 7
        '
        'cmbInterest2
        '
        Me.cmbInterest2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInterest2.FormattingEnabled = True
        Me.cmbInterest2.Items.AddRange(New Object() {"AI Ethics", "Economics", "FinTech", "Tech Startups", "Sustainable Innovation"})
        Me.cmbInterest2.Location = New System.Drawing.Point(212, 162)
        Me.cmbInterest2.Name = "cmbInterest2"
        Me.cmbInterest2.Size = New System.Drawing.Size(82, 21)
        Me.cmbInterest2.TabIndex = 9
        '
        'cmbSkill2
        '
        Me.cmbSkill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSkill2.FormattingEnabled = True
        Me.cmbSkill2.Items.AddRange(New Object() {"Python", "UI/UX Design", "AI", "Data Analysis", "Project Management"})
        Me.cmbSkill2.Location = New System.Drawing.Point(212, 125)
        Me.cmbSkill2.Name = "cmbSkill2"
        Me.cmbSkill2.Size = New System.Drawing.Size(82, 21)
        Me.cmbSkill2.TabIndex = 8
        '
        'cmbInterest3
        '
        Me.cmbInterest3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInterest3.FormattingEnabled = True
        Me.cmbInterest3.Items.AddRange(New Object() {"AI Ethics", "Economics", "FinTech", "Tech Startups", "Sustainable Innovation"})
        Me.cmbInterest3.Location = New System.Drawing.Point(311, 162)
        Me.cmbInterest3.Name = "cmbInterest3"
        Me.cmbInterest3.Size = New System.Drawing.Size(82, 21)
        Me.cmbInterest3.TabIndex = 11
        '
        'cmbSkill3
        '
        Me.cmbSkill3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSkill3.FormattingEnabled = True
        Me.cmbSkill3.Items.AddRange(New Object() {"Python", "UI/UX Design", "AI", "Data Analysis", "Project Management"})
        Me.cmbSkill3.Location = New System.Drawing.Point(311, 125)
        Me.cmbSkill3.Name = "cmbSkill3"
        Me.cmbSkill3.Size = New System.Drawing.Size(82, 21)
        Me.cmbSkill3.TabIndex = 10
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(42, 203)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(63, 13)
        Me.lblDesc.TabIndex = 12
        Me.lblDesc.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(114, 200)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(279, 100)
        Me.txtDescription.TabIndex = 13
        '
        'lblEditProfile
        '
        Me.lblEditProfile.AutoSize = True
        Me.lblEditProfile.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditProfile.Location = New System.Drawing.Point(170, 9)
        Me.lblEditProfile.Name = "lblEditProfile"
        Me.lblEditProfile.Size = New System.Drawing.Size(110, 25)
        Me.lblEditProfile.TabIndex = 14
        Me.lblEditProfile.Text = "Edit Profile"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(318, 315)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(114, 315)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmProfileEditPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 361)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblEditProfile)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.cmbInterest3)
        Me.Controls.Add(Me.cmbSkill3)
        Me.Controls.Add(Me.cmbInterest2)
        Me.Controls.Add(Me.cmbSkill2)
        Me.Controls.Add(Me.cmbInterest1)
        Me.Controls.Add(Me.cmbSkill1)
        Me.Controls.Add(Me.lblInterest)
        Me.Controls.Add(Me.lblSkills)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "frmProfileEditPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProfileEditPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblSkills As Label
    Friend WithEvents lblInterest As Label
    Friend WithEvents cmbSkill1 As ComboBox
    Friend WithEvents cmbInterest1 As ComboBox
    Friend WithEvents cmbInterest2 As ComboBox
    Friend WithEvents cmbSkill2 As ComboBox
    Friend WithEvents cmbInterest3 As ComboBox
    Friend WithEvents cmbSkill3 As ComboBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblEditProfile As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class

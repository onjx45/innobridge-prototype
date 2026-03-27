<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProject
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
        Me.pnlPostProject = New System.Windows.Forms.Panel()
        Me.pnlNewProject = New System.Windows.Forms.Panel()
        Me.dtpProjectDate = New System.Windows.Forms.DateTimePicker()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescriptionTitle = New System.Windows.Forms.Label()
        Me.txtProjectTitle = New System.Windows.Forms.TextBox()
        Me.lblProjectTitle = New System.Windows.Forms.Label()
        Me.picPreview = New System.Windows.Forms.PictureBox()
        Me.lblPostProject = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlPostProject.SuspendLayout()
        Me.pnlNewProject.SuspendLayout()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebarMark
        '
        Me.pnlSidebarMark.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSidebarMark.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebarMark.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebarMark.Name = "pnlSidebarMark"
        Me.pnlSidebarMark.Size = New System.Drawing.Size(109, 422)
        Me.pnlSidebarMark.TabIndex = 19
        '
        'pnlPostProject
        '
        Me.pnlPostProject.BackColor = System.Drawing.Color.White
        Me.pnlPostProject.Controls.Add(Me.pnlNewProject)
        Me.pnlPostProject.Controls.Add(Me.btnBack)
        Me.pnlPostProject.Location = New System.Drawing.Point(101, -2)
        Me.pnlPostProject.Name = "pnlPostProject"
        Me.pnlPostProject.Size = New System.Drawing.Size(616, 426)
        Me.pnlPostProject.TabIndex = 20
        '
        'pnlNewProject
        '
        Me.pnlNewProject.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlNewProject.Controls.Add(Me.dtpProjectDate)
        Me.pnlNewProject.Controls.Add(Me.btnBrowse)
        Me.pnlNewProject.Controls.Add(Me.btnSubmit)
        Me.pnlNewProject.Controls.Add(Me.lblDate)
        Me.pnlNewProject.Controls.Add(Me.btnCancel)
        Me.pnlNewProject.Controls.Add(Me.txtDescription)
        Me.pnlNewProject.Controls.Add(Me.lblDescriptionTitle)
        Me.pnlNewProject.Controls.Add(Me.txtProjectTitle)
        Me.pnlNewProject.Controls.Add(Me.lblProjectTitle)
        Me.pnlNewProject.Controls.Add(Me.picPreview)
        Me.pnlNewProject.Controls.Add(Me.lblPostProject)
        Me.pnlNewProject.Location = New System.Drawing.Point(117, 14)
        Me.pnlNewProject.Name = "pnlNewProject"
        Me.pnlNewProject.Size = New System.Drawing.Size(433, 379)
        Me.pnlNewProject.TabIndex = 32
        '
        'dtpProjectDate
        '
        Me.dtpProjectDate.Location = New System.Drawing.Point(32, 313)
        Me.dtpProjectDate.Name = "dtpProjectDate"
        Me.dtpProjectDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpProjectDate.TabIndex = 34
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(251, 56)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(58, 23)
        Me.btnBrowse.TabIndex = 33
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        Me.btnBrowse.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoSize = True
        Me.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(292, 341)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(82, 25)
        Me.btnSubmit.TabIndex = 33
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(29, 297)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(85, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Date Of Project"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(32, 342)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 24)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(32, 159)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(365, 125)
        Me.txtDescription.TabIndex = 5
        '
        'lblDescriptionTitle
        '
        Me.lblDescriptionTitle.AutoSize = True
        Me.lblDescriptionTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionTitle.Location = New System.Drawing.Point(29, 143)
        Me.lblDescriptionTitle.Name = "lblDescriptionTitle"
        Me.lblDescriptionTitle.Size = New System.Drawing.Size(66, 13)
        Me.lblDescriptionTitle.TabIndex = 4
        Me.lblDescriptionTitle.Text = "Description"
        '
        'txtProjectTitle
        '
        Me.txtProjectTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectTitle.Location = New System.Drawing.Point(32, 104)
        Me.txtProjectTitle.Name = "txtProjectTitle"
        Me.txtProjectTitle.Size = New System.Drawing.Size(365, 23)
        Me.txtProjectTitle.TabIndex = 3
        '
        'lblProjectTitle
        '
        Me.lblProjectTitle.AutoSize = True
        Me.lblProjectTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectTitle.Location = New System.Drawing.Point(29, 88)
        Me.lblProjectTitle.Name = "lblProjectTitle"
        Me.lblProjectTitle.Size = New System.Drawing.Size(66, 13)
        Me.lblProjectTitle.TabIndex = 2
        Me.lblProjectTitle.Text = "Project Title"
        '
        'picPreview
        '
        Me.picPreview.BackColor = System.Drawing.Color.White
        Me.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPreview.Location = New System.Drawing.Point(315, 9)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(82, 70)
        Me.picPreview.TabIndex = 1
        Me.picPreview.TabStop = False
        Me.picPreview.Visible = False
        '
        'lblPostProject
        '
        Me.lblPostProject.AutoSize = True
        Me.lblPostProject.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostProject.Location = New System.Drawing.Point(37, 19)
        Me.lblPostProject.Name = "lblPostProject"
        Me.lblPostProject.Size = New System.Drawing.Size(193, 30)
        Me.lblPostProject.TabIndex = 0
        Me.lblPostProject.Text = "Post a New Project"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(13, 14)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 36)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmAddProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlPostProject)
        Me.Controls.Add(Me.pnlSidebarMark)
        Me.Name = "frmAddProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddProject"
        Me.pnlPostProject.ResumeLayout(False)
        Me.pnlNewProject.ResumeLayout(False)
        Me.pnlNewProject.PerformLayout()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebarMark As Panel
    Friend WithEvents pnlPostProject As Panel
    Friend WithEvents pnlNewProject As Panel
    Friend WithEvents txtProjectTitle As TextBox
    Friend WithEvents lblProjectTitle As Label
    Friend WithEvents picPreview As PictureBox
    Friend WithEvents lblPostProject As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblDescriptionTitle As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents dtpProjectDate As DateTimePicker
End Class

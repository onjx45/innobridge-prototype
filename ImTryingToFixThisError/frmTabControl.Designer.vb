<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTabControl
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
        Me.pnlTabControl = New System.Windows.Forms.Panel()
        Me.lblProject = New System.Windows.Forms.Label()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.btnDeleteProject = New System.Windows.Forms.Button()
        Me.btnRefreshProject = New System.Windows.Forms.Button()
        Me.btnDeleteUsers = New System.Windows.Forms.Button()
        Me.btnRefreshUsers = New System.Windows.Forms.Button()
        Me.tabControlAdmin = New System.Windows.Forms.TabControl()
        Me.Users = New System.Windows.Forms.TabPage()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.tabProject = New System.Windows.Forms.TabPage()
        Me.dgvProjects = New System.Windows.Forms.DataGridView()
        Me.pnlTabControl.SuspendLayout()
        Me.tabControlAdmin.SuspendLayout()
        Me.Users.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProject.SuspendLayout()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSidebarMark
        '
        Me.pnlSidebarMark.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSidebarMark.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebarMark.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebarMark.Name = "pnlSidebarMark"
        Me.pnlSidebarMark.Size = New System.Drawing.Size(109, 422)
        Me.pnlSidebarMark.TabIndex = 21
        '
        'pnlTabControl
        '
        Me.pnlTabControl.BackColor = System.Drawing.Color.White
        Me.pnlTabControl.Controls.Add(Me.lblProject)
        Me.pnlTabControl.Controls.Add(Me.lblUsers)
        Me.pnlTabControl.Controls.Add(Me.btnDeleteProject)
        Me.pnlTabControl.Controls.Add(Me.btnRefreshProject)
        Me.pnlTabControl.Controls.Add(Me.btnDeleteUsers)
        Me.pnlTabControl.Controls.Add(Me.btnRefreshUsers)
        Me.pnlTabControl.Controls.Add(Me.tabControlAdmin)
        Me.pnlTabControl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlTabControl.Location = New System.Drawing.Point(102, -2)
        Me.pnlTabControl.Name = "pnlTabControl"
        Me.pnlTabControl.Size = New System.Drawing.Size(616, 426)
        Me.pnlTabControl.TabIndex = 22
        '
        'lblProject
        '
        Me.lblProject.AutoSize = True
        Me.lblProject.Location = New System.Drawing.Point(27, 381)
        Me.lblProject.Name = "lblProject"
        Me.lblProject.Size = New System.Drawing.Size(89, 13)
        Me.lblProject.TabIndex = 6
        Me.lblProject.Text = "Projects Button:"
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Location = New System.Drawing.Point(27, 352)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(77, 13)
        Me.lblUsers.TabIndex = 5
        Me.lblUsers.Text = "Users button:"
        '
        'btnDeleteProject
        '
        Me.btnDeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteProject.Location = New System.Drawing.Point(242, 376)
        Me.btnDeleteProject.Name = "btnDeleteProject"
        Me.btnDeleteProject.Size = New System.Drawing.Size(156, 23)
        Me.btnDeleteProject.TabIndex = 4
        Me.btnDeleteProject.Text = "Delete Selected Project"
        Me.btnDeleteProject.UseVisualStyleBackColor = True
        '
        'btnRefreshProject
        '
        Me.btnRefreshProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefreshProject.Location = New System.Drawing.Point(161, 376)
        Me.btnRefreshProject.Name = "btnRefreshProject"
        Me.btnRefreshProject.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshProject.TabIndex = 3
        Me.btnRefreshProject.Text = "Refresh"
        Me.btnRefreshProject.UseVisualStyleBackColor = True
        '
        'btnDeleteUsers
        '
        Me.btnDeleteUsers.FlatAppearance.BorderSize = 0
        Me.btnDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteUsers.Location = New System.Drawing.Point(242, 347)
        Me.btnDeleteUsers.Name = "btnDeleteUsers"
        Me.btnDeleteUsers.Size = New System.Drawing.Size(156, 23)
        Me.btnDeleteUsers.TabIndex = 2
        Me.btnDeleteUsers.Text = "Delete Selected User"
        Me.btnDeleteUsers.UseVisualStyleBackColor = True
        '
        'btnRefreshUsers
        '
        Me.btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefreshUsers.Location = New System.Drawing.Point(161, 347)
        Me.btnRefreshUsers.Name = "btnRefreshUsers"
        Me.btnRefreshUsers.Size = New System.Drawing.Size(75, 23)
        Me.btnRefreshUsers.TabIndex = 1
        Me.btnRefreshUsers.Text = "Refresh"
        Me.btnRefreshUsers.UseVisualStyleBackColor = True
        '
        'tabControlAdmin
        '
        Me.tabControlAdmin.Controls.Add(Me.Users)
        Me.tabControlAdmin.Controls.Add(Me.tabProject)
        Me.tabControlAdmin.Location = New System.Drawing.Point(30, 30)
        Me.tabControlAdmin.Name = "tabControlAdmin"
        Me.tabControlAdmin.SelectedIndex = 0
        Me.tabControlAdmin.Size = New System.Drawing.Size(488, 311)
        Me.tabControlAdmin.TabIndex = 0
        '
        'Users
        '
        Me.Users.Controls.Add(Me.dgvUsers)
        Me.Users.Location = New System.Drawing.Point(4, 22)
        Me.Users.Name = "Users"
        Me.Users.Padding = New System.Windows.Forms.Padding(3)
        Me.Users.Size = New System.Drawing.Size(480, 285)
        Me.Users.TabIndex = 0
        Me.Users.Text = "Users"
        Me.Users.UseVisualStyleBackColor = True
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(6, 6)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(468, 273)
        Me.dgvUsers.TabIndex = 0
        '
        'tabProject
        '
        Me.tabProject.Controls.Add(Me.dgvProjects)
        Me.tabProject.Location = New System.Drawing.Point(4, 22)
        Me.tabProject.Name = "tabProject"
        Me.tabProject.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProject.Size = New System.Drawing.Size(480, 285)
        Me.tabProject.TabIndex = 1
        Me.tabProject.Text = "Project"
        Me.tabProject.UseVisualStyleBackColor = True
        '
        'dgvProjects
        '
        Me.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjects.Location = New System.Drawing.Point(6, 6)
        Me.dgvProjects.Name = "dgvProjects"
        Me.dgvProjects.ReadOnly = True
        Me.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjects.Size = New System.Drawing.Size(468, 273)
        Me.dgvProjects.TabIndex = 1
        '
        'frmTabControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlTabControl)
        Me.Controls.Add(Me.pnlSidebarMark)
        Me.Name = "frmTabControl"
        Me.Text = "frmTabControl"
        Me.pnlTabControl.ResumeLayout(False)
        Me.pnlTabControl.PerformLayout()
        Me.tabControlAdmin.ResumeLayout(False)
        Me.Users.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProject.ResumeLayout(False)
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebarMark As Panel
    Friend WithEvents pnlTabControl As Panel
    Friend WithEvents tabControlAdmin As TabControl
    Friend WithEvents Users As TabPage
    Friend WithEvents tabProject As TabPage
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents btnDeleteUsers As Button
    Friend WithEvents btnRefreshUsers As Button
    Friend WithEvents dgvProjects As DataGridView
    Friend WithEvents lblProject As Label
    Friend WithEvents lblUsers As Label
    Friend WithEvents btnDeleteProject As Button
    Friend WithEvents btnRefreshProject As Button
End Class

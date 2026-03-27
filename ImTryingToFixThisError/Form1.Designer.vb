<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginPage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginPage))
        Me.lblNewToInnoBridge = New System.Windows.Forms.Label()
        Me.lblSignUpNow = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblTermsService = New System.Windows.Forms.Label()
        Me.lblTOS = New System.Windows.Forms.Label()
        Me.lblPP = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.chkAdminLogin = New System.Windows.Forms.CheckBox()
        Me.txtAdminPasskey = New System.Windows.Forms.TextBox()
        Me.picEmail = New System.Windows.Forms.PictureBox()
        Me.picPass = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNewToInnoBridge
        '
        Me.lblNewToInnoBridge.AutoSize = True
        Me.lblNewToInnoBridge.BackColor = System.Drawing.Color.Transparent
        Me.lblNewToInnoBridge.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewToInnoBridge.Location = New System.Drawing.Point(419, 53)
        Me.lblNewToInnoBridge.Name = "lblNewToInnoBridge"
        Me.lblNewToInnoBridge.Size = New System.Drawing.Size(123, 17)
        Me.lblNewToInnoBridge.TabIndex = 0
        Me.lblNewToInnoBridge.Text = "New to InnoBridge?"
        '
        'lblSignUpNow
        '
        Me.lblSignUpNow.AutoSize = True
        Me.lblSignUpNow.BackColor = System.Drawing.Color.Transparent
        Me.lblSignUpNow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUpNow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSignUpNow.Location = New System.Drawing.Point(545, 54)
        Me.lblSignUpNow.Name = "lblSignUpNow"
        Me.lblSignUpNow.Size = New System.Drawing.Size(88, 15)
        Me.lblSignUpNow.TabIndex = 1
        Me.lblSignUpNow.Text = "Sign up now →"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(408, 98)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(243, 37)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Login to continue"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(415, 177)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(207, 22)
        Me.txtEmail.TabIndex = 3
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmail.ForeColor = System.Drawing.Color.DimGray
        Me.lblEmail.Location = New System.Drawing.Point(419, 181)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        Me.lblEmail.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPassword.ForeColor = System.Drawing.Color.DimGray
        Me.lblPassword.Location = New System.Drawing.Point(418, 216)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        Me.lblPassword.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(415, 212)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(207, 22)
        Me.txtPassword.TabIndex = 5
        '
        'lblTermsService
        '
        Me.lblTermsService.AutoSize = True
        Me.lblTermsService.BackColor = System.Drawing.Color.Transparent
        Me.lblTermsService.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTermsService.Location = New System.Drawing.Point(407, 307)
        Me.lblTermsService.Name = "lblTermsService"
        Me.lblTermsService.Size = New System.Drawing.Size(236, 26)
        Me.lblTermsService.TabIndex = 8
        Me.lblTermsService.Text = "By logging in, you agree to our Terms of Service," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                         and P" &
    "rivacy Policy"
        '
        'lblTOS
        '
        Me.lblTOS.AutoSize = True
        Me.lblTOS.BackColor = System.Drawing.Color.Transparent
        Me.lblTOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTOS.Location = New System.Drawing.Point(554, 307)
        Me.lblTOS.Name = "lblTOS"
        Me.lblTOS.Size = New System.Drawing.Size(87, 13)
        Me.lblTOS.TabIndex = 9
        Me.lblTOS.Text = "Terms of Service" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPP
        '
        Me.lblPP.AutoSize = True
        Me.lblPP.BackColor = System.Drawing.Color.Transparent
        Me.lblPP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPP.Location = New System.Drawing.Point(503, 320)
        Me.lblPP.Name = "lblPP"
        Me.lblPP.Size = New System.Drawing.Size(73, 13)
        Me.lblPP.TabIndex = 10
        Me.lblPP.Text = "Privacy Policy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(459, 351)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(135, 36)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.chkShowPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.Location = New System.Drawing.Point(415, 242)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(104, 17)
        Me.chkShowPassword.TabIndex = 12
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = False
        '
        'chkAdminLogin
        '
        Me.chkAdminLogin.AutoSize = True
        Me.chkAdminLogin.BackColor = System.Drawing.Color.Transparent
        Me.chkAdminLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdminLogin.Location = New System.Drawing.Point(563, 242)
        Me.chkAdminLogin.Name = "chkAdminLogin"
        Me.chkAdminLogin.Size = New System.Drawing.Size(59, 17)
        Me.chkAdminLogin.TabIndex = 13
        Me.chkAdminLogin.Text = "Admin"
        Me.chkAdminLogin.UseVisualStyleBackColor = False
        '
        'txtAdminPasskey
        '
        Me.txtAdminPasskey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdminPasskey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPasskey.ForeColor = System.Drawing.Color.Black
        Me.txtAdminPasskey.Location = New System.Drawing.Point(415, 265)
        Me.txtAdminPasskey.Name = "txtAdminPasskey"
        Me.txtAdminPasskey.Size = New System.Drawing.Size(207, 22)
        Me.txtAdminPasskey.TabIndex = 14
        '
        'picEmail
        '
        Me.picEmail.BackgroundImage = Global.ImTryingToFixThisError.My.Resources.Resources.information_icon
        Me.picEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEmail.Location = New System.Drawing.Point(396, 179)
        Me.picEmail.Name = "picEmail"
        Me.picEmail.Size = New System.Drawing.Size(16, 18)
        Me.picEmail.TabIndex = 15
        Me.picEmail.TabStop = False
        '
        'picPass
        '
        Me.picPass.BackgroundImage = Global.ImTryingToFixThisError.My.Resources.Resources.information_icon
        Me.picPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPass.Location = New System.Drawing.Point(396, 214)
        Me.picPass.Name = "picPass"
        Me.picPass.Size = New System.Drawing.Size(16, 18)
        Me.picPass.TabIndex = 16
        Me.picPass.TabStop = False
        '
        'frmLoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.picPass)
        Me.Controls.Add(Me.picEmail)
        Me.Controls.Add(Me.txtAdminPasskey)
        Me.Controls.Add(Me.chkAdminLogin)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPP)
        Me.Controls.Add(Me.lblTOS)
        Me.Controls.Add(Me.lblTermsService)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblSignUpNow)
        Me.Controls.Add(Me.lblNewToInnoBridge)
        Me.Name = "frmLoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Page"
        CType(Me.picEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewToInnoBridge As Label
    Friend WithEvents lblSignUpNow As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblTermsService As Label
    Friend WithEvents lblTOS As Label
    Friend WithEvents lblPP As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents chkAdminLogin As CheckBox
    Friend WithEvents txtAdminPasskey As TextBox
    Friend WithEvents picEmail As PictureBox
    Friend WithEvents picPass As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
End Class

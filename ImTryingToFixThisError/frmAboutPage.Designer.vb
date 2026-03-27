<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAboutPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAboutPage))
        Me.pnlSidebarMark = New System.Windows.Forms.Panel()
        Me.pnlProfilePage = New System.Windows.Forms.Panel()
        Me.lblWhoAreWeTitle = New System.Windows.Forms.Label()
        Me.lblAboutTitle = New System.Windows.Forms.Label()
        Me.lblWhoAreWeDesc = New System.Windows.Forms.Label()
        Me.lblInnoBridgeTitle = New System.Windows.Forms.Label()
        Me.lblWhatWeDoTitle = New System.Windows.Forms.Label()
        Me.lblWhatWeDoDesc = New System.Windows.Forms.Label()
        Me.lblWhyInnoBridgeTitle = New System.Windows.Forms.Label()
        Me.lblWhyInnoBridgeDesc = New System.Windows.Forms.Label()
        Me.lblVisionTitle = New System.Windows.Forms.Label()
        Me.lblVisionDesc = New System.Windows.Forms.Label()
        Me.pnlProfilePage.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebarMark
        '
        Me.pnlSidebarMark.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSidebarMark.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebarMark.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebarMark.Name = "pnlSidebarMark"
        Me.pnlSidebarMark.Size = New System.Drawing.Size(109, 422)
        Me.pnlSidebarMark.TabIndex = 24
        '
        'pnlProfilePage
        '
        Me.pnlProfilePage.BackColor = System.Drawing.Color.White
        Me.pnlProfilePage.Controls.Add(Me.lblVisionDesc)
        Me.pnlProfilePage.Controls.Add(Me.lblVisionTitle)
        Me.pnlProfilePage.Controls.Add(Me.lblWhyInnoBridgeDesc)
        Me.pnlProfilePage.Controls.Add(Me.lblWhyInnoBridgeTitle)
        Me.pnlProfilePage.Controls.Add(Me.lblWhatWeDoDesc)
        Me.pnlProfilePage.Controls.Add(Me.lblWhatWeDoTitle)
        Me.pnlProfilePage.Controls.Add(Me.lblInnoBridgeTitle)
        Me.pnlProfilePage.Controls.Add(Me.lblWhoAreWeDesc)
        Me.pnlProfilePage.Controls.Add(Me.lblWhoAreWeTitle)
        Me.pnlProfilePage.Controls.Add(Me.lblAboutTitle)
        Me.pnlProfilePage.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlProfilePage.ForeColor = System.Drawing.Color.Black
        Me.pnlProfilePage.Location = New System.Drawing.Point(102, -2)
        Me.pnlProfilePage.Name = "pnlProfilePage"
        Me.pnlProfilePage.Size = New System.Drawing.Size(616, 426)
        Me.pnlProfilePage.TabIndex = 25
        '
        'lblWhoAreWeTitle
        '
        Me.lblWhoAreWeTitle.AutoSize = True
        Me.lblWhoAreWeTitle.BackColor = System.Drawing.Color.White
        Me.lblWhoAreWeTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhoAreWeTitle.ForeColor = System.Drawing.Color.Black
        Me.lblWhoAreWeTitle.Location = New System.Drawing.Point(24, 68)
        Me.lblWhoAreWeTitle.Name = "lblWhoAreWeTitle"
        Me.lblWhoAreWeTitle.Size = New System.Drawing.Size(92, 17)
        Me.lblWhoAreWeTitle.TabIndex = 20
        Me.lblWhoAreWeTitle.Text = "Who Are We?"
        '
        'lblAboutTitle
        '
        Me.lblAboutTitle.BackColor = System.Drawing.Color.White
        Me.lblAboutTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutTitle.ForeColor = System.Drawing.Color.Black
        Me.lblAboutTitle.Location = New System.Drawing.Point(177, 24)
        Me.lblAboutTitle.Name = "lblAboutTitle"
        Me.lblAboutTitle.Size = New System.Drawing.Size(143, 32)
        Me.lblAboutTitle.TabIndex = 3
        Me.lblAboutTitle.Text = "About Us – InnoBridge"
        '
        'lblWhoAreWeDesc
        '
        Me.lblWhoAreWeDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhoAreWeDesc.Location = New System.Drawing.Point(25, 88)
        Me.lblWhoAreWeDesc.Name = "lblWhoAreWeDesc"
        Me.lblWhoAreWeDesc.Size = New System.Drawing.Size(551, 77)
        Me.lblWhoAreWeDesc.TabIndex = 21
        Me.lblWhoAreWeDesc.Text = resources.GetString("lblWhoAreWeDesc.Text")
        '
        'lblInnoBridgeTitle
        '
        Me.lblInnoBridgeTitle.BackColor = System.Drawing.Color.White
        Me.lblInnoBridgeTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInnoBridgeTitle.ForeColor = System.Drawing.Color.Black
        Me.lblInnoBridgeTitle.Location = New System.Drawing.Point(312, 24)
        Me.lblInnoBridgeTitle.Name = "lblInnoBridgeTitle"
        Me.lblInnoBridgeTitle.Size = New System.Drawing.Size(143, 32)
        Me.lblInnoBridgeTitle.TabIndex = 22
        Me.lblInnoBridgeTitle.Text = "InnoBridge"
        '
        'lblWhatWeDoTitle
        '
        Me.lblWhatWeDoTitle.AutoSize = True
        Me.lblWhatWeDoTitle.BackColor = System.Drawing.Color.White
        Me.lblWhatWeDoTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatWeDoTitle.ForeColor = System.Drawing.Color.Black
        Me.lblWhatWeDoTitle.Location = New System.Drawing.Point(24, 174)
        Me.lblWhatWeDoTitle.Name = "lblWhatWeDoTitle"
        Me.lblWhatWeDoTitle.Size = New System.Drawing.Size(115, 17)
        Me.lblWhatWeDoTitle.TabIndex = 23
        Me.lblWhatWeDoTitle.Text = "What Do We Do?"
        '
        'lblWhatWeDoDesc
        '
        Me.lblWhatWeDoDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatWeDoDesc.Location = New System.Drawing.Point(25, 194)
        Me.lblWhatWeDoDesc.Name = "lblWhatWeDoDesc"
        Me.lblWhatWeDoDesc.Size = New System.Drawing.Size(551, 76)
        Me.lblWhatWeDoDesc.TabIndex = 24
        Me.lblWhatWeDoDesc.Text = resources.GetString("lblWhatWeDoDesc.Text")
        '
        'lblWhyInnoBridgeTitle
        '
        Me.lblWhyInnoBridgeTitle.AutoSize = True
        Me.lblWhyInnoBridgeTitle.BackColor = System.Drawing.Color.White
        Me.lblWhyInnoBridgeTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhyInnoBridgeTitle.ForeColor = System.Drawing.Color.Black
        Me.lblWhyInnoBridgeTitle.Location = New System.Drawing.Point(24, 270)
        Me.lblWhyInnoBridgeTitle.Name = "lblWhyInnoBridgeTitle"
        Me.lblWhyInnoBridgeTitle.Size = New System.Drawing.Size(114, 17)
        Me.lblWhyInnoBridgeTitle.TabIndex = 25
        Me.lblWhyInnoBridgeTitle.Text = "Why InnoBridge?"
        '
        'lblWhyInnoBridgeDesc
        '
        Me.lblWhyInnoBridgeDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhyInnoBridgeDesc.Location = New System.Drawing.Point(25, 290)
        Me.lblWhyInnoBridgeDesc.Name = "lblWhyInnoBridgeDesc"
        Me.lblWhyInnoBridgeDesc.Size = New System.Drawing.Size(551, 63)
        Me.lblWhyInnoBridgeDesc.TabIndex = 26
        Me.lblWhyInnoBridgeDesc.Text = resources.GetString("lblWhyInnoBridgeDesc.Text")
        '
        'lblVisionTitle
        '
        Me.lblVisionTitle.AutoSize = True
        Me.lblVisionTitle.BackColor = System.Drawing.Color.White
        Me.lblVisionTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisionTitle.ForeColor = System.Drawing.Color.Black
        Me.lblVisionTitle.Location = New System.Drawing.Point(24, 350)
        Me.lblVisionTitle.Name = "lblVisionTitle"
        Me.lblVisionTitle.Size = New System.Drawing.Size(74, 17)
        Me.lblVisionTitle.TabIndex = 27
        Me.lblVisionTitle.Text = "Our Vision"
        '
        'lblVisionDesc
        '
        Me.lblVisionDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisionDesc.Location = New System.Drawing.Point(25, 367)
        Me.lblVisionDesc.Name = "lblVisionDesc"
        Me.lblVisionDesc.Size = New System.Drawing.Size(551, 45)
        Me.lblVisionDesc.TabIndex = 28
        Me.lblVisionDesc.Text = "To create a vibrant ecosystem where students and industries grow together through" &
    " innovation, collaboration, and real-world problem solving."
        '
        'frmAboutPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 422)
        Me.Controls.Add(Me.pnlProfilePage)
        Me.Controls.Add(Me.pnlSidebarMark)
        Me.Name = "frmAboutPage"
        Me.Text = "frmAboutPage"
        Me.pnlProfilePage.ResumeLayout(False)
        Me.pnlProfilePage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebarMark As Panel
    Friend WithEvents pnlProfilePage As Panel
    Friend WithEvents lblWhoAreWeTitle As Label
    Friend WithEvents lblAboutTitle As Label
    Friend WithEvents lblWhoAreWeDesc As Label
    Friend WithEvents lblWhatWeDoDesc As Label
    Friend WithEvents lblWhatWeDoTitle As Label
    Friend WithEvents lblInnoBridgeTitle As Label
    Friend WithEvents lblVisionDesc As Label
    Friend WithEvents lblVisionTitle As Label
    Friend WithEvents lblWhyInnoBridgeDesc As Label
    Friend WithEvents lblWhyInnoBridgeTitle As Label
End Class

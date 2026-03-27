<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrivacyPolicy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrivacyPolicy))
        Me.lblTOS = New System.Windows.Forms.Label()
        Me.btnPPok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTOS
        '
        Me.lblTOS.Font = New System.Drawing.Font("Segoe UI", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOS.Location = New System.Drawing.Point(12, 9)
        Me.lblTOS.Name = "lblTOS"
        Me.lblTOS.Size = New System.Drawing.Size(634, 447)
        Me.lblTOS.TabIndex = 1
        Me.lblTOS.Text = resources.GetString("lblTOS.Text")
        '
        'btnPPok
        '
        Me.btnPPok.Location = New System.Drawing.Point(603, 409)
        Me.btnPPok.Name = "btnPPok"
        Me.btnPPok.Size = New System.Drawing.Size(89, 23)
        Me.btnPPok.TabIndex = 2
        Me.btnPPok.Text = "I understand"
        Me.btnPPok.UseVisualStyleBackColor = True
        '
        'frmPrivacyPolicy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 453)
        Me.Controls.Add(Me.btnPPok)
        Me.Controls.Add(Me.lblTOS)
        Me.Name = "frmPrivacyPolicy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrivacyPolicy"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTOS As Label
    Friend WithEvents btnPPok As Button
End Class

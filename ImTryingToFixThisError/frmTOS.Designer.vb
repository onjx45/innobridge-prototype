<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTOS))
        Me.lblTOS = New System.Windows.Forms.Label()
        Me.btnTOSok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTOS
        '
        Me.lblTOS.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTOS.Location = New System.Drawing.Point(25, 28)
        Me.lblTOS.Name = "lblTOS"
        Me.lblTOS.Size = New System.Drawing.Size(671, 405)
        Me.lblTOS.TabIndex = 0
        Me.lblTOS.Text = resources.GetString("lblTOS.Text")
        '
        'btnTOSok
        '
        Me.btnTOSok.Location = New System.Drawing.Point(607, 410)
        Me.btnTOSok.Name = "btnTOSok"
        Me.btnTOSok.Size = New System.Drawing.Size(89, 23)
        Me.btnTOSok.TabIndex = 1
        Me.btnTOSok.Text = "I understand"
        Me.btnTOSok.UseVisualStyleBackColor = True
        '
        'frmTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 446)
        Me.Controls.Add(Me.btnTOSok)
        Me.Controls.Add(Me.lblTOS)
        Me.Name = "frmTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTOS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTOS As Label
    Friend WithEvents btnTOSok As Button
End Class

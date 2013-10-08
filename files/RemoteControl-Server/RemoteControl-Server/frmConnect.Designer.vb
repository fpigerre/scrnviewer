<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnect
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.cmdListen = New System.Windows.Forms.Button
        Me.cmdStop = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port:"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(47, 6)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(225, 20)
        Me.txtPort.TabIndex = 1
        Me.txtPort.Text = "1256"
        '
        'cmdListen
        '
        Me.cmdListen.Location = New System.Drawing.Point(15, 32)
        Me.cmdListen.Name = "cmdListen"
        Me.cmdListen.Size = New System.Drawing.Size(257, 23)
        Me.cmdListen.TabIndex = 2
        Me.cmdListen.Text = "Start Listening"
        Me.cmdListen.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(15, 61)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(257, 23)
        Me.cmdStop.TabIndex = 3
        Me.cmdStop.Text = "Stop Listening"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'frmConnect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 89)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdListen)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnect"
        Me.Text = "Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents cmdListen As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStream
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
        Me.pbScreen = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.pbScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbScreen
        '
        Me.pbScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbScreen.Location = New System.Drawing.Point(0, 0)
        Me.pbScreen.Name = "pbScreen"
        Me.pbScreen.Size = New System.Drawing.Size(726, 447)
        Me.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbScreen.TabIndex = 0
        Me.pbScreen.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbScreen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 447)
        Me.Panel1.TabIndex = 1
        '
        'frmStream
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 447)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmStream"
        Me.Text = "Stream"
        CType(Me.pbScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class

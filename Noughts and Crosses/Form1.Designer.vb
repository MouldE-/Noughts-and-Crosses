<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.startButton = New System.Windows.Forms.Button()
        Me.players0 = New System.Windows.Forms.RadioButton()
        Me.players2 = New System.Windows.Forms.RadioButton()
        Me.players1 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'startButton
        '
        Me.startButton.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.Location = New System.Drawing.Point(147, 31)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(121, 72)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "START GAME"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'players0
        '
        Me.players0.AutoSize = True
        Me.players0.Location = New System.Drawing.Point(32, 31)
        Me.players0.Name = "players0"
        Me.players0.Size = New System.Drawing.Size(68, 17)
        Me.players0.TabIndex = 2
        Me.players0.TabStop = True
        Me.players0.Text = "0 Players"
        Me.players0.UseVisualStyleBackColor = True
        '
        'players2
        '
        Me.players2.AutoSize = True
        Me.players2.Checked = True
        Me.players2.Location = New System.Drawing.Point(32, 77)
        Me.players2.Name = "players2"
        Me.players2.Size = New System.Drawing.Size(68, 17)
        Me.players2.TabIndex = 3
        Me.players2.TabStop = True
        Me.players2.Text = "2 Players"
        Me.players2.UseVisualStyleBackColor = True
        '
        'players1
        '
        Me.players1.AutoSize = True
        Me.players1.Location = New System.Drawing.Point(32, 54)
        Me.players1.Name = "players1"
        Me.players1.Size = New System.Drawing.Size(63, 17)
        Me.players1.TabIndex = 4
        Me.players1.Text = "1 Player"
        Me.players1.UseVisualStyleBackColor = True
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 148)
        Me.Controls.Add(Me.players1)
        Me.Controls.Add(Me.players2)
        Me.Controls.Add(Me.players0)
        Me.Controls.Add(Me.startButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Launcher"
        Me.Text = "Launcher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startButton As Button
    Friend WithEvents players0 As RadioButton
    Friend WithEvents players2 As RadioButton
    Friend WithEvents players1 As RadioButton
End Class

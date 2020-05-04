<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.playerLabel = New System.Windows.Forms.Label()
        Me.botTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Part9 = New Noughts_and_Crosses.Part()
        Me.Part8 = New Noughts_and_Crosses.Part()
        Me.Part7 = New Noughts_and_Crosses.Part()
        Me.Part6 = New Noughts_and_Crosses.Part()
        Me.Part5 = New Noughts_and_Crosses.Part()
        Me.Part4 = New Noughts_and_Crosses.Part()
        Me.Part3 = New Noughts_and_Crosses.Part()
        Me.Part1 = New Noughts_and_Crosses.Part()
        Me.Part2 = New Noughts_and_Crosses.Part()
        Me.SuspendLayout()
        '
        'playerLabel
        '
        Me.playerLabel.AutoSize = True
        Me.playerLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerLabel.Location = New System.Drawing.Point(12, 348)
        Me.playerLabel.Name = "playerLabel"
        Me.playerLabel.Size = New System.Drawing.Size(89, 25)
        Me.playerLabel.TabIndex = 17
        Me.playerLabel.Text = "Player: O"
        '
        'botTimer
        '
        Me.botTimer.Interval = 1000
        '
        'Part9
        '
        Me.Part9.FlatAppearance.BorderSize = 0
        Me.Part9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Part9.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part9.Location = New System.Drawing.Point(224, 224)
        Me.Part9.Name = "Part9"
        Me.Part9.Size = New System.Drawing.Size(100, 100)
        Me.Part9.TabIndex = 16
        Me.Part9.TabStop = False
        '
        'Part8
        '
        Me.Part8.FlatAppearance.BorderSize = 0
        Me.Part8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Part8.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part8.Location = New System.Drawing.Point(118, 224)
        Me.Part8.Name = "Part8"
        Me.Part8.Size = New System.Drawing.Size(100, 100)
        Me.Part8.TabIndex = 15
        Me.Part8.TabStop = False
        '
        'Part7
        '
        Me.Part7.FlatAppearance.BorderSize = 0
        Me.Part7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Part7.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part7.Location = New System.Drawing.Point(12, 224)
        Me.Part7.Name = "Part7"
        Me.Part7.Size = New System.Drawing.Size(100, 100)
        Me.Part7.TabIndex = 14
        Me.Part7.TabStop = False
        '
        'Part6
        '
        Me.Part6.FlatAppearance.BorderSize = 0
        Me.Part6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Part6.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part6.Location = New System.Drawing.Point(224, 118)
        Me.Part6.Name = "Part6"
        Me.Part6.Size = New System.Drawing.Size(100, 100)
        Me.Part6.TabIndex = 13
        Me.Part6.TabStop = False
        '
        'Part5
        '
        Me.Part5.FlatAppearance.BorderSize = 0
        Me.Part5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Part5.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part5.Location = New System.Drawing.Point(118, 118)
        Me.Part5.Name = "Part5"
        Me.Part5.Size = New System.Drawing.Size(100, 100)
        Me.Part5.TabIndex = 12
        Me.Part5.TabStop = False
        '
        'Part4
        '
        Me.Part4.FlatAppearance.BorderSize = 0
        Me.Part4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Part4.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part4.Location = New System.Drawing.Point(12, 118)
        Me.Part4.Name = "Part4"
        Me.Part4.Size = New System.Drawing.Size(100, 100)
        Me.Part4.TabIndex = 11
        Me.Part4.TabStop = False
        '
        'Part3
        '
        Me.Part3.FlatAppearance.BorderSize = 0
        Me.Part3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Part3.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part3.Location = New System.Drawing.Point(224, 12)
        Me.Part3.Name = "Part3"
        Me.Part3.Size = New System.Drawing.Size(100, 100)
        Me.Part3.TabIndex = 10
        Me.Part3.TabStop = False
        '
        'Part1
        '
        Me.Part1.FlatAppearance.BorderSize = 0
        Me.Part1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Part1.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part1.Location = New System.Drawing.Point(12, 12)
        Me.Part1.Name = "Part1"
        Me.Part1.Size = New System.Drawing.Size(100, 100)
        Me.Part1.TabIndex = 9
        Me.Part1.TabStop = False
        '
        'Part2
        '
        Me.Part2.FlatAppearance.BorderSize = 0
        Me.Part2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Part2.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part2.Location = New System.Drawing.Point(118, 12)
        Me.Part2.Name = "Part2"
        Me.Part2.Size = New System.Drawing.Size(100, 100)
        Me.Part2.TabIndex = 1
        Me.Part2.TabStop = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 396)
        Me.Controls.Add(Me.playerLabel)
        Me.Controls.Add(Me.Part9)
        Me.Controls.Add(Me.Part8)
        Me.Controls.Add(Me.Part7)
        Me.Controls.Add(Me.Part6)
        Me.Controls.Add(Me.Part5)
        Me.Controls.Add(Me.Part4)
        Me.Controls.Add(Me.Part3)
        Me.Controls.Add(Me.Part1)
        Me.Controls.Add(Me.Part2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Game"
        Me.ShowInTaskbar = False
        Me.Text = "Noughts and Crosses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Part2 As Part
    Friend WithEvents Part1 As Part
    Friend WithEvents Part3 As Part
    Friend WithEvents Part4 As Part
    Friend WithEvents Part5 As Part
    Friend WithEvents Part6 As Part
    Friend WithEvents Part7 As Part
    Friend WithEvents Part8 As Part
    Friend WithEvents Part9 As Part
    Friend WithEvents playerLabel As Label
    Friend WithEvents botTimer As Timer
End Class

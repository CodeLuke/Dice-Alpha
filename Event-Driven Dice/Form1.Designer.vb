<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiceGame
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.prbLoad = New System.Windows.Forms.ProgressBar()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lblRule1 = New System.Windows.Forms.Label()
        Me.lblRule21 = New System.Windows.Forms.Label()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblRule2 = New System.Windows.Forms.Label()
        Me.grpRules = New System.Windows.Forms.GroupBox()
        Me.lblRule3 = New System.Windows.Forms.Label()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.pbxDie3 = New System.Windows.Forms.PictureBox()
        Me.pbxDie2 = New System.Windows.Forms.PictureBox()
        Me.pbxDie1 = New System.Windows.Forms.PictureBox()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRules.SuspendLayout()
        CType(Me.pbxDie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDie2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDie1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.btnReset)
        Me.pnlHeader.Controls.Add(Me.btnStart)
        Me.pnlHeader.Controls.Add(Me.picLogo)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(801, 114)
        Me.pnlHeader.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Yu Gothic UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(240, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(264, 65)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Dice Game"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(579, 63)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(168, 36)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(579, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(168, 36)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Event_Driven_Dice.My.Resources.Resources.dielogo
        Me.picLogo.InitialImage = Global.Event_Driven_Dice.My.Resources.Resources.dielogo
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(182, 114)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'prbLoad
        '
        Me.prbLoad.Location = New System.Drawing.Point(0, 427)
        Me.prbLoad.Name = "prbLoad"
        Me.prbLoad.Size = New System.Drawing.Size(801, 23)
        Me.prbLoad.TabIndex = 2
        '
        'lstScore
        '
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.Location = New System.Drawing.Point(47, 189)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(96, 108)
        Me.lstScore.TabIndex = 6
        '
        'lblRule1
        '
        Me.lblRule1.AutoSize = True
        Me.lblRule1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRule1.ForeColor = System.Drawing.Color.White
        Me.lblRule1.Location = New System.Drawing.Point(17, 29)
        Me.lblRule1.Name = "lblRule1"
        Me.lblRule1.Size = New System.Drawing.Size(125, 21)
        Me.lblRule1.TabIndex = 7
        Me.lblRule1.Text = "1 point per spot"
        '
        'lblRule21
        '
        Me.lblRule21.AutoSize = True
        Me.lblRule21.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRule21.ForeColor = System.Drawing.Color.White
        Me.lblRule21.Location = New System.Drawing.Point(228, 391)
        Me.lblRule21.Name = "lblRule21"
        Me.lblRule21.Size = New System.Drawing.Size(0, 30)
        Me.lblRule21.TabIndex = 8
        '
        'tmrTimer
        '
        '
        'lblRule2
        '
        Me.lblRule2.AutoSize = True
        Me.lblRule2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRule2.ForeColor = System.Drawing.Color.White
        Me.lblRule2.Location = New System.Drawing.Point(172, 29)
        Me.lblRule2.Name = "lblRule2"
        Me.lblRule2.Size = New System.Drawing.Size(156, 21)
        Me.lblRule2.TabIndex = 9
        Me.lblRule2.Text = "6s are worth double"
        '
        'grpRules
        '
        Me.grpRules.Controls.Add(Me.lblRule3)
        Me.grpRules.Controls.Add(Me.lblRule2)
        Me.grpRules.Controls.Add(Me.lblRule1)
        Me.grpRules.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRules.ForeColor = System.Drawing.Color.White
        Me.grpRules.Location = New System.Drawing.Point(83, 356)
        Me.grpRules.Name = "grpRules"
        Me.grpRules.Size = New System.Drawing.Size(593, 65)
        Me.grpRules.TabIndex = 10
        Me.grpRules.TabStop = False
        Me.grpRules.Text = "Rules"
        '
        'lblRule3
        '
        Me.lblRule3.AutoSize = True
        Me.lblRule3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRule3.Location = New System.Drawing.Point(360, 29)
        Me.lblRule3.Name = "lblRule3"
        Me.lblRule3.Size = New System.Drawing.Size(219, 21)
        Me.lblRule3.TabIndex = 10
        Me.lblRule3.Text = "Triple Rolls are worth double"
        '
        'lblScores
        '
        Me.lblScores.AutoSize = True
        Me.lblScores.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScores.ForeColor = System.Drawing.Color.White
        Me.lblScores.Location = New System.Drawing.Point(65, 165)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(59, 21)
        Me.lblScores.TabIndex = 10
        Me.lblScores.Text = "Scores"
        '
        'pbxDie3
        '
        Me.pbxDie3.Location = New System.Drawing.Point(614, 165)
        Me.pbxDie3.Name = "pbxDie3"
        Me.pbxDie3.Size = New System.Drawing.Size(150, 150)
        Me.pbxDie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDie3.TabIndex = 5
        Me.pbxDie3.TabStop = False
        '
        'pbxDie2
        '
        Me.pbxDie2.Location = New System.Drawing.Point(233, 165)
        Me.pbxDie2.Name = "pbxDie2"
        Me.pbxDie2.Size = New System.Drawing.Size(150, 150)
        Me.pbxDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDie2.TabIndex = 4
        Me.pbxDie2.TabStop = False
        '
        'pbxDie1
        '
        Me.pbxDie1.Location = New System.Drawing.Point(426, 165)
        Me.pbxDie1.Name = "pbxDie1"
        Me.pbxDie1.Size = New System.Drawing.Size(150, 150)
        Me.pbxDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDie1.TabIndex = 3
        Me.pbxDie1.TabStop = False
        '
        'frmDiceGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblScores)
        Me.Controls.Add(Me.grpRules)
        Me.Controls.Add(Me.lblRule21)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.pbxDie3)
        Me.Controls.Add(Me.pbxDie2)
        Me.Controls.Add(Me.pbxDie1)
        Me.Controls.Add(Me.prbLoad)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "frmDiceGame"
        Me.Text = "Dice Game"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRules.ResumeLayout(False)
        Me.grpRules.PerformLayout()
        CType(Me.pbxDie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDie2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDie1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents prbLoad As ProgressBar
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents pbxDie1 As PictureBox
    Friend WithEvents pbxDie2 As PictureBox
    Friend WithEvents pbxDie3 As PictureBox
    Friend WithEvents lstScore As ListBox
    Friend WithEvents lblRule1 As Label
    Friend WithEvents lblRule21 As Label
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents lblRule2 As Label
    Friend WithEvents grpRules As GroupBox
    Friend WithEvents lblScores As Label
    Friend WithEvents lblRule3 As Label
End Class

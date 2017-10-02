<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tmrSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.rbtnEasy = New System.Windows.Forms.RadioButton
        Me.btnStart = New System.Windows.Forms.Button
        Me.rbtnMedium = New System.Windows.Forms.RadioButton
        Me.btnStop = New System.Windows.Forms.Button
        Me.rbtnHard = New System.Windows.Forms.RadioButton
        Me.lblCredits = New System.Windows.Forms.Label
        Me.timeoutbar = New System.Windows.Forms.ProgressBar
        Me.lblIdle = New System.Windows.Forms.Label
        Me.btnPause = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.butterfly = New System.Windows.Forms.PictureBox
        Me.bgImage = New System.Windows.Forms.PictureBox
        Me.goldbutterfly = New System.Windows.Forms.PictureBox
        Me.btnHelp = New System.Windows.Forms.Button
        CType(Me.butterfly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goldbutterfly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrSpeed
        '
        Me.tmrSpeed.Interval = 900
        '
        'tmrTimeout
        '
        Me.tmrTimeout.Interval = 1000
        '
        'rbtnEasy
        '
        Me.rbtnEasy.AutoSize = True
        Me.rbtnEasy.Checked = True
        Me.rbtnEasy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnEasy.Location = New System.Drawing.Point(197, 394)
        Me.rbtnEasy.Name = "rbtnEasy"
        Me.rbtnEasy.Size = New System.Drawing.Size(48, 17)
        Me.rbtnEasy.TabIndex = 3
        Me.rbtnEasy.TabStop = True
        Me.rbtnEasy.Text = "Easy"
        Me.rbtnEasy.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.Control
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStart.Location = New System.Drawing.Point(270, 389)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 62)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'rbtnMedium
        '
        Me.rbtnMedium.AutoSize = True
        Me.rbtnMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.rbtnMedium.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnMedium.Location = New System.Drawing.Point(197, 413)
        Me.rbtnMedium.Name = "rbtnMedium"
        Me.rbtnMedium.Size = New System.Drawing.Size(62, 17)
        Me.rbtnMedium.TabIndex = 4
        Me.rbtnMedium.Text = "Medium"
        Me.rbtnMedium.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.SystemColors.Control
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStop.Enabled = False
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStop.Location = New System.Drawing.Point(433, 389)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 62)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'rbtnHard
        '
        Me.rbtnHard.AutoSize = True
        Me.rbtnHard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnHard.Location = New System.Drawing.Point(197, 431)
        Me.rbtnHard.Name = "rbtnHard"
        Me.rbtnHard.Size = New System.Drawing.Size(48, 17)
        Me.rbtnHard.TabIndex = 5
        Me.rbtnHard.Text = "Hard"
        Me.rbtnHard.UseVisualStyleBackColor = True
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredits.Location = New System.Drawing.Point(644, 406)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(25, 25)
        Me.lblCredits.TabIndex = 4
        Me.lblCredits.Text = "0"
        '
        'timeoutbar
        '
        Me.timeoutbar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.timeoutbar.Location = New System.Drawing.Point(12, 359)
        Me.timeoutbar.Name = "timeoutbar"
        Me.timeoutbar.Size = New System.Drawing.Size(756, 23)
        Me.timeoutbar.Step = 20
        Me.timeoutbar.TabIndex = 4
        Me.timeoutbar.Value = 100
        '
        'lblIdle
        '
        Me.lblIdle.AutoSize = True
        Me.lblIdle.BackColor = System.Drawing.SystemColors.Control
        Me.lblIdle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdle.Location = New System.Drawing.Point(105, 405)
        Me.lblIdle.Name = "lblIdle"
        Me.lblIdle.Size = New System.Drawing.Size(25, 25)
        Me.lblIdle.TabIndex = 7
        Me.lblIdle.Text = "0"
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.SystemColors.Control
        Me.btnPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPause.Enabled = False
        Me.btnPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.Location = New System.Drawing.Point(351, 389)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 63)
        Me.btnPause.TabIndex = 8
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "IDLE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(633, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "CREDITS"
        '
        'butterfly
        '
        Me.butterfly.BackColor = System.Drawing.Color.Transparent
        Me.butterfly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butterfly.Image = Global.WindowsApplication1.My.Resources.Resources.bfly1
        Me.butterfly.Location = New System.Drawing.Point(139, 79)
        Me.butterfly.Name = "butterfly"
        Me.butterfly.Size = New System.Drawing.Size(47, 50)
        Me.butterfly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.butterfly.TabIndex = 10
        Me.butterfly.TabStop = False
        Me.butterfly.Visible = False
        '
        'bgImage
        '
        Me.bgImage.Image = Global.WindowsApplication1.My.Resources.Resources.garden
        Me.bgImage.Location = New System.Drawing.Point(-1, 0)
        Me.bgImage.Name = "bgImage"
        Me.bgImage.Size = New System.Drawing.Size(780, 353)
        Me.bgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bgImage.TabIndex = 9
        Me.bgImage.TabStop = False
        '
        'goldbutterfly
        '
        Me.goldbutterfly.Image = Global.WindowsApplication1.My.Resources.Resources.animated_butterfly_yellow
        Me.goldbutterfly.Location = New System.Drawing.Point(83, 79)
        Me.goldbutterfly.Name = "goldbutterfly"
        Me.goldbutterfly.Size = New System.Drawing.Size(50, 50)
        Me.goldbutterfly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.goldbutterfly.TabIndex = 13
        Me.goldbutterfly.TabStop = False
        Me.goldbutterfly.Visible = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.SystemColors.Control
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(514, 390)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 60)
        Me.btnHelp.TabIndex = 15
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(780, 459)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.goldbutterfly)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIdle)
        Me.Controls.Add(Me.lblCredits)
        Me.Controls.Add(Me.butterfly)
        Me.Controls.Add(Me.bgImage)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.timeoutbar)
        Me.Controls.Add(Me.rbtnHard)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.rbtnMedium)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.rbtnEasy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catch Butterfly"
        CType(Me.butterfly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goldbutterfly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrSpeed As System.Windows.Forms.Timer
    Friend WithEvents tmrTimeout As System.Windows.Forms.Timer
    Friend WithEvents rbtnEasy As System.Windows.Forms.RadioButton
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents rbtnMedium As System.Windows.Forms.RadioButton
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents rbtnHard As System.Windows.Forms.RadioButton
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents timeoutbar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblIdle As System.Windows.Forms.Label
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents bgImage As System.Windows.Forms.PictureBox
    Friend WithEvents butterfly As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents goldbutterfly As System.Windows.Forms.PictureBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button

End Class

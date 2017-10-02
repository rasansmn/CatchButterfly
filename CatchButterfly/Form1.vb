' CatchButterfly Game By Rasan
Public Class frmMain
    Dim hor As Integer
    Dim ver As Integer
    Dim speed As Integer
    Dim crdtsperclick As Integer
    Dim idle As Integer
    Dim credits As Integer
    Dim remains As Integer
    Dim randval As Integer

    Private Sub tmrSpeed_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSpeed.Tick
        hor = Int(Rnd() * 700)
        ver = Int(Rnd() * 300)
        butterfly.Visible = True
        butterfly.Location = New Point(hor, ver)
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'new game
        If rbtnEasy.Checked = True Then
            speed = 1250
            crdtsperclick = 10
        ElseIf rbtnMedium.Checked = True Then
            speed = 1000
            crdtsperclick = 20
        Else
            speed = 750
            crdtsperclick = 30
        End If

        tmrSpeed.Interval = speed
        tmrSpeed.Enabled = True
        tmrTimeout.Enabled = True
        butterfly.Visible = True
        remains = 100
        idle = 5
        lblIdle.Text = idle
        rbtnEasy.Enabled = False
        rbtnMedium.Enabled = False
        rbtnHard.Enabled = False
        btnStart.Enabled = False
        btnHelp.Enabled = False
        btnStop.Enabled = True
        btnPause.Enabled = True
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        'pause
        tmrSpeed.Enabled = False
        tmrTimeout.Enabled = False
        butterfly.Visible = False
        goldbutterfly.Visible = False

        Dim result As DialogResult = MessageBox.Show("Your Credits: " & credits & vbCrLf & vbCrLf & "Do you want to stop this game?", "Stop Game", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            'reset everything and startup
            tmrSpeed.Enabled = False
            tmrTimeout.Enabled = False
            rbtnEasy.Enabled = True
            rbtnMedium.Enabled = True
            rbtnHard.Enabled = True
            btnStart.Enabled = True
            btnHelp.Enabled = True
            btnStop.Enabled = False
            btnPause.Enabled = False
            remains = 100
            idle = 0
            credits = 0
            lblIdle.Text = idle
            lblCredits.Text = credits
            timeoutbar.Value = remains
            'guess if someone resume after pause it
            btnPause.Text = "Pause"
        ElseIf result = Windows.Forms.DialogResult.No Then
            'resume
            tmrSpeed.Enabled = True
            tmrTimeout.Enabled = True
            butterfly.Visible = True
            'guess if someone resume after pause it
            btnPause.Text = "Pause"
        End If
    End Sub

    Private Sub tmrTimeout_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeout.Tick
        'reducing timeout
        idle = idle - 1
        If idle = 0 Then
            'this is the punishment for ur delay!
            If credits > 0 Then
                credits = credits - 10
            End If
            remains = remains - 20
        End If

        If idle = -1 Then
            'start a new count
            idle = 5
        End If

        lblIdle.Text = idle
        lblCredits.Text = credits
        timeoutbar.Value = remains

        If remains = 0 Then
            'game over
            tmrSpeed.Enabled = False
            tmrTimeout.Enabled = False
            butterfly.Visible = False
            goldbutterfly.Visible = False

            Dim result As DialogResult = MessageBox.Show("Your Credits: " & credits & vbCrLf & vbCrLf & "Do you want to start a new game?", "Game Over", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                'new game
                If rbtnEasy.Checked = True Then
                    speed = 1250
                    crdtsperclick = 10
                ElseIf rbtnMedium.Checked = True Then
                    speed = 1000
                    crdtsperclick = 20
                Else
                    speed = 750
                    crdtsperclick = 30
                End If

                tmrSpeed.Interval = speed
                tmrSpeed.Enabled = True
                tmrTimeout.Enabled = True
                butterfly.Visible = True
                remains = 100
                idle = 5
                credits = 0
                lblIdle.Text = idle
                timeoutbar.Value = remains
                lblCredits.Text = credits
                rbtnEasy.Enabled = False
                rbtnMedium.Enabled = False
                rbtnHard.Enabled = False
                btnStart.Enabled = False
                btnHelp.Enabled = False
                btnStop.Enabled = True
                btnPause.Enabled = True
            ElseIf result = Windows.Forms.DialogResult.No Then
                'reset everything and statup
                tmrSpeed.Enabled = False
                tmrTimeout.Enabled = False
                rbtnEasy.Enabled = True
                rbtnMedium.Enabled = True
                rbtnHard.Enabled = True
                btnStart.Enabled = True
                btnHelp.Enabled = True
                btnStop.Enabled = False
                btnPause.Enabled = False
                remains = 100
                idle = 0
                credits = 0
                lblIdle.Text = idle
                lblCredits.Text = credits
                timeoutbar.Value = remains
            End If
        End If
        'catch gold butterfly and win 50 credits
        randval = Int(Rnd() * 10)
        hor = Int(Rnd() * 700)
        ver = Int(Rnd() * 300)
        goldbutterfly.Location = New Point(hor, ver)
        If randval = 7 Then
            goldbutterfly.Visible = True
        Else
            goldbutterfly.Visible = False
        End If
    End Sub

    Private Sub bgImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bgImage.Click
        If tmrTimeout.Enabled = True Then
            'punishment :P
            If credits > 0 Then
                credits = credits - 10
            End If
            remains = remains - 20
            idle = 5
            lblCredits.Text = credits
            lblIdle.Text = idle
            timeoutbar.Value = remains

            If remains = 0 Then
                'game over
                tmrSpeed.Enabled = False
                tmrTimeout.Enabled = False
                butterfly.Visible = False
                goldbutterfly.Visible = False

                Dim result As DialogResult = MessageBox.Show("Your Credits: " & credits & vbCrLf & vbCrLf & "Do you want to start a new game?", "Game Over", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    'new game
                    If rbtnEasy.Checked = True Then
                        speed = 1250
                        crdtsperclick = 10
                    ElseIf rbtnMedium.Checked = True Then
                        speed = 1000
                        crdtsperclick = 20
                    Else
                        speed = 750
                        crdtsperclick = 30
                    End If

                    tmrSpeed.Interval = speed
                    tmrSpeed.Enabled = True
                    tmrTimeout.Enabled = True
                    butterfly.Visible = True
                    remains = 100
                    idle = 5
                    credits = 0
                    lblIdle.Text = idle
                    timeoutbar.Value = remains
                    lblCredits.Text = credits
                    rbtnEasy.Enabled = False
                    rbtnMedium.Enabled = False
                    rbtnHard.Enabled = False
                    btnStart.Enabled = False
                    btnHelp.Enabled = False
                    btnStop.Enabled = True
                    btnPause.Enabled = True
                ElseIf result = Windows.Forms.DialogResult.No Then
                    'reset everything and startup
                    tmrSpeed.Enabled = False
                    tmrTimeout.Enabled = False
                    rbtnEasy.Enabled = True
                    rbtnMedium.Enabled = True
                    rbtnHard.Enabled = True
                    btnStart.Enabled = True
                    btnHelp.Enabled = True
                    btnStop.Enabled = False
                    btnPause.Enabled = False
                    remains = 100
                    idle = 0
                    credits = 0
                    lblIdle.Text = idle
                    lblCredits.Text = credits
                    timeoutbar.Value = remains
                End If
            End If
        End If
    End Sub

    Private Sub butterfly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butterfly.Click
        If tmrTimeout.Enabled = True Then
            credits = credits + crdtsperclick
            lblCredits.Text = credits
            idle = 5
            lblIdle.Text = idle
        End If
    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        'toggle switch
        If tmrTimeout.Enabled = True Then
            tmrSpeed.Enabled = False
            tmrTimeout.Enabled = False
            btnPause.Text = "Resume"
        Else
            tmrSpeed.Enabled = True
            tmrTimeout.Enabled = True
            btnPause.Text = "Pause"
        End If
    End Sub

    Private Sub goldbutterfly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goldbutterfly.Click
        If tmrTimeout.Enabled = True Then
            credits = credits + 50
            lblCredits.Text = credits
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        frmHelp.Show()
    End Sub

End Class

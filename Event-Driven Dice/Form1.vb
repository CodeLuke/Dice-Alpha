Public Class frmDiceGame

    Dim Die1, Die2, Die3 As Integer
    Dim DicePoints As Integer
    Dim random As Random
    Dim RollCount As Integer = 0
    Dim Chips As Integer = 100


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Starts the timer when Start is clicked
        tmrTimer.Start()
        btnReset.Enabled = False

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clears variable and list values when reset is clicked
        GameScore = 0
        Die1 = 0 : Die2 = 0 : Die3 = 0
        RollCount = 0

        lstScore.Items.Clear()
        btnStart.Enabled = True

    End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        'Increments the load bar every tick
        random = New Random

        prbLoad.Increment(4)

        If prbLoad.Value = 100 Then
            'Adds the necessary points on the random dice when the load bar reaches 100
            tmrTimer.Stop()
            prbLoad.Value = 0
            RollCount += 1

            DicePoints = Die1 + Die2 + Die3

            If Die1 = 6 And Die2 = 6 And Die3 = 6 Then
                DicePoints += 18
            ElseIf (Die1 = 6 And Die2 = 6) Or (Die1 = 6 And Die3 = 6) Or (Die2 = 6 And Die3 = 6) Then
                DicePoints += 12
            ElseIf Die1 = 6 Xor Die2 = 6 Xor Die3 = 6 Then
                DicePoints += 6
            End If

            If Die1 = Die2 And Die2 = Die3 Then
                DicePoints *= 2
            End If

            'Adds Score to list
            lstScore.Items.Add("Roll " & RollCount & ": " & DicePoints)
            GameScore += DicePoints
            DicePoints = 0
            'Ends game after maximum number of rolls (5)
            If RollCount >= 5 Then
                MsgBox("Your game score was " & GameScore,, "Game Over")
                tmrTimer.Stop()
                btnStart.Enabled = False
                btnReset.Enabled = True

            End If


        Else
            'Sets dice to random number when the timer ticks before the load bar is full
            Die1 = random.Next(1, 7)
            Die2 = random.Next(1, 7)
            Die3 = random.Next(1, 7)

            MatchImage(Die1, pbxDie1)
            MatchImage(Die2, pbxDie2)
            MatchImage(Die3, pbxDie3)

        End If

    End Sub

    Dim GameScore As Integer


    Private Sub frmDiceGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialises dice images to 6
        pbxDie1.Image = My.Resources.dieface6
        pbxDie2.Image = My.Resources.dieface6
        pbxDie3.Image = My.Resources.dieface6


        btnStart.Enabled = False

    End Sub

    Sub MatchImage(Die As Integer, pbxDie As PictureBox)
        If Die = 1 Then
            pbxDie.Image = My.Resources.dieface1

        ElseIf Die = 2 Then
            pbxDie.Image = My.Resources.dieface2

        ElseIf Die = 3 Then
            pbxDie.Image = My.Resources.dieface3

        ElseIf Die = 4 Then
            pbxDie.Image = My.Resources.dieface4

        ElseIf Die = 5 Then
            pbxDie.Image = My.Resources.dieface5

        ElseIf Die = 6 Then
            pbxDie.Image = My.Resources.dieface6
        End If
    End Sub
End Class

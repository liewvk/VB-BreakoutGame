Public Class Form1
    Dim paddleSpeed As Integer = 15
    Dim ballSpeedX As Integer = 5
    Dim ballSpeedY As Integer = -5

    Dim movingLeft As Boolean = False
    Dim movingRight As Boolean = False

    Dim score As Integer = 0
    Dim lives As Integer = 3

    Dim gameStarted As Boolean = False
    Dim gameOver As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        lblScore.Text = "Score: 0"
        lblLives.Text = "Lives: 3"
        lblStatus.Text = "Click Start to begin."

        gameTimer.Interval = 20
    End Sub

    Private Sub StartGame()
        score = 0
        lives = 3
        gameStarted = True
        gameOver = False

        lblScore.Text = "Score: 0"
        lblLives.Text = "Lives: 3"
        lblStatus.Text = "Break all the bricks!"

        ResetAllBricks()
        ResetBallAndPaddle()

        gameTimer.Start()
    End Sub

    Private Sub ResetBallAndPaddle()
        picPaddle.Left = (Me.ClientSize.Width - picPaddle.Width) \ 2
        picPaddle.Top = Me.ClientSize.Height - 80

        picBall.Left = picPaddle.Left + (picPaddle.Width \ 2) - (picBall.Width \ 2)
        picBall.Top = picPaddle.Top - picBall.Height - 5

        ballSpeedX = 5
        ballSpeedY = -5
    End Sub

    Private Sub ResetAllBricks()
        For Each ctrl As Control In Me.Controls
            If ctrl.Tag = "brick" Then
                ctrl.Visible = True
            End If
        Next
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Not gameStarted OrElse gameOver Then Exit Sub

        If e.KeyCode = Keys.Left Then
            movingLeft = True
        ElseIf e.KeyCode = Keys.Right Then
            movingRight = True
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Then
            movingLeft = False
        ElseIf e.KeyCode = Keys.Right Then
            movingRight = False
        End If
    End Sub

    Private Sub MovePaddle()
        If movingLeft Then picPaddle.Left -= paddleSpeed
        If movingRight Then picPaddle.Left += paddleSpeed

        If picPaddle.Left < 0 Then picPaddle.Left = 0
        If picPaddle.Right > Me.ClientSize.Width Then
            picPaddle.Left = Me.ClientSize.Width - picPaddle.Width
        End If
    End Sub

    Private Sub MoveBall()
        picBall.Left += ballSpeedX
        picBall.Top += ballSpeedY
    End Sub

    Private Sub CheckBrickCollision()
        For Each ctrl As Control In Me.Controls
            If ctrl.Tag = "brick" AndAlso ctrl.Visible Then
                If picBall.Bounds.IntersectsWith(ctrl.Bounds) Then
                    ctrl.Visible = False
                    score += 10
                    lblScore.Text = "Score: " & score.ToString()
                    ballSpeedY = -ballSpeedY
                    Exit For
                End If
            End If
        Next
    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If Not gameStarted OrElse gameOver Then Exit Sub

        MovePaddle()
        MoveBall()

        If picBall.Left <= 0 OrElse picBall.Right >= Me.ClientSize.Width Then
            ballSpeedX = -ballSpeedX
        End If

        If picBall.Top <= 0 Then
            ballSpeedY = -ballSpeedY
        End If

        If picBall.Bounds.IntersectsWith(picPaddle.Bounds) AndAlso ballSpeedY > 0 Then
            ballSpeedY = -ballSpeedY
        End If

        CheckBrickCollision()
        CheckForWin()

        If gameOver Then Exit Sub

        If picBall.Top > Me.ClientSize.Height Then
            lives -= 1
            lblLives.Text = "Lives: " & lives.ToString()

            If lives <= 0 Then
                ShowGameOver()
            Else
                ResetBallAndPaddle()
            End If
        End If
    End Sub
    Private Sub GameButtons_PreviewKeyDown(
    sender As Object,
    e As PreviewKeyDownEventArgs
) Handles btnStart.PreviewKeyDown, btnRestart.PreviewKeyDown

        If e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right Then
            e.IsInputKey = True
        End If
    End Sub
    Private Sub Form1_Deactivate(
    sender As Object,
    e As EventArgs
) Handles Me.Deactivate

        movingLeft = False
        movingRight = False
    End Sub

    Private Sub CheckForWin()
        For Each ctrl As Control In Me.Controls
            If ctrl.Tag = "brick" AndAlso ctrl.Visible Then
                Exit Sub
            End If
        Next

        ' No bricks remain.
        gameTimer.Stop()
        gameStarted = False
        gameOver = True
        movingLeft = False
        movingRight = False

        lblStatus.Text = "You win!"
        MessageBox.Show("Congratulations! You broke all the bricks.",
                    "You win!")
    End Sub

    Private Sub ShowGameOver()
        gameTimer.Stop()
        gameStarted = False
        gameOver = True
        lblStatus.Text = "Game Over!"
        MessageBox.Show("You lost all your lives.")
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartGame()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        StartGame()
    End Sub

End Class

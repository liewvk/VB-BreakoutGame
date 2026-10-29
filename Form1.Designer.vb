<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnStart = New Button()
        btnRestart = New Button()
        btnExit = New Button()
        lblScore = New Label()
        lblLives = New Label()
        lblStatus = New Label()
        picBall = New PictureBox()
        picPaddle = New PictureBox()
        gameTimer = New Timer(components)
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel9 = New Panel()
        CType(picBall, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPaddle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(12, 37)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(108, 31)
        btnStart.TabIndex = 0
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRestart.Location = New Point(12, 87)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(108, 31)
        btnRestart.TabIndex = 0
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(12, 142)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(108, 31)
        btnExit.TabIndex = 0
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(22, 210)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(56, 25)
        lblScore.TabIndex = 1
        lblScore.Text = "Score"
        ' 
        ' lblLives
        ' 
        lblLives.AutoSize = True
        lblLives.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLives.Location = New Point(22, 258)
        lblLives.Name = "lblLives"
        lblLives.Size = New Size(50, 25)
        lblLives.TabIndex = 1
        lblLives.Text = "Lives"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(22, 305)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(60, 25)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Status"
        ' 
        ' picBall
        ' 
        picBall.Image = CType(resources.GetObject("picBall.Image"), Image)
        picBall.Location = New Point(191, 370)
        picBall.Name = "picBall"
        picBall.Size = New Size(31, 30)
        picBall.SizeMode = PictureBoxSizeMode.StretchImage
        picBall.TabIndex = 2
        picBall.TabStop = False
        ' 
        ' picPaddle
        ' 
        picPaddle.Image = CType(resources.GetObject("picPaddle.Image"), Image)
        picPaddle.Location = New Point(437, 370)
        picPaddle.Name = "picPaddle"
        picPaddle.Size = New Size(162, 30)
        picPaddle.SizeMode = PictureBoxSizeMode.StretchImage
        picPaddle.TabIndex = 2
        picPaddle.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel1.Location = New Point(245, 43)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(60, 20)
        Panel1.TabIndex = 3
        Panel1.Tag = "brick"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel2.Location = New Point(388, 43)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(60, 20)
        Panel2.TabIndex = 3
        Panel2.Tag = "brick"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel3.Location = New Point(528, 43)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(60, 20)
        Panel3.TabIndex = 3
        Panel3.Tag = "brick"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel4.Location = New Point(245, 89)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(60, 20)
        Panel4.TabIndex = 3
        Panel4.Tag = "brick"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel5.Location = New Point(388, 87)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(60, 20)
        Panel5.TabIndex = 3
        Panel5.Tag = "brick"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel6.Location = New Point(528, 87)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(60, 20)
        Panel6.TabIndex = 3
        Panel6.Tag = "brick"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel7.Location = New Point(245, 131)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(60, 20)
        Panel7.TabIndex = 3
        Panel7.Tag = "brick"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel8.Location = New Point(528, 129)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(60, 20)
        Panel8.TabIndex = 3
        Panel8.Tag = "brick"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel9.Location = New Point(388, 129)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(60, 20)
        Panel9.TabIndex = 3
        Panel9.Tag = "brick"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 450)
        Controls.Add(Panel9)
        Controls.Add(Panel8)
        Controls.Add(Panel5)
        Controls.Add(Panel6)
        Controls.Add(Panel7)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(picPaddle)
        Controls.Add(picBall)
        Controls.Add(lblStatus)
        Controls.Add(lblLives)
        Controls.Add(lblScore)
        Controls.Add(btnExit)
        Controls.Add(btnRestart)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "Breakout Game"
        CType(picBall, ComponentModel.ISupportInitialize).EndInit()
        CType(picPaddle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents picBall As PictureBox
    Friend WithEvents picPaddle As PictureBox
    Friend WithEvents gameTimer As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel

End Class

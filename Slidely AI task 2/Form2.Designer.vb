Partial Class Form2
    Inherits System.Windows.Forms.Form

    ' Declare controls
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Private WithEvents txtGithubLink As System.Windows.Forms.TextBox
    Private WithEvents txtStopwatchTime As System.Windows.Forms.TextBox
    Private WithEvents btnPrevious As System.Windows.Forms.Button
    Private WithEvents btnNext As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private lblHeading As System.Windows.Forms.Label
    Private lblName As System.Windows.Forms.Label
    Private lblEmail As System.Windows.Forms.Label
    Private lblPhoneNum As System.Windows.Forms.Label
    Private lblGithubLink As System.Windows.Forms.Label
    Private lblStopwatchTime As System.Windows.Forms.Label
    Private WithEvents panelTitleBar As System.Windows.Forms.Panel
    Private WithEvents panelBodyBar As System.Windows.Forms.Panel

    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnClose = New Button()
        lblHeading = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNum = New Label()
        lblGithubLink = New Label()
        lblStopwatchTime = New Label()
        panelTitleBar = New Panel()
        panelBodyBar = New Panel()
        panelTitleBar.SuspendLayout()
        panelBodyBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.LightGray
        txtName.Location = New Point(342, 116)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(250, 31)
        txtName.TabIndex = 0
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.LightGray
        txtEmail.Location = New Point(342, 171)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(250, 31)
        txtEmail.TabIndex = 1
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.BackColor = Color.LightGray
        txtPhoneNum.Location = New Point(342, 227)
        txtPhoneNum.Multiline = True
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.ReadOnly = True
        txtPhoneNum.Size = New Size(250, 37)
        txtPhoneNum.TabIndex = 2
        txtPhoneNum.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.LightGray
        txtGithubLink.Location = New Point(342, 290)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(250, 47)
        txtGithubLink.TabIndex = 3
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = Color.LightGray
        txtStopwatchTime.Location = New Point(342, 364)
        txtStopwatchTime.Multiline = True
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(250, 37)
        txtStopwatchTime.TabIndex = 4
        txtStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.LightGoldenrodYellow
        btnPrevious.Location = New Point(3, 412)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(308, 41)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "PREVIOUS (Ctrl+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightBlue
        btnNext.Location = New Point(318, 412)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(281, 41)
        btnNext.TabIndex = 6
        btnNext.Text = "NEXT (Ctrl+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.LightPink
        btnClose.ForeColor = Color.Black
        btnClose.Location = New Point(538, -3)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(65, 54)
        btnClose.TabIndex = 7
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Arial", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(18, 13)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(459, 23)
        lblHeading.TabIndex = 8
        lblHeading.Text = "Vivek Upadhyay, Slidely Task 2 - View Submissions"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(18, 68)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 9
        lblName.Text = "Name"
        lblName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(23, 126)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 10
        lblEmail.Text = "Email"
        lblEmail.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Location = New Point(18, 188)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(106, 25)
        lblPhoneNum.TabIndex = 11
        lblPhoneNum.Text = "Phone Num"
        lblPhoneNum.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(18, 236)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(116, 50)
        lblGithubLink.TabIndex = 12
        lblGithubLink.Text = " Github Link  " & vbCrLf & " For Task 2"
        lblGithubLink.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(18, 303)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(100, 50)
        lblStopwatchTime.TabIndex = 13
        lblStopwatchTime.Text = "Stopwatch " & vbCrLf & "time"
        lblStopwatchTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' panelTitleBar
        ' 
        panelTitleBar.BackColor = SystemColors.Window
        panelTitleBar.BorderStyle = BorderStyle.FixedSingle
        panelTitleBar.Controls.Add(btnClose)
        panelTitleBar.Location = New Point(1, 1)
        panelTitleBar.Name = "panelTitleBar"
        panelTitleBar.Size = New Size(604, 52)
        panelTitleBar.TabIndex = 1
        ' 
        ' panelBodyBar
        ' 
        panelBodyBar.AllowDrop = True
        panelBodyBar.BackColor = SystemColors.Window
        panelBodyBar.BorderStyle = BorderStyle.FixedSingle
        panelBodyBar.Controls.Add(lblStopwatchTime)
        panelBodyBar.Controls.Add(lblGithubLink)
        panelBodyBar.Controls.Add(lblPhoneNum)
        panelBodyBar.Controls.Add(lblEmail)
        panelBodyBar.Controls.Add(lblName)
        panelBodyBar.Controls.Add(btnPrevious)
        panelBodyBar.Controls.Add(lblHeading)
        panelBodyBar.Controls.Add(btnNext)
        panelBodyBar.Location = New Point(1, 52)
        panelBodyBar.Name = "panelBodyBar"
        panelBodyBar.Size = New Size(604, 558)
        panelBodyBar.TabIndex = 0
        ' 
        ' Form2
        ' 
        BackColor = Color.White
        ClientSize = New Size(607, 612)
        Controls.Add(txtName)
        Controls.Add(txtEmail)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtGithubLink)
        Controls.Add(txtStopwatchTime)
        Controls.Add(panelTitleBar)
        Controls.Add(panelBodyBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        Text = "Vivek Upadhyay, Slidely Task 2 - View Submissions"
        panelTitleBar.ResumeLayout(False)
        panelBodyBar.ResumeLayout(False)
        panelBodyBar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
End Class

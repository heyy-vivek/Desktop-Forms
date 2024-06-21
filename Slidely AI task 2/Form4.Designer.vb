Partial Class Form4
    Inherits System.Windows.Forms.Form
    Private WithEvents txtEmailSearch As System.Windows.Forms.TextBox
    Private WithEvents btnSearch As System.Windows.Forms.Button
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Private WithEvents txtGithubLink As System.Windows.Forms.TextBox
    Private WithEvents txtStopwatchTime As System.Windows.Forms.TextBox
    Private WithEvents btnUpdate As System.Windows.Forms.Button
    Private WithEvents btnDelete As System.Windows.Forms.Button
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
        btnSearch = New Button()
        txtEmailSearch = New TextBox()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnUpdate = New Button()
        btnDelete = New Button()
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
        panelBodyBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.NavajoWhite
        btnSearch.Location = New Point(12, 113)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(173, 38)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search by Email ID"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtEmailSearch
        ' 
        txtEmailSearch.Location = New Point(252, 120)
        txtEmailSearch.Name = "txtEmailSearch"
        txtEmailSearch.Size = New Size(257, 31)
        txtEmailSearch.TabIndex = 1
        txtEmailSearch.Text = "Enter Email"
        txtEmailSearch.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(252, 192)
        txtName.Name = "txtName"
        txtName.Size = New Size(257, 31)
        txtName.TabIndex = 0
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(252, 242)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(257, 31)
        txtEmail.TabIndex = 1
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(252, 294)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(257, 31)
        txtPhoneNum.TabIndex = 2
        txtPhoneNum.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(252, 348)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(257, 50)
        txtGithubLink.TabIndex = 3
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(252, 442)
        txtStopwatchTime.Multiline = True
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(257, 36)
        txtStopwatchTime.TabIndex = 4
        txtStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.LightGreen
        btnUpdate.Location = New Point(3, 473)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(251, 43)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "Update (CTRL+U)"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LightCoral
        btnDelete.Location = New Point(262, 527)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(247, 43)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete (CTRL+D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.LightGoldenrodYellow
        btnPrevious.Location = New Point(3, 545)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(251, 44)
        btnPrevious.TabIndex = 7
        btnPrevious.Text = "Previous (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightBlue
        btnNext.Location = New Point(262, 599)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(247, 44)
        btnNext.TabIndex = 8
        btnNext.Text = "Next (CTRL+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.LightPink
        btnClose.ForeColor = Color.Black
        btnClose.Location = New Point(473, 1)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 52)
        btnClose.TabIndex = 9
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Arial", 10.0F)
        lblHeading.Location = New Point(3, 12)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(479, 23)
        lblHeading.TabIndex = 8
        lblHeading.Text = "Vivek Upadhyay, Slidely Task 2 - Update Submissions"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(20, 198)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 9
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(25, 248)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 10
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Location = New Point(20, 300)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(106, 25)
        lblPhoneNum.TabIndex = 11
        lblPhoneNum.Text = "Phone Num"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(20, 351)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(106, 50)
        lblGithubLink.TabIndex = 12
        lblGithubLink.Text = "Github Link " & vbCrLf & " For Task 2"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(20, 428)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(95, 50)
        lblStopwatchTime.TabIndex = 13
        lblStopwatchTime.Text = "Stopwatch" & vbCrLf & "    time"
        ' 
        ' panelTitleBar
        ' 
        panelTitleBar.BackColor = SystemColors.Window
        panelTitleBar.BorderStyle = BorderStyle.FixedSingle
        panelTitleBar.Location = New Point(1, 1)
        panelTitleBar.Name = "panelTitleBar"
        panelTitleBar.Size = New Size(548, 52)
        panelTitleBar.TabIndex = 0
        ' 
        ' panelBodyBar
        ' 
        panelBodyBar.AllowDrop = True
        panelBodyBar.BackColor = SystemColors.Window
        panelBodyBar.BorderStyle = BorderStyle.FixedSingle
        panelBodyBar.Controls.Add(btnUpdate)
        panelBodyBar.Controls.Add(lblHeading)
        panelBodyBar.Controls.Add(btnPrevious)
        panelBodyBar.Location = New Point(1, 53)
        panelBodyBar.Name = "panelBodyBar"
        panelBodyBar.Size = New Size(547, 643)
        panelBodyBar.TabIndex = 0
        ' 
        ' Form4
        ' 
        BackColor = Color.White
        ClientSize = New Size(550, 697)
        Controls.Add(btnClose)
        Controls.Add(btnNext)
        Controls.Add(btnDelete)
        Controls.Add(btnSearch)
        Controls.Add(txtEmailSearch)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhoneNum)
        Controls.Add(lblEmail)
        Controls.Add(panelTitleBar)
        Controls.Add(panelBodyBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        Text = "Update Submission"
        panelBodyBar.ResumeLayout(False)
        panelBodyBar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

End Class

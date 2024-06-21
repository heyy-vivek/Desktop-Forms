Partial Class Form3
    Inherits System.Windows.Forms.Form

    ' Declare controls
    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhone As System.Windows.Forms.TextBox
    Private WithEvents txtGitHub As System.Windows.Forms.TextBox
    Private WithEvents txtStopwatch As System.Windows.Forms.TextBox
    Private WithEvents btnToggleStopwatch As System.Windows.Forms.Button
    Private WithEvents btnSubmit As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private lblHeading As System.Windows.Forms.Label
    Private lblName As System.Windows.Forms.Label
    Private lblEmail As System.Windows.Forms.Label
    Private lblPhone As System.Windows.Forms.Label
    Private lblGitHub As System.Windows.Forms.Label
    Private WithEvents panelTitleBar As System.Windows.Forms.Panel
    Private WithEvents panelBodyBar As System.Windows.Forms.Panel


    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        txtStopwatch = New TextBox()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        btnClose = New Button()
        lblHeading = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGitHub = New Label()
        panelTitleBar = New Panel()
        panelBodyBar = New Panel()
        panelTitleBar.SuspendLayout()
        panelBodyBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(150, 153)
        txtName.Name = "txtName"
        txtName.Size = New Size(449, 31)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(150, 217)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(449, 31)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(150, 274)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(449, 31)
        txtPhone.TabIndex = 2
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(150, 327)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(449, 31)
        txtGitHub.TabIndex = 3
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.BackColor = Color.LightGray
        txtStopwatch.ForeColor = Color.Black
        txtStopwatch.Location = New Point(331, 396)
        txtStopwatch.Multiline = True
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.ReadOnly = True
        txtStopwatch.Size = New Size(268, 41)
        txtStopwatch.TabIndex = 4
        txtStopwatch.Text = "00:00:00"
        txtStopwatch.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.LightGoldenrodYellow
        btnToggleStopwatch.Location = New Point(12, 396)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(313, 41)
        btnToggleStopwatch.TabIndex = 5
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (Ctrl+T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.ForeColor = Color.Black
        btnSubmit.Location = New Point(12, 481)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(587, 41)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "SUBMIT (Ctrl+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.LightPink
        btnClose.ForeColor = Color.Black
        btnClose.Location = New Point(566, -2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(59, 53)
        btnClose.TabIndex = 7
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Arial", 10.0F)
        lblHeading.Location = New Point(10, 38)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(466, 23)
        lblHeading.TabIndex = 8
        lblHeading.Text = "Vivek Upadhyay, Slidely Task 2 - Create Submission"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(30, 156)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 9
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(30, 220)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 10
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(23, 274)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(106, 25)
        lblPhone.TabIndex = 11
        lblPhone.Text = "Phone Num"
        ' 
        ' lblGitHub
        ' 
        lblGitHub.AutoSize = True
        lblGitHub.Location = New Point(20, 317)
        lblGitHub.Name = "lblGitHub"
        lblGitHub.Size = New Size(109, 50)
        lblGitHub.TabIndex = 12
        lblGitHub.Text = "GitHub Link " & vbCrLf & " For Task 2"
        ' 
        ' panelTitleBar
        ' 
        panelTitleBar.BackColor = SystemColors.Window
        panelTitleBar.BorderStyle = BorderStyle.FixedSingle
        panelTitleBar.Controls.Add(btnClose)
        panelTitleBar.Location = New Point(1, 1)
        panelTitleBar.Name = "panelTitleBar"
        panelTitleBar.Size = New Size(626, 52)
        panelTitleBar.TabIndex = 0
        ' 
        ' panelBodyBar
        ' 
        panelBodyBar.AllowDrop = True
        panelBodyBar.BackColor = SystemColors.Window
        panelBodyBar.BorderStyle = BorderStyle.FixedSingle
        panelBodyBar.Controls.Add(lblHeading)
        panelBodyBar.Location = New Point(1, 53)
        panelBodyBar.Name = "panelBodyBar"
        panelBodyBar.Size = New Size(626, 558)
        panelBodyBar.TabIndex = 0
        ' 
        ' Form3
        ' 
        BackColor = Color.White
        ClientSize = New Size(629, 613)
        Controls.Add(lblName)
        Controls.Add(lblEmail)
        Controls.Add(lblPhone)
        Controls.Add(lblGitHub)
        Controls.Add(txtName)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGitHub)
        Controls.Add(txtStopwatch)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(btnSubmit)
        Controls.Add(panelTitleBar)
        Controls.Add(panelBodyBar)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        Text = "Vivek Upadhyay, Slidely Task 2 - Create Submission"
        panelTitleBar.ResumeLayout(False)
        panelBodyBar.ResumeLayout(False)
        panelBodyBar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
End Class

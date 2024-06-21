Partial Class Form1
    Inherits System.Windows.Forms.Form
    Private WithEvents panelTitleBar As System.Windows.Forms.Panel
    Private WithEvents panelBodyBar As System.Windows.Forms.Panel
    Private WithEvents btnViewSubmissions As System.Windows.Forms.Button
    Private WithEvents btnCreateSubmission As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnUpdate As System.Windows.Forms.Button

    Private lblHeading As System.Windows.Forms.Label

    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        btnClose = New Button()
        btnUpdate = New Button()
        lblHeading = New Label()
        panelTitleBar = New Panel()
        panelBodyBar = New Panel()
        panelTitleBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.LightGoldenrodYellow
        btnViewSubmissions.FlatAppearance.BorderSize = 0
        btnViewSubmissions.FlatStyle = FlatStyle.Flat
        btnViewSubmissions.ForeColor = Color.Black
        btnViewSubmissions.Location = New Point(14, 140)
        btnViewSubmissions.Margin = New Padding(5, 6, 5, 6)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(568, 64)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL+V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.LightBlue
        btnCreateSubmission.ForeColor = Color.Black
        btnCreateSubmission.Location = New Point(14, 216)
        btnCreateSubmission.Margin = New Padding(5, 6, 5, 6)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(568, 64)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL+N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.LightPink
        btnClose.ForeColor = Color.Black
        btnClose.Location = New Point(528, -1)
        btnClose.Margin = New Padding(5, 6, 5, 6)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(74, 58)
        btnClose.TabIndex = 0
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.LightGreen
        btnUpdate.ForeColor = Color.Black
        btnUpdate.Location = New Point(14, 292)
        btnUpdate.Margin = New Padding(5, 6, 5, 6)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(568, 64)
        btnUpdate.TabIndex = 4
        btnUpdate.Text = "UPDATE (CTRL+U)"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Arial", 10.0F)
        lblHeading.Location = New Point(14, 80)
        lblHeading.Margin = New Padding(5, 0, 5, 0)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(450, 23)
        lblHeading.TabIndex = 3
        lblHeading.Text = "Vivek Upadhyay, Slidely Task 2 - Slidely Form App"
        ' 
        ' panelTitleBar
        ' 
        panelTitleBar.BackColor = SystemColors.Window
        panelTitleBar.BorderStyle = BorderStyle.FixedSingle
        panelTitleBar.Controls.Add(panelBodyBar)
        panelTitleBar.Controls.Add(btnClose)
        panelTitleBar.Location = New Point(0, 1)
        panelTitleBar.Name = "panelTitleBar"
        panelTitleBar.Size = New Size(598, 364)
        panelTitleBar.TabIndex = 0
        ' 
        ' panelBodyBar
        ' 
        panelBodyBar.AllowDrop = True
        panelBodyBar.BackColor = SystemColors.Window
        panelBodyBar.BorderStyle = BorderStyle.FixedSingle
        panelBodyBar.Location = New Point(-1, 51)
        panelBodyBar.Name = "panelBodyBar"
        panelBodyBar.Size = New Size(603, 320)
        panelBodyBar.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(601, 368)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnUpdate)
        Controls.Add(lblHeading)
        Controls.Add(panelTitleBar)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 6, 5, 6)
        Name = "Form1"
        Text = "Vivek Upadhyay, Slidely Task 2 - Slidely Form App"
        panelTitleBar.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()


    End Sub
End Class

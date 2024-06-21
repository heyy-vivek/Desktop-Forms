
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class Form2
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0
    Public drag As Boolean
    Public down As Integer
    Public up As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        LoadSubmissions()
        Me.KeyPreview = True
    End Sub

    Private Sub LoadSubmissions()
        Try
            Dim json As String = File.ReadAllText("C:\Users\vivek\Desktop\Slidely AI\Backend\db.json")
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
            If submissions Is Nothing OrElse submissions.Count = 0 Then
                Throw New Exception("No data found in the JSON file.")
            End If
            DisplayCurrentSubmission()
        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}")
        End Try
    End Sub

    Private Sub DisplayCurrentSubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission As Submission = submissions(currentIndex)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhoneNum.Text = submission.Phone
            txtGithubLink.Text = submission.GithubLink
            txtStopwatchTime.Text = submission.StopwatchTime
        End If
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set the form's title
        Me.Text = "Vivek Upadhyay, Slidely Task 2 - View Submissions"
        Me.FormBorderStyle = FormBorderStyle.None

        RoundButtonHelper.RoundButton(btnNext)
        RoundButtonHelper.RoundButton(btnPrevious)

        ' Set controls to read-only
        txtName.ReadOnly = True
        txtEmail.ReadOnly = True
        txtPhoneNum.ReadOnly = True
        txtGithubLink.ReadOnly = True
        txtStopwatchTime.ReadOnly = True


    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle keyboard shortcuts
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ' Navigate to previous entry
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplayCurrentSubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Navigate to next entry
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplayCurrentSubmission()
        End If
    End Sub


    Private Sub txtGithubLink_TextChanged(sender As Object, e As EventArgs) Handles txtGithubLink.TextChanged

    End Sub



    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            down = e.X
            up = e.Y
        End If
    End Sub

    Private Sub panelTitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseUp
        If e.Button = MouseButtons.Left Then
            drag = False
        End If
    End Sub

    Private Sub panelTitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseMove
        If drag Then
            Dim temp As Point = New Point
            temp.X = Location.X + (e.X - down)
            temp.Y = Location.Y + (e.Y - up)
            Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub panelTitleBar_Paint(sender As Object, e As PaintEventArgs) Handles panelTitleBar.Paint

    End Sub

    Private Sub panelBodyBar_Paint(sender As Object, e As PaintEventArgs) Handles panelBodyBar.Paint

    End Sub

    ' Handle the mouse down event to allow form dragging
    'Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
    'If e.Button = MouseButtons.Left Then
    '       ReleaseCapture()
    '      SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    'End If
    'End Sub '


End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class


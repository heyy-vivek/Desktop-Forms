Imports System.Net
Imports System.Net.Http
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports Newtonsoft.Json

Public Class Form3

    Public drag As Boolean
    Public down As Integer
    Public up As Integer

    Private stopwatch As New Stopwatch()

    Public Sub New()
        InitializeComponent()
        ' Additional initialization if needed
        Me.KeyPreview = True
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButtonHelper.RoundButton(btnSubmit)
        RoundButtonHelper.RoundButton(btnToggleStopwatch)
        Me.FormBorderStyle = FormBorderStyle.None


    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        txtStopwatch.Text = stopwatch.Elapsed.ToString()
    End Sub
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .githublink = txtGitHub.Text,
            .stopwatchtime = stopwatch.Elapsed.ToString()
        }
        Dim json As String = JsonConvert.SerializeObject(submission)
        Using client As New HttpClient()
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submissions/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission saved successfully!")
            Else
                MessageBox.Show("Error: " & response.StatusCode.ToString())
            End If
        End Using
    End Sub


    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lblStopwatch_Click(sender As Object, e As EventArgs) Handles txtStopwatch.Click

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtStopwatch_TextChanged(sender As Object, e As EventArgs) Handles txtStopwatch.TextChanged

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



    ' Handle the mouse down event to allow form dragging
    'Private Sub Form3_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
    'If e.Button = MouseButtons.Left Then
    '       ReleaseCapture()
    '      SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    'End If
    'End Sub

End Class


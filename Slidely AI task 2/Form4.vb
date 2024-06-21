Imports System.IO
Imports System.Net.Http
Imports System.Runtime.InteropServices
Imports Newtonsoft.Json

Public Class Form4

    Public Property CurrentIndex As Integer = 0
    Private Submissions As List(Of Submission)

    Private isPlaceholderShown As Boolean
    Public drag As Boolean
    Public down As Integer
    Public up As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.KeyPreview = True
        isPlaceholderShown = True

        ' Load the data
        LoadData()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Vivek Upadhyay, Slidely Task 2 - Update Submission"
        Me.FormBorderStyle = FormBorderStyle.None

        RoundButtonHelper.RoundButton(btnNext)
        RoundButtonHelper.RoundButton(btnPrevious)
        RoundButtonHelper.RoundButton(btnUpdate)
        RoundButtonHelper.RoundButton(btnDelete)

        ' Load the first submission
        If Submissions IsNot Nothing AndAlso Submissions.Count > 0 Then
            DisplaySubmission(CurrentIndex)
        Else
            MessageBox.Show("No submissions found.")
        End If
    End Sub

    Private Sub LoadData()
        Try
            Dim json As String = File.ReadAllText("C:\Users\vivek\Desktop\Slidely AI\Backend\db.json")
            Submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim email As String = txtEmailSearch.Text
        Dim client As New HttpClient()

        Try
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/submissions/search?Email=" & email)
            response.EnsureSuccessStatusCode()
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()

            Dim foundSubmissions As List(Of Submission) = JsonConvert.DeserializeObject(Of List(Of Submission))(responseBody)
            If foundSubmissions IsNot Nothing AndAlso foundSubmissions.Count > 0 Then
                ' Find the index in the original submissions list
                Dim index As Integer = -1
                For i As Integer = 0 To Submissions.Count - 1
                    If Submissions(i).Email = email Then
                        index = i
                        Exit For
                    End If
                Next

                If index >= 0 Then
                    CurrentIndex = index
                    DisplaySubmission(CurrentIndex)
                    MessageBox.Show("submissions found!")
                Else
                    MessageBox.Show("No submissions found with this email.")
                End If
            Else
                MessageBox.Show("No submissions found with this email.")
            End If
        Catch ex As HttpRequestException
            MessageBox.Show("Error searching submissions: " & ex.Message)
        End Try
    End Sub


    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < Submissions.Count Then
            txtName.Text = Submissions(index).Name
            txtEmail.Text = Submissions(index).Email
            txtPhoneNum.Text = Submissions(index).Phone
            txtGithubLink.Text = Submissions(index).GithubLink
            txtStopwatchTime.Text = Submissions(index).StopwatchTime
        End If
    End Sub

    Private Sub SaveData()
        Try
            Dim dbPath As String = "C:\Users\vivek\Desktop\Slidely AI\Backend\db.json"
            Dim jsonData As String = JsonConvert.SerializeObject(Submissions, Formatting.Indented)
            File.WriteAllText(dbPath, jsonData)
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub


    Private Sub txtEmailSearch_Click(sender As Object, e As EventArgs) Handles txtEmailSearch.Click
        If isPlaceholderShown Then
            txtEmailSearch.Text = String.Empty
            isPlaceholderShown = False
        End If
    End Sub

    Private Sub txtEmailSearch_Enter(sender As Object, e As EventArgs) Handles txtEmailSearch.Enter
        If isPlaceholderShown Then
            txtEmailSearch.Text = String.Empty
            isPlaceholderShown = False
        End If
    End Sub

    Private Sub txtEmailSearch_Leave(sender As Object, e As EventArgs) Handles txtEmailSearch.Leave
        If String.IsNullOrWhiteSpace(txtEmailSearch.Text) Then
            txtEmailSearch.Text = "Enter email"
            isPlaceholderShown = True
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Clear the search text box if not showing placeholder
        If Not isPlaceholderShown Then
            txtEmailSearch.Text = "Enter Email"
            isPlaceholderShown = True
        End If

        ' Your existing logic to navigate to the next submission
        If CurrentIndex < Submissions.Count - 1 Then
            CurrentIndex += 1
            DisplaySubmission(CurrentIndex)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ' Clear the search text box if not showing placeholder
        If Not isPlaceholderShown Then
            txtEmailSearch.Text = "Enter Email"
            isPlaceholderShown = True
        End If

        ' Your existing logic to navigate to the previous submission
        If CurrentIndex > 0 Then
            CurrentIndex -= 1
            DisplaySubmission(CurrentIndex)
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not isPlaceholderShown Then
            txtEmailSearch.Text = "Enter Email"
            isPlaceholderShown = True
        End If
        If CurrentIndex >= 0 AndAlso CurrentIndex < Submissions.Count Then
            Submissions(CurrentIndex).Name = txtName.Text
            Submissions(CurrentIndex).Email = txtEmail.Text
            Submissions(CurrentIndex).Phone = txtPhoneNum.Text
            Submissions(CurrentIndex).GithubLink = txtGithubLink.Text
            Submissions(CurrentIndex).StopwatchTime = txtStopwatchTime.Text

            SaveData()
            MessageBox.Show("Submission updated successfully!")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not isPlaceholderShown Then
            txtEmailSearch.Text = "Enter Email"
            isPlaceholderShown = True
        End If
        If CurrentIndex >= 0 AndAlso CurrentIndex < Submissions.Count Then
            Submissions.RemoveAt(CurrentIndex)
            SaveData()

            ' Adjust index if necessary
            If CurrentIndex >= Submissions.Count Then
                CurrentIndex = Submissions.Count - 1
            End If

            If Submissions.Count > 0 Then
                DisplaySubmission(CurrentIndex)
            Else
                ' Clear the fields if no submissions are left
                txtName.Clear()
                txtEmail.Clear()
                txtPhoneNum.Clear()
                txtGithubLink.Clear()
                txtStopwatchTime.Clear()
            End If

            MessageBox.Show("Submission deleted successfully!")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle keyboard shortcuts
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.U Then
            btnUpdate.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
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


End Class



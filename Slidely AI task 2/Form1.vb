Imports System.Runtime.InteropServices

Public Class Form1


    Public drag As Boolean
    Public down As Integer
    Public up As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButtonHelper.RoundButton(btnViewSubmissions)
        RoundButtonHelper.RoundButton(btnCreateSubmission)
        RoundButtonHelper.RoundButton(btnUpdate)
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ' Open View Submissions form
        Dim viewForm As New Form2()
        viewForm.ShowDialog()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        ' Open Create Submission form
        Dim createForm As New Form3()
        createForm.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Open Update form
        Dim updateForm As New Form4()
        updateForm.ShowDialog()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle keyboard shortcuts
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.U Then
            btnUpdate.PerformClick()
        End If
    End Sub




    Private Sub panelBodyBar_Paint(sender As Object, e As PaintEventArgs) Handles panelBodyBar.Paint

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






    'Private Sub lblHeading_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    'End Sub
End Class

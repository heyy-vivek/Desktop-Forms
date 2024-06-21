Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundButtonHelper
    Public Shared Sub RoundButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0




        Dim Radius As New GraphicsPath

        Radius.StartFigure()
        'left corner top
        Radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'top line
        Radius.AddLine(20, 0, btn.Width - 20, 0)
        'right corner top
        Radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'right line
        Radius.AddLine(btn.Width, 20, btn.Width, btn.Height - 20)
        'right corner bottom
        Radius.AddArc(New Rectangle(btn.Width - 20, btn.Height - 20, 20, 20), 0, 90)
        'bottom line
        Radius.AddLine(btn.Width - 20, btn.Height, 20, btn.Height)
        'left corner bottom
        Radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'left line
        Radius.AddLine(0, btn.Height - 20, 0, 20)
        Radius.CloseFigure()

        ' Set the rounded region to the button
        btn.Region = New Region(Radius)
    End Sub
End Class

Imports System.Drawing
Public Class RoundButton
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Me.Size = New Size(50, 50)
        Dim aCircle As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
        aCircle.AddEllipse(New RectangleF(0, 0, 50, 50))
        Me.Region = New Region(aCircle)
    End Sub

    Private Sub RoundButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Imports System.Drawing
Imports PatternMaker

Public Class DrawnPattern
    Inherits Pattern
    Public Overrides Sub Draw(sender As Object, e As PaintEventArgs)
        e.Graphics.DrawRectangle(Pens.Black, 0, 0, 60, 60)
        Dim point As Integer
        For point = 0 To m_points.Length - 2
            Dim pt1 As Point = m_points(point)
            Dim pt2 As Point = m_points(point + 1)
            e.Graphics.DrawLine(Pens.Black, pt1, pt2)
        Next
    End Sub

    Public Overrides Function Clone() As Pattern
        Dim newPattern As New DrawnPattern
        newPattern.m_points = CType(m_points.Clone, Point())
        Return newPattern
    End Function

    Public Overrides Function GetEditor() As PatternEditor
        Return New DrawPatternEditor(Me)
    End Function
    Private m_points() As Point = New Point() {}
    Public Property Points() As Point()
        Get
            Return m_points
        End Get
        Set(value As Point())
            m_points = value
        End Set
    End Property

End Class

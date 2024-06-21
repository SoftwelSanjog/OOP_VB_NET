Imports PatternMaker
Public Class BitmapPattern
    Inherits Pattern

    Public Overrides Sub Draw(sender As Object, e As PaintEventArgs)
        e.Graphics.DrawImage(New System.Drawing.Bitmap(m_bitmapFile), 0, 0)
    End Sub
    Public Overrides Function Clone() As Pattern
        Dim newpattern As New BitmapPattern
        newpattern.BitmapFile = m_bitmapFile
        Return newpattern
    End Function

    Public Overrides Function GetEditor() As PatternEditor
        Return New BitmapPatternEditor(Me)
    End Function
    Private m_bitmapFile As String = String.Empty
    Public Property BitmapFile As String
        Get
            Return m_bitmapFile
        End Get
        Set(value As String)
            m_bitmapFile = value
        End Set
    End Property
End Class

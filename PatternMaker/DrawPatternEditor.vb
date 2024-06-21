Public Class DrawPatternEditor
    Inherits PatternEditor
    Private m_points() As Point = New Point() {}
    Private m_pattern As DrawnPattern
    Public Sub New(ByVal pattern As DrawnPattern)
        MyBase.New
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReDim Me.m_points(pattern.Points.Length - 1)
        pattern.Points.CopyTo(Me.m_points, 0)
        AddHandler Me.PictureBox1.Paint, AddressOf Me.Draw
        m_pattern = pattern
    End Sub
    Public Sub Draw(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.DrawRectangle(New Pen(Brushes.Black, 1), 0, 0, 60, 60)

        For point As Integer = 0 To m_points.Length - 2
            Dim one As Point = m_points(point)
            Dim two As Point = m_points(point + 1)
            e.Graphics.DrawLine(Pens.Black, one, two)
        Next
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Me.Label1.Text = String.Format("{0},{1}", e.X, e.Y)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        ReDim Preserve m_points(m_points.Length)
        m_points(m_points.Length - 1) = New Point(e.X, e.Y)
        Me.Refresh()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        m_pattern.Points = m_points
        MyBase.RaiseSaved(Me, New System.EventArgs)
    End Sub
End Class

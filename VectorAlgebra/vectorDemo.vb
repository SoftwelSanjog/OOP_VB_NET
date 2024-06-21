Public Class vectorDemo
    Private m_maths As New SortedList
    Private Function VectorA() As Vector
        Return New Vector(Integer.Parse(XVectorA.Value), Integer.Parse(YVectorA.Value))
    End Function
    Private Function VectorB() As Vector
        Return New Vector(Integer.Parse(XVectorB.Value), Integer.Parse(YVecorB.Value))
    End Function
    Private Sub vectorDemo_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawLine(Pens.Black, 20, 170, 320, 170)
        e.Graphics.DrawLine(Pens.Black, 170, 20, 170, 320)
    End Sub
    Private Function VectorToPoint(ByVal vector As Vector) As Point
        Return New Point(vector.X * 15 + 170, -vector.Y * 15 + 170)
    End Function
    Private Sub DrawVector(ByVal vector As Vector, ByVal color As Color)
        Dim origin As Point = VectorToPoint(New Vector(0, 0))
        Dim ptend As Point = VectorToPoint(vector)
        Me.CreateGraphics.DrawLine(New Pen(New SolidBrush(color), 2), origin, ptend)


    End Sub
    Private Sub DrawVector(ByVal avector As Vector, ByVal bvector As Vector, ByVal color As Color)
        Dim origin As Point = VectorToPoint(bvector)
        Dim ptend As Point = VectorToPoint(avector + bvector)
        Me.CreateGraphics.DrawLine(New Pen(New SolidBrush(color), 2), origin, ptend)

    End Sub
    Private Sub AddVectors(a As Vector, b As Vector)
        DrawVector(a, Color.Red)
        DrawVector(b, a, Color.Blue)
        Dim sum As Vector = a + b
        DrawVector(sum, Color.Green)
        Me.result.Text = sum.ToString
    End Sub
    Private Sub SubstractVectors(ByVal a As Vector, ByVal b As Vector)
        DrawVector(a, Color.Red)
        DrawVector(-b, a, Color.Blue)
        Dim diff As Vector = a - b
        DrawVector(diff, Color.Green)
        Me.result.Text = diff.ToString
    End Sub

    Private Sub vectorDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        'm_maths.Add("Add", New Vector)
    End Sub
End Class

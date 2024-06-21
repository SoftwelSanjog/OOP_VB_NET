Public Class Form1
    Private istosort As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        istosort = False

        icomparabletest()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim starttime As DateTime = DateTime.Now

        For i = 0 To 200
            istosort = True
            icomparabletest()
        Next
        Dim endtime As DateTime = DateTime.Now
        Dim duration As TimeSpan = starttime - endtime
        Console.Write(duration)
    End Sub
    Private Sub icomparabletest()
        Dim points As New ArrayList
        Dim rgen As New System.Random
        Dim pt As SortablePoint
        Dim count As Integer
        Dim graph As Graphics = Me.CreateGraphics
        'graph.Clear(Me.BackColor)
        Dim a As Color
        For count = 0 To 200
            points.Add(New SortablePoint(rgen.Next(Me.Width), rgen.Next(Me.Height)))
        Next
        If istosort Then
            'The arraylist's sort method uses the icomparable.compareto method to sor the sortablepoint instances.
            'the intensity if the color depends on the point's position among the sorted point.the higher the value the less instense the color.

            points.Sort()
        End If

        For count = 0 To 200
            pt = CType(points(count), SortablePoint)
            a = System.Drawing.Color.FromArgb(25, 25, count)
            Dim brush As New System.Drawing.SolidBrush(a)
            graph.FillEllipse(brush, pt.X, pt.Y, 10, 10)
            brush.Dispose()
        Next
    End Sub

    'Implementing IEnumerable interface for custom classes
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim points As New SortedPointList
        points.AddRandomPoints(5, 500)
        Dim g As Graphics = Me.CreateGraphics
        g.Clear(Me.BackColor)
        Dim count As Integer = 1
        Dim a As Color
        Dim pt As SortablePoint
        For Each pt In points
            a = Color.FromArgb(25, 25, count)
            count += 1
            Dim brush As New SolidBrush(a)
            g.FillEllipse(brush, pt.X, pt.Y, 10, 10)
            g.DrawString(pt.ToString, New Font("Arial", 8), Brushes.Black, pt.X + 11, pt.Y)
            brush.Dispose()

        Next
    End Sub
End Class

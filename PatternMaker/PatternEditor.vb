Public Class PatternEditor
    Public Event Saved(sender As Object, e As EventArgs)
    Public Sub RaiseSaved(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent Saved(sender, e)
    End Sub
End Class

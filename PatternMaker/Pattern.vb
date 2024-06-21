Public MustInherit Class Pattern
    Public MustOverride Sub Draw(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
    Public MustOverride Function GetEditor() As PatternEditor
    Public MustOverride Function Clone() As Pattern
End Class

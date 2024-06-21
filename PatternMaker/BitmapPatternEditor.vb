Public Class BitmapPatternEditor
    Inherits PatternEditor
    Private m_bitmapFile As String
    Private m_pattern As BitmapPattern
    Public Sub New(ByVal pattern As BitmapPattern)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_pattern = pattern
        m_bitmapFile = pattern.BitmapFile
        AddHandler Me.PictureBox1.Paint, AddressOf Me.Draw
    End Sub
    Public Sub Draw(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.DrawImage(New System.Drawing.Bitmap(m_bitmapFile), 0, 0)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Me.OpenFileDialog1.ShowDialog()
        If (Me.OpenFileDialog1.FileName.Length <> 0) Then
            m_bitmapFile = Me.OpenFileDialog1.FileName
            Me.PictureBox1.Refresh()
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        m_pattern.BitmapFile = m_bitmapFile
        MyBase.RaiseSaved(Me, New System.EventArgs)
    End Sub
End Class

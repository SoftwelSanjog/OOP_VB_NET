<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatternMaker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.templates = New System.Windows.Forms.Panel()
        Me.patterns = New System.Windows.Forms.Panel()
        Me.editor = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Templates"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Editor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Patterns"
        '
        'templates
        '
        Me.templates.AutoScroll = True
        Me.templates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.templates.Location = New System.Drawing.Point(3, 16)
        Me.templates.Name = "templates"
        Me.templates.Size = New System.Drawing.Size(146, 217)
        Me.templates.TabIndex = 3
        '
        'patterns
        '
        Me.patterns.AutoScroll = True
        Me.patterns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.patterns.Location = New System.Drawing.Point(3, 252)
        Me.patterns.Name = "patterns"
        Me.patterns.Size = New System.Drawing.Size(409, 84)
        Me.patterns.TabIndex = 4
        '
        'editor
        '
        Me.editor.Location = New System.Drawing.Point(155, 16)
        Me.editor.Name = "editor"
        Me.editor.Size = New System.Drawing.Size(257, 217)
        Me.editor.TabIndex = 0
        Me.editor.TabStop = False
        '
        'PatternMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 365)
        Me.Controls.Add(Me.editor)
        Me.Controls.Add(Me.patterns)
        Me.Controls.Add(Me.templates)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PatternMaker"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents templates As Panel
    Friend WithEvents patterns As Panel
    Friend WithEvents editor As GroupBox
End Class

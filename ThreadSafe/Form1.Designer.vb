<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "Windows Form Designer generated code"

    Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.setTextUnsafeBtn = New System.Windows.Forms.Button()
        Me.setTextSafeBtn = New System.Windows.Forms.Button()
        Me.setTextBackgroundWorkerBtn = New System.Windows.Forms.Button()
        Me.backgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '   
        ' textBox1  
        '   
        Me.textBox1.Location = New System.Drawing.Point(12, 12)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(240, 20)
        Me.textBox1.TabIndex = 0
        '   
        ' setTextUnsafeBtn  
        '   
        Me.setTextUnsafeBtn.Location = New System.Drawing.Point(15, 55)
        Me.setTextUnsafeBtn.Name = "setTextUnsafeBtn"
        Me.setTextUnsafeBtn.TabIndex = 1
        Me.setTextUnsafeBtn.Text = "Unsafe Call"
        '   
        ' setTextSafeBtn  
        '   
        Me.setTextSafeBtn.Location = New System.Drawing.Point(96, 55)
        Me.setTextSafeBtn.Name = "setTextSafeBtn"
        Me.setTextSafeBtn.TabIndex = 2
        Me.setTextSafeBtn.Text = "Safe Call"
        '   
        ' setTextBackgroundWorkerBtn  
        '   
        Me.setTextBackgroundWorkerBtn.Location = New System.Drawing.Point(177, 55)
        Me.setTextBackgroundWorkerBtn.Name = "setTextBackgroundWorkerBtn"
        Me.setTextBackgroundWorkerBtn.TabIndex = 3
        Me.setTextBackgroundWorkerBtn.Text = "Safe BW Call"
        '   
        ' backgroundWorker1  
        '   
        '   
        ' Form1  
        '   
        Me.ClientSize = New System.Drawing.Size(268, 96)
        Me.Controls.Add(setTextBackgroundWorkerBtn)
        Me.Controls.Add(setTextSafeBtn)
        Me.Controls.Add(setTextUnsafeBtn)
        Me.Controls.Add(textBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub 'InitializeComponent   

#End Region

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.fire = New System.Windows.Forms.PictureBox()
        Me.throttle = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Train1 = New EventsANDException.Train()
        Me.Track1 = New EventsANDException.Track()
        CType(Me.fire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.throttle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fire
        '
        Me.fire.BackgroundImage = Global.EventsANDException.My.Resources.Resources.fire
        Me.fire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.fire.Location = New System.Drawing.Point(322, 73)
        Me.fire.Name = "fire"
        Me.fire.Size = New System.Drawing.Size(60, 83)
        Me.fire.TabIndex = 1
        Me.fire.TabStop = False
        '
        'throttle
        '
        Me.throttle.LargeChange = 10
        Me.throttle.Location = New System.Drawing.Point(12, 0)
        Me.throttle.Maximum = 50
        Me.throttle.Name = "throttle"
        Me.throttle.Size = New System.Drawing.Size(543, 45)
        Me.throttle.SmallChange = 5
        Me.throttle.TabIndex = 3
        Me.throttle.TickFrequency = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(637, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Train1
        '
        Me.Train1.BackColor = System.Drawing.Color.Maroon
        Me.Train1.Location = New System.Drawing.Point(12, 60)
        Me.Train1.Name = "Train1"
        Me.Train1.Size = New System.Drawing.Size(84, 96)
        Me.Train1.Speed = 0
        Me.Train1.TabIndex = 2
        '
        'Track1
        '
        Me.Track1.Frequency = 1
        Me.Track1.Location = New System.Drawing.Point(12, 174)
        Me.Track1.Name = "Track1"
        Me.Track1.Size = New System.Drawing.Size(940, 25)
        Me.Track1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 212)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.throttle)
        Me.Controls.Add(Me.Train1)
        Me.Controls.Add(Me.fire)
        Me.Controls.Add(Me.Track1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.fire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.throttle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Track1 As Track
    Friend WithEvents fire As PictureBox
    Friend WithEvents Train1 As Train
    Friend WithEvents throttle As TrackBar
    Friend WithEvents Button1 As Button
End Class

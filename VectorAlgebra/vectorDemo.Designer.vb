<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vectorDemo
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.XVectorA = New System.Windows.Forms.NumericUpDown()
        Me.YVectorA = New System.Windows.Forms.NumericUpDown()
        Me.YVecorB = New System.Windows.Forms.NumericUpDown()
        Me.XVectorB = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.scalar = New System.Windows.Forms.NumericUpDown()
        Me.result = New System.Windows.Forms.TextBox()
        CType(Me.XVectorA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YVectorA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YVecorB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XVectorB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scalar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(368, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(445, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(300, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vector A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(303, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vecor B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(303, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Result"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(493, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "*"
        '
        'XVectorA
        '
        Me.XVectorA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.XVectorA.Location = New System.Drawing.Point(368, 42)
        Me.XVectorA.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.XVectorA.Minimum = New Decimal(New Integer() {5, 0, 0, -2147483648})
        Me.XVectorA.Name = "XVectorA"
        Me.XVectorA.Size = New System.Drawing.Size(44, 23)
        Me.XVectorA.TabIndex = 6
        '
        'YVectorA
        '
        Me.YVectorA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.YVectorA.Location = New System.Drawing.Point(437, 42)
        Me.YVectorA.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.YVectorA.Minimum = New Decimal(New Integer() {5, 0, 0, -2147483648})
        Me.YVectorA.Name = "YVectorA"
        Me.YVectorA.Size = New System.Drawing.Size(52, 23)
        Me.YVectorA.TabIndex = 7
        '
        'YVecorB
        '
        Me.YVecorB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.YVecorB.Location = New System.Drawing.Point(421, 99)
        Me.YVecorB.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.YVecorB.Minimum = New Decimal(New Integer() {5, 0, 0, -2147483648})
        Me.YVecorB.Name = "YVecorB"
        Me.YVecorB.Size = New System.Drawing.Size(52, 23)
        Me.YVecorB.TabIndex = 9
        '
        'XVectorB
        '
        Me.XVectorB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.XVectorB.Location = New System.Drawing.Point(371, 99)
        Me.XVectorB.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.XVectorB.Minimum = New Decimal(New Integer() {5, 0, 0, -2147483648})
        Me.XVectorB.Name = "XVectorB"
        Me.XVectorB.Size = New System.Drawing.Size(44, 23)
        Me.XVectorB.TabIndex = 8
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NumericUpDown5.Location = New System.Drawing.Point(363, 70)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(129, 23)
        Me.NumericUpDown5.TabIndex = 10
        '
        'scalar
        '
        Me.scalar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.scalar.Location = New System.Drawing.Point(512, 99)
        Me.scalar.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.scalar.Minimum = New Decimal(New Integer() {3, 0, 0, -2147483648})
        Me.scalar.Name = "scalar"
        Me.scalar.Size = New System.Drawing.Size(52, 23)
        Me.scalar.TabIndex = 11
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(368, 134)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(168, 20)
        Me.result.TabIndex = 12
        '
        'vectorDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 346)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.scalar)
        Me.Controls.Add(Me.NumericUpDown5)
        Me.Controls.Add(Me.YVecorB)
        Me.Controls.Add(Me.XVectorB)
        Me.Controls.Add(Me.YVectorA)
        Me.Controls.Add(Me.XVectorA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "vectorDemo"
        Me.Text = "Form1"
        CType(Me.XVectorA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YVectorA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YVecorB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XVectorB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scalar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents XVectorA As NumericUpDown
    Friend WithEvents YVectorA As NumericUpDown
    Friend WithEvents YVecorB As NumericUpDown
    Friend WithEvents XVectorB As NumericUpDown
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents scalar As NumericUpDown
    Friend WithEvents result As TextBox
End Class

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
        Me.chkSelectedPoints = New System.Windows.Forms.CheckedListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnbSaveBinary = New System.Windows.Forms.Button()
        Me.btnLoadBinary = New System.Windows.Forms.Button()
        Me.bynSaveXML = New System.Windows.Forms.Button()
        Me.btmLoadXML = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.lsttrainglelist = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkSelectedPoints
        '
        Me.chkSelectedPoints.FormattingEnabled = True
        Me.chkSelectedPoints.Location = New System.Drawing.Point(0, 0)
        Me.chkSelectedPoints.Name = "chkSelectedPoints"
        Me.chkSelectedPoints.Size = New System.Drawing.Size(120, 154)
        Me.chkSelectedPoints.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 175)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnbSaveBinary
        '
        Me.btnbSaveBinary.Location = New System.Drawing.Point(12, 204)
        Me.btnbSaveBinary.Name = "btnbSaveBinary"
        Me.btnbSaveBinary.Size = New System.Drawing.Size(75, 23)
        Me.btnbSaveBinary.TabIndex = 2
        Me.btnbSaveBinary.Text = "Save Binary"
        Me.btnbSaveBinary.UseVisualStyleBackColor = True
        '
        'btnLoadBinary
        '
        Me.btnLoadBinary.Location = New System.Drawing.Point(93, 204)
        Me.btnLoadBinary.Name = "btnLoadBinary"
        Me.btnLoadBinary.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadBinary.TabIndex = 3
        Me.btnLoadBinary.Text = "Load Binary"
        Me.btnLoadBinary.UseVisualStyleBackColor = True
        '
        'bynSaveXML
        '
        Me.bynSaveXML.Location = New System.Drawing.Point(174, 204)
        Me.bynSaveXML.Name = "bynSaveXML"
        Me.bynSaveXML.Size = New System.Drawing.Size(75, 23)
        Me.bynSaveXML.TabIndex = 4
        Me.bynSaveXML.Text = "Save XML"
        Me.bynSaveXML.UseVisualStyleBackColor = True
        '
        'btmLoadXML
        '
        Me.btmLoadXML.Location = New System.Drawing.Point(255, 204)
        Me.btmLoadXML.Name = "btmLoadXML"
        Me.btmLoadXML.Size = New System.Drawing.Size(75, 23)
        Me.btmLoadXML.TabIndex = 5
        Me.btmLoadXML.Text = "Load XML"
        Me.btmLoadXML.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(174, 175)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(255, 175)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(75, 23)
        Me.btnClearAll.TabIndex = 7
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'lsttrainglelist
        '
        Me.lsttrainglelist.FormattingEnabled = True
        Me.lsttrainglelist.Location = New System.Drawing.Point(139, 0)
        Me.lsttrainglelist.Name = "lsttrainglelist"
        Me.lsttrainglelist.Size = New System.Drawing.Size(191, 160)
        Me.lsttrainglelist.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 237)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lsttrainglelist)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btmLoadXML)
        Me.Controls.Add(Me.bynSaveXML)
        Me.Controls.Add(Me.btnLoadBinary)
        Me.Controls.Add(Me.btnbSaveBinary)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.chkSelectedPoints)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkSelectedPoints As CheckedListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnbSaveBinary As Button
    Friend WithEvents btnLoadBinary As Button
    Friend WithEvents bynSaveXML As Button
    Friend WithEvents btmLoadXML As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents lsttrainglelist As ListBox
    Friend WithEvents Button1 As Button
End Class

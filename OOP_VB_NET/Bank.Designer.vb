﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bank
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
        Me.btnIntrest = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cboAccount = New System.Windows.Forms.ComboBox()
        Me.cboAction = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Transaction"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Amount"
        '
        'btnIntrest
        '
        Me.btnIntrest.Enabled = False
        Me.btnIntrest.Location = New System.Drawing.Point(124, 138)
        Me.btnIntrest.Name = "btnIntrest"
        Me.btnIntrest.Size = New System.Drawing.Size(75, 23)
        Me.btnIntrest.TabIndex = 4
        Me.btnIntrest.Text = "Add Inerest"
        Me.btnIntrest.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(43, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "submit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cboAccount
        '
        Me.cboAccount.FormattingEnabled = True
        Me.cboAccount.Location = New System.Drawing.Point(78, 18)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(121, 21)
        Me.cboAccount.TabIndex = 6
        '
        'cboAction
        '
        Me.cboAction.FormattingEnabled = True
        Me.cboAction.Items.AddRange(New Object() {"Deposit", "WithDraw"})
        Me.cboAction.Location = New System.Drawing.Point(78, 58)
        Me.cboAction.Name = "cboAction"
        Me.cboAction.Size = New System.Drawing.Size(121, 21)
        Me.cboAction.TabIndex = 7
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(78, 97)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(121, 20)
        Me.txtAmount.TabIndex = 8
        Me.txtAmount.Text = "100"
        '
        'Bank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 173)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cboAction)
        Me.Controls.Add(Me.cboAccount)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnIntrest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Bank"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnIntrest As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cboAccount As ComboBox
    Friend WithEvents cboAction As ComboBox
    Friend WithEvents txtAmount As TextBox
End Class

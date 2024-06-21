Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    ' This delegate enables asynchronous calls for setting  
    ' the text property on a TextBox control.  
    Delegate Sub StringArgReturningVoidDelegate([text] As String)

    ' This thread is used to demonstrate both thread-safe and  
    ' unsafe ways to call a Windows Forms control.  
    Private demoThread As Thread = Nothing

    ' This BackgroundWorker is used to demonstrate the   
    ' preferred way of performing asynchronous operations.  
    Private WithEvents backgroundWorker1 As BackgroundWorker

    Private textBox1 As TextBox
    Private WithEvents setTextUnsafeBtn As Button
    Private WithEvents setTextSafeBtn As Button
    Private WithEvents setTextBackgroundWorkerBtn As Button



    ' This event handler creates a thread that calls a   
    ' Windows Forms control in an unsafe way.  
    Private Sub setTextUnsafeBtn_Click(
    ByVal sender As Object,
    ByVal e As EventArgs) Handles setTextUnsafeBtn.Click

        Me.demoThread = New Thread(
        New ThreadStart(AddressOf Me.ThreadProcUnsafe))

        Me.demoThread.Start()
    End Sub

    ' This method is executed on the worker thread and makes  
    ' an unsafe call on the TextBox control.  
    Private Sub ThreadProcUnsafe()
        Me.textBox1.Text = "This text was set unsafely."
    End Sub

    ' This event handler creates a thread that calls a   
    ' Windows Forms control in a thread-safe way.  
    Private Sub setTextSafeBtn_Click(
    ByVal sender As Object,
    ByVal e As EventArgs) Handles setTextSafeBtn.Click

        Me.demoThread = New Thread(
        New ThreadStart(AddressOf Me.ThreadProcSafe))

        Me.demoThread.Start()
    End Sub

    ' This method is executed on the worker thread and makes  
    ' a thread-safe call on the TextBox control.  
    Private Sub ThreadProcSafe()
        Me.SetText("This text was set safely.")
    End Sub

    ' This method demonstrates a pattern for making thread-safe  
    ' calls on a Windows Forms control.   
    '  
    ' If the calling thread is different from the thread that  
    ' created the TextBox control, this method creates a  
    ' StringArgReturningVoidDelegate and calls itself asynchronously using the  
    ' Invoke method.  
    '  
    ' If the calling thread is the same as the thread that created  
    ' the TextBox control, the Text property is set directly.   

    Private Sub SetText(ByVal [text] As String)

        ' InvokeRequired required compares the thread ID of the  
        ' calling thread to the thread ID of the creating thread.  
        ' If these threads are different, it returns true.  
        If Me.textBox1.InvokeRequired Then
            Dim d As New StringArgReturningVoidDelegate(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.textBox1.Text = [text]
        End If
    End Sub

    ' This event handler starts the form's   
    ' BackgroundWorker by calling RunWorkerAsync.  
    '  
    ' The Text property of the TextBox control is set  
    ' when the BackgroundWorker raises the RunWorkerCompleted  
    ' event.  
    Private Sub setTextBackgroundWorkerBtn_Click(
    ByVal sender As Object,
    ByVal e As EventArgs) Handles setTextBackgroundWorkerBtn.Click
        Me.backgroundWorker1.RunWorkerAsync()
    End Sub

    ' This event handler sets the Text property of the TextBox  
    ' control. It is called on the thread that created the   
    ' TextBox control, so the call is thread-safe.  
    '  
    ' BackgroundWorker is the preferred way to perform asynchronous  
    ' operations.  
    Private Sub backgroundWorker1_RunWorkerCompleted(
    ByVal sender As Object,
    ByVal e As RunWorkerCompletedEventArgs) _
    Handles backgroundWorker1.RunWorkerCompleted
        Me.textBox1.Text =
        "This text was set safely by BackgroundWorker."
    End Sub
    <STAThread()>
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub
End Class

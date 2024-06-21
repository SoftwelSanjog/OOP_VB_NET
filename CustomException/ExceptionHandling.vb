Public Class ExceptionHandling
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            lstPersons.Items.Add(New Person("Sanjog Shakya"))
            lstPersons.Items.Add(New Person("SanjogShakya"))
        Catch ex As NameFormatIncorretException
            If Not IsNothing(ex.InnerException) Then
                MsgBox(ex.Message & vbCrLf & ex.InnerException.Message)
            Else
                MsgBox(ex.Message)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lstPersons.Text = String.Empty
    End Sub
End Class

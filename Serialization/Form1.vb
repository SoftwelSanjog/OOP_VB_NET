Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Public Class Form1
    Private m_xmlfile As String = Application.StartupPath + "traingle.xml"
    Private m_binaryfile As String = Application.StartupPath + "\traingles.dat"
    Private m_traingle As New TraingleCollection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        For x = 0 To 6
            For y = 0 To 6
                Me.chkSelectedPoints.Items.Add(New XYPoint(x, y))
            Next
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim checkedPoints As CheckedListBox.CheckedItemCollection = Me.chkSelectedPoints.CheckedItems
        If checkedPoints.Count = 3 Then
            m_traingle.Add(New Traingle(CType(checkedPoints(0), XYPoint), CType(checkedPoints(1), XYPoint), CType(checkedPoints(2), XYPoint)))
            lsttrainglelist.Items.AddRange(m_traingle.ToArray())
            Dim item As Integer
            For Each item In chkSelectedPoints.CheckedIndices
                chkSelectedPoints.SetItemChecked(item, False)
            Next
        Else
            MsgBox("You must Select Exactly three points.")
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lsttrainglelist.SelectedIndex <> -1 Then
            m_traingle.Remove(CType(lsttrainglelist.SelectedItem, Traingle))
            lsttrainglelist.Items.Clear()
            lsttrainglelist.Items.AddRange(m_traingle.ToArray())
        End If
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        m_traingle.Clear()
        lsttrainglelist.Items.Clear()
    End Sub

    Private Sub btnbSaveBinary_Click(sender As Object, e As EventArgs) Handles btnbSaveBinary.Click
        Dim stream As New System.IO.FileStream(m_binaryfile, System.IO.FileMode.Create)
        Dim binary As New BinaryFormatter
        binary.Serialize(stream, m_traingle)
        stream.Close()
    End Sub

    Private Sub btnLoadBinary_Click(sender As Object, e As EventArgs) Handles btnLoadBinary.Click
        Dim stream As New System.IO.FileStream(m_binaryfile, System.IO.FileMode.Open)
        Dim binary As New BinaryFormatter()
        m_traingle = CType(binary.Deserialize(stream), TraingleCollection)
        stream.Close()
        lsttrainglelist.Items.Clear()
        lsttrainglelist.Items.AddRange(m_traingle.ToArray())
    End Sub

    Private Sub bynSaveXML_Click(sender As Object, e As EventArgs) Handles bynSaveXML.Click
        Dim writer As New System.IO.StreamWriter(m_xmlfile)
        Dim xmlserial As New XmlSerializer(m_traingle.GetType)
        xmlserial.Serialize(writer, m_traingle)
        writer.Close()
    End Sub

    Private Sub btmLoadXML_Click(sender As Object, e As EventArgs) Handles btmLoadXML.Click
        Dim reader As New System.IO.StreamReader(m_xmlfile)
        Dim xmlserial As New XmlSerializer(System.Type.GetType("Serialization.TraingleCollection"))
        m_traingle = CType(xmlserial.Deserialize(reader), TraingleCollection)
        reader.Close()
        lsttrainglelist.Items.Clear()
        lsttrainglelist.Items.AddRange(m_traingle.ToArray)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(m_traingle.Count)
    End Sub
End Class

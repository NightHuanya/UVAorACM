Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$ = LineInput(1)
        Dim z% = 1
        Do Until a = "0 0"
            Dim b$() = a.Split
            Dim c As New List(Of String)
            For i = 1 To Val(b(0))
                c.Add(LineInput(1))
            Next
            PrintLine(2, "CASE# " & z & ":")
            For i = 1 To Val(b(1))
                Dim d$ = LineInput(1)
                If c.Contains(d) = True Then
                    PrintLine(2, d & " found at " & c.IndexOf(d) + 2)
                Else
                    PrintLine(2, d & " not found")
                End If
            Next
            a = LineInput(1)
        Loop
    End Sub
End Class

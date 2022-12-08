Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Do Until EOF(1) = True
            Dim a$() = LineInput(1).Split
            Dim b$() = LineInput(1).Split
            Dim x% = 0
            If a.Count > b.Count Then
                For k = 0 To b.Count - 1
                    If a.Contains(b(k)) = True Then x += 1
                Next
                If x = 0 Then
                    PrintLine(2, "A and B are disjoint")
                ElseIf x = b.Count Then
                    PrintLine(2, "B is a proper subset of A")
                Else
                    PrintLine(2, "I'm confused!")
                End If
            ElseIf b.Count > a.Count Then
                For k = 0 To a.Count - 1
                    If b.Contains(a(k)) = True Then x += 1
                Next
                If x = 0 Then
                    PrintLine(2, "A and B are disjoint")
                ElseIf x = a.Count Then
                    PrintLine(2, "A is a proper subset of B")
                Else
                    PrintLine(2, "I'm confused!")
                End If
            Else
                For k = 0 To a.Count - 1
                    If b.Contains(a(k)) = True Then x += 1
                Next
                If x = 0 Then
                    PrintLine(2, "A and B are disjoint")
                ElseIf x = b.Count Then
                    PrintLine(2, "A equals B")
                Else
                    PrintLine(2, "I'm confused!")
                End If
            End If
        Loop
    End Sub
End Class

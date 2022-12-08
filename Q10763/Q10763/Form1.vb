Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        Do Until a = 0
            Dim ans As New List(Of String)
            For i = 1 To a
                Dim c$ = LineInput(1)
                Dim b$() = c.Split
                If ans.Contains(b(0) & " " & b(1)) = True Then
                    ans.Remove(b(0) & " " & b(1))
                ElseIf ans.Contains(b(1) & " " & b(0)) = True Then
                    ans.Remove(b(1) & " " & b(0))
                Else
                    ans.Add(c)
                End If
            Next
            If ans.Count <> 0 Then
                PrintLine(2, "NO")
            Else
                PrintLine(2, "YES")
            End If
            a = LineInput(1)
        Loop
    End Sub
End Class

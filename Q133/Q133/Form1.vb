Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$ = LineInput(1)
        Do Until a = "0 0 0"
            Dim PE As New List(Of String)
            Dim b$() = a.Split
            For k = 0 To Val(b(0))
                PE.Add(k)
                Do Until Len(PE(k)) = 3 : PE(k) = " " & PE(k) : Loop
            Next
            Dim ans As New List(Of String)
            Dim c% = 0
            Dim d% = Val(b(0)) + 1
            Do
                Dim x% = Val(b(1)), y% = Val(b(2))
                Do Until x = 0
                    If c = PE.Count - 1 Then c = 1 Else c += 1
                    If PE(c) <> "x" Then
                        x -= 1
                    End If
                Loop
                Do Until y = 0
                    If d = 1 Then d = PE.Count - 1 Else d -= 1
                    If PE(d) <> "x" Then
                        y -= 1
                    End If
                Loop
                If PE(c) <> PE(d) Then
                    ans.Add(PE(c) & (PE(d)))
                    PE(c) = "x" : PE(d) = "x"
                Else
                    ans.Add(PE(c))
                    PE(c) = "x"
                End If
                For k = 1 To PE.Count - 1
                    If PE(k) <> "x" Then Exit For
                    If k = PE.Count - 1 Then Exit Do
                Next
            Loop
            PrintLine(2, Join(ans.ToArray, ","))
            a = LineInput(1)
        Loop
    End Sub
End Class

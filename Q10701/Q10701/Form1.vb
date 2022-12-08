Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        For i = 1 To a
            Dim b$() = LineInput(1).Split
            Dim ans$ = ""
            QQ(b(1), b(2), ans)
            PrintLine(2, ans)
        Next
    End Sub
    Function QQ(ByVal a$, ByVal b$, ByRef ans$)
        For i = 1 To Len(a)
            If InStr(b, Mid(a, i, 1)) <> 0 Then
                Dim x$ = Mid(b, 1, InStr(b, Mid(a, i, 1)) - 1), y$ = Mid(b, InStr(b, Mid(a, i, 1)) + 1, Len(b) - InStr(b, Mid(a, i, 1)))
                If Len(x) = 1 Then
                    ans = ans & x
                Else
                    QQ(a, x, ans)
                End If
                If Len(y) = 1 Then
                    ans = ans & y
                Else
                    QQ(a, y, ans)
                End If
                ans = ans & Mid(a, i, 1)
                Exit Function
            End If
        Next
    End Function
End Class

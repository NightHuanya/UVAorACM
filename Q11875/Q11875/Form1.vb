Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, f, g As Integer
        Dim c$
        Dim d()
        a = LineInput(1)
        For i = 1 To a
            c = LineInput(1)
            For j = 1 To Len(c)
                Select Case Mid(c, j, 1)
                    Case "0" To "9"
                        b = b & Mid(c, j, 1)
                    Case Else
                        f = j
                        Exit For
                End Select
            Next
            ReDim d(b - 1)
            For k = f + 1 To Len(c)
                Select Case Mid(c, k, 1)
                    Case "0" To "9"
                        d(g) = d(g) & Mid(c, k, 1)
                    Case Else
                        g = g + 1
                End Select
            Next

            Array.Sort(d)
            If i <> a Then
                PrintLine(2, "Case " & i & ": " & d(b \ 2))
            Else
                Print(2, "Case " & i & ": " & d(b \ 2))
            End If

            b = 0
            f = 0
            g = 0
        Next

    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As Single
        Dim d$

        a = LineInput(1)

        For i = 1 To a

            d = LineInput(1)

            For j = 1 To Len(d)
                Select Case Mid(d, j, 1)
                    Case "0" To "9"
                        b = b & Mid(d, j, 1)
                    Case "-"
                        b = Mid(d, j, 1) & b
                    Case Else
                        c = b
                        b = 0
                End Select
            Next

            c = Format(c + ((b - 32) * 5 / 9), ".00")

            If i = a Then
                Print(2, "Case " & i & ": " & c)
            Else
                PrintLine(2, "Case " & i & ": " & c)
            End If





        Next


    End Sub
End Class

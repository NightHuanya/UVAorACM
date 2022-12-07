Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d, f, g, h As Integer
        Dim x, y As String

        a = LineInput(1)

        For i = 1 To a
            LineInput(1)
            x = LineInput(1)
            y = LineInput(1)
            For j = 1 To Len(x)
                Select Case Mid(x, j, 1)
                    Case "0" To "9"
                        b = b & Mid(x, j, 1)
                    Case Else
                        d = c
                        c = b
                        b = 0
                End Select
            Next

            For k = 1 To Len(y)
                Select Case Mid(y, k, 1)
                    Case "0" To "9"
                        f = f & Mid(y, k, 1)
                    Case Else
                        h = g
                        g = f
                        f = 0
                End Select
            Next

            If f > b Then
                If i = a Then
                    Print(2, "Case #" & i & ": Invalid birth date")
                Else
                    PrintLine(2, "Case #" & i & ": Invalid birth date")
                End If
            ElseIf b = f And g > c Then
                If i = a Then
                    Print(2, "Case #" & i & ": Invalid birth date")
                Else
                    PrintLine(2, "Case #" & i & ": Invalid birth date")
                End If
            ElseIf b = f And g > c And f > b Then
                If i = a Then
                    Print(2, "Case #" & i & ": Invalid birth date")
                Else
                    PrintLine(2, "Case #" & i & ": Invalid birth date")
                End If
            ElseIf b - f > 131 Or b - f > 130 And c >= g And f >= b Then
                If i = a Then
                    Print(2, "Case #" & i & ": Check birth date")
                Else
                    PrintLine(2, "Case #" & i & ": Check birth date")
                End If
            Else
                If c >= g And d >= h Then
                    If i = a Then
                        Print(2, "Case #" & i & ": " & b - f)
                    Else
                        PrintLine(2, "Case #" & i & ": " & b - f)
                    End If
                Else
                    If i = a Then
                        Print(2, "Case #" & i & ": " & b - f - 1)
                    Else
                        PrintLine(2, "Case #" & i & ": " & b - f - 1)
                    End If
                End If
            End If
            b = 0
            c = 0
            d = 0
            f = 0
            g = 0
            h = 0
        Next
    End Sub
End Class

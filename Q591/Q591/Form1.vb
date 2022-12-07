Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a, b, c, f, g, h As Integer
        Dim d As String
        a = 1
        b = 1
        h = 1
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim aa()

        a = LineInput(1)
        Do Until a = 0
            d = LineInput(1)
            ReDim aa(a - 1)

            For i = 1 To Len(d)
                Select Case Mid(d, i, 1)

                    Case "0" To "9"
                        aa(c) = aa(c) & Mid(d, i, 1)
                    Case Else
                        c = c + 1
                End Select

            Next

            For i = 0 To c
                f = f + aa(i)
            Next

            f = f / (c + 1)

            For j = 0 To c
                If aa(j) > f Then
                    g = g + aa(j) - f
                End If
            Next



            a = LineInput(1)

            If EOF(1) <> True Then
                PrintLine(2, "Set #" & h & vbNewLine & "The minimum number of moves is " & g & "." & vbNewLine)
            Else
                Print(2, "Set #" & h & vbNewLine & "The minimum number of moves is " & g & ".")
            End If
            b = 1
            h = h + 1
            c = 0
            g = 0
            f = 0
        Loop
    End Sub
End Class

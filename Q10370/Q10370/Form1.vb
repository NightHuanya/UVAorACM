Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, d, f, g As Integer
        Dim b$
        Dim c()
        Dim h, z As Double
        f = 2
        a = LineInput(1)

        For i = 1 To a

            b = LineInput(1)

            For j = 1 To Len(b)
                Select Case Mid(b, j, 1)
                    Case "0" To "9"
                        d = d & Mid(b, j, 1)
                        f = f + 1
                    Case Else
                        Exit For
                End Select
            Next

            ReDim c(d - 1)

            For k = f To Len(b)
                Select Case Mid(b, k, 1)
                    Case "0" To "9"
                        c(g) = c(g) & Mid(b, k, 1)
                    Case Else
                        g = g + 1
                End Select
            Next

            For l = 0 To d - 1
                h = h + c(l)
            Next

            h = h / d

            For m = 0 To d - 1
                If c(m) > h Then
                    z = z + 1
                End If
            Next

            z = z / d
            z = z * 100

            If i = a Then
                Print(2, Format(z, ".000") & "%")
            Else
                PrintLine(2, Format(z, ".000") & "%")
            End If

            f = 2
            g = 0
            h = 0
            z = 0
            d = 0

        Next













    End Sub
End Class

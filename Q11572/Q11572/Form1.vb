Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, f As Long
        Dim d()

        a = LineInput(1)

        For i = 1 To a
            b = LineInput(1)
            ReDim d(b)
            For j = 1 To b

                c = LineInput(1)

                For k = 0 To b
                    If d(k) = c Then
                        Exit For
                    End If
                    If k = b Then
                        d(j) = c
                        f = f + 1
                    End If
                Next
            Next

            If i = a Then
                Print(2, f)
            Else
                PrintLine(2, f)
            End If
            f = 0
        Next

    End Sub
End Class

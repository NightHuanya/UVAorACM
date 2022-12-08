Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d As Long

        a = LineInput(1)
        c = 1

        For i = 1 To a
            b = LineInput(1)

            For j = 1 To b
                If b >= c Then
                    b = b - c
                    c = c + 1
                    d = d + 1
                Else
                    Exit For
                End If
            Next

            If i = a Then
                Print(2, d)
            Else
                PrintLine(2, d)
            End If

            c = 1
            d = 0

        Next

    End Sub
End Class

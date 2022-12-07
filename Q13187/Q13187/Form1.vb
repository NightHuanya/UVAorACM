Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d As String
        c = 1
        a = LineInput(1)
        d = 0.0
        For i = 1 To Val(a)
            b = LineInput(1)

            Do
                d = Val(c + 1) ^ 0.5 - 1

                If d = b Then
                    Exit Do
                Else
                    c = Val(c) + 1

                End If

            Loop

            If i = Val(a) Then
                Print(2, c)
            Else
                PrintLine(2, c)
            End If
            c = 1
        Next

    End Sub
End Class

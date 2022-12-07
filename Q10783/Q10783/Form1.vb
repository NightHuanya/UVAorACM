Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim a, b, c, d As Integer

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        d = LineInput(1)

        For i = 1 To d
            a = LineInput(1)
            b = LineInput(1)
            For j = a To b
                If j Mod 2 = 1 Then
                    c = c + j
                End If
            Next

            If EOF(1) = True Then
                Print(2, "Case " & i & ": " & c)
            Else
                PrintLine(2, "Case " & i & ": " & c)
            End If
            c = 0
        Next









    End Sub
End Class

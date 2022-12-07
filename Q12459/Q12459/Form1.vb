Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d, f As Long
        f = LineInput(1)
        a = 1
        Do Until f = 0
            For i = 1 To f
                c = a
                d = b
                b = c + d
                a = d
            Next

            f = LineInput(1)

            If f <> 0 Then
                PrintLine(2, a + b)
            Else
                Print(2, a + b)
            End If
            a = 1
            b = 0
        Loop




    End Sub
End Class

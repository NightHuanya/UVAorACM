Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d, f As Long
        Dim g As Boolean = False
        f = LineInput(1)
        a = 1
        Do Until f = -1
            For i = 1 To f
                a = a - c
                b = b - d
                c = a
                d = b
                b = c + d
                If i > 1 Then
                    a = d + 1
                End If
                c = 0
                d = 0
            Next
            f = LineInput(1)
            If f <> -1 Then
                PrintLine(2, b & Space(1) & a + b)
            Else
                Print(2, b & Space(1) & a + b)
            End If
            a = 1
            b = 0
        Loop
    End Sub
End Class

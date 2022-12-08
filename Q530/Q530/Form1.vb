Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a, b, c, d, f, g, h As String
        d = "1"
        f = "1"
        g = "1"
        h = "1"
        a = LineInput(1)
        Do Until a = "0 0"
            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "0" To "9"
                        b = b & Mid(a, i, 1)
                    Case Else
                        c = b
                        b = ""
                End Select
            Next
            For j = 1 To Val(c)
                d = Val(d) * j
            Next
            For k = 1 To Val(c) - Val(b)
                f = Val(f) * k
            Next
            For l = 1 To Val(b)
                g = Val(g) * l
            Next
            h = Val(d) / (Val(f) * Val(g))
            a = LineInput(1)
            If a <> "0 0" Then
                PrintLine(2, h)
            Else
                Print(2, h)
            End If
            b = ""
            c = ""
            d = "1"
            f = "1"
            g = "1"
            h = "1"
        Loop





    End Sub
End Class

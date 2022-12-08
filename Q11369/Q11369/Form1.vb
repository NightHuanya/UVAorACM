Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, g As Integer
        Dim d$
        Dim f()
        Dim aa As Long
        a = LineInput(1)
        For i = 1 To a
            b = LineInput(1)
            d = LineInput(1)
            ReDim f(b)
            For j = 1 To b
                For k = 1 To Len(d)
                    Select Case Mid(d, g + k, 1)
                        Case "0" To "9"
                            c = c & Mid(d, g + k, 1)
                        Case Else
                            g = g + k
                            Exit For
                    End Select
                Next
                f(j) = c
                c = 0
            Next
            Array.Sort(f)
            Array.Reverse(f)
            b = b \ 3
            For l = 1 To b
                aa = aa + f(l * 3 - 1)
            Next
            If i = a Then
                Print(2, aa)
            Else
                PrintLine(2, aa)
            End If
            c = 0
            g = 0
            aa = 0
        Next
    End Sub
End Class

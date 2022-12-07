Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a, b, c, f, g, h, l As Single
        Dim d$
        c = 1

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        a = LineInput(1)

        For i = 1 To a
            b = LineInput(1)
            For j = 1 To b
                d = LineInput(1)
                For k = 1 To Len(d)
                    Select Case Mid(d, k, 1)
                        Case "0" To "9"
                            If c = 1 Then
                                f = f & Mid(d, k, 1)
                            ElseIf c = 2 Then
                                g = g & Mid(d, k, 1)
                            ElseIf c = 3 Then
                                h = h & Mid(d, k, 1)
                            End If

                        Case Else
                            c = c + 1
                    End Select
                Next
                l = l + (f / g) * h * g

                f = 0
                g = 0
                h = 0
                c = 1
            Next
            If i = a Then
                Print(2, l)
            Else
                PrintLine(2, l)
            End If
            l = 0
        Next



    End Sub
End Class

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a(100), b(100)
        Dim c$, d$, g$, h$
        Dim f, z As Integer
        c = LineInput(1)
        For i = 1 To Len(c)
            a(101 - i) = Mid(c, Len(c) + 1 - i, 1)
        Next
        Do Until d = "0"
            d = LineInput(1)
            For i = 1 To Len(d)
                b(101 - i) = Mid(d, Len(d) + 1 - i, 1)
            Next

            For i = 100 To 1 Step -1


                If Val(a(i)) + Val(b(i)) > 9 Then

                    f = Val(a(i)) + Val(b(i)) - 10
                    a(i) = f
                    a(i - 1) = Val(a(i - 1)) + 1
                Else
                    a(i) = Val(a(i)) + Val(b(i))
                End If

            Next

            If d = "0" Then
                g = ""
                For i = 100 To 1 Step -1
                    g = a(i) & g
                Next
                z = Len(g)
                For i = 1 To z
                    If Mid(g, 1, 1) = "0" Then
                        For j = 2 To Len(g)
                            h = h & Mid(g, j, 1)
                        Next
                    Else
                        Exit For
                    End If
                    g = h
                    h = ""
                Next
                Print(2, g)
            End If
            ReDim b(100)
        Loop

    End Sub
End Class

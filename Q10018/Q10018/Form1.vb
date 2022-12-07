Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, c, h As Long
        Dim b$
        Dim d(), f(), g()
        h = 1

        a = LineInput(1)

        For i = 1 To a
            b = LineInput(1)

            ReDim d(Len(b) - 1)

            For j = 0 To Len(b) - 1
                d(j) = Mid(b, j + 1, 1)
            Next

            Array.Reverse(d)

            For k = 0 To d.Length - 1
                c = c & d(k)
            Next

            c = c + Val(b)
            b = c

            ReDim f(Len(b) - 1)
            ReDim g(Len(b) - 1)

            For l = 0 To Len(b) - 1
                f(l) = Mid(b, l + 1, 1)
            Next

            Array.Copy(f, g, Len(b))

            Array.Reverse(f)
            Do
                For m = 0 To f.Length - 1
                    If f(m) <> g(m) Then
                        h = h + 1
                        Exit For
                    ElseIf m = f.Length - 1 Then
                        If i = a Then
                            Print(2, h & Space(1) & b)
                            Exit Do
                        Else
                            PrintLine(2, h & Space(1) & b)
                            Exit Do
                        End If
                    End If
                Next
                c = 0
                For aa = 0 To f.Length - 1
                    c = c & f(aa)
                Next
                c = c + Val(b)
                b = c

                ReDim f(Len(b) - 1)
                ReDim g(Len(b) - 1)

                For n = 0 To Len(b) - 1
                    f(n) = Mid(b, n + 1, 1)
                Next

                Array.Copy(f, g, Len(b))

                Array.Reverse(f)
            Loop
            b = ""
            h = 1
            c = 0
        Next

    End Sub
End Class

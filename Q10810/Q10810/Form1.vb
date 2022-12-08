Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, f, g, h As Integer
        Dim c(), d() As Long

        a = LineInput(1)

        Do Until a = 0
            ReDim c(a - 1)
            ReDim d(a - 1)
            For i = 0 To a - 1
                c(i) = LineInput(1)
                d(i) = c(i)
            Next
            Array.Sort(d)
            Do Until f = a - 1

                If c(f) <> d(f) Then
                    For i = 0 To a - 1
                        If c(i) = d(f) Then
                            b = i
                            Exit For
                        End If
                    Next
                    g = c(b)
                    c(b) = c(b - 1)
                    c(b - 1) = g
                    h = h + 1
                End If

                If c(f) = d(f) Then
                    f = f + 1
                End If
            Loop
            a = LineInput(1)
            If a = 0 Then
                Print(2, h)
            Else
                PrintLine(2, h)
            End If
            f = 0
            g = 0
            h = 0
        Loop


    End Sub
End Class

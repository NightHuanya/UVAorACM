Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d As Integer
        Dim f$
        d = 100
        a = LineInput(1)
        For i = 1 To a
            LineInput(1)
            f = LineInput(1)
            For j = 1 To Len(f)
                Select Case Mid(f, j, 1)
                    Case "0" To "9"
                        b = b & Mid(f, j, 1)
                    Case Else
                        If b > c Then
                            c = b
                        End If
                        If b < d Then
                            d = b
                        End If
                        b = 0
                End Select
                If j = Len(f) Then
                    If b > c Then
                        c = b
                    End If
                    If b < d Then
                        d = b
                    End If
                End If
            Next

            If i = a Then
                Print(2, (c - d) * 2)
            Else
                PrintLine(2, (c - d) * 2)
            End If
            b = 0
            c = 0
            d = 100
        Next
    End Sub
End Class

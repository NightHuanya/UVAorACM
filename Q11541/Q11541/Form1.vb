Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a, b, c As Integer
        Dim d$, f$
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        a = LineInput(1)

        For i = 1 To a

            d = LineInput(1)
            Print(2, "Case " & i & ": ")
            For j = 1 To Len(d)
                Select Case Mid(d, j, 1)
                    Case "A" To "Z"
                        If j > 1 Then
                            For k = 1 To b
                                Print(2, f)
                            Next
                        End If
                        f = Mid(d, j, 1)
                        b = 0
                    Case "0" To "9"
                        b = b & Mid(d, j, 1)
                End Select
                If j = Len(d) Then
                    For k = 1 To b
                        Print(2, f)
                    Next
                    b = 0
                End If
            Next
            If EOF(1) <> True Then
                PrintLine(2)
            End If
        Next

    End Sub
End Class

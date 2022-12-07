Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As Long

        a = LineInput(1)

        For i = 1 To a
            b = LineInput(1)
            For j = 1 To b - 1
                If b Mod j = 0 Then
                    c = c + j
                End If
            Next
            If b = c Then
                If i = a Then
                    Print(2, "perfect")
                Else
                    PrintLine(2, "perfect")
                End If
            ElseIf b > c Then
                If i = a Then
                    Print(2, "deficient")
                Else
                    PrintLine(2, "deficient")
                End If
            ElseIf b < c Then
                If i = a Then
                    Print(2, "abundant")
                Else
                    PrintLine(2, "abundant")
                End If
            End If
            c = 0
        Next
    End Sub
End Class

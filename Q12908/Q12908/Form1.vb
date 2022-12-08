Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d As Long
        a = LineInput(1)
        Do Until a = 0
            For i = 1 To a
                b = b + i
                d = d + 1
                If b >= a Then
                    Exit For
                End If

            Next

            If b = a Then
                c = d + 1
                d = d + 1
            ElseIf b > a Then
                c = b - a
            End If

            a = LineInput(1)

            If a = 0 Then
                Print(2, c & Space(1) & d)
            Else
                PrintLine(2, c & Space(1) & d)
            End If

            b = 0
            c = 0
            d = 0

        Loop

    End Sub
End Class

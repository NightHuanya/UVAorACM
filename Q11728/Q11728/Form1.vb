Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d As Integer

        d = 1
        a = LineInput(1)

        Do Until a = 0

            For i = 1 To a

                For j = 1 To i
                    If i Mod j = 0 Then
                        b = b + j
                    End If
                Next
                If b = a Then
                    c = i
                    b = 0
                Else
                    b = 0
                End If
                If i = a And c = 0 Then
                    c = -1
                End If
            Next

            a = LineInput(1)

            If a = 0 Then
                Print(2, "Case " & d & ": " & c)
            Else
                PrintLine(2, "Case " & d & ": " & c)
            End If

            c = 0
            b = 0
            d = d + 1

        Loop

    End Sub
End Class

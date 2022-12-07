Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d, f As Long

        a = LineInput(1)

        For i = 1 To a
            b = LineInput(1)
            For j = 1 To b
                For k = 1 To j
                    If j Mod k = 0 Then
                        c = c + 1
                    End If
                Next
                If c >= d Then
                    d = c
                    f = j
                End If
                c = 0
            Next

            If i = a Then
                Print(2, f)
            Else
                PrintLine(2, f)
            End If
            c = 0
            f = 0
            d = 0
        Next



    End Sub
End Class

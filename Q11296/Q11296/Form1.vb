Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As Long

        Do Until EOF(1) = True

            a = LineInput(1)

            For i = 0 To a
                For j = 0 To a
                    For k = 0 To a
                        If i + 2 * j + 2 * k = a Then
                            b = b + 1
                        End If
                    Next
                Next
            Next

            If EOF(1) = True Then
                Print(2, b)
            Else
                PrintLine(2, b)
            End If
            b = 0
        Loop

    End Sub
End Class

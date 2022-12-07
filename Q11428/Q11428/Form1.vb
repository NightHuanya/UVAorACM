Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As Long

        a = LineInput(1)
        Do Until a = 0

            For i = 1 To a
                For j = 1 To a
                    If a = i ^ 3 - j ^ 3 Then
                        b = i
                        If j < c Or c = 0 Then
                            c = j
                        End If
                    End If
                Next
            Next
            a = LineInput(1)
            If b = 0 Then
                If a = 0 Then
                    Print(2, "No solution")
                Else
                    PrintLine(2, "No solution")
                End If
            Else
                If a = 0 Then
                    Print(2, b & Space(1) & c)
                Else
                    PrintLine(2, b & Space(1) & c)
                End If
            End If
            b = 0
            c = 0
        Loop


    End Sub
End Class

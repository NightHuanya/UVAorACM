Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d, f As Long
        a = LineInput(1)
        Do Until a = -1

            For i = 1 To a
                For j = i To a
                    b = b + j
                    If b = a Then
                        c = i
                        d = j
                        Exit For
                    End If
                Next
                b = 0
                If c <> 0 Then
                    Exit For
                End If
            Next
            f = a
            a = LineInput(1)
            If a = -1 Then
                Print(2, f & " = " & c & " + ... + " & d)
            Else
                PrintLine(2, f & " = " & c & " + ... + " & d)
            End If

            c = 0
            b = 0
            d = 0
            f = 0
        Loop


    End Sub
End Class

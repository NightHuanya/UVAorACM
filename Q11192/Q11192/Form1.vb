Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)


        Dim a, d, g As String
        Dim b%, f%
        Dim c()

        f = 1
        a = LineInput(1)
        Do
            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "0" To "9"
                        b = b & Mid(a, i, 1)
                    Case "A" To "Z"
                        d = d & Mid(a, i, 1)
                End Select
            Next
            If b = 0 Then
                Exit Do
            End If
            ReDim c(b - 1)


            For k = 1 To Len(d) / b
                For j = 0 To b - 1
                    c(j) = Mid(d, f, 1)
                    f = f + 1
                Next
                Array.Reverse(c)
                For l = 0 To b - 1
                    g = g & c(l)
                Next
            Next


            a = LineInput(1)
            If a = "0" Then
                Print(2, g)
            Else
                PrintLine(2, g)
            End If
            f = 1
            g = ""
            b = 0
            d = ""
        Loop
    End Sub
End Class

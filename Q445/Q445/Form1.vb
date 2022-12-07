Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As String
        Dim c, d As Long

        Do Until EOF(1) = True
            a = LineInput(1)
            d = d + 1
            If d > 1 Then
                Print(2, vbNewLine)
            End If
            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "b"
                        b = " "
                        For j = 1 To c
                            Print(2, b)
                        Next
                        c = 0
                    Case "0" To "9"
                        c = c + Val(Mid(a, i, 1))
                    Case "A" To "Z"
                        b = Mid(a, i, 1)
                        For j = 1 To c
                            Print(2, b)
                        Next
                        c = 0
                    Case "*"
                        b = Mid(a, i, 1)
                        For j = 1 To c
                            Print(2, b)
                        Next
                        c = 0
                    Case "!"
                        Print(2, vbNewLine)
                End Select

            Next

        Loop

    End Sub
End Class

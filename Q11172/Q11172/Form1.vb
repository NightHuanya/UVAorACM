Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a As String
        Dim b, c, d As Long

        b = LineInput(1)

        For i = 1 To b
            a = LineInput(1)

            For j = 1 To Len(a)
                Select Case Mid(a, j, 1)
                    Case "0" To "9"
                        c = c & Mid(a, j, 1)
                    Case Else
                        d = c
                        c = 0
                End Select
            Next

            If d > c Then
                If i = b Then
                    Print(2, ">")
                Else
                    PrintLine(2, ">")
                End If
            ElseIf d < c Then
                If i = b Then
                    Print(2, "<")
                Else
                    PrintLine(2, "<")
                End If
            Else
                If i = b Then
                    Print(2, "=")
                Else
                    PrintLine(2, "=")
                End If
            End If
            c = 0
            d = 0
        Next
    End Sub
End Class

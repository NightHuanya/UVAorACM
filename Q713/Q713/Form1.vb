Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As String
        Dim d As Long

        d = LineInput(1)
        For i = 1 To d
            a = LineInput(1)

            For j = 1 To Len(a)
                Select Case Mid(a, j, 1)
                    Case "0" To "9"
                        b = b & Mid(a, j, 1)
                    Case Else
                        c = b
                        b = ""
                End Select
            Next
            c = StrReverse(c)
            b = StrReverse(b)

            b = Val(b) + Val(c)
            b = StrReverse(b)

            Do
                If Mid(b, 1, 1) = "0" Then
                    b = Mid(b, 2, Len(b) - 1)
                Else
                    Exit Do
                End If
            Loop

            If i = d Then
                Print(2, b)
            Else
                PrintLine(2, b)
            End If
            b = ""
            c = ""
        Next

    End Sub
End Class

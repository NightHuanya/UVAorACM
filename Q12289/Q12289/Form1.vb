Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b As Integer
        Dim d As String
        Dim c(0, 2)
        For z = 0 To 2
            c(0, z) = Mid("one", z + 1, 1)
        Next

        a = LineInput(1)

        For i = 1 To a

            d = LineInput(1)

            If Len(d) = 5 Then
                If i = a Then
                    Print(2, 3)
                Else
                    PrintLine(2, 3)
                End If
            Else
                For j = 1 To Len(d)
                    If Mid(d, j, 1) = c(0, j - 1) Then
                        b = b + 1
                    End If
                Next
                If b >= 2 Then
                    If i = a Then
                        Print(2, 1)
                    Else
                        PrintLine(2, 1)
                    End If
                Else
                    If i = a Then
                        Print(2, 2)
                    Else
                        PrintLine(2, 2)
                    End If
                End If
            End If
            b = 0
        Next





    End Sub
End Class

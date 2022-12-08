Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As Long
        Dim d As String

        a = LineInput(1)

        For i = 1 To a
            b = LineInput(1)
            For j = 1 To b
                d = j
                For k = 1 To Len(d)
                    c = c + Val(Mid(d, k, 1))
                Next
            Next
            If c Mod 3 = 0 Then
                If i = a Then
                    Print(2, "YES")
                Else
                    PrintLine(2, "YES")
                End If
            Else
                If i = a Then
                    Print(2, "NO")
                Else
                    PrintLine(2, "NO")
                End If
            End If
            b = 0
            c = 0
        Next
    End Sub
End Class

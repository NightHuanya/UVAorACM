Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b(2), c As Long
        Dim f As String

        a = LineInput(1)

        For i = 1 To a
            f = LineInput(1)
            For j = 1 To Len(f)
                Select Case Mid(f, j, 1)
                    Case "0" To "9"
                        b(c) = b(c) & Mid(f, j, 1)
                    Case Else
                        c = c + 1
                End Select
            Next
            Array.Sort(b)
            Array.Reverse(b)
            If b(0) < b(1) + b(2) Then
                If i = a Then
                    Print(2, "OK")
                Else
                    PrintLine(2, "OK")
                End If
            Else
                If i = a Then
                    Print(2, "Wrong!! ")
                Else
                    PrintLine(2, "Wrong!! ")
                End If
            End If
            ReDim b(2)
            c = 0
        Next

    End Sub
End Class

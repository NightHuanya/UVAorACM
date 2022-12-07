Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)
        Dim a, b, c, d As String
        a = LineInput(1)
        Do Until a = 0

            b = Mid(a, Len(a), 1)

            For i = 1 To Len(a) - 1
                c = c & Mid(a, i, 1)
            Next
            b = Val(b) * 5

            d = Val(c) - Val(b)

            a = LineInput(1)
            If Val(d) Mod 17 = 0 Then
                If a = 0 Then
                    Print(2, 1)
                Else
                    PrintLine(2, 1)
                End If
            Else
                If a = 0 Then
                    Print(2, 0)
                Else
                    PrintLine(2, 0)
                End If
            End If
            b = ""
            c = ""
            d = ""
        Loop




    End Sub
End Class

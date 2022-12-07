Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, f As Long
        Dim d, g As String
        d = LineInput(1)
        Do


            For i = 1 To Len(d)
                Select Case Mid(d, i, 1)
                    Case "0" To "9"
                        a = a & Mid(d, i, 1)
                    Case Else
                        b = a
                        a = 0
                End Select
            Next
            g = b
            For j = 1 To a - 1
                c = Mid(g, Len(g), 1)
                f = b * c
                g = f
            Next
            If a = 0 Then
                g = 1
            End If
            d = LineInput(1)
            If d <> "0 0" Then
                PrintLine(2, Mid(g, Len(g), 1))
            Else
                Print(2, Mid(g, Len(g), 1))
            End If
            a = 0
            b = 0
            c = 0
            f = 0
            g = ""
        Loop Until (d = "0 0")

    End Sub
End Class

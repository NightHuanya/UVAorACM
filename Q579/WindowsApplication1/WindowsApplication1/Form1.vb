Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)


        Dim a, b, c As String
        Dim d As Integer
        Dim f As Double

        Do
            b = ""
            c = ""
            a = LineInput(1)
            If a = "0:00" Then
                Exit Do
            End If
            d = 2
            For i = 1 To Len(a)
                If Mid(a, i, 1) <> ":" Then
                    b = b & Mid(a, i, 1)
                    d = d + 1
                ElseIf Mid(a, i, 1) = ":" Then
                    Exit For
                End If
            Next

            For i = d To Len(a)
                c = c & Mid(a, i, 1)
            Next

            f = (((30 * Val(b) - Val(c) * (30 / 60)) - Val(c) * 6) ^ 2) ^ (1 / 2)


            If f > 180 Then
                f = 360 - f
            End If

            PrintLine(2, Format(f, "0.000"))

        Loop

    End Sub
End Class

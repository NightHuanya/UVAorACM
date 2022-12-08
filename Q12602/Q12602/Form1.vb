Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c, d As String
        Dim f As Integer

        f = LineInput(1)

        For i = 1 To f
            a = LineInput(1)

            For j = 1 To Len(a)
                Select Case Mid(a, j, 1)
                    Case "A" To "Z"
                        b = Val(b) + (Asc(Mid(a, j, 1)) - 65) * 26 ^ (3 - j)
                    Case "0" To "9"
                        c = c & Mid(a, j, 1)
                End Select
            Next

            If Math.Abs(Val(b) - Val(c)) <= 100 Then

                If i = f Then
                    Print(2, "nice")
                Else
                    PrintLine(2, "nice")
                End If

            Else

                If i = f Then
                    Print(2, "not nice")
                Else
                    PrintLine(2, "not nice")
                End If

            End If

            b = ""
            c = b
            d = b

        Next

    End Sub
End Class

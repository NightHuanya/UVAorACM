Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a As String
        Dim b, c, d, f, g As Long
        a = LineInput(1)
        Do Until a = "0 0"
            g = g + 1
            For i = 1 To Len(a)
                Select Case Mid(a, i, 1)
                    Case "0" To "9"
                        b = b & Mid(a, i, 1)
                    Case Else
                        c = b
                        b = 0
                End Select
            Next

            For i = c To b

                d = i

                Do Until d = 1 Or d = 0
                    If d Mod 2 = 1 Then
                        f = f + 1
                    End If
                    d = d \ 2

                Loop

                If d Mod 2 = 1 Then
                    f = f + 1
                End If

            Next

            a = LineInput(1)

            If a = "0 0" Then
                Print(2, "Case " & g & ": " & f)
            Else
                PrintLine(2, "Case " & g & ": " & f)
            End If

            b = 0
            c = 0
            d = 0
            f = 0

        Loop

    End Sub
End Class

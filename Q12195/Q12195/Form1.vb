Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim W, H, Q, F, S, T, X As Single
        Dim a, b As Single
        Dim c$

        W = 1 : H = 1 / 2 : Q = 1 / 4 : F = 1 / 8 : S = 1 / 16 : T = 1 / 32 : X = 1 / 64

        c = LineInput(1)

        Do Until c = "*"

            For i = 1 To Len(c)
                Select Case Mid(c, i, 1)
                    Case "W"
                        a = a + W
                    Case "H"
                        a = a + H
                    Case "Q"
                        a = a + Q
                    Case "E"
                        a = a + F
                    Case "S"
                        a = a + S
                    Case "T"
                        a = a + T
                    Case "X"
                        a = a + X
                    Case Else
                        If a = 1 Then
                            b = b + 1
                        End If
                        a = 0
                       
                End Select

            Next

            c = LineInput(1)

            If c <> "*" Then
                PrintLine(2, b)
            Else
                Print(2, b)
            End If
            b = 0
        Loop




    End Sub
End Class

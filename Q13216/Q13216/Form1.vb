Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim a, b, c As String

        a = LineInput(1)

        For i = 1 To Val(a)

            b = LineInput(1)

            c = Val(b)
            If Val(c) > 3 Then
                c = Val(c) Mod 4
                Select Case Val(c)
                    Case 0
                        c = 36
                    Case 1
                        c = 16
                    Case 2
                        c = 56
                    Case 3
                        c = 96

                End Select
            Else
                Select Case Val(c)
                    Case 0
                        c = 1
                    Case 1
                        c = 66
                    Case 2
                        c = 56
                    Case 3
                        c = 96
                End Select
            End If
            If i = Val(a) Then
                Print(2, c)
            Else
                PrintLine(2, c)
            End If
            c = ""
        Next


    End Sub
End Class

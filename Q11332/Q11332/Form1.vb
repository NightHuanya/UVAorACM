Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Dim b, c As Integer
        Dim a$

        a = LineInput(1)

        Do

            Do
                If Len(a) = 1 Then
                    Exit Do
                Else
                    For i = 1 To Len(a)
                        b = b + Mid(a, i, 1)
                    Next
                    a = b
                    b = 0
                End If
            Loop

            b = a
            a = LineInput(1)

            If a = 0 Then
                Print(2, b)
            Else
                PrintLine(2, b)
            End If
            b = 0

        Loop Until a = 0



    End Sub
End Class

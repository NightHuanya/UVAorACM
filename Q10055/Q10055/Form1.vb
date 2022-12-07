Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim a$
        Dim b, c, d As Long


        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Do Until EOF(1) = True

            a = LineInput(1)


            For i = 1 To Len(a)

                Select Case Mid(a, i, 1)
                    Case "0" To "9"
                        b = b & Mid(a, i, 1)

                    Case Else
                        c = b
                        b = 0
                End Select
            Next


            d = (c - b) ^ 2 ^ 0.5


            If EOF(1) = True Then
                Print(2, d)
            Else
                PrintLine(2, d)
            End If

            d = 0
            c = 0
            b = 0

        Loop

    End Sub
End Class

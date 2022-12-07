Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim c, d As Integer
        Dim b$, a$

        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out1.txt", 2)

        Do Until EOF(1) = True


            b = LineInput(1)


            For i = 1 To Len(b)

                Select Case Mid(b, i, 1)

                    Case "0" To "9"
                        a = a & Mid(b, i, 1)
                    Case Else
                        c = Val(a)
                        a = ""

                End Select

            Next

            d = Val(a) * c * 2

            If EOF(1) = True Then
                Print(2, d)

            Else
                PrintLine(2, d)

            End If

            a = ""
            d = 0
            c = 0
        Loop
    End Sub
End Class
